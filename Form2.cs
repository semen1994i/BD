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
    public partial class Form2 : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["BD_6.Properties.Settings.db22207ConnectionString"].ConnectionString;

        private SqlConnection sqlConnection = new SqlConnection();
        public Form2()
        {
            InitializeComponent();
            ourTable();
            updateCombobox2();
            Show();
        }

        public void ourTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select txtSubjectName from tblSubject", connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.ValueMember = "txtSubjectName";
                connection.Close();
            }
            

        }

        private void updateCombobox2()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select txtTeacherName from tblTeacher " +
                    "join tblSubject on tblTeacher.intTeacherId = tblSubject.intTeacherId" +
                    " where " +
                    "tblSubject.txtSubjectName = '" + comboBox1.Text + "'", connection);


                DataSet ds = new DataSet();
                adapter.Fill(ds);
                teachers.DataSource = ds.Tables[0];
                teachers.ValueMember = "txtTeacherName";
                connection.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db22207DataSet11.tblSubject". При необходимости она может быть перемещена или удалена.
            this.tblSubjectTableAdapter.Fill(this.db22207DataSet11.tblSubject);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void text_subject(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void otmena(object sender, EventArgs e)
        {
            Close();
        }

        private void sending(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand($"INSERT INTO tblLesson (intSubjectId, datLessonDate, txtTheme) VALUES (@intSubjectId, @datLessonDate, @txtTheme)", sqlConnection);
            int id = subjectIdByTeacherName(teachers.Text.ToString());
            command.Parameters.AddWithValue("intSubjectId", id);
            DateTime date = DateTime.Parse(textBox1.Text.ToString());
            command.Parameters.AddWithValue("datLessonDate", date);
            command.Parameters.AddWithValue("txtTheme", textBox3.Text);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            sqlDataReader.Close();

            //По какой-то причине если выводить месседж бокс, то команда вставки выполнится дважды
/*            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Запись добавлена!");*/
            sqlConnection.Close();
            Close();
        }

        private int subjectIdByTeacherName(string name)
        {
            int id;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select intSubjectId from tblSubject " +
                    "join tblTeacher on tblTeacher.intTeacherId = tblSubject.intTeacherId" +
                    " where '" + name + "' = txtTeacherName and txtSubjectName = '" + comboBox1.Text + "'", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                id = (int)ds.Tables[0].Rows[0].ItemArray[0];
            }
            return id;
        }

        private int GettingId(string str)
        {
            int id;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select intSubjectId from tblSubject where " + str + " = txtSubjectName", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                id = (int)ds.Tables[0].Rows[0].ItemArray[0];
            }
            return id;
        }

        private void date(object sender, EventArgs e)
        {

        }

        private void topic(object sender, EventArgs e)
        {

        }

        private void text_Teacher(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCombobox2();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
