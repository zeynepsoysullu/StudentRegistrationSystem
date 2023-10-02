using System.Data.SqlClient;
namespace Visual_Project
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OTRGS7H\SQLEXPRESS;Initial Catalog=CourseStudentRegistration;Integrated Security=True");

        private void GetData()
        {
            con.Open();
            SqlCommand Command = new SqlCommand("SELECT * FROM Teacher", con);
            SqlDataReader read = Command.ExecuteReader();
            while (read.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = read["ID"].ToString();
                item.SubItems.Add(read["TeacherName"].ToString());
                item.SubItems.Add(read["TeacherSurname"].ToString());

                listViewTeacher.Items.Add(item);
            }
            con.Close();
            
        }
       private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 HomePage = new Form1();
            HomePage.Show();
            this.Hide();
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            listViewTeacher.Items.Clear();
            GetData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand Command = new SqlCommand("DELETE FROM Teacher WHERE ID" + " = " + txtID.Text, con);
            Command.ExecuteReader();

            con.Close();
            MessageBox.Show("Deleted completed", "Successful");
            txtID.Clear();
        }
    }
}
