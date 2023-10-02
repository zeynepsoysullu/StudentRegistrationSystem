namespace Visual_Project
{
    public partial class REPORT : Form
    {
        public REPORT()
        {
            InitializeComponent();
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 HomePage = new Form1();
            HomePage.Show();
            this.Hide();
        }
        private void btnStudent_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Close();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Close();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Close();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            INSTALLEMENT Feelist = new INSTALLEMENT();
            Feelist.Show();
            this.Hide();
        }
    }
}
