﻿using System.Data.SqlClient;

namespace Visual_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OTRGS7H\SQLEXPRESS;Initial Catalog=CourseStudentRegistration;Integrated Security=True");

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 HomePage = new Form1();
            HomePage.Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "" || txtBoxSurname.Text == "" || txtBoxStudentNum.Text == "") //text box değerleri yoksa bu alana gir
            {
                MessageBox.Show("Please fill in the Fields", "Error");
            }
            else
            {
                con.Open();
                SqlCommand command = new SqlCommand("insert into Student (StudentName,StudentSurname,StudentNo)values ('" + txtBoxName.Text.ToString() + "','" + txtBoxSurname.Text.ToString() + "','" + txtBoxStudentNum.Text.ToString() + "')", con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registration has been created.", "Successful");
            }

        }
    }
}
