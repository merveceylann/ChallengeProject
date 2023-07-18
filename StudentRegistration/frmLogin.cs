namespace StudentRegistration
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStudentDetail frmStudent = new frmStudentDetail();
            frmStudent.number = maskedTextBox1.Text;
            frmStudent.Show();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text=="1111")
            {
                frmTeacherDetail frmTeacher = new frmTeacherDetail();
                frmTeacher.Show();
            }
        }
    }
}