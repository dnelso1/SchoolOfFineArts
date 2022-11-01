using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SchoolOfFineArtsDB;
using SchoolOfFineArtsModels;
using CrudOperations;
using DbRepositories;
using System.ComponentModel;
using System.Collections.Immutable;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SchoolOfFineArts
{
    public partial class Form1 : Form
    {
        //private BindingList<Teacher> teacherList = new BindingList<Teacher>();   
        // use readonly as they are only set at form creation
        private readonly string _cnstr;
        private readonly DbContextOptionsBuilder _optionsBuilder;
        private readonly TeacherRepo _teacherRepo;
        private readonly StudentRepo _studentRepo;
        private readonly CourseRepo _courseRepo;
        private readonly Create _create;
        private readonly Read _read;
        private readonly Update _update;
        private readonly Delete _delete;

        public Form1()
        {
            InitializeComponent();
            //dgvResults.DataSource = teacherList;
            _cnstr = Program._configuration["ConnectionStrings:SchoolOfFineArtsDB"];
            _optionsBuilder = new DbContextOptionsBuilder<SchoolOfFineArtsDbContext>().UseSqlServer(_cnstr);
            _teacherRepo = new TeacherRepo(_optionsBuilder);
            _studentRepo = new StudentRepo(_optionsBuilder);
            _courseRepo = new CourseRepo(_optionsBuilder);
            _create = new Create();
            _read = new Read();
            _update = new Update();
            _delete = new Delete();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        private Teacher InstantiateTeacher()
        {
            var t = new Teacher();
            t.Id = Convert.ToInt32(lblTeacherIdTxt.Text);
            t.FirstName = txtTeacherFirstName.Text;
            t.LastName = txtTeacherLastName.Text;
            t.Age = Convert.ToInt32(numTeacherAge.Value);
            return t;
        }

        private Student InstantiateStudent()
        {
            var s = new Student();
            s.Id = Convert.ToInt32(lblStudentIdTxt.Text);
            s.FirstName = txtStudentFirstName.Text;
            s.LastName = txtStudentLastName.Text;
            s.DateOfBirth = dtStudentDoB.Value.Date;
            return s;
        }

        private Course InstantiateCourse()
        {
            var c = new Course();
            c.Id = Convert.ToInt32(lblCourseIdTxt.Text ?? "0");
            c.Name = txtCourseName.Text;
            c.Abbreviation = txtCourseAbbreviation.Text;
            c.Department = txtCourseDepartment.Text;
            c.NumCredits = Convert.ToInt32(cboCourseCredits.SelectedItem);
            c.TeacherId = ((Teacher)cboCourseTeacher.SelectedItem).Id;
            //c.Teacher = ((Teacher)cboCourseTeacher.SelectedItem);
            return c;
        }

        private void LoadTeachers(bool isSearch = false)
        {
            // get list of teachers and put it in the binding list
            var teacherList = _read.DisplayTeachers(_teacherRepo);
            var dbTeachers = new BindingList<Teacher>(teacherList);
            dgvTeachers.DataSource = dbTeachers;
            dgvTeachers.Refresh();

            if (!isSearch)
            {
                cboCourseTeacher.SelectedIndex = -1;
                cboCourseTeacher.Items.Clear();
                var tList = dgvTeachers.DataSource as BindingList<Teacher>;
                cboCourseTeacher.Items.AddRange(tList.ToArray());
                cboCourseTeacher.DisplayMember = "FriendlyName";
                cboCourseTeacher.ValueMember = "Id";
            }
        }

        private void LoadStudents()
        {
            //take advantage of disposability of the connection and context:
            var studentList = _read.DisplayStudents(_studentRepo);
            var dbStudents = new BindingList<Student>(studentList);
            dgvStudents.DataSource = dbStudents;
            dgvStudents.Refresh();

            if (tabControl1.SelectedIndex == 3)
            {
                lstStudents.Items.Clear();
                lstStudents.Items.AddRange(dbStudents.OrderBy(s => s.LastName).ToArray());
            }
        }

        private void LoadCourses()
        {
            var courseList = _read.DisplayCourses(_courseRepo);
            var dbCourses = new BindingList<CourseDTO>(courseList);
            dgvCourses.DataSource = dbCourses;
            dgvCourses.Refresh();

            if (tabControl1.SelectedIndex == 3)
            {
                dgvCourseAssignments.DataSource = dbCourses;
                dgvCourseAssignments.Refresh();
            }
        }

        private void ClearForm()
        {

            if (tabControl1.SelectedIndex == 0)
            {
                lblTeacherIdTxt.Text = "0";
                txtTeacherFirstName.Text = string.Empty;
                txtTeacherLastName.Text = string.Empty;
                numTeacherAge.Value = 16;
                LoadTeachers();
                dgvTeachers.ClearSelection();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                lblStudentIdTxt.Text = "0";
                txtStudentFirstName.Text = string.Empty;
                txtStudentLastName.Text = string.Empty;
                dtStudentDoB.Value = DateTime.Today;
                LoadStudents();
                dgvStudents.ClearSelection();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                lblCourseIdTxt.Text = "0";
                txtCourseName.Text = string.Empty;
                txtCourseAbbreviation.Text = string.Empty;
                txtCourseDepartment.Text = string.Empty;
                cboCourseCredits.SelectedIndex = 2;
                cboCourseTeacher.SelectedIndex = -1;
                LoadCourses();
                dgvCourses.ClearSelection();
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                LoadCourses();
                LoadStudents();
                ResetCourseSelections();
                ClearStudentSelections();
            }
        }

        private void ResetCourseSelections()
        {
            txtSelectedCourseId.Text = "0";
            txtSelectedCourse.Text = string.Empty;
            dgvCourseAssignments.ClearSelection();
        }

        private void ClearStudentSelections()
        {
            foreach (int i in lstStudents.CheckedIndices)
            {
                lstStudents.SetItemCheckState(i, CheckState.Unchecked);
            }
            lstStudents.ClearSelected();
        }

        private int GetDataId(DataGridViewRow row)
        {
            // grab the row that was clicked in the grid
            int dataId = 0;
            foreach (DataGridViewTextBoxCell cell in row.Cells)
            {
                if (cell.OwningColumn.Name.Equals("Id", StringComparison.OrdinalIgnoreCase))
                {
                    dataId = Convert.ToInt32(cell.Value);
                }
            }
            return dataId;
        }

        private void dgvTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow? row;
            try
            {
                row = dgvTeachers.Rows[e.RowIndex];
            }
            catch (Exception ex)
            {
                ClearForm();
                return;
            }

            var dataId = GetDataId(row);
            if (dataId <= 0)
            {
                ClearForm();
                return;
            }

            var t = _read.DisplaySingle(dataId, _teacherRepo);
            if (t is not null)
            {
                lblTeacherIdTxt.Text = t.Id.ToString();
                txtTeacherFirstName.Text = t.FirstName;
                txtTeacherLastName.Text = t.LastName;
                numTeacherAge.Value = t.Age;
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow? row;
            try
            {
                row = dgvStudents.Rows[e.RowIndex];
            }
            catch (Exception ex)
            {
                ClearForm();
                return;
            }

            var dataId = GetDataId(row);
            if (dataId <= 0)
            {
                ClearForm();
                return;
            }

            var s = _read.DisplaySingle(dataId, _studentRepo);
            if (s is not null)
            {
                lblStudentIdTxt.Text = s.Id.ToString();
                txtStudentFirstName.Text = s.FirstName;
                txtStudentLastName.Text = s.LastName;
                dtStudentDoB.Value = s.DateOfBirth;
            }
        }

        private void dgvCoursesAndAssignments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow? row;
            bool isCourse = false;
            bool isAssociation = false;
            try
            {
                if (tabControl1.SelectedIndex == 2)
                {
                    row = dgvCourses.Rows[e.RowIndex];
                    isCourse = true;
                }
                else
                {
                    row = dgvCourseAssignments.Rows[e.RowIndex];
                    isAssociation = true;
                }
            }
            catch (Exception ex)
            {
                ResetCourseSelections();
                return;
            }

            var dataId = GetDataId(row);
            if (dataId <= 0)
            {
                ResetCourseSelections();
                return;
            }

            var c = _read.DisplaySingle(dataId, _courseRepo);
            if (c is not null)
            {
                if (isCourse)
                {
                    lblCourseIdTxt.Text = c.Id.ToString();
                    txtCourseName.Text = c.Name;
                    txtCourseAbbreviation.Text = c.Abbreviation;
                    txtCourseDepartment.Text = c.Department;
                    foreach (var item in cboCourseCredits.Items)
                    {
                        if (Convert.ToInt32(item) == c.NumCredits)
                        {
                            cboCourseCredits.SelectedItem = item;
                        }
                    }
                    foreach (var item in cboCourseTeacher.Items)
                    {
                        var t = (Teacher)item;
                        if (t.Id == c.TeacherId)
                        {
                            cboCourseTeacher.SelectedItem = item;
                        }
                    }
                }
                else if (isAssociation)
                {
                    txtSelectedCourseId.Text = c.Id.ToString();
                    txtSelectedCourse.Text = $"({c.Abbreviation}) {c.Name}";
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                Teacher t = InstantiateTeacher();
                _create.AddTeacher(t, _teacherRepo);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                Student s = InstantiateStudent();
                _create.AddStudent(s, _studentRepo);
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                Course c = InstantiateCourse();
                _create.AddCourse(c, _courseRepo);
            }
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                Teacher t = InstantiateTeacher();
                _update.EditTeacher(t, _teacherRepo);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                Student s = InstantiateStudent();
                _update.EditStudent(s, _studentRepo);
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                Course c = InstantiateCourse();
                _update.EditCourse(c, _courseRepo);
            }
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmDelete = MessageBox.Show("Are you sure you want to delete this item?", "Are you sure?", MessageBoxButtons.YesNo);

            if (confirmDelete == DialogResult.No)
            {
                return;
            }

            if (tabControl1.SelectedIndex == 0)
            {
                var id = Convert.ToInt32(lblTeacherIdTxt.Text);
                _delete.RemoveTeacher(id, _teacherRepo);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                var id = Convert.ToInt32(lblStudentIdTxt.Text);
                _delete.RemoveStudent(id, _studentRepo);
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                var id = Convert.ToInt32(lblCourseIdTxt.Text);
                _delete.RemoveCourse(id, _courseRepo);
            }
            ClearForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 0)
            {
                LoadTeachers(true);
                var tList = dgvTeachers.DataSource as BindingList<Teacher>;
                var fList = tList.Where(t => t.LastName.ToLower().Contains(txtTeacherLastName.Text.ToLower()) &&
                                            t.FirstName.ToLower().Contains(txtTeacherFirstName.Text.ToLower())).ToList();
                dgvTeachers.DataSource = new BindingList<Teacher>(fList);
                dgvTeachers.ClearSelection();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                LoadStudents();
                var sList = dgvStudents.DataSource as BindingList<Student>;
                var fList = sList.Where(s => s.LastName.ToLower().Contains(txtStudentLastName.Text.ToLower()) &&
                                            s.FirstName.ToLower().Contains(txtStudentFirstName.Text.ToLower())).ToList();
                dgvStudents.DataSource = new BindingList<Student>(fList);
                dgvStudents.ClearSelection();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                LoadCourses();
                var cList = dgvCourses.DataSource as BindingList<CourseDTO>;
                var fList = cList.Where(c => c.Name.ToLower().Contains(txtCourseName.Text.ToLower())).ToList();// &&
                                                                                                               //c.FirstName.ToLower().Contains(txtTeacherFirstName.Text.ToLower())).ToList();
                dgvCourses.DataSource = new BindingList<CourseDTO>(fList);
                dgvCourses.ClearSelection();
            }
        }

        private void btnClearStudentSelections_Click(object sender, EventArgs e)
        {
            ClearStudentSelections();
        }

        private void btnAssociate_Click(object sender, EventArgs e)
        {
            // no student or course is selected
            if (lstStudents.CheckedIndices.Count == 0 || string.IsNullOrWhiteSpace(txtSelectedCourseId.Text) || txtSelectedCourseId.Text == "0")
            {
                MessageBox.Show("You must select a course and at least one student.",
                                        "Invalid Selections",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                return;
            }

            var students = lstStudents.CheckedItems.Cast<Student>().ToList();
            var studentNames = string.Empty;
            foreach (var s in students)
            {
                if (studentNames.Length > 0)
                {
                    studentNames = $"{studentNames}, ";
                }
                studentNames = $"{studentNames}{s.FirstName} {s.LastName}";
            }
            var message = $"Are you sure you want to add {studentNames} to {txtSelectedCourse.Text}";
            MessageBox.Show(message, "Confirm Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}