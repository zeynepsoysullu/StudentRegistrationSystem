using System.Data.SqlClient;

namespace Visual_Project
{
    public partial class INSTALLEMENT : Form
    {
        public INSTALLEMENT()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OTRGS7H\SQLEXPRESS;Initial Catalog=CourseStudentRegistration;Integrated Security=True"); // connection string yani sql adresini içeren string 

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 HomePage = new Form1();
            HomePage.Show();
            this.Hide();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lstViewFee.Items.Clear();
            con.Open();
            if (comboBox1.Text!="")
            {
                SqlCommand Command = new SqlCommand("SELECT * FROM " + comboBox1.Text, con);
                SqlDataReader read = Command.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = read["ID"].ToString();
                    item.SubItems.Add(read["Name"].ToString());
                    item.SubItems.Add(read["Surname"].ToString());
                    item.SubItems.Add(read["Semester"].ToString());
                    item.SubItems.Add(read["StudentOrTeacher"].ToString());
                    item.SubItems.Add(read["Fee"].ToString());
                    item.SubItems.Add(read["Installment1"].ToString());
                    item.SubItems.Add(read["Installment2"].ToString());
                    item.SubItems.Add(read["Installment3"].ToString());
                    item.SubItems.Add(read["Installment4"].ToString());
                    item.SubItems.Add(read["Installment5"].ToString());
                    
                    lstViewFee.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Please fill in the fields.", "Error");
            }
            
            con.Close();

            
        }

        private void INSTALLEMENT_Load(object sender, EventArgs e)
        {
            SqlCommand CourseCommand = new SqlCommand("SELECT * FROM Course", con); // sql komutu Course tablosuna connection stringi kullanarak sorgu yapan satır
            con.Open(); // Database ile bağlantıyı açar
            SqlDataReader Coursesdr = CourseCommand.ExecuteReader();// Tablodaki verileri okur
            while (Coursesdr.Read())// tabloda kaç kayıt varsa okuyana kadar dön
            {
                comboBox1.Items.Add(Coursesdr["CourseName"]); //combobox 1 course name columnlarındaki değerleri ekle
                //CourseList.Add(new Course()// course Listesine ekle 
                //{
                //    Id = ((int)Coursesdr["ID"]),// Database deki course tablosunda id değerlerini course liste ekle
                //    CourseName = Coursesdr["CourseName"] as string,// Database deki course tablosunda name değerlerini course liste ekle
                //});
            }
            con.Close();// bağlantıyı kapat
        }
    }
}
