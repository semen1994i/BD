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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(InsertData.Data.ToArray());
            getTable();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public void getTable()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["BD_6.Properties.Settings.db22207ConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var dateF = InsertData.Data[3].ToString().Split(' ')[0].Split('.');
                var date = dateF[2] + "-" + dateF[1] + "-" + dateF[0];
                SqlDataAdapter adapter = new SqlDataAdapter("select tblPupil.txtPupilSurname as 'Фамилия ученика', tblPupil.txtPupilName as 'Имя ученика', tblPupil.datBirthday as 'Дата рождения', tblMark.intMarkValue as 'Оценка', tblMark.txtMarkComment as 'Замечания'"
                + " from tblMark, tblPupil, tblLesson, tblSubject"
                + " where tblMark.intPupilId = tblPupil.intPupilId and tblMark.intLessonId = tblLesson.intLessonId and tblSubject.intSubjectId = tblLesson.intSubjectId  and tblSubject.txtSubjectName = '" +
                InsertData.Data[0].ToString() + "' and tblLesson.datLessonDate ='" + date + "'", connection);

                DataSet Table = new DataSet();
                adapter.Fill(Table);
                dataGridView2.DataSource = Table.Tables[0];
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Visible = false;
            f4.ShowDialog();
            getTable();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
