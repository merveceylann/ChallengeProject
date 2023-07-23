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
using System.Security.Cryptography;

namespace StudentRegistration
{
    public partial class frmTeacherDetail : Form
    {
        public frmTeacherDetail()
        {
            InitializeComponent();
        }

        SqlConnection data_connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbOBS;Integrated Security=True;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        void GridFill()
        {
            data_connection.Open();

            SqlDataAdapter command = new SqlDataAdapter("select * from TBLSTD", data_connection);
            DataSet ds = new DataSet();

            command.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];

            data_connection.Close();
        }

        void StdState()
        {
            data_connection.Open();

            SqlCommand passedStd = new SqlCommand("select count(STATE) from TBLSTD where STATE=1", data_connection);
            int passedStdCount = (int)passedStd.ExecuteScalar();
            SqlCommand failedStd = new SqlCommand("select count(STATE) from TBLSTD where STATE=0", data_connection);
            int failedStdCount = (int)failedStd.ExecuteScalar();

            label12.Text = passedStdCount.ToString();
            label11.Text = failedStdCount.ToString();
          
            data_connection.Close();
        }
        private void frmTeacherDetail_Load(object sender, EventArgs e)
        {
            //this.TBLSTDTableAdapter.Fill(this.sqlDataAdapterBindingSource.TBLSTD);
            GridFill();
            StdState();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            data_connection.Open();
            SqlCommand command = new SqlCommand("insert into TBLSTD (STDNO, STDNAME, STDSURNAME) values (@p1, @p2, @p3)", data_connection);
            SqlCommand command2 = new SqlCommand("select * from TBLSTD", data_connection);
            command.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p2", textBox3.Text);
            command.Parameters.AddWithValue("@p3", textBox2.Text);
            command.ExecuteNonQuery();

            data_connection.Close();
            MessageBox.Show("Student added successfuly.");
            GridFill();
            StdState();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            maskedTextBox1.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            txtExam1.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            txtExam2.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            txtExam3.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();
            label10.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            double avg, e1, e2, e3;
            string state;
            e1 = Convert.ToDouble(txtExam1.Text);
            e2 = Convert.ToDouble(txtExam2.Text);
            e3 = Convert.ToDouble(txtExam3.Text);
            avg = (e1 + e2 + e3) / 3;
            label10.Text = avg.ToString();

            if (avg >= 50)
            {
                state = "True";
            }
            else
            {
                state = "False";
            }

            data_connection.Open();
            SqlCommand command = new SqlCommand("update TBLSTD set STDE1=@p1,  STDE2=@p2, STDE3=@p3, AVG=@p4, STATE=@p5 where STDNO=@p6", data_connection);

            command.Parameters.AddWithValue("@p1", txtExam1.Text);
            command.Parameters.AddWithValue("@p2", txtExam2.Text);
            command.Parameters.AddWithValue("@p3", txtExam3.Text);
            command.Parameters.AddWithValue("@p4", decimal.Parse(label10.Text));
            command.Parameters.AddWithValue("@p5", state);
            command.Parameters.AddWithValue("@p6", maskedTextBox1.Text);

            command.ExecuteNonQuery();
            data_connection.Close();
            GridFill();
            StdState();
            MessageBox.Show("Student updated successfuly.");
            
        }
    }
}
