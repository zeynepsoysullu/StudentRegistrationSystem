namespace Visual_Project
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblCreatingInstructorRegistration = new System.Windows.Forms.Label();
            this.lblInstructorName = new System.Windows.Forms.Label();
            this.lblInstructorSurname = new System.Windows.Forms.Label();
            this.txtBoxInstructorName = new System.Windows.Forms.TextBox();
            this.txtBoxInstructorSurname = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreatingInstructorRegistration
            // 
            this.lblCreatingInstructorRegistration.AutoSize = true;
            this.lblCreatingInstructorRegistration.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblCreatingInstructorRegistration.Font = new System.Drawing.Font("SimSun-ExtB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreatingInstructorRegistration.Location = new System.Drawing.Point(36, 37);
            this.lblCreatingInstructorRegistration.Name = "lblCreatingInstructorRegistration";
            this.lblCreatingInstructorRegistration.Size = new System.Drawing.Size(657, 37);
            this.lblCreatingInstructorRegistration.TabIndex = 0;
            this.lblCreatingInstructorRegistration.Text = "Creating Instructor Registration";
            // 
            // lblInstructorName
            // 
            this.lblInstructorName.AutoSize = true;
            this.lblInstructorName.BackColor = System.Drawing.Color.Linen;
            this.lblInstructorName.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInstructorName.Location = new System.Drawing.Point(40, 114);
            this.lblInstructorName.Name = "lblInstructorName";
            this.lblInstructorName.Size = new System.Drawing.Size(218, 23);
            this.lblInstructorName.TabIndex = 1;
            this.lblInstructorName.Text = "Instructor Name ";
            // 
            // lblInstructorSurname
            // 
            this.lblInstructorSurname.AutoSize = true;
            this.lblInstructorSurname.BackColor = System.Drawing.Color.Linen;
            this.lblInstructorSurname.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInstructorSurname.Location = new System.Drawing.Point(40, 168);
            this.lblInstructorSurname.Name = "lblInstructorSurname";
            this.lblInstructorSurname.Size = new System.Drawing.Size(257, 23);
            this.lblInstructorSurname.TabIndex = 2;
            this.lblInstructorSurname.Text = "Instructor Surname ";
            // 
            // txtBoxInstructorName
            // 
            this.txtBoxInstructorName.Location = new System.Drawing.Point(301, 114);
            this.txtBoxInstructorName.Name = "txtBoxInstructorName";
            this.txtBoxInstructorName.Size = new System.Drawing.Size(143, 27);
            this.txtBoxInstructorName.TabIndex = 1;
            // 
            // txtBoxInstructorSurname
            // 
            this.txtBoxInstructorSurname.Location = new System.Drawing.Point(301, 168);
            this.txtBoxInstructorSurname.Name = "txtBoxInstructorSurname";
            this.txtBoxInstructorSurname.Size = new System.Drawing.Size(143, 27);
            this.txtBoxInstructorSurname.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCreate.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(173, 234);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(105, 64);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Linen;
            this.btnBack.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(322, 236);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 62);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(705, 403);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtBoxInstructorSurname);
            this.Controls.Add(this.txtBoxInstructorName);
            this.Controls.Add(this.lblInstructorSurname);
            this.Controls.Add(this.lblInstructorName);
            this.Controls.Add(this.lblCreatingInstructorRegistration);
            this.Name = "Form3";
            this.Text = "INSTRUCTOR REGISTRATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCreatingInstructorRegistration;
        private Label lblInstructorName;
        private Label lblInstructorSurname;
        private TextBox txtBoxInstructorName;
        private TextBox txtBoxInstructorSurname;
        private Button btnCreate;
        private Button btnBack;
    }
}