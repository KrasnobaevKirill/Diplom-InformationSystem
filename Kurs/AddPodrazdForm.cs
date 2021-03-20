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
    public partial class AddPodrazdForm : Form
    { 
        private SqlDataAdapter _dataAdapter = new SqlDataAdapter();

        public AddPodrazdForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectToSql.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("P14", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@НазваниеПодразделения",nazv_.Text));
                        command.Parameters.Add(new SqlParameter("@Описание", opis_.Text));
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

