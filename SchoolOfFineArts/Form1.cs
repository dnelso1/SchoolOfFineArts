using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SchoolOfFineArtsDB;
using SchoolOfFineArtsModels;
//using CrudOperations;
using DbRepositories;
using System.ComponentModel;
using System.Text;
//using GenericRepository;

namespace SchoolOfFineArts
{
    public partial class Form1 : Form
    {
        //private BindingList<Teacher> teacherList = new BindingList<Teacher>();   
        // use readonly as they are only set at form creation
        private readonly string _cnstr;
        private readonly DbContextOptionsBuilder _optionsBuilder;
        //private readonly GenericRepository<Teacher> _tRepo;
        //private readonly GenericRepository<Student> _sRepo;
        //private readonly GenericRepository<Course> _cRepo;
        //private readonly GenericRepository<CourseEnrollment> _ceRepo;
        private readonly TeacherRepo _tRepo;
        private readonly StudentRepo _sRepo;
        private readonly CourseRepo _cRepo;
        private readonly CourseEnrollmentRepo _ceRepo;

        public Form1()
        {
            InitializeComponent();
            _cnstr = Program._configuration["ConnectionStrings:SchoolOfFineArtsDB"];
            _optionsBuilder = new DbContextOptionsBuilder<SchoolOfFineArtsDbContext>().UseSqlServer(_cnstr);
            //_tRepo = new GenericRepository<Teacher>(_optionsBuilder);
            //_sRepo = new GenericRepository<Student>(_optionsBuilder);
            //_cRepo = new GenericRepository<Course>(_optionsBuilder);
            //_ceRepo = new GenericRepository<CourseEnrollment>(_optionsBuilder);
            _tRepo = new TeacherRepo(_optionsBuilder);
            _sRepo = new StudentRepo(_optionsBuilder);
            _cRepo = new CourseRepo(_optionsBuilder);
            _ceRepo = new CourseEnrollmentRepo(_optionsBuilder);
        }


        // INSTANTIATIONS
        public Teacher InstantiateTeacher()
        {
            var t = new Teacher();
            t.Id = Convert.ToInt32(lblTeacherIdTxt.Text);
            t.FirstName = txtTeacherFirstName.Text;
            t.LastName = txtTeacherLastName.Text;
            t.Age = Convert.ToInt32(numTeacherAge.Value);
            return t;
        }

        public Student InstantiateStudent()
        {
            var s = new Student();
            s.Id = Convert.ToInt32(lblStudentIdTxt.Text);
            s.FirstName = txtStudentFirstName.Text;
            s.LastName = txtStudentLastName.Text;
            s.DateOfBirth = dtStudentDoB.Value.Date;
            return s;
        }

        public Course InstantiateCourse()
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


        // LOAD
        public void Form1_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        public void LoadTeachers(bool isSearch = false)
        {
            // get list of teachers and put it in the binding list
            var teacherList = _tRepo.GetAll();
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

        public void LoadStudents()
        {
            //take advantage of disposability of the connection and context:
            var studentList = _sRepo.GetAll();
            var dbStudents = new BindingList<Student>(studentList);
            dgvStudents.DataSource = dbStudents;
            dgvStudents.Refresh();

            if (tabControl1.SelectedIndex == 3)
            {
                lstStudents.Items.Clear();
                lstStudents.Items.AddRange(dbStudents.OrderBy(s => s.LastName).ToArray());
            }
        }

        public void LoadCourses()
        {
            var courseList = _cRepo.GetAll();
            var dbCourses = new BindingList<CourseDTO>(courseList);
            dgvCourses.DataSource = dbCourses;
            dgvCourses.Refresh();

            if (tabControl1.SelectedIndex == 3)
            {
                dgvCourseAssignments.DataSource = dbCourses;
                dgvCourseAssignments.Refresh();
            }
        }

        public void LoadCoursesInfoDTOs()
        {
            var coursesInfoDTOList = _ceRepo.GetAll();
            var dbCoursesInfoDTOs = new BindingList<CoursesInfoDTO>(coursesInfoDTOList);
            dgvCoursesInfo.DataSource = dbCoursesInfoDTOs;
            dgvCoursesInfo.Refresh();
        }


        // RESET/CLEAR
        public void ClearForm()
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
                LoadCoursesInfoDTOs();
                ResetCourseSelections();
                ClearStudentSelections();
                dgvCoursesInfo.ClearSelection();
            }
        }

        public void ResetCourseSelections()
        {
            txtSelectedCourseId.Text = "0";
            txtSelectedCourse.Text = string.Empty;
            txtSelectedStudentId.Text = "0";
            txtSelectedStudent.Text = string.Empty;
            dgvCourseAssignments.ClearSelection();
        }

        public void ClearStudentSelections()
        {
            foreach (int i in lstStudents.CheckedIndices)
            {
                lstStudents.SetItemCheckState(i, CheckState.Unchecked);
            }
            lstStudents.ClearSelected();
        }


        // GET INFO
        public int GetDataId(DataGridViewRow row)
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

        public (int, int) GetCourseAndStudentIds(DataGridViewRow row)
        {
            int cId = 0;
            int sId = 0;

            foreach (DataGridViewTextBoxCell cell in row.Cells)
            {
                if (cell.OwningColumn.Name.Equals("CourseId", StringComparison.OrdinalIgnoreCase))
                {
                    cId = Convert.ToInt32(cell.Value);
                }
                if (cell.OwningColumn.Name.Equals("StudentId", StringComparison.OrdinalIgnoreCase))
                {
                    sId = Convert.ToInt32(cell.Value);
                }
            }
            return (cId, sId);
        }


        // DISPLAY MESSAGE BOXES
        public DialogResult ShowMessageBoxYesNo(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void ShowMessageBoxOkError(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        // DATA GRID VIEW CLICKS
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

            var t = _tRepo.GetById(dataId);
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

            var s = _sRepo.GetById(dataId);
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

            var c = _cRepo.GetById(dataId);
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

        private void dgvCoursesInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow? row;
            try
            {
                row = dgvCoursesInfo.Rows[e.RowIndex];
            }
            catch (Exception ex)
            {
                ClearForm();
                return;
            }

            (int cId, int sId) dataId = GetCourseAndStudentIds(row);
            if (dataId.cId <= 0 || dataId.sId <= 0)
            {
                ClearForm();
                return;
            }

            var ceDTO = _ceRepo.GetById(dataId.cId, dataId.sId);
            if (ceDTO is not null)
            {
                txtSelectedStudentId.Text = ceDTO.StudentId.ToString();
                txtSelectedStudent.Text = ceDTO.StudentName;
                txtSelectedCourseId.Text = ceDTO.CourseId.ToString();
                txtSelectedCourse.Text = ceDTO.Course;
            }
        }


        // BUTTON CLICKS
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                Teacher t = InstantiateTeacher();
                _tRepo.Insert(t);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                Student s = InstantiateStudent();
                _sRepo.Insert(s);
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                Course c = InstantiateCourse();
                _cRepo.Insert(c);
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                AssociateStudentsToCourse();
            }
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                Teacher t = InstantiateTeacher();
                _tRepo.Update(t);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                Student s = InstantiateStudent();
                _sRepo.Update(s);
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                Course c = InstantiateCourse();
                _cRepo.Update(c);
            }
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmDelete = ShowMessageBoxYesNo("Are you sure you want to delete this item?", "Are you sure?");

            if (confirmDelete == DialogResult.No)
            {
                ClearForm();
                return;
            }

            if (tabControl1.SelectedIndex == 0)
            {
                var id = Convert.ToInt32(lblTeacherIdTxt.Text);
                _tRepo.Delete(id);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                var id = Convert.ToInt32(lblStudentIdTxt.Text);
                _sRepo.Delete(id);
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                var id = Convert.ToInt32(lblCourseIdTxt.Text);
                _cRepo.Delete(id);
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                RemoveStudentFromCourse();
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
            else if (tabControl1.SelectedIndex == 3)
            {
                LoadCourses();
                var cList = dgvCourseAssignments.DataSource as BindingList<CourseDTO>;
                var fList = cList.Where(c => c.Name.ToLower().Contains(txtSelectedCourse.Text.ToLower())).ToList();// &&
                                                                                                                   //c.FirstName.ToLower().Contains(txtTeacherFirstName.Text.ToLower())).ToList();
                dgvCourseAssignments.DataSource = new BindingList<CourseDTO>(fList);
                dgvCourseAssignments.ClearSelection();
            }
        }

        private void btnClearStudentSelections_Click(object sender, EventArgs e)
        {
            ClearStudentSelections();
        }


        // CRUD HELPER FUNCTIONS
        public void AssociateStudentsToCourse()
        {
            var courseId = txtSelectedCourseId.Text;
            var courseName = txtSelectedCourse.Text;

            // no student or course is selected
            if (lstStudents.CheckedIndices.Count == 0 || string.IsNullOrWhiteSpace(courseId) || courseId == "0")
            {
                ShowMessageBoxOkError("You must select a course and at least one student.", "Invalid Selections");
                return;
            }

            var students = lstStudents.CheckedItems.Cast<Student>().ToList();
            var sb = new StringBuilder();
            foreach (var s in students)
            {
                if (sb.Length > 2)
                {
                    sb.Append(", ");
                }
                if (s.Equals(students.Last()))
                {
                    sb.Append("and ");
                }
                sb.Append($"{s.FirstName} {s.LastName}");
            }

            var studentNames = sb.ToString();
            var confirmAssociate = ShowMessageBoxYesNo($"Are you sure you want to add {studentNames} to {courseName}?", "Confirm Add");

            if (confirmAssociate == DialogResult.No)
            {
                var confirmReset = ShowMessageBoxYesNo("Do you want to clear your Student and Course selections?", "Reset Selections");
                if (confirmReset == DialogResult.Yes)
                {
                    ClearForm();
                }
                return;
            }

            (bool success, string msg) result = _ceRepo.Insert(students, Convert.ToInt32(courseId), courseName);

            MessageBox.Show(result.msg);

            if (result.success)
            {
                ClearForm();
            }
        }

        public void RemoveStudentFromCourse()
        {
            var sId = txtSelectedStudentId.Text;
            var sName = txtSelectedStudent.Text;
            var cId = txtSelectedCourseId.Text;
            var cName = txtSelectedCourse.Text;

            if (string.IsNullOrWhiteSpace(sId) || sId == "0")
            {
                ShowMessageBoxOkError("You must select at least one student.", "Invalid Selections");
                return;
            }
            if (string.IsNullOrWhiteSpace(cId) || cId == "0")
            {
                ShowMessageBoxOkError("You must select at least one course.", "Invalid Selections");
                return;
            }

            //confirm delete
            var confirmDelete = ShowMessageBoxYesNo("Are you sure you want to delete this item?", "Are you sure?");

            if (confirmDelete == DialogResult.No)
            {
                //if no, reset form
                dgvCoursesInfo.ClearSelection();
                //ClearForm();
                return;
            }

            //delete association
            (bool success, string msg) result = _ceRepo.Delete(Convert.ToInt32(sId), sName, Convert.ToInt32(cId), cName);

            MessageBox.Show(result.msg);

            if (result.success)
            {
                dgvCoursesInfo.ClearSelection();
            }
        }
    }
}