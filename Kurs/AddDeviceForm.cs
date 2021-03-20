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
    public partial class AddDeviceForm : Form
    {
        private SqlDataAdapter _dataAdapter = new SqlDataAdapter();

        public AddDeviceForm()
        {
            InitializeComponent();
        }

        public AddDeviceForm(string id)
        {
            InitializeComponent();
        }
        
        private void AddDeviceForm_Load(object sender, EventArgs e)
        {
            sost_.SelectedIndex = 0;

            _dataAdapter = new SqlDataAdapter("select * from dbo.Марка", ConnectToSql.ConnectionString);
            var table = new DataTable(); 
            _dataAdapter.Fill(table);
            marka_.DataSource = table.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("МаркаПрибора")).ToList();

            _dataAdapter = new SqlDataAdapter("select * from dbo.Сотрудник", ConnectToSql.ConnectionString);
            var table1 = new DataTable();
            _dataAdapter.Fill(table1);
            kodsotr_.DataSource = table1.Rows.OfType<DataRow>().Select(dr => dr.Field<int>("КодСотрудника")).ToList();

            _dataAdapter = new SqlDataAdapter("select * from dbo.Подразделение", ConnectToSql.ConnectionString);
            var table2 = new DataTable();
            _dataAdapter.Fill(table2);
            mesto_.DataSource = table2.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("НазваниеПодразделения")).ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectToSql.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("P11", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ЗаводскойНомер", int.Parse(zavnomer_.Text)));
                        command.Parameters.Add(new SqlParameter("@МаркаПрибора", marka_.Text));
                        command.Parameters.Add(new SqlParameter("@КодСотрудника", int.Parse(kodsotr_.Text)));
                        command.Parameters.Add(new SqlParameter("@МестоУстановки", mesto_.Text));
                        command.Parameters.Add(new SqlParameter("@ДатаВыпуска", datevyp_.Value));
                        command.Parameters.Add(new SqlParameter("@ДатаВводаВЭксплуатацию", datevvoda_.Value));
                        command.Parameters.Add(new SqlParameter("@Состояние", sost_.Text));
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
