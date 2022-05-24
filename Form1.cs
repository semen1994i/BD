using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BD_6
{
    public partial class Form1 : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["BD_6.Properties.Settings.db22207ConnectionString"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            GetTable();
            Size = new System.Drawing.Size(900, 600);
            Text = "Уроки";
        }

        private void GetTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT tblLesson.datLessonDate, tblLesson.txtTheme, tblSubject.txtSubjectName, tblTeacher.txtTeacherName FROM     tblLesson INNER JOIN tblSubject ON tblLesson.intSubjectId = tblSubject.intSubjectId INNER JOIN tblTeacher ON tblSubject.intTeacherId = tblTeacher.intTeacherId", connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db22207DataSet.tblLesson". При необходимости она может быть перемещена или удалена.
//            this.tblLessonTableAdapter.Fill(this.db22207DataSet.tblLesson);

        }

        private void Adding(object sender, EventArgs e)
        {
            Text = "Добавить урок";
            Form2 f2 = new Form2(); f2.Visible = false;
            f2.ShowDialog();
            GetTable();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows[e.RowIndex].Cells.Count; i++)
                InsertData.Data.Add(dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString());
            Form3 f3 = new Form3(); f3.Visible = false;
            f3.ShowDialog();
            InsertData.Data.Clear();
        }
    }
    static class InsertData
    {
        public static List<object> Data { get; set; } = new List<object>();
    }
}
