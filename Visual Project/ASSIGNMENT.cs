using System.Data;
using System.Data.SqlClient;


namespace Visual_Project
{
    public partial class ASSIGNMENT : Form
    {
        public ASSIGNMENT()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OTRGS7H\SQLEXPRESS;Initial Catalog=CourseStudentRegistration;Integrated Security=True"); // connection string yani sql adresini içeren string 
      
     
        private void GetStudent()
        {
            
            SqlCommand CommandStudent = new SqlCommand("SELECT * FROM Student", con); // sql komutu Student tablosuna connection stringi kullanarak sorgu yapan satır
            con.Open(); // Database ile bağlantıyı açar
            SqlDataReader Studentsdr = CommandStudent.ExecuteReader(); // Tablodaki verileri okur
            while (Studentsdr.Read()) // tabloda kaç kayıt varsa okuyana kadar dön
            {
                cmbBoxCourseStudent.Items.Add(Studentsdr["StudentSurname"]); //combobox 4 student name columnlarındaki değerleri ekle
                //StudentList.Add(new Student() // Student Listesine ekle 
                //{
                //    Id = ((int)Studentsdr["ID"]), // Database deki student tablosunda id değerlerini student liste ekle
                //    StudentName = Studentsdr["StudentName"] as string,// Database deki student tablosunda name değerlerini student liste ekle
                //});
            }
            con.Close(); // bağlantıyı kapat

        }
        private void GetTeacher()
        {
            SqlCommand CommandTeacher = new SqlCommand("SELECT * FROM Teacher", con);// sql komutu Teacher tablosuna connection stringi kullanarak sorgu yapan satır
            con.Open(); // Database ile bağlantıyı açar
            SqlDataReader Teachersdr = CommandTeacher.ExecuteReader();// Tablodaki verileri okur
            while (Teachersdr.Read())// tabloda kaç kayıt varsa okuyana kadar dön
            {
                cmbBoxTeacher.Items.Add(Teachersdr["TeacherSurname"]); //combobox 2 teacher name columnlarındaki değerleri ekle
                //TeacherList.Add(new Teacher()// teacher Listesine ekle 
                //{
                //    Id = ((int)Teachersdr["ID"]),// Database deki teacher tablosunda id değerlerini teacher liste ekle
                //    TeacherName = Teachersdr["TeacherName"] as string,// Database deki teacher tablosunda name değerlerini teacher liste ekle
                //});
            }
            con.Close();// bağlantıyı kapat
        }
        private void GetCourse()
        {
            SqlCommand CourseCommand = new SqlCommand("SELECT * FROM Course", con); // sql komutu Course tablosuna connection stringi kullanarak sorgu yapan satır
            con.Open(); // Database ile bağlantıyı açar
            SqlDataReader Coursesdr = CourseCommand.ExecuteReader();// Tablodaki verileri okur
            while (Coursesdr.Read())// tabloda kaç kayıt varsa okuyana kadar dön
            {
                cmbBoxCourseTe.Items.Add(Coursesdr["CourseName"]); //combobox 1 course name columnlarındaki değerleri ekle
                cmbBoxCourseSt.Items.Add(Coursesdr["CourseName"]); //combobox 3 course name columnlarındaki değerleri ekle
                //CourseList.Add(new Course()// course Listesine ekle 
                //{
                //    Id = ((int)Coursesdr["ID"]),// Database deki course tablosunda id değerlerini course liste ekle
                //    CourseName = Coursesdr["CourseName"] as string,// Database deki course tablosunda name değerlerini course liste ekle
                //});
            }
            con.Close();// bağlantıyı kapat
        }
   
        //public class araba
        //{
        //    public string Marka { get; set; }
        //    public TekerlekMarkası Tekerlek { get; set; }
        //}
        //public class TekerlekMarkası
        //{
        //    public string Audi { get; set; }
        //    public string Bmw { get; set; }
        //}


        private void btnCreate_Click(object sender, EventArgs e)
        {
            con.Open();
            if ((cmbBoxCourseTe.Text == "" || cmbBoxTeacher.Text == "" )& (cmbBoxCourseSt.Text =="" || cmbBoxCourseStudent.Text==""))
            {
                MessageBox.Show("Please fill in the fields .", "Error");
            }
            else
            {
            if (cmbBoxCourseTe.Text != "" && cmbBoxTeacher.Text != "")
            {

                string sql = "select * from Teacher where TeacherSurname = '"+ cmbBoxTeacher.Text + "' ";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                DataTable table = new DataTable();
                adapter.Fill(table);
                
                var ad=table.Rows[0]["TeacherName"].ToString();
                
                var teacherorstudent = "Teacher";
                var Installment = "-";
                string sqlTeacher = "insert into " + cmbBoxCourseTe.Text + "(Name,Surname,StudentOrTeacher,Installment1,Installment2,Installment3,Installment4,Installment5)Values('" + ad + "','" + cmbBoxTeacher.Text + "','" + teacherorstudent + "','" + Installment + "','" + Installment + "','" + Installment + "','" + Installment + "','" + Installment + "')";

                SqlCommand cmd2 = new SqlCommand(sqlTeacher, con);
                cmd2.ExecuteNonQuery();

            }
            if (cmbBoxCourseSt.Text!="" && cmbBoxCourseStudent.Text != "")
            {
                string sql = "select * from Student where StudentSurname = '" + cmbBoxCourseStudent.Text + "' ";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                DataTable table = new DataTable();
                adapter.Fill(table);

                var ad = table.Rows[0]["StudentName"].ToString();

                var teacherorstudent = "Student";
                var Installment = "not paid";
                string sqlStudent = "insert into " + cmbBoxCourseSt.Text + "(Name,Surname,StudentOrTeacher,Installment1,Installment2,Installment3,Installment4,Installment5)Values('" + ad + "','" + cmbBoxCourseStudent.Text + "','" + teacherorstudent + "','" + Installment + "','" + Installment + "','" + Installment + "','" + Installment + "','" + Installment + "')";

                SqlCommand cmd2 = new SqlCommand(sqlStudent, con);
                cmd2.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Assignment completed", "Successful");
            }

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 HomePage = new Form1();
            HomePage.Show();
            this.Hide();
        }

        private void ASSIGNMENT_Load_1(object sender, EventArgs e)
        {
            GetTeacher();
            GetStudent();
            GetCourse();
        }
    }
}
