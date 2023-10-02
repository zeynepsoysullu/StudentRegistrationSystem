namespace Visual_Project
{
    partial class ASSIGNMENT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ASSIGNMENT));
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbBoxCourseTe = new System.Windows.Forms.ComboBox();
            this.cmbBoxTeacher = new System.Windows.Forms.ComboBox();
            this.cmbBoxCourseSt = new System.Windows.Forms.ComboBox();
            this.cmbBoxCourseStudent = new System.Windows.Forms.ComboBox();
            this.lblTeacherAssigment = new System.Windows.Forms.Label();
            this.lblStudentAssignment = new System.Windows.Forms.Label();
            this.lblAssignment = new System.Windows.Forms.Label();
            this.btnAssignment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Linen;
            this.btnBack.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(484, 286);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 55);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbBoxCourseTe
            // 
            this.cmbBoxCourseTe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCourseTe.FormattingEnabled = true;
            this.cmbBoxCourseTe.Location = new System.Drawing.Point(279, 89);
            this.cmbBoxCourseTe.Name = "cmbBoxCourseTe";
            this.cmbBoxCourseTe.Size = new System.Drawing.Size(151, 28);
            this.cmbBoxCourseTe.TabIndex = 1;
            // 
            // cmbBoxTeacher
            // 
            this.cmbBoxTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxTeacher.FormattingEnabled = true;
            this.cmbBoxTeacher.Location = new System.Drawing.Point(452, 89);
            this.cmbBoxTeacher.Name = "cmbBoxTeacher";
            this.cmbBoxTeacher.Size = new System.Drawing.Size(151, 28);
            this.cmbBoxTeacher.TabIndex = 2;
            // 
            // cmbBoxCourseSt
            // 
            this.cmbBoxCourseSt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCourseSt.FormattingEnabled = true;
            this.cmbBoxCourseSt.Location = new System.Drawing.Point(279, 206);
            this.cmbBoxCourseSt.Name = "cmbBoxCourseSt";
            this.cmbBoxCourseSt.Size = new System.Drawing.Size(151, 28);
            this.cmbBoxCourseSt.TabIndex = 3;
            // 
            // cmbBoxCourseStudent
            // 
            this.cmbBoxCourseStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCourseStudent.FormattingEnabled = true;
            this.cmbBoxCourseStudent.Location = new System.Drawing.Point(452, 206);
            this.cmbBoxCourseStudent.Name = "cmbBoxCourseStudent";
            this.cmbBoxCourseStudent.Size = new System.Drawing.Size(151, 28);
            this.cmbBoxCourseStudent.TabIndex = 4;
            // 
            // lblTeacherAssigment
            // 
            this.lblTeacherAssigment.AutoSize = true;
            this.lblTeacherAssigment.BackColor = System.Drawing.Color.Linen;
            this.lblTeacherAssigment.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTeacherAssigment.Location = new System.Drawing.Point(33, 94);
            this.lblTeacherAssigment.Name = "lblTeacherAssigment";
            this.lblTeacherAssigment.Size = new System.Drawing.Size(231, 23);
            this.lblTeacherAssigment.TabIndex = 21;
            this.lblTeacherAssigment.Text = "Teacher Assigment";
            // 
            // lblStudentAssignment
            // 
            this.lblStudentAssignment.AutoSize = true;
            this.lblStudentAssignment.BackColor = System.Drawing.Color.Linen;
            this.lblStudentAssignment.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudentAssignment.Location = new System.Drawing.Point(29, 211);
            this.lblStudentAssignment.Name = "lblStudentAssignment";
            this.lblStudentAssignment.Size = new System.Drawing.Size(244, 23);
            this.lblStudentAssignment.TabIndex = 22;
            this.lblStudentAssignment.Text = "Student Assignment";
            // 
            // lblAssignment
            // 
            this.lblAssignment.AutoSize = true;
            this.lblAssignment.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblAssignment.Font = new System.Drawing.Font("SimSun-ExtB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAssignment.Location = new System.Drawing.Point(33, 38);
            this.lblAssignment.Name = "lblAssignment";
            this.lblAssignment.Size = new System.Drawing.Size(217, 37);
            this.lblAssignment.TabIndex = 24;
            this.lblAssignment.Text = "Assignment";
            // 
            // btnAssignment
            // 
            this.btnAssignment.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAssignment.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAssignment.Location = new System.Drawing.Point(297, 286);
            this.btnAssignment.Name = "btnAssignment";
            this.btnAssignment.Size = new System.Drawing.Size(158, 55);
            this.btnAssignment.TabIndex = 5;
            this.btnAssignment.Text = "&Assignment";
            this.btnAssignment.UseVisualStyleBackColor = false;
            this.btnAssignment.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // ASSIGNMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(650, 386);
            this.Controls.Add(this.btnAssignment);
            this.Controls.Add(this.lblAssignment);
            this.Controls.Add(this.lblStudentAssignment);
            this.Controls.Add(this.lblTeacherAssigment);
            this.Controls.Add(this.cmbBoxCourseStudent);
            this.Controls.Add(this.cmbBoxCourseSt);
            this.Controls.Add(this.cmbBoxTeacher);
            this.Controls.Add(this.cmbBoxCourseTe);
            this.Controls.Add(this.btnBack);
            this.Name = "ASSIGNMENT";
            this.Text = "ASSIGNMENT";
            this.Load += new System.EventHandler(this.ASSIGNMENT_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private ComboBox cmbBoxCourseTe;
        private ComboBox cmbBoxTeacher;
        private ComboBox cmbBoxCourseSt;
        private ComboBox cmbBoxCourseStudent;
        private Label lblTeacherAssigment;
        private Label lblStudentAssignment;
        private ColumnHeader Id;
        private Label lblAssignment;
        private Button btnAssignment;
    }
}