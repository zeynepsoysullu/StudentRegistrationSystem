using System.Data.SqlClient;


namespace Visual_Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OTRGS7H\SQLEXPRESS;Initial Catalog=CourseStudentRegistration;Integrated Security=True");// connection string yani sql adresini içeren string 

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 HomePage = new Form1();
            HomePage.Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtBoxCourseName.Text == "" || txtBoxFee.Text == "" || cmbBoxCouerseSemester.SelectedIndex == -1) //text box değerleri yoksa bu alana gir
            {
                MessageBox.Show("Please fill in the Fields", "Error");
            }
            else
            {
                try
                {
                    string sql = @"CREATE TABLE [dbo].[" + txtBoxCourseName.Text + @"](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NULL,
	[Surname] [varchar](30) NULL,
	[Semester] [varchar](50) DEFAULT " + "'" + cmbBoxCouerseSemester.Text + "'" + @",
	[StudentOrTeacher] [varchar](20) NULL,
	[Fee] [decimal](18,0) DEFAULT " + txtBoxFee.Text + @",
	[Installment1] [varchar](30) NULL,
	[Installment2] [varchar](30) NULL,
	[Installment3] [varchar](30) NULL,
	[Installment4] [varchar](30) NULL,
	[Installment5] [varchar](30) NULL,
	[CreationTime] datetime NULL
) ON [PRIMARY]";

                    con.Open();//Bağlantıyı açar
                    SqlCommand command2 = new SqlCommand(sql, con);
                    command2.ExecuteNonQuery();

                    SqlCommand command = new SqlCommand("insert into Course (CourseName,Fee,Semester)values ('" + txtBoxCourseName.Text.ToString() + "','" + txtBoxFee.Text + "','" + cmbBoxCouerseSemester.Text.ToString() + "')", con);//(con)Connection string kullanarak tabloya ulaşıyor text box ve comboboxlardan gelen değerleri Course tablosundaki değerlere atıyor ve yeni kayıt ekliyor
                    command.ExecuteNonQuery();//
                    con.Close();//Bağlantıyı kapat
                    MessageBox.Show("Registration has been created.", "Successful");
                    /*  GetData();// Dataları getiren metodu çağırır */
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning");
                }
            }
        }

    }
}
