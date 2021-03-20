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
    public partial class Form1 : Form
    {
        private SqlDataAdapter _dataAdapter = new SqlDataAdapter();

        private void GetData(string selectCommand, BindingSource bindingSource)
        {
            try
            {
                _dataAdapter = new SqlDataAdapter(selectCommand, ConnectToSql.ConnectionString);
                var table = new DataTable();
                _dataAdapter.Fill(table);
                bindingSource.DataSource = table;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void Refreshh()
        {
            Form1_Load(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select Тип, ЗаводскойНомер, Прибор.МаркаПрибора, КодСотрудника, МестоУстановки, ДатаВыпуска, ДатаВводаВЭксплуатацию, Состояние from Metrology.dbo.Прибор inner join  Metrology.dbo.Марка on Прибор.МаркаПрибора = Марка.МаркаПрибора", bindingSource1);
            dataGridView2.DataSource = bindingSource2;
            GetData("select * from Марка", bindingSource2);
            dataGridView3.DataSource = bindingSource3;
            GetData("select * from Сотрудник", bindingSource3);
            dataGridView4.DataSource = bindingSource4;
            GetData("select * from Подразделение", bindingSource4);
            dataGridView5.DataSource = bindingSource5;
            GetData("select * from Организация", bindingSource5);
            dataGridView6.DataSource = bindingSource6;
            GetData("select * from Поверка", bindingSource6);
            dataGridView7.DataSource = bindingSource7;
            GetData("select * from Калибровка", bindingSource7);
            dataGridView8.DataSource = bindingSource8;
            GetData("select * from Ремонт", bindingSource8);
            crystalReportViewer2.RefreshReport();
        }
        public void SetRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }
        private void search(TextBox tb, DataGridView dg, object sender, EventArgs e)  //Поиск
        {
            for (int i = 0; i < dg.Rows.Count; i++)
            {

                dg.CurrentCell = null;
                bool isVisible = false;
                for (int j = 0; j < dg.Columns.Count; j++)
                {
                    if (dg[j, i].Value.ToString().IndexOf(tb.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        isVisible = true;
                    }
                }
                dg.Rows[i].Visible = isVisible;
            }
        }


        private void AddDevice_Click(object sender, EventArgs e) // Добавление прибора
        {
            var form = new AddDeviceForm();
            form.Owner = this;
            form.ShowDialog();
            textBox1.Text = "";
        }

        private void AddMarka_Click(object sender, EventArgs e)  // Добавление марки
        {
            var form = new AddMarkaForm();
            form.Owner = this;
            form.ShowDialog();
            textBox2.Text = "";
        }

        private void AddSotrudnik_Click(object sender, EventArgs e)   // Добавление сотрудника
        {
            var form = new AddSotrudnikForm();
            form.Owner = this;
            form.ShowDialog();
            textBox3.Text = "";
        }

        private void AddPodrazd_Click(object sender, EventArgs e)  // Добавление подразделения
        {
            var form = new AddPodrazdForm();
            form.Owner = this;
            form.ShowDialog();
            textBox4.Text = "";
        }

        private void AddOrganiz_Click(object sender, EventArgs e)   // Добавление организации
        {
            var form = new AddOrganizForm();
            form.Owner = this;
            form.ShowDialog();
            textBox5.Text = "";
        }

        private void AddPoverka_Click(object sender, EventArgs e)   // Добавление записи о поверке
        {
            var form = new AddPoverkaForm();
            form.Owner = this;
            form.ShowDialog();
            textBox6.Text = "";
            crystalReportViewer2.RefreshReport();
        }

        private void AddKalibr_Click(object sender, EventArgs e)  // Добавление записи о калибровке
        {
            var form = new AddKalibrovkaForm();
            form.Owner = this;
            form.ShowDialog();
            textBox7.Text = "";
        }

        private void AddRemont_Click(object sender, EventArgs e)   // Добавление записи о ремонте
        {
            var form = new AddRemontForm();
            form.Owner = this;
            form.ShowDialog();
            textBox8.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search(textBox1, dataGridView1, sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            search(textBox2, dataGridView2, sender, e);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            search(textBox3, dataGridView3, sender, e);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            search(textBox4, dataGridView4, sender, e);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            search(textBox5, dataGridView5, sender, e);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            search(textBox6, dataGridView6, sender, e);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            search(textBox7, dataGridView7, sender, e);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            search(textBox8, dataGridView8, sender, e);
        }


        private void Delete(string storedProcedure, DataGridView dataGrid, int x,BindingSource bs)  //Удаление записей
        {
            try
            {
                var selected = int.Parse(dataGrid.SelectedRows[0].Cells[x].FormattedValue.ToString());
                dataGrid.DataSource = bs;
                GetData(storedProcedure + " " + selected, bs);
                Refreshh();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при удалении");
            }
        }
        private void DeleteButton1_Click(object sender, EventArgs e)
        {
            Delete("P19", dataGridView1, 1, bindingSource1);
            search(textBox1, dataGridView1, sender, e);
        }

        private void DeleteButton6_Click(object sender, EventArgs e)
        {
            Delete("P20", dataGridView6, 0, bindingSource6);
            search(textBox6, dataGridView6, sender, e);
            crystalReportViewer2.RefreshReport();
        }

        private void DeleteButton7_Click(object sender, EventArgs e)
        {
            Delete("P21", dataGridView7, 0, bindingSource7);
            search(textBox7, dataGridView7, sender, e);
        }

        private void DeleteButton8_Click(object sender, EventArgs e)
        {
            Delete("P22", dataGridView8, 0, bindingSource8);
            search(textBox8, dataGridView8, sender, e);
        }

        private void ShowPoverka_Click(object sender, EventArgs e) //Приборы, которые необходимо поверить в указанный срок
        {
            try
            {
                dataGridView1.DataSource = bindingSource1;
                GetData("P10" + " " + showpov_.Text, bindingSource1);
                search(textBox1, dataGridView1, sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Заполните поле корректно!");
            }
        }

        private void clearpov__Click(object sender, EventArgs e)
        {
            Refreshh();
            showpov_.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //Выход при закрытии
        {
            Application.Exit();
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) //Нумерация строк
        {
            SetRowNumber(dataGridView2);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SetRowNumber(dataGridView1);
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SetRowNumber(dataGridView3);
        }

        private void dataGridView4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SetRowNumber(dataGridView4);
        }

        private void dataGridView5_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SetRowNumber(dataGridView5);
        }

        private void dataGridView6_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SetRowNumber(dataGridView6);
        }

        private void dataGridView7_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SetRowNumber(dataGridView7);
        }

        private void dataGridView8_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SetRowNumber(dataGridView8);
        }

        private void Otchet_Click(object sender, EventArgs e)
        {
            if (crystalReportViewer2.Visible == false)
            {
                crystalReportViewer2.Visible = true;
                label6.Visible = false;
                textBox6.Visible = false;
                DeleteButton6.Visible = false;
                AddPoverka.Visible = false;
            }
            else
            {
                crystalReportViewer2.Visible = false;
                label6.Visible = true;
                textBox6.Visible = true;
                DeleteButton6.Visible = true;
                AddPoverka.Visible = true;
            }
        }
    }
}
