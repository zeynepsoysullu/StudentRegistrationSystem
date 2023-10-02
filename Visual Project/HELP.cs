namespace Visual_Project
{
    public partial class HELP : Form
    {
        public HELP()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 HomePage = new Form1();
            HomePage.Show();
            this.Hide();
        }
    }
}
