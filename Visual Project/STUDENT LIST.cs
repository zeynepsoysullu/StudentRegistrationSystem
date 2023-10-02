using System.Data.SqlClient;
namespace Visual_Project
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OTRGS7H\SQLEXPRESS;Initial Catalog=CourseStudentRegistration;Integrated Security=True");
        private void GetData()
        {
            con.Open();
            SqlCommand Command = new SqlCommand("SELECT * FROM Student", con);
            SqlDataReader read = Command.ExecuteReader();
            while (read.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = read["ID"].ToString();
                item.SubItems.Add(read["StudentName"].ToString());
                item.SubItems.Add(read["StudentSurname"].ToString());
                item.SubItems.Add(read["StudentNo"].ToString());

                listViewStudent.Items.Add(item);
            }
            con.Close();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 HomePage = new Form1();
            HomePage.Show();
            this.Hide();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            listViewStudent.Items.Clear();
            GetData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand Command = new SqlCommand("DELETE FROM Student WHERE ID" + " = " + txtID.Text, con);
            Command.ExecuteReader();

            con.Close();
            MessageBox.Show("Deletion completed", "Successful");
            txtID.Clear();
        }
    }
}
