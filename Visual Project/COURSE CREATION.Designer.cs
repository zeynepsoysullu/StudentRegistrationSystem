namespace Visual_Project
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.lblCourseCreation = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseSemester = new System.Windows.Forms.Label();
            this.txtBoxCourseName = new System.Windows.Forms.TextBox();
            this.cmbBoxCouerseSemester = new System.Windows.Forms.ComboBox();
            this.txtBoxFee = new System.Windows.Forms.TextBox();
            this.lblFee = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCourseCreation
            // 
            this.lblCourseCreation.AutoSize = true;
            this.lblCourseCreation.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblCourseCreation.Font = new System.Drawing.Font("SimSun-ExtB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCourseCreation.Location = new System.Drawing.Point(35, 21);
            this.lblCourseCreation.Name = "lblCourseCreation";
            this.lblCourseCreation.Size = new System.Drawing.Size(317, 37);
            this.lblCourseCreation.TabIndex = 0;
            this.lblCourseCreation.Text = "Course Creation";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.Color.Linen;
            this.lblCourseName.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCourseName.Location = new System.Drawing.Point(42, 87);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(153, 23);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "Course Name";
            // 
            // lblCourseSemester
            // 
            this.lblCourseSemester.AutoSize = true;
            this.lblCourseSemester.BackColor = System.Drawing.Color.Linen;
            this.lblCourseSemester.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCourseSemester.Location = new System.Drawing.Point(42, 150);
            this.lblCourseSemester.Name = "lblCourseSemester";
            this.lblCourseSemester.Size = new System.Drawing.Size(205, 23);
            this.lblCourseSemester.TabIndex = 2;
            this.lblCourseSemester.Text = "Course Semester";
            // 
            // txtBoxCourseName
            // 
            this.txtBoxCourseName.Location = new System.Drawing.Point(256, 88);
            this.txtBoxCourseName.Name = "txtBoxCourseName";
            this.txtBoxCourseName.Size = new System.Drawing.Size(149, 27);
            this.txtBoxCourseName.TabIndex = 1;
            // 
            // cmbBoxCouerseSemester
            // 
            this.cmbBoxCouerseSemester.FormattingEnabled = true;
            this.cmbBoxCouerseSemester.Items.AddRange(new object[] {
            "Fall Semester ( 4 Months)",
            "Spring Semester ( 3 Months)"});
            this.cmbBoxCouerseSemester.Location = new System.Drawing.Point(256, 151);
            this.cmbBoxCouerseSemester.Name = "cmbBoxCouerseSemester";
            this.cmbBoxCouerseSemester.Size = new System.Drawing.Size(236, 28);
            this.cmbBoxCouerseSemester.TabIndex = 2;
            
            // 
            // txtBoxFee
            // 
            this.txtBoxFee.Location = new System.Drawing.Point(256, 205);
            this.txtBoxFee.Name = "txtBoxFee";
            this.txtBoxFee.Size = new System.Drawing.Size(149, 27);
            this.txtBoxFee.TabIndex = 3;
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.BackColor = System.Drawing.Color.Linen;
            this.lblFee.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFee.Location = new System.Drawing.Point(42, 205);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(49, 23);
            this.lblFee.TabIndex = 5;
            this.lblFee.Text = "Fee";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCreate.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(194, 260);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(102, 41);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Linen;
            this.btnBack.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(315, 260);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 41);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(495, 361);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtBoxFee);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.cmbBoxCouerseSemester);
            this.Controls.Add(this.txtBoxCourseName);
            this.Controls.Add(this.lblCourseSemester);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblCourseCreation);
            this.Name = "Form4";
            this.Text = "COURSE CREATION";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCourseCreation;
        private Label lblCourseName;
        private Label lblCourseSemester;
        private TextBox txtBoxCourseName;
        private ComboBox cmbBoxCouerseSemester;
        private TextBox txtBoxFee;
        private Label lblFee;
        private Button btnCreate;
        private Button btnBack;
        private Label label1;
    }
}