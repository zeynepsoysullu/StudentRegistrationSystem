using System.Data;
using System.Data.SqlClient;

namespace Visual_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OTRGS7H\SQLEXPRESS;Initial Catalog=CourseStudentRegistration;Integrated Security=True");
        private void btnExıt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill in the Fields", "Error");
            }
            else
            {
                con.Open();
                SqlCommand CommandLoginScreen = new SqlCommand("SELECT * FROM LoginScreen", con);
                SqlDataReader Loginsdr = CommandLoginScreen.ExecuteReader();
                while (Loginsdr.Read()) // tabloda kaç kayıt varsa okuyana kadar dön
                {
                    if (txtUserName.Text == Loginsdr["Users_name"].ToString() && txtPassword.Text == Loginsdr["PaswordNo"].ToString())
                    {
                        
                        Form1 HomePage = new Form1();
                        HomePage.Show();
                        this.Hide();
                        
                    }
                }
                con.Close();
                txtUserName.Clear();
                txtPassword.Clear();
            }

            //if (txtUserName.Text == "" || txtPassword.Text == "")
            //{
            //    MessageBox.Show("Username and password cannot be passed blank.", "Warning!");
            //    txtUserName.Clear();
            //    txtPassword.Clear();
            //}
            //else
            //{
            //    if (txtUserName.Text == "zeynep" && txtPassword.Text == "1411")
            //    {
            //        Form1 HomePage = new Form1();
            //        HomePage.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("The username or password is incorrect.", "Warning!");
            //        txtUserName.Clear();
            //        txtPassword.Clear();
            //    }

            //}

        }


        private void chckBoxShow_CheckedChanged_1(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (chckBoxShow.Checked)
            {
                //karakteri göster.
                txtPassword.PasswordChar = '\0';
                chckBoxShow.Text = "Hide";
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                txtPassword.PasswordChar = '*';
                chckBoxShow.Text = "Show";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }

}

