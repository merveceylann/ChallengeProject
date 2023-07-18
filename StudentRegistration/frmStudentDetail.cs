using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentRegistration
{
    public partial class frmStudentDetail : Form
    {
        public frmStudentDetail()
        {
            InitializeComponent();
        }
        public string number;

        SqlConnection data_connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbOBS;Integrated Security=True;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void frmStudentDetail_Load(object sender, EventArgs e)
        {
            lblNumber.Text = number;

            data_connection.Open();
            SqlCommand command = new SqlCommand("select * from TBLSTD where STDNO=@p1", data_connection);
            command.Parameters.AddWithValue("@p1", number);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblNameSurname.Text = reader[2].ToString() + " " + reader[3].ToString();
                lblExam1.Text = reader[4].ToString();
                lblExam2.Text = reader[5].ToString();
                lblExam3.Text = reader[6].ToString();
                lblAvg.Text = reader[7].ToString();
                lblState.Text = reader[8].ToString();
            }
            data_connection.Close();
        }
    }
}
