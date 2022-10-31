using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SchoolOfFineArtsDB;
using SchoolOfFineArtsModels;
using CrudOperations;
using DbRepositories;
using System.ComponentModel;

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
        }

        private void LoadCourses()
        {
            var courseList = _read.DisplayCourses(_courseRepo);
            //var teacherList = _read.DisplayTeachers(_teacherRepo);
            var dbCourses = new BindingList<CourseDTO>(courseList);
            //var dbTeachers = new List<Teacher>(teacherList);
            dgvCourses.DataSource = dbCourses;
            //foreach (DataGridViewRow row in dgvCourses.Rows)
            //{
            //    var tId = Convert.ToInt32(row.Cells[5].Value);
            //    row.Cells[6].Value = dbTeachers.SingleOrDefault(x => x.Id == tId);
            //}
            dgvCourses.Refresh();

            //var cList = dgvCourses.DataSource as BindingList<Course>;
            //var fList = cList.Where(c => c.Name.ToLower().Contains(txtCourseName.Text.ToLower())).ToList();
            //dgvCourses.DataSource = new BindingList<Course>(fList);
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
        }

        private void dgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow? row;
            bool isTeacher = false;
            bool isStudent = false;
            bool isCourse = false;
            try
            {
                if (tabControl1.SelectedIndex == 0)
                {
                    row = dgvTeachers.Rows[e.RowIndex];
                    isTeacher = true;
                }
                else if (tabControl1.SelectedIndex == 1)
                {
                    row = dgvStudents.Rows[e.RowIndex];
                    isStudent = true;
                }
                else //if (tabControl1.SelectedTab == tabCourses)
                {
                    row = dgvCourses.Rows[e.RowIndex];
                    isCourse = true;
                }
            }
            catch
            {
                ClearForm();
                return;
            }

            // grab the row that was clicked in the grid
            int dataId = 0;
            foreach (DataGridViewTextBoxCell cell in row.Cells)
            {
                if (cell.OwningColumn.Name.Equals("Id", StringComparison.OrdinalIgnoreCase))
                {
                    dataId = Convert.ToInt32(cell.Value);
                    if (dataId == 0)
                    {
                        ClearForm();
                        return;
                    }
                }
            }

            if (isTeacher)
            {
                var t = _read.DisplaySingle(dataId, _teacherRepo);
                if (t is not null)
                {
                    lblTeacherIdTxt.Text = t.Id.ToString();
                    txtTeacherFirstName.Text = t.FirstName;
                    txtTeacherLastName.Text = t.LastName;
                    numTeacherAge.Value = t.Age;
                }
            }
            else if (isStudent)
            {
                var s = _read.DisplaySingle(dataId, _studentRepo);
                if (s is not null)
                {
                    lblStudentIdTxt.Text = s.Id.ToString();
                    txtStudentFirstName.Text = s.FirstName;
                    txtStudentLastName.Text = s.LastName;
                    dtStudentDoB.Value = s.DateOfBirth;
                }
            }
            else if (isCourse)
            {
                var c = _read.DisplaySingle(dataId, _courseRepo);
                if (c is not null)
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
    }
}