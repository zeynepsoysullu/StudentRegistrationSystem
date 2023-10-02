namespace Visual_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Hide();
        }

        private void btnStudentRegistration_Click(object sender, EventArgs e)//Form 2 ye yani öðrenci Ekranýna giden button
        {
            Form2 StudentRegistiration = new Form2();
            StudentRegistiration.Show();
            this.Hide();
        }
        private void btnCourseCreation_Click(object sender, EventArgs e)//Form 4 ye yani Course Ekranýna giden button
        {
            Form4 CourseCreation = new Form4();
            CourseCreation.Show();
            this.Hide();
        }
        private void btnFee_Click(object sender, EventArgs e)
        {
            FEE Fee = new FEE();
            Fee.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            REPORT Report = new REPORT();
            Report.Show();
            this.Hide();
        }
        private void btnCreatingInstructorRegistration_Click_1(object sender, EventArgs e)//Form 3 ye yani Teacher Ekranýna giden button
        {
            Form3 CreatingInstructorRegistration = new Form3();
            CreatingInstructorRegistration.Show();
            this.Hide();
        }
        private void btnAssignment_Click_1(object sender, EventArgs e)//Form 5 ye yani Atama Ekranýna giden button
        {
            ASSIGNMENT Assignment = new ASSIGNMENT();
            Assignment.Show();
            this.Hide();
        }


        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            HELP AboutSetting = new HELP();
            AboutSetting.Show();
            this.Hide();
        }
    }
}