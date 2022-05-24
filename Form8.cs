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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["BD_6.Properties.Settings.db22207ConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select txtSubjectName from tblSubject", connection);

                DataTable ds = new DataTable();
                adapter.Fill(ds);

                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox1.DataSource = ds;

                comboBox1.DisplayMember = "txtSubjectName";
                comboBox1.ValueMember = "txtSubjectName";

                connection.Close();
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "report3DataSet1.DataTable1". При необходимости она может быть перемещена или удалена.
            this.DataTable1TableAdapter.Fill(this.report3DataSet1.DataTable1, comboBox1.Text);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.Fill(this.report3DataSet1.DataTable1, comboBox1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
