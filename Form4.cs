using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_6
{
    public partial class Form4 : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["BD_6.Properties.Settings.db22207ConnectionString"].ConnectionString;

        public Form4()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(new[] { InsertData.Data[0], InsertData.Data[3], InsertData.Data[2] });
            getPupils();
            comboBox2.Items.AddRange(new string[] { "2", "3", "4", "5" });
        }

        private void getPupils()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select concat(replace(txtPupilSurname, ' ', ''), ' ' ,replace(txtPupilName, ' ', '') ) " +
                    "as 'conc' from tblPupil", connection);


                DataSet ds = new DataSet();
                adapter.Fill(ds);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.ValueMember = "conc";
                connection.Close();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["BD_6.Properties.Settings.db22207ConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            var dateF = InsertData.Data[3].ToString().Split(' ')[0].Split('.');
            var date = dateF[2] + "-" + dateF[1] + "-" + dateF[0];
            SqlCommand command = new SqlCommand(
                "insert into tblMark(intLessonId, intPupilId, intMarkValue, txtMarkComment)"
                + " select les = (select top 1 intLessonId from tblLesson, tblSubject where tblLesson.intSubjectId = tblSubject.intSubjectId and" +
                " tblSubject.txtSubjectName = '" + InsertData.Data[0].ToString() + "' and tblLesson.datLessonDate = '" + date + "'), pup = " +
                "(select intPupilId from tblPupil where  '" + comboBox1.Text.Split(' ')[0] + "'= txtPupilSurname and txtPupilName ='" + comboBox1.Text.Split(' ')[1] + "'), " +
                " mark = " + comboBox2.Text + ", com ='"+ textBox1.Text + "'"
                , sqlConnection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            sqlDataReader.Close();

            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
