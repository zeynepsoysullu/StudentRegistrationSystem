namespace Visual_Project
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.listViewTeacher = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetList = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewTeacher
            // 
            this.listViewTeacher.BackColor = System.Drawing.Color.Linen;
            this.listViewTeacher.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewTeacher.Location = new System.Drawing.Point(12, 12);
            this.listViewTeacher.Name = "listViewTeacher";
            this.listViewTeacher.Size = new System.Drawing.Size(368, 412);
            this.listViewTeacher.TabIndex = 0;
            this.listViewTeacher.UseCompatibleStateImageBehavior = false;
            this.listViewTeacher.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TeacherName";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TeacherSurname";
            this.columnHeader3.Width = 150;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(440, 248);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(70, 27);
            this.txtID.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Linen;
            this.lblID.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(459, 213);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(36, 23);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "Id";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDelete.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(423, 291);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 54);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGetList
            // 
            this.btnGetList.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnGetList.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetList.Location = new System.Drawing.Point(423, 37);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(110, 64);
            this.btnGetList.TabIndex = 5;
            this.btnGetList.Text = "&Get List";
            this.btnGetList.UseVisualStyleBackColor = false;
            this.btnGetList.Click += new System.EventHandler(this.btnGetList_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Linen;
            this.btnBack.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(418, 367);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 47);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(559, 472);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnGetList);
            this.Controls.Add(this.listViewTeacher);
            this.Name = "Form11";
            this.Text = "TEACHER LIST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listViewTeacher;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox txtID;
        private Label lblID;
        private Button btnDelete;
        private Button btnGetList;
        private Button btnBack;
    }
}