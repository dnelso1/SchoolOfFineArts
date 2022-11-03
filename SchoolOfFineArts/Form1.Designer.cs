namespace SchoolOfFineArts
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTeacherFirstName = new System.Windows.Forms.Label();
            this.lblTeacherLastName = new System.Windows.Forms.Label();
            this.txtTeacherFirstName = new System.Windows.Forms.TextBox();
            this.txtTeacherLastName = new System.Windows.Forms.TextBox();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.lblTeacherAge = new System.Windows.Forms.Label();
            this.numTeacherAge = new System.Windows.Forms.NumericUpDown();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.lblTeacherId = new System.Windows.Forms.Label();
            this.pnlTeacherButtons = new System.Windows.Forms.Panel();
            this.btnUpdateTeacher = new System.Windows.Forms.Button();
            this.btnResetTeacherForm = new System.Windows.Forms.Button();
            this.pnlTeacherForm = new System.Windows.Forms.Panel();
            this.lblTeacherIdTxt = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTeachers = new System.Windows.Forms.TabPage();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.pnlStudentForm = new System.Windows.Forms.Panel();
            this.lblStudentIdTxt = new System.Windows.Forms.Label();
            this.txtStudentLastName = new System.Windows.Forms.TextBox();
            this.lblStudentFirstName = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblStudentLastName = new System.Windows.Forms.Label();
            this.lblStudentDoB = new System.Windows.Forms.Label();
            this.txtStudentFirstName = new System.Windows.Forms.TextBox();
            this.dtStudentDoB = new System.Windows.Forms.DateTimePicker();
            this.pnlStudentButtons = new System.Windows.Forms.Panel();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnResetStudentForm = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.tabCourses = new System.Windows.Forms.TabPage();
            this.pnlCourseForm = new System.Windows.Forms.Panel();
            this.lblCourseCredits = new System.Windows.Forms.Label();
            this.lblCourseTeacher = new System.Windows.Forms.Label();
            this.cboCourseTeacher = new System.Windows.Forms.ComboBox();
            this.cboCourseCredits = new System.Windows.Forms.ComboBox();
            this.lblCourseIdTxt = new System.Windows.Forms.Label();
            this.lblCourseId = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseDepartment = new System.Windows.Forms.TextBox();
            this.lblCourseDepartment = new System.Windows.Forms.Label();
            this.txtCourseAbbreviation = new System.Windows.Forms.TextBox();
            this.lblCourseAbbreviation = new System.Windows.Forms.Label();
            this.pnlCourses = new System.Windows.Forms.Panel();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnResetCoursesForm = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.tabStudentCourses = new System.Windows.Forms.TabPage();
            this.txtSelectedStudentId = new System.Windows.Forms.TextBox();
            this.txtSelectedStudent = new System.Windows.Forms.TextBox();
            this.lblSelectedStudent = new System.Windows.Forms.Label();
            this.lblSelectedStudentId = new System.Windows.Forms.Label();
            this.dgvCoursesInfo = new System.Windows.Forms.DataGridView();
            this.lstStudents = new System.Windows.Forms.CheckedListBox();
            this.txtSelectedCourse = new System.Windows.Forms.TextBox();
            this.txtSelectedCourseId = new System.Windows.Forms.TextBox();
            this.lblSelectedCourse = new System.Windows.Forms.Label();
            this.lblSelectedCourseId = new System.Windows.Forms.Label();
            this.dgvCourseAssignments = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClearStudentSelections = new System.Windows.Forms.Button();
            this.btnAssociate = new System.Windows.Forms.Button();
            this.btnRemoveStudentFromCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTeacherAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.pnlTeacherButtons.SuspendLayout();
            this.pnlTeacherForm.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTeachers.SuspendLayout();
            this.tabStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.pnlStudentForm.SuspendLayout();
            this.pnlStudentButtons.SuspendLayout();
            this.tabCourses.SuspendLayout();
            this.pnlCourseForm.SuspendLayout();
            this.pnlCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.tabStudentCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoursesInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseAssignments)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTeacherFirstName
            // 
            this.lblTeacherFirstName.AutoSize = true;
            this.lblTeacherFirstName.Location = new System.Drawing.Point(37, 113);
            this.lblTeacherFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTeacherFirstName.Name = "lblTeacherFirstName";
            this.lblTeacherFirstName.Size = new System.Drawing.Size(134, 32);
            this.lblTeacherFirstName.TabIndex = 1;
            this.lblTeacherFirstName.Text = "First Name:";
            // 
            // lblTeacherLastName
            // 
            this.lblTeacherLastName.AutoSize = true;
            this.lblTeacherLastName.Location = new System.Drawing.Point(37, 171);
            this.lblTeacherLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTeacherLastName.Name = "lblTeacherLastName";
            this.lblTeacherLastName.Size = new System.Drawing.Size(131, 32);
            this.lblTeacherLastName.TabIndex = 2;
            this.lblTeacherLastName.Text = "Last Name:";
            // 
            // txtTeacherFirstName
            // 
            this.txtTeacherFirstName.Location = new System.Drawing.Point(208, 105);
            this.txtTeacherFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.txtTeacherFirstName.Name = "txtTeacherFirstName";
            this.txtTeacherFirstName.Size = new System.Drawing.Size(392, 39);
            this.txtTeacherFirstName.TabIndex = 8;
            this.txtTeacherFirstName.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTeacherLastName
            // 
            this.txtTeacherLastName.Location = new System.Drawing.Point(208, 166);
            this.txtTeacherLastName.Margin = new System.Windows.Forms.Padding(6);
            this.txtTeacherLastName.Name = "txtTeacherLastName";
            this.txtTeacherLastName.Size = new System.Drawing.Size(392, 39);
            this.txtTeacherLastName.TabIndex = 9;
            this.txtTeacherLastName.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(15, 17);
            this.btnAddTeacher.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(163, 49);
            this.btnAddTeacher.TabIndex = 16;
            this.btnAddTeacher.Text = "Add";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTeacherAge
            // 
            this.lblTeacherAge.AutoSize = true;
            this.lblTeacherAge.Location = new System.Drawing.Point(41, 239);
            this.lblTeacherAge.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTeacherAge.Name = "lblTeacherAge";
            this.lblTeacherAge.Size = new System.Drawing.Size(61, 32);
            this.lblTeacherAge.TabIndex = 22;
            this.lblTeacherAge.Text = "Age:";
            // 
            // numTeacherAge
            // 
            this.numTeacherAge.Location = new System.Drawing.Point(208, 235);
            this.numTeacherAge.Margin = new System.Windows.Forms.Padding(6);
            this.numTeacherAge.Maximum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.numTeacherAge.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numTeacherAge.Name = "numTeacherAge";
            this.numTeacherAge.Size = new System.Drawing.Size(392, 39);
            this.numTeacherAge.TabIndex = 23;
            this.numTeacherAge.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(35, 469);
            this.dgvTeachers.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.RowHeadersWidth = 82;
            this.dgvTeachers.RowTemplate.Height = 41;
            this.dgvTeachers.Size = new System.Drawing.Size(886, 623);
            this.dgvTeachers.TabIndex = 24;
            this.dgvTeachers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeachers_CellClick);
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteTeacher.Location = new System.Drawing.Point(15, 139);
            this.btnDeleteTeacher.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(163, 49);
            this.btnDeleteTeacher.TabIndex = 27;
            this.btnDeleteTeacher.Text = "Delete";
            this.btnDeleteTeacher.UseVisualStyleBackColor = true;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTeacherId
            // 
            this.lblTeacherId.AutoSize = true;
            this.lblTeacherId.Location = new System.Drawing.Point(41, 45);
            this.lblTeacherId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTeacherId.Name = "lblTeacherId";
            this.lblTeacherId.Size = new System.Drawing.Size(42, 32);
            this.lblTeacherId.TabIndex = 38;
            this.lblTeacherId.Text = "ID:";
            // 
            // pnlTeacherButtons
            // 
            this.pnlTeacherButtons.Controls.Add(this.btnUpdateTeacher);
            this.pnlTeacherButtons.Controls.Add(this.btnResetTeacherForm);
            this.pnlTeacherButtons.Controls.Add(this.btnAddTeacher);
            this.pnlTeacherButtons.Controls.Add(this.btnDeleteTeacher);
            this.pnlTeacherButtons.Location = new System.Drawing.Point(35, 81);
            this.pnlTeacherButtons.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlTeacherButtons.Name = "pnlTeacherButtons";
            this.pnlTeacherButtons.Size = new System.Drawing.Size(193, 267);
            this.pnlTeacherButtons.TabIndex = 39;
            // 
            // btnUpdateTeacher
            // 
            this.btnUpdateTeacher.Location = new System.Drawing.Point(15, 78);
            this.btnUpdateTeacher.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateTeacher.Name = "btnUpdateTeacher";
            this.btnUpdateTeacher.Size = new System.Drawing.Size(163, 49);
            this.btnUpdateTeacher.TabIndex = 29;
            this.btnUpdateTeacher.Text = "Update";
            this.btnUpdateTeacher.UseVisualStyleBackColor = true;
            this.btnUpdateTeacher.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnResetTeacherForm
            // 
            this.btnResetTeacherForm.Location = new System.Drawing.Point(15, 201);
            this.btnResetTeacherForm.Margin = new System.Windows.Forms.Padding(6);
            this.btnResetTeacherForm.Name = "btnResetTeacherForm";
            this.btnResetTeacherForm.Size = new System.Drawing.Size(163, 51);
            this.btnResetTeacherForm.TabIndex = 28;
            this.btnResetTeacherForm.Text = "Reset";
            this.btnResetTeacherForm.UseVisualStyleBackColor = true;
            this.btnResetTeacherForm.Click += new System.EventHandler(this.Form1_Load);
            // 
            // pnlTeacherForm
            // 
            this.pnlTeacherForm.Controls.Add(this.lblTeacherIdTxt);
            this.pnlTeacherForm.Controls.Add(this.txtTeacherLastName);
            this.pnlTeacherForm.Controls.Add(this.lblTeacherFirstName);
            this.pnlTeacherForm.Controls.Add(this.lblTeacherId);
            this.pnlTeacherForm.Controls.Add(this.lblTeacherLastName);
            this.pnlTeacherForm.Controls.Add(this.txtTeacherFirstName);
            this.pnlTeacherForm.Controls.Add(this.numTeacherAge);
            this.pnlTeacherForm.Controls.Add(this.lblTeacherAge);
            this.pnlTeacherForm.Location = new System.Drawing.Point(277, 62);
            this.pnlTeacherForm.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlTeacherForm.Name = "pnlTeacherForm";
            this.pnlTeacherForm.Size = new System.Drawing.Size(644, 311);
            this.pnlTeacherForm.TabIndex = 40;
            // 
            // lblTeacherIdTxt
            // 
            this.lblTeacherIdTxt.AutoSize = true;
            this.lblTeacherIdTxt.Enabled = false;
            this.lblTeacherIdTxt.Location = new System.Drawing.Point(208, 45);
            this.lblTeacherIdTxt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTeacherIdTxt.Name = "lblTeacherIdTxt";
            this.lblTeacherIdTxt.Size = new System.Drawing.Size(27, 32);
            this.lblTeacherIdTxt.TabIndex = 39;
            this.lblTeacherIdTxt.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTeachers);
            this.tabControl1.Controls.Add(this.tabStudents);
            this.tabControl1.Controls.Add(this.tabCourses);
            this.tabControl1.Controls.Add(this.tabStudentCourses);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(977, 1199);
            this.tabControl1.TabIndex = 42;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.Form1_Load);
            // 
            // tabTeachers
            // 
            this.tabTeachers.Controls.Add(this.dgvTeachers);
            this.tabTeachers.Controls.Add(this.pnlTeacherForm);
            this.tabTeachers.Controls.Add(this.pnlTeacherButtons);
            this.tabTeachers.Location = new System.Drawing.Point(8, 46);
            this.tabTeachers.Margin = new System.Windows.Forms.Padding(6);
            this.tabTeachers.Name = "tabTeachers";
            this.tabTeachers.Padding = new System.Windows.Forms.Padding(6);
            this.tabTeachers.Size = new System.Drawing.Size(961, 1145);
            this.tabTeachers.TabIndex = 0;
            this.tabTeachers.Text = "Instructors";
            this.tabTeachers.UseVisualStyleBackColor = true;
            // 
            // tabStudents
            // 
            this.tabStudents.Controls.Add(this.dgvStudents);
            this.tabStudents.Controls.Add(this.pnlStudentForm);
            this.tabStudents.Controls.Add(this.pnlStudentButtons);
            this.tabStudents.Location = new System.Drawing.Point(8, 46);
            this.tabStudents.Margin = new System.Windows.Forms.Padding(6);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new System.Windows.Forms.Padding(6);
            this.tabStudents.Size = new System.Drawing.Size(961, 1145);
            this.tabStudents.TabIndex = 2;
            this.tabStudents.Text = "Students";
            this.tabStudents.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(35, 469);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 82;
            this.dgvStudents.RowTemplate.Height = 41;
            this.dgvStudents.Size = new System.Drawing.Size(886, 623);
            this.dgvStudents.TabIndex = 42;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // pnlStudentForm
            // 
            this.pnlStudentForm.Controls.Add(this.lblStudentIdTxt);
            this.pnlStudentForm.Controls.Add(this.txtStudentLastName);
            this.pnlStudentForm.Controls.Add(this.lblStudentFirstName);
            this.pnlStudentForm.Controls.Add(this.lblStudentId);
            this.pnlStudentForm.Controls.Add(this.lblStudentLastName);
            this.pnlStudentForm.Controls.Add(this.lblStudentDoB);
            this.pnlStudentForm.Controls.Add(this.txtStudentFirstName);
            this.pnlStudentForm.Controls.Add(this.dtStudentDoB);
            this.pnlStudentForm.Location = new System.Drawing.Point(277, 62);
            this.pnlStudentForm.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlStudentForm.Name = "pnlStudentForm";
            this.pnlStudentForm.Size = new System.Drawing.Size(644, 311);
            this.pnlStudentForm.TabIndex = 45;
            // 
            // lblStudentIdTxt
            // 
            this.lblStudentIdTxt.AutoSize = true;
            this.lblStudentIdTxt.Enabled = false;
            this.lblStudentIdTxt.Location = new System.Drawing.Point(208, 45);
            this.lblStudentIdTxt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStudentIdTxt.Name = "lblStudentIdTxt";
            this.lblStudentIdTxt.Size = new System.Drawing.Size(27, 32);
            this.lblStudentIdTxt.TabIndex = 39;
            this.lblStudentIdTxt.Text = "0";
            // 
            // txtStudentLastName
            // 
            this.txtStudentLastName.Location = new System.Drawing.Point(208, 166);
            this.txtStudentLastName.Margin = new System.Windows.Forms.Padding(6);
            this.txtStudentLastName.Name = "txtStudentLastName";
            this.txtStudentLastName.Size = new System.Drawing.Size(392, 39);
            this.txtStudentLastName.TabIndex = 9;
            this.txtStudentLastName.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStudentFirstName
            // 
            this.lblStudentFirstName.AutoSize = true;
            this.lblStudentFirstName.Location = new System.Drawing.Point(37, 113);
            this.lblStudentFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStudentFirstName.Name = "lblStudentFirstName";
            this.lblStudentFirstName.Size = new System.Drawing.Size(134, 32);
            this.lblStudentFirstName.TabIndex = 1;
            this.lblStudentFirstName.Text = "First Name:";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(41, 45);
            this.lblStudentId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(42, 32);
            this.lblStudentId.TabIndex = 38;
            this.lblStudentId.Text = "ID:";
            // 
            // lblStudentLastName
            // 
            this.lblStudentLastName.AutoSize = true;
            this.lblStudentLastName.Location = new System.Drawing.Point(37, 171);
            this.lblStudentLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStudentLastName.Name = "lblStudentLastName";
            this.lblStudentLastName.Size = new System.Drawing.Size(131, 32);
            this.lblStudentLastName.TabIndex = 2;
            this.lblStudentLastName.Text = "Last Name:";
            // 
            // lblStudentDoB
            // 
            this.lblStudentDoB.AutoSize = true;
            this.lblStudentDoB.Location = new System.Drawing.Point(37, 241);
            this.lblStudentDoB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStudentDoB.Name = "lblStudentDoB";
            this.lblStudentDoB.Size = new System.Drawing.Size(159, 32);
            this.lblStudentDoB.TabIndex = 6;
            this.lblStudentDoB.Text = "Date Of Birth:";
            // 
            // txtStudentFirstName
            // 
            this.txtStudentFirstName.Location = new System.Drawing.Point(208, 105);
            this.txtStudentFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.txtStudentFirstName.Name = "txtStudentFirstName";
            this.txtStudentFirstName.Size = new System.Drawing.Size(392, 39);
            this.txtStudentFirstName.TabIndex = 8;
            this.txtStudentFirstName.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtStudentDoB
            // 
            this.dtStudentDoB.Location = new System.Drawing.Point(208, 230);
            this.dtStudentDoB.Margin = new System.Windows.Forms.Padding(6);
            this.dtStudentDoB.Name = "dtStudentDoB";
            this.dtStudentDoB.Size = new System.Drawing.Size(392, 39);
            this.dtStudentDoB.TabIndex = 18;
            // 
            // pnlStudentButtons
            // 
            this.pnlStudentButtons.Controls.Add(this.btnUpdateStudent);
            this.pnlStudentButtons.Controls.Add(this.btnResetStudentForm);
            this.pnlStudentButtons.Controls.Add(this.btnAddStudent);
            this.pnlStudentButtons.Controls.Add(this.btnDeleteStudent);
            this.pnlStudentButtons.Location = new System.Drawing.Point(35, 81);
            this.pnlStudentButtons.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlStudentButtons.Name = "pnlStudentButtons";
            this.pnlStudentButtons.Size = new System.Drawing.Size(193, 267);
            this.pnlStudentButtons.TabIndex = 44;
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(15, 78);
            this.btnUpdateStudent.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(163, 49);
            this.btnUpdateStudent.TabIndex = 30;
            this.btnUpdateStudent.Text = "Update";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnResetStudentForm
            // 
            this.btnResetStudentForm.Location = new System.Drawing.Point(15, 201);
            this.btnResetStudentForm.Margin = new System.Windows.Forms.Padding(6);
            this.btnResetStudentForm.Name = "btnResetStudentForm";
            this.btnResetStudentForm.Size = new System.Drawing.Size(163, 51);
            this.btnResetStudentForm.TabIndex = 28;
            this.btnResetStudentForm.Text = "Reset";
            this.btnResetStudentForm.UseVisualStyleBackColor = true;
            this.btnResetStudentForm.Click += new System.EventHandler(this.Form1_Load);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(15, 17);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(163, 49);
            this.btnAddStudent.TabIndex = 16;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteStudent.Location = new System.Drawing.Point(15, 139);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(163, 49);
            this.btnDeleteStudent.TabIndex = 27;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabCourses
            // 
            this.tabCourses.Controls.Add(this.pnlCourseForm);
            this.tabCourses.Controls.Add(this.pnlCourses);
            this.tabCourses.Controls.Add(this.dgvCourses);
            this.tabCourses.Location = new System.Drawing.Point(8, 46);
            this.tabCourses.Margin = new System.Windows.Forms.Padding(6);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.Padding = new System.Windows.Forms.Padding(6);
            this.tabCourses.Size = new System.Drawing.Size(961, 1145);
            this.tabCourses.TabIndex = 1;
            this.tabCourses.Text = "Courses";
            this.tabCourses.UseVisualStyleBackColor = true;
            // 
            // pnlCourseForm
            // 
            this.pnlCourseForm.Controls.Add(this.lblCourseCredits);
            this.pnlCourseForm.Controls.Add(this.lblCourseTeacher);
            this.pnlCourseForm.Controls.Add(this.cboCourseTeacher);
            this.pnlCourseForm.Controls.Add(this.cboCourseCredits);
            this.pnlCourseForm.Controls.Add(this.lblCourseIdTxt);
            this.pnlCourseForm.Controls.Add(this.lblCourseId);
            this.pnlCourseForm.Controls.Add(this.lblCourseName);
            this.pnlCourseForm.Controls.Add(this.txtCourseName);
            this.pnlCourseForm.Controls.Add(this.txtCourseDepartment);
            this.pnlCourseForm.Controls.Add(this.lblCourseDepartment);
            this.pnlCourseForm.Controls.Add(this.txtCourseAbbreviation);
            this.pnlCourseForm.Controls.Add(this.lblCourseAbbreviation);
            this.pnlCourseForm.Location = new System.Drawing.Point(277, 9);
            this.pnlCourseForm.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlCourseForm.Name = "pnlCourseForm";
            this.pnlCourseForm.Size = new System.Drawing.Size(644, 439);
            this.pnlCourseForm.TabIndex = 46;
            // 
            // lblCourseCredits
            // 
            this.lblCourseCredits.AutoSize = true;
            this.lblCourseCredits.Location = new System.Drawing.Point(37, 358);
            this.lblCourseCredits.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCourseCredits.Name = "lblCourseCredits";
            this.lblCourseCredits.Size = new System.Drawing.Size(93, 32);
            this.lblCourseCredits.TabIndex = 8;
            this.lblCourseCredits.Text = "Credits:";
            // 
            // lblCourseTeacher
            // 
            this.lblCourseTeacher.AutoSize = true;
            this.lblCourseTeacher.Location = new System.Drawing.Point(37, 297);
            this.lblCourseTeacher.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCourseTeacher.Name = "lblCourseTeacher";
            this.lblCourseTeacher.Size = new System.Drawing.Size(120, 32);
            this.lblCourseTeacher.TabIndex = 10;
            this.lblCourseTeacher.Text = "Instructor:";
            // 
            // cboCourseTeacher
            // 
            this.cboCourseTeacher.FormattingEnabled = true;
            this.cboCourseTeacher.Location = new System.Drawing.Point(208, 290);
            this.cboCourseTeacher.Margin = new System.Windows.Forms.Padding(6);
            this.cboCourseTeacher.Name = "cboCourseTeacher";
            this.cboCourseTeacher.Size = new System.Drawing.Size(392, 40);
            this.cboCourseTeacher.TabIndex = 11;
            // 
            // cboCourseCredits
            // 
            this.cboCourseCredits.FormattingEnabled = true;
            this.cboCourseCredits.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboCourseCredits.Location = new System.Drawing.Point(208, 352);
            this.cboCourseCredits.Margin = new System.Windows.Forms.Padding(6);
            this.cboCourseCredits.Name = "cboCourseCredits";
            this.cboCourseCredits.Size = new System.Drawing.Size(91, 40);
            this.cboCourseCredits.TabIndex = 12;
            // 
            // lblCourseIdTxt
            // 
            this.lblCourseIdTxt.AutoSize = true;
            this.lblCourseIdTxt.Enabled = false;
            this.lblCourseIdTxt.Location = new System.Drawing.Point(208, 49);
            this.lblCourseIdTxt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCourseIdTxt.Name = "lblCourseIdTxt";
            this.lblCourseIdTxt.Size = new System.Drawing.Size(27, 32);
            this.lblCourseIdTxt.TabIndex = 13;
            this.lblCourseIdTxt.Text = "0";
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Location = new System.Drawing.Point(37, 49);
            this.lblCourseId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(42, 32);
            this.lblCourseId.TabIndex = 0;
            this.lblCourseId.Text = "ID:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(37, 111);
            this.lblCourseName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(164, 32);
            this.lblCourseName.TabIndex = 2;
            this.lblCourseName.Text = "Course Name:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(208, 105);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(6);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(392, 39);
            this.txtCourseName.TabIndex = 3;
            this.txtCourseName.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCourseDepartment
            // 
            this.txtCourseDepartment.Location = new System.Drawing.Point(208, 228);
            this.txtCourseDepartment.Margin = new System.Windows.Forms.Padding(6);
            this.txtCourseDepartment.Name = "txtCourseDepartment";
            this.txtCourseDepartment.Size = new System.Drawing.Size(392, 39);
            this.txtCourseDepartment.TabIndex = 7;
            // 
            // lblCourseDepartment
            // 
            this.lblCourseDepartment.AutoSize = true;
            this.lblCourseDepartment.Location = new System.Drawing.Point(37, 235);
            this.lblCourseDepartment.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCourseDepartment.Name = "lblCourseDepartment";
            this.lblCourseDepartment.Size = new System.Drawing.Size(147, 32);
            this.lblCourseDepartment.TabIndex = 6;
            this.lblCourseDepartment.Text = "Department:";
            // 
            // txtCourseAbbreviation
            // 
            this.txtCourseAbbreviation.Location = new System.Drawing.Point(208, 166);
            this.txtCourseAbbreviation.Margin = new System.Windows.Forms.Padding(6);
            this.txtCourseAbbreviation.Name = "txtCourseAbbreviation";
            this.txtCourseAbbreviation.Size = new System.Drawing.Size(392, 39);
            this.txtCourseAbbreviation.TabIndex = 5;
            // 
            // lblCourseAbbreviation
            // 
            this.lblCourseAbbreviation.AutoSize = true;
            this.lblCourseAbbreviation.Location = new System.Drawing.Point(37, 173);
            this.lblCourseAbbreviation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCourseAbbreviation.Name = "lblCourseAbbreviation";
            this.lblCourseAbbreviation.Size = new System.Drawing.Size(155, 32);
            this.lblCourseAbbreviation.TabIndex = 4;
            this.lblCourseAbbreviation.Text = "Abbreviation:";
            // 
            // pnlCourses
            // 
            this.pnlCourses.Controls.Add(this.btnUpdateCourse);
            this.pnlCourses.Controls.Add(this.btnResetCoursesForm);
            this.pnlCourses.Controls.Add(this.btnAddCourse);
            this.pnlCourses.Controls.Add(this.btnDeleteCourse);
            this.pnlCourses.Location = new System.Drawing.Point(35, 81);
            this.pnlCourses.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlCourses.Name = "pnlCourses";
            this.pnlCourses.Size = new System.Drawing.Size(193, 268);
            this.pnlCourses.TabIndex = 45;
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.Location = new System.Drawing.Point(15, 78);
            this.btnUpdateCourse.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(163, 49);
            this.btnUpdateCourse.TabIndex = 30;
            this.btnUpdateCourse.Text = "Update";
            this.btnUpdateCourse.UseVisualStyleBackColor = true;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnResetCoursesForm
            // 
            this.btnResetCoursesForm.Location = new System.Drawing.Point(15, 201);
            this.btnResetCoursesForm.Margin = new System.Windows.Forms.Padding(6);
            this.btnResetCoursesForm.Name = "btnResetCoursesForm";
            this.btnResetCoursesForm.Size = new System.Drawing.Size(163, 51);
            this.btnResetCoursesForm.TabIndex = 28;
            this.btnResetCoursesForm.Text = "Reset";
            this.btnResetCoursesForm.UseVisualStyleBackColor = true;
            this.btnResetCoursesForm.Click += new System.EventHandler(this.Form1_Load);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(15, 17);
            this.btnAddCourse.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(163, 49);
            this.btnAddCourse.TabIndex = 16;
            this.btnAddCourse.Text = "Add";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteCourse.Location = new System.Drawing.Point(15, 139);
            this.btnDeleteCourse.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(163, 49);
            this.btnDeleteCourse.TabIndex = 27;
            this.btnDeleteCourse.Text = "Delete";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvCourses
            // 
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(35, 469);
            this.dgvCourses.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowHeadersWidth = 82;
            this.dgvCourses.RowTemplate.Height = 41;
            this.dgvCourses.Size = new System.Drawing.Size(886, 623);
            this.dgvCourses.TabIndex = 25;
            this.dgvCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoursesAndAssignments_CellClick);
            // 
            // tabStudentCourses
            // 
            this.tabStudentCourses.Controls.Add(this.txtSelectedStudentId);
            this.tabStudentCourses.Controls.Add(this.txtSelectedStudent);
            this.tabStudentCourses.Controls.Add(this.lblSelectedStudent);
            this.tabStudentCourses.Controls.Add(this.lblSelectedStudentId);
            this.tabStudentCourses.Controls.Add(this.dgvCoursesInfo);
            this.tabStudentCourses.Controls.Add(this.lstStudents);
            this.tabStudentCourses.Controls.Add(this.txtSelectedCourse);
            this.tabStudentCourses.Controls.Add(this.txtSelectedCourseId);
            this.tabStudentCourses.Controls.Add(this.lblSelectedCourse);
            this.tabStudentCourses.Controls.Add(this.lblSelectedCourseId);
            this.tabStudentCourses.Controls.Add(this.dgvCourseAssignments);
            this.tabStudentCourses.Controls.Add(this.panel1);
            this.tabStudentCourses.Location = new System.Drawing.Point(8, 46);
            this.tabStudentCourses.Name = "tabStudentCourses";
            this.tabStudentCourses.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentCourses.Size = new System.Drawing.Size(961, 1145);
            this.tabStudentCourses.TabIndex = 3;
            this.tabStudentCourses.Text = "Student Courses";
            this.tabStudentCourses.UseVisualStyleBackColor = true;
            // 
            // txtSelectedStudentId
            // 
            this.txtSelectedStudentId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSelectedStudentId.Enabled = false;
            this.txtSelectedStudentId.Location = new System.Drawing.Point(265, 330);
            this.txtSelectedStudentId.Name = "txtSelectedStudentId";
            this.txtSelectedStudentId.Size = new System.Drawing.Size(96, 32);
            this.txtSelectedStudentId.TabIndex = 57;
            this.txtSelectedStudentId.Text = "0";
            // 
            // txtSelectedStudent
            // 
            this.txtSelectedStudent.Location = new System.Drawing.Point(318, 365);
            this.txtSelectedStudent.Name = "txtSelectedStudent";
            this.txtSelectedStudent.Size = new System.Drawing.Size(640, 39);
            this.txtSelectedStudent.TabIndex = 56;
            // 
            // lblSelectedStudent
            // 
            this.lblSelectedStudent.AutoSize = true;
            this.lblSelectedStudent.Location = new System.Drawing.Point(361, 330);
            this.lblSelectedStudent.Name = "lblSelectedStudent";
            this.lblSelectedStudent.Size = new System.Drawing.Size(207, 32);
            this.lblSelectedStudent.TabIndex = 55;
            this.lblSelectedStudent.Text = "Selected Student: ";
            // 
            // lblSelectedStudentId
            // 
            this.lblSelectedStudentId.AutoSize = true;
            this.lblSelectedStudentId.Location = new System.Drawing.Point(22, 330);
            this.lblSelectedStudentId.Name = "lblSelectedStudentId";
            this.lblSelectedStudentId.Size = new System.Drawing.Size(237, 32);
            this.lblSelectedStudentId.TabIndex = 54;
            this.lblSelectedStudentId.Text = "Selected Student ID: ";
            // 
            // dgvCoursesInfo
            // 
            this.dgvCoursesInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoursesInfo.Location = new System.Drawing.Point(37, 817);
            this.dgvCoursesInfo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvCoursesInfo.Name = "dgvCoursesInfo";
            this.dgvCoursesInfo.RowHeadersWidth = 82;
            this.dgvCoursesInfo.RowTemplate.Height = 41;
            this.dgvCoursesInfo.Size = new System.Drawing.Size(886, 285);
            this.dgvCoursesInfo.TabIndex = 53;
            this.dgvCoursesInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoursesInfo_CellClick);
            // 
            // lstStudents
            // 
            this.lstStudents.CheckOnClick = true;
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(439, 118);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(484, 184);
            this.lstStudents.TabIndex = 52;
            // 
            // txtSelectedCourse
            // 
            this.txtSelectedCourse.Location = new System.Drawing.Point(283, 430);
            this.txtSelectedCourse.Name = "txtSelectedCourse";
            this.txtSelectedCourse.Size = new System.Drawing.Size(640, 39);
            this.txtSelectedCourse.TabIndex = 51;
            // 
            // txtSelectedCourseId
            // 
            this.txtSelectedCourseId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSelectedCourseId.Enabled = false;
            this.txtSelectedCourseId.Location = new System.Drawing.Point(283, 389);
            this.txtSelectedCourseId.Name = "txtSelectedCourseId";
            this.txtSelectedCourseId.Size = new System.Drawing.Size(200, 32);
            this.txtSelectedCourseId.TabIndex = 50;
            this.txtSelectedCourseId.Text = "0";
            // 
            // lblSelectedCourse
            // 
            this.lblSelectedCourse.AutoSize = true;
            this.lblSelectedCourse.Location = new System.Drawing.Point(49, 431);
            this.lblSelectedCourse.Name = "lblSelectedCourse";
            this.lblSelectedCourse.Size = new System.Drawing.Size(198, 32);
            this.lblSelectedCourse.TabIndex = 49;
            this.lblSelectedCourse.Text = "Selected Course: ";
            // 
            // lblSelectedCourseId
            // 
            this.lblSelectedCourseId.AutoSize = true;
            this.lblSelectedCourseId.Location = new System.Drawing.Point(49, 389);
            this.lblSelectedCourseId.Name = "lblSelectedCourseId";
            this.lblSelectedCourseId.Size = new System.Drawing.Size(228, 32);
            this.lblSelectedCourseId.TabIndex = 48;
            this.lblSelectedCourseId.Text = "Selected Course ID: ";
            // 
            // dgvCourseAssignments
            // 
            this.dgvCourseAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseAssignments.Location = new System.Drawing.Point(37, 480);
            this.dgvCourseAssignments.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvCourseAssignments.Name = "dgvCourseAssignments";
            this.dgvCourseAssignments.RowHeadersWidth = 82;
            this.dgvCourseAssignments.RowTemplate.Height = 41;
            this.dgvCourseAssignments.Size = new System.Drawing.Size(886, 283);
            this.dgvCourseAssignments.TabIndex = 47;
            this.dgvCourseAssignments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoursesAndAssignments_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnClearStudentSelections);
            this.panel1.Controls.Add(this.btnAssociate);
            this.panel1.Controls.Add(this.btnRemoveStudentFromCourse);
            this.panel1.Location = new System.Drawing.Point(49, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 268);
            this.panel1.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 78);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 49);
            this.button1.TabIndex = 30;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnClearStudentSelections
            // 
            this.btnClearStudentSelections.Location = new System.Drawing.Point(15, 201);
            this.btnClearStudentSelections.Margin = new System.Windows.Forms.Padding(6);
            this.btnClearStudentSelections.Name = "btnClearStudentSelections";
            this.btnClearStudentSelections.Size = new System.Drawing.Size(163, 51);
            this.btnClearStudentSelections.TabIndex = 28;
            this.btnClearStudentSelections.Text = "Clear Selections";
            this.btnClearStudentSelections.UseVisualStyleBackColor = true;
            this.btnClearStudentSelections.Click += new System.EventHandler(this.btnClearStudentSelections_Click);
            // 
            // btnAssociate
            // 
            this.btnAssociate.Location = new System.Drawing.Point(15, 17);
            this.btnAssociate.Margin = new System.Windows.Forms.Padding(6);
            this.btnAssociate.Name = "btnAssociate";
            this.btnAssociate.Size = new System.Drawing.Size(163, 49);
            this.btnAssociate.TabIndex = 16;
            this.btnAssociate.Text = "Associate Course to Students";
            this.btnAssociate.UseVisualStyleBackColor = true;
            this.btnAssociate.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemoveStudentFromCourse
            // 
            this.btnRemoveStudentFromCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveStudentFromCourse.Location = new System.Drawing.Point(15, 139);
            this.btnRemoveStudentFromCourse.Margin = new System.Windows.Forms.Padding(6);
            this.btnRemoveStudentFromCourse.Name = "btnRemoveStudentFromCourse";
            this.btnRemoveStudentFromCourse.Size = new System.Drawing.Size(163, 49);
            this.btnRemoveStudentFromCourse.TabIndex = 27;
            this.btnRemoveStudentFromCourse.Text = "Remove Student From Course";
            this.btnRemoveStudentFromCourse.UseVisualStyleBackColor = true;
            this.btnRemoveStudentFromCourse.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 1199);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "School of Fine Arts Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTeacherAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.pnlTeacherButtons.ResumeLayout(false);
            this.pnlTeacherForm.ResumeLayout(false);
            this.pnlTeacherForm.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabTeachers.ResumeLayout(false);
            this.tabStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.pnlStudentForm.ResumeLayout(false);
            this.pnlStudentForm.PerformLayout();
            this.pnlStudentButtons.ResumeLayout(false);
            this.tabCourses.ResumeLayout(false);
            this.pnlCourseForm.ResumeLayout(false);
            this.pnlCourseForm.PerformLayout();
            this.pnlCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.tabStudentCourses.ResumeLayout(false);
            this.tabStudentCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoursesInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseAssignments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label lblTeacherFirstName;
        private Label lblTeacherLastName;
        private TextBox txtTeacherFirstName;
        private TextBox txtTeacherLastName;
        private Button btnAddTeacher;
        private Label lblTeacherAge;
        private NumericUpDown numTeacherAge;
        private DataGridView dgvTeachers;
        private Button btnDeleteTeacher;
        private Label lblTeacherId;
        private Panel pnlTeacherButtons;
        private Panel pnlTeacherForm;
        private TabControl tabControl1;
        private TabPage tabTeachers;
        private TabPage tabCourses;
        private TextBox txtCourseDepartment;
        private Label lblCourseDepartment;
        private TextBox txtCourseAbbreviation;
        private Label lblCourseAbbreviation;
        private TextBox txtCourseName;
        private Label lblCourseName;
        private Label lblCourseId;
        private ComboBox cboCourseTeacher;
        private Label lblCourseTeacher;
        private Label lblCourseCredits;
        private ComboBox cboCourseCredits;
        private DataGridView dgvCourses;
        private Label lblCourseIdTxt;
        private TabPage tabStudents;
        private DataGridView dgvStudents;
        private Panel pnlStudentForm;
        private TextBox txtStudentLastName;
        private Label lblStudentFirstName;
        private Label lblStudentId;
        private Label lblStudentLastName;
        private Label lblStudentDoB;
        private TextBox txtStudentFirstName;
        private DateTimePicker dtStudentDoB;
        private Panel pnlStudentButtons;
        private Button btnAddStudent;
        private Button btnDeleteStudent;
        private Label lblTeacherIdTxt;
        private Label lblStudentIdTxt;
        private Button btnResetStudentForm;
        private Button btnResetTeacherForm;
        private Panel pnlCourses;
        private Button btnResetCoursesForm;
        private Button btnAddCourse;
        private Button btnDeleteCourse;
        private Panel pnlCourseForm;
        private Button btnUpdateTeacher;
        private Button btnUpdateStudent;
        private Button btnUpdateCourse;
        private TabPage tabStudentCourses;
        private TextBox txtSelectedCourse;
        private TextBox txtSelectedCourseId;
        private Label lblSelectedCourse;
        private Label lblSelectedCourseId;
        private DataGridView dgvCourseAssignments;
        private Panel panel1;
        private Button button1;
        private Button btnClearStudentSelections;
        private Button btnAssociate;
        private Button btnRemoveStudentFromCourse;
        private CheckedListBox lstStudents;
        private DataGridView dgvCoursesInfo;
        private TextBox txtSelectedStudentId;
        private TextBox txtSelectedStudent;
        private Label lblSelectedStudent;
        private Label lblSelectedStudentId;
    }
}