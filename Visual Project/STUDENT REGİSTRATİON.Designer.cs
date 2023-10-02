namespace Visual_Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblStudentRegistration = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.lblStudentNum = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtBoxStudentNum = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCourseSemester = new System.Windows.Forms.Label();
            this.cmbBoxCouerseSemester = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblStudentRegistration
            // 
            this.lblStudentRegistration.AutoSize = true;
            this.lblStudentRegistration.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblStudentRegistration.Font = new System.Drawing.Font("SimSun-ExtB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudentRegistration.Location = new System.Drawing.Point(51, 29);
            this.lblStudentRegistration.Name = "lblStudentRegistration";
            this.lblStudentRegistration.Size = new System.Drawing.Size(417, 37);
            this.lblStudentRegistration.TabIndex = 0;
            this.lblStudentRegistration.Text = "Student Registration";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Linen;
            this.lblName.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(51, 106);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.Linen;
            this.lblSurname.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSurname.Location = new System.Drawing.Point(51, 160);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(101, 23);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(265, 107);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(125, 27);
            this.txtBoxName.TabIndex = 1;
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Location = new System.Drawing.Point(265, 161);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(125, 27);
            this.txtBoxSurname.TabIndex = 2;
            // 
            // lblStudentNum
            // 
            this.lblStudentNum.AutoSize = true;
            this.lblStudentNum.BackColor = System.Drawing.Color.Linen;
            this.lblStudentNum.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudentNum.Location = new System.Drawing.Point(51, 215);
            this.lblStudentNum.Name = "lblStudentNum";
            this.lblStudentNum.Size = new System.Drawing.Size(179, 23);
            this.lblStudentNum.TabIndex = 5;
            this.lblStudentNum.Text = "StudentNumber";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCreate.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(306, 379);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(117, 58);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtBoxStudentNum
            // 
            this.txtBoxStudentNum.Location = new System.Drawing.Point(265, 211);
            this.txtBoxStudentNum.Name = "txtBoxStudentNum";
            this.txtBoxStudentNum.Size = new System.Drawing.Size(125, 27);
            this.txtBoxStudentNum.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Linen;
            this.btnBack.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(440, 379);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 58);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCourseSemester
            // 
            this.lblCourseSemester.AutoSize = true;
            this.lblCourseSemester.BackColor = System.Drawing.Color.Linen;
            this.lblCourseSemester.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCourseSemester.Location = new System.Drawing.Point(54, 265);
            this.lblCourseSemester.Name = "lblCourseSemester";
            this.lblCourseSemester.Size = new System.Drawing.Size(205, 23);
            this.lblCourseSemester.TabIndex = 18;
            this.lblCourseSemester.Text = "Course Semester";
            // 
            // cmbBoxCouerseSemester
            // 
            this.cmbBoxCouerseSemester.FormattingEnabled = true;
            this.cmbBoxCouerseSemester.Items.AddRange(new object[] {
            "Fall Semester ( 4 Months)",
            "Spring Semester ( 3 Months)"});
            this.cmbBoxCouerseSemester.Location = new System.Drawing.Point(265, 260);
            this.cmbBoxCouerseSemester.Name = "cmbBoxCouerseSemester";
            this.cmbBoxCouerseSemester.Size = new System.Drawing.Size(203, 28);
            this.cmbBoxCouerseSemester.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(581, 468);
            this.Controls.Add(this.cmbBoxCouerseSemester);
            this.Controls.Add(this.lblCourseSemester);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtBoxStudentNum);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblStudentNum);
            this.Controls.Add(this.txtBoxSurname);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStudentRegistration);
            this.Name = "Form2";
            this.Text = "STUDENT REGİSTRATİON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Label lblStudentRegistration;
        private Label lblName;
        private Label lblSurname;
        private TextBox txtBoxName;
        private TextBox txtBoxSurname;
        private Label lblStudentNum;
        private OpenFileDialog openFileDialog2;
        private Button btnCreate;
        private TextBox txtBoxStudentNum;
        private ListView listViewStudent;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnBack;
        private Label lblCourseSemester;
        private ComboBox cmbBoxCouerseSemester;
    }
}