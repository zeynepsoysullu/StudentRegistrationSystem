using System.Data.SqlClient;


namespace Visual_Project
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OTRGS7H\SQLEXPRESS;Initial Catalog=CourseStudentRegistration;Integrated Security=True");
        private void GetData()
        {
            con.Open();
            SqlCommand Command = new SqlCommand("SELECT * FROM Course", con);
            SqlDataReader read = Command.ExecuteReader();
            while (read.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = read["ID"].ToString();
                item.SubItems.Add(read["CourseName"].ToString());
                item.SubItems.Add(read["Fee"].ToString());
                item.SubItems.Add(read["Semester"].ToString());

                listViewCourse.Items.Add(item);
            }
            con.Close();

        }
        
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Diğer formumu açabilmem için o formun classından nesne türetiyorum.
            Form1 HomePage = new Form1();
            //Show metodu ile nesne olarak türettiğim ikinci formumu açıyorum.
            HomePage.Show();
            //Bu mevcut formu kapatıyorum.
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                con.Open();
                SqlCommand Command = new SqlCommand("DELETE FROM Course WHERE ID" + " = " + txtId.Text, con);
                Command.ExecuteReader();

                con.Close();
                MessageBox.Show("Deletion completed", "Successful");
                txtId.Clear();
            }
            else
                MessageBox.Show("Lütfen id yi girin", "Hata");
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            listViewCourse.Items.Clear();
            GetData();
        }
    }
}
