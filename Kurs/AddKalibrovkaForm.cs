using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    public partial class AddKalibrovkaForm : Form
    {
        private SqlDataAdapter _dataAdapter = new SqlDataAdapter();

        public AddKalibrovkaForm()
        {
            InitializeComponent();
        }

        private void AddKalibrovkaForm_Load(object sender, EventArgs e)
        {
            _dataAdapter = new SqlDataAdapter("select * from dbo.Организация", ConnectToSql.ConnectionString);
            var table = new DataTable();
            _dataAdapter.Fill(table);
            organ_.DataSource = table.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("НазваниеОрганизации")).ToList();

            _dataAdapter = new SqlDataAdapter("select * from dbo.Прибор", ConnectToSql.ConnectionString);
            var table1 = new DataTable();
            _dataAdapter.Fill(table1);
            nomerprib_.DataSource = table1.Rows.OfType<DataRow>().Select(dr => dr.Field<int>("ЗаводскойНомер")).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectToSql.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("P17", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@НомерПротокола", int.Parse(nomerprot_.Text)));
                        command.Parameters.Add(new SqlParameter("@НазваниеОрганизации", organ_.Text));
                        command.Parameters.Add(new SqlParameter("@НомерПрибора", int.Parse(nomerprib_.Text)));
                        command.Parameters.Add(new SqlParameter("@Дата", date_.Value));
                        command.Parameters.Add(new SqlParameter("@ФиоКалибрующего", fio_.Text));
                        command.Parameters.Add(new SqlParameter("@Результат", res_.Text));
                        command.ExecuteNonQuery();
                    }


                    catch (Exception)
                    {
                        MessageBox.Show("Введите корректные данные");
                    }


                    Form1 main = this.Owner as Form1;
                    if (main != null)
                    {
                        main.Refreshh();
                    }
                }
            }
        }
    }
}