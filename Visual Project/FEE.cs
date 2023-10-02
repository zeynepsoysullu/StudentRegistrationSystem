using System.Data;
using System.Data.SqlClient;

namespace Visual_Project
{
    public partial class FEE : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OTRGS7H\SQLEXPRESS;Initial Catalog=CourseStudentRegistration;Integrated Security=True"); // connection string yani sql adresini içeren string 

        public FEE()
        {
            InitializeComponent();
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            con.Open();
            if (txtStudentName.Text != "" && txtStudentSurname.Text != "")
            {
                string sql2 = "select * from " + cmbBoxFee.Text + " where Surname = '" + txtStudentSurname.Text + "' ";
                SqlDataAdapter adapter2 = new SqlDataAdapter(sql2, con);
                DataTable table2 = new DataTable();
                adapter2.Fill(table2);

                int id = (int)table2.Rows[0]["Id"];
                string installment1 = table2.Rows[0]["Installment1"].ToString();
                string installment2 = table2.Rows[0]["Installment2"].ToString();
                string installment3 = table2.Rows[0]["Installment3"].ToString();
                string installment4 = table2.Rows[0]["Installment4"].ToString();
                string installment5 = table2.Rows[0]["Installment5"].ToString();
                if (installment1 == "not paid")
                {
                    string sqlInstallment = "UPDATE " + cmbBoxFee.Text + " SET Installment1 = 'Paid'  WHERE Id = " + id;
                    SqlCommand CommandInstallment1 = new SqlCommand(sqlInstallment, con); // sql komutu Student tablosuna connection stringi kullanarak sorgu yapan satır
                    SqlDataReader Installment1sdr = CommandInstallment1.ExecuteReader();
                }
                else if (installment2 == "not paid")
                {
                    string sqlInstallment = "UPDATE " + cmbBoxFee.Text + " SET Installment2 = 'Paid'  WHERE Id = " + id;
                    SqlCommand CommandInstallment = new SqlCommand(sqlInstallment, con); // sql komutu Student tablosuna connection stringi kullanarak sorgu yapan satır
                    SqlDataReader Installmentsdr = CommandInstallment.ExecuteReader();
                }
                else if (installment3 == "not paid")
                {
                    string sqlInstallment = "UPDATE " + cmbBoxFee.Text + " SET Installment3 = 'Paid'  WHERE Id = " + id;
                    SqlCommand CommandInstallment = new SqlCommand(sqlInstallment, con); // sql komutu Student tablosuna connection stringi kullanarak sorgu yapan satır
                    SqlDataReader Installmentsdr = CommandInstallment.ExecuteReader();
                }
                else if (installment4 == "not paid")
                {
                    string sqlInstallment = "UPDATE " + cmbBoxFee.Text + " SET Installment4 = 'Paid'  WHERE Id = " + id;
                    SqlCommand CommandInstallment = new SqlCommand(sqlInstallment, con); // sql komutu Student tablosuna connection stringi kullanarak sorgu yapan satır
                    SqlDataReader Installmentsdr = CommandInstallment.ExecuteReader();
                }
                else if (installment5 == "not paid")
                {
                    string sqlInstallment = "UPDATE " + cmbBoxFee.Text + " SET Installment5 = 'Paid'  WHERE Id = " + id;
                    SqlCommand CommandInstallment = new SqlCommand(sqlInstallment, con); // sql komutu Student tablosuna connection stringi kullanarak sorgu yapan satır
                    SqlDataReader Installmentsdr = CommandInstallment.ExecuteReader();
                }


            }
            con.Close();

            if (txtStudentName.Text == "" || txtStudentSurname.Text == "" || txtPrice.Text == "" || cmbBoxFee.SelectedIndex == -1) //text box değerleri yoksa bu alana gir
            {
                MessageBox.Show("Please fill in the Fields", "Error");
            }
            else
            {
            
                MessageBox.Show("Payment received.", "Successful");
            }
            
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 HomePage = new Form1();
            HomePage.Show();
            this.Hide();
        }

        private void cmbBoxFee_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select * from Course where CourseName = '" + cmbBoxFee.Text + "' ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

            DataTable table = new DataTable();
            adapter.Fill(table);

            decimal fee =(decimal) table.Rows[0]["Fee"];
            fee = fee / 5;
            txtPrice.Text = fee.ToString();
            con.Close();
            lblInstallment.Enabled = true;
            lblInstallment5.Enabled=true;
            lblPrice.Visible= true;
            txtPrice.Visible=true;

        }

        private void FEE_Load_1(object sender, EventArgs e)
        {
            lblInstallment.Enabled = false;
            lblInstallment5.Enabled = false;
            lblPrice.Visible = false;
            txtPrice.Visible = false;

            SqlCommand CommandStudent = new SqlCommand("SELECT * FROM Course", con); // sql komutu Student tablosuna connection stringi kullanarak sorgu yapan satır
            con.Open(); // Database ile bağlantıyı açar
            SqlDataReader Studentsdr = CommandStudent.ExecuteReader(); // Tablodaki verileri okur
            while (Studentsdr.Read()) // tabloda kaç kayıt varsa okuyana kadar dön
            {
                cmbBoxFee.Items.Add(Studentsdr["CourseName"]); //combobox 4 student name columnlarındaki değerleri ekle
                //StudentList.Add(new Student() // Student Listesine ekle 
                //{
                //    Id = ((int)Studentsdr["ID"]), // Database deki student tablosunda id değerlerini student liste ekle
                //    StudentName = Studentsdr["StudentName"] as string,// Database deki student tablosunda name değerlerini student liste ekle
                //});
            }
            con.Close();
        }
    }
}
