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

namespace Kurs
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

            var foo = @"Data Source=" + ServerTextBox.Text + ";Initial Catalog=" + DBTextBox.Text + ";User ID = "
                + LoginTextBox.Text + "; Password =" + PasswordTextBox.Text;
            var connection = new SqlConnection(foo);
           try
            {
                connection.Open();
                ConnectToSql.ConnectionString = foo;
                var mainForm = new Form1();
                mainForm.Show();
                Hide();
            }
           catch (Exception)
            {

                MessageBox.Show("Ошибка подключения");
            }
        }
    }
}
