namespace Visual_Project
{
    partial class REPORT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REPORT));
            this.lblReport = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblReport.Font = new System.Drawing.Font("SimSun-ExtB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReport.Location = new System.Drawing.Point(60, 25);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(137, 37);
            this.lblReport.TabIndex = 1;
            this.lblReport.Text = "Report";
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnPayment.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPayment.Location = new System.Drawing.Point(371, 178);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(278, 58);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "&Pay List";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.BackColor = System.Drawing.Color.Linen;
            this.btnCourse.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCourse.Location = new System.Drawing.Point(371, 89);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(278, 58);
            this.btnCourse.TabIndex = 3;
            this.btnCourse.Text = "&Course List";
            this.btnCourse.UseVisualStyleBackColor = false;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.BackColor = System.Drawing.Color.Linen;
            this.btnTeacher.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTeacher.Location = new System.Drawing.Point(60, 166);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(278, 58);
            this.btnTeacher.TabIndex = 2;
            this.btnTeacher.Text = "&Teacher List";
            this.btnTeacher.UseVisualStyleBackColor = false;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnStudent.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStudent.Location = new System.Drawing.Point(60, 89);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(278, 58);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "&Student List";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Linen;
            this.btnBack.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(538, 268);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 62);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // REPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(667, 384);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.btnTeacher);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.lblReport);
            this.Name = "REPORT";
            this.Text = "REPORT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblReport;
        private Button btnPayment;
        private Button btnCourse;
        private Button btnTeacher;
        private Button btnStudent;
        private Button btnBack;
    }
}