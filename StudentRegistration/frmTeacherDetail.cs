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
    public partial class frmTeacherDetail : Form
    {
        public frmTeacherDetail()
        {
            InitializeComponent();
        }

        SqlConnection data_connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbOBS;Integrated Security=True;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void frmTeacherDetail_Load(object sender, EventArgs e)
        {
            //this.TBLSTDTableAdapter.Fill(this.sqlDataAdapterBindingSource.TBLSTD);
        }

        private void sqlDataAdapterBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            data_connection.Open();
            SqlCommand command = new SqlCommand("insert into TBLSTD (STDNO,STDNAME,STDSURNAME) values (@p1,@p2,@p3)", data_connection);
            command.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p2", textBox3.Text);
            command.Parameters.AddWithValue("@p3", textBox2.Text);
            command.ExecuteNonQuery();
            data_connection.Close();
            MessageBox.Show("Student added successfuly.");
            dataGridView1.Refresh(); 
        }
    }
}
