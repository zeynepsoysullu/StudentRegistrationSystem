namespace Visual_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExıt = new System.Windows.Forms.Button();
            this.chckBoxShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Bisque;
            this.txtUserName.Location = new System.Drawing.Point(269, 112);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(152, 27);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Bisque;
            this.txtPassword.Location = new System.Drawing.Point(269, 214);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(152, 27);
            this.txtPassword.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblUserName.Font = new System.Drawing.Font("SimSun-ExtB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.Location = new System.Drawing.Point(35, 112);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(197, 37);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblPassword.Font = new System.Drawing.Font("SimSun-ExtB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(45, 201);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(177, 37);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnLogin.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(508, 112);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 60);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExıt
            // 
            this.btnExıt.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnExıt.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExıt.Location = new System.Drawing.Point(508, 201);
            this.btnExıt.Name = "btnExıt";
            this.btnExıt.Size = new System.Drawing.Size(121, 57);
            this.btnExıt.TabIndex = 5;
            this.btnExıt.Text = "&Exıt";
            this.btnExıt.UseVisualStyleBackColor = false;
            this.btnExıt.Click += new System.EventHandler(this.btnExıt_Click);
            // 
            // chckBoxShow
            // 
            this.chckBoxShow.AutoSize = true;
            this.chckBoxShow.Location = new System.Drawing.Point(354, 275);
            this.chckBoxShow.Name = "chckBoxShow";
            this.chckBoxShow.Size = new System.Drawing.Size(67, 24);
            this.chckBoxShow.TabIndex = 3;
            this.chckBoxShow.Text = "Show";
            this.chckBoxShow.UseVisualStyleBackColor = true;
            this.chckBoxShow.CheckedChanged += new System.EventHandler(this.chckBoxShow_CheckedChanged_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(745, 416);
            this.Controls.Add(this.chckBoxShow);
            this.Controls.Add(this.btnExıt);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Name = "Login";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lblUserName;
        private Label lblPassword;
        private Button btnLogin;
        private Button btnExıt;
        private CheckBox chckBoxShow;
    }
}