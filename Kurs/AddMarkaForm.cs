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
    public partial class AddMarkaForm : Form
    {
        private SqlDataAdapter _dataAdapter = new SqlDataAdapter();

        public AddMarkaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectToSql.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("P12", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@МаркаПрибора",marka_.Text));
                        command.Parameters.Add(new SqlParameter("@Тип", type_.Text));
                        command.Parameters.Add(new SqlParameter("@Производитель", proizv_.Text));
                        command.Parameters.Add(new SqlParameter("@ПериодичностьПоверки", int.Parse(period_.Text)));
                        command.Parameters.Add(new SqlParameter("@СрокЭксплуатации", int.Parse(srok_.Text)));
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
