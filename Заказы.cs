using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Заказы : Form
    {
        public static string connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Database1.mdb";
        private OleDbConnection myConnection;
        public Заказы()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void Заказы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Детали_на_складе". При необходимости она может быть перемещена или удалена.
            this.детали_на_складеTableAdapter.Fill(this.database1DataSet1.Детали_на_складе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Заказчики". При необходимости она может быть перемещена или удалена.
            this.заказчикиTableAdapter.Fill(this.database1DataSet1.Заказчики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Отгрузка". При необходимости она может быть перемещена или удалена.
            this.отгрузкаTableAdapter.Fill(this.database1DataSet1.Отгрузка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Накладная_отгрузки". При необходимости она может быть перемещена или удалена.
            this.накладная_отгрузкиTableAdapter.Fill(this.database1DataSet1.Накладная_отгрузки);
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dataGridView2.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dataGridView2.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dataGridView1.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dataGridView1.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Добавить_деталь form = new Добавить_деталь(database1DataSet1);
            form.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Добавить_заказчика form = new Добавить_заказчика(database1DataSet1);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (накладнаяОтгрузкиBindingSource.Current == null)
                MessageBox.Show("Невозможно удалить пустую строку!", "Erorr");
            else
                накладнаяОтгрузкиBindingSource.RemoveCurrent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (отгрузкаBindingSource.Current == null)
                MessageBox.Show("Невозможно удалить пустую строку!", "Erorr");
            else
                отгрузкаBindingSource.RemoveCurrent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           накладнаяОтгрузкиBindingSource.Filter = $"Номер_накладной like'{toolStripTextBox1.Text}%'";
            //сделать сортировку
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            отгрузкаBindingSource.Filter = "[Заказчик] "  + toolStripTextBox1.Text;
            //сделать сортировку
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Добавить_заказ form = new Добавить_заказ(database1DataSet1);
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Добавить_позицию_заказа form = new Добавить_позицию_заказа(database1DataSet1);
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.отгрузкаTableAdapter.Update(this.database1DataSet1.Отгрузка);
           // this.накладная_отгрузкиTableAdapter.Update(this.database1DataSet1.Накладная_отгрузки);
            this.заказчикиTableAdapter.Update(this.database1DataSet1.Заказчики);
            this.детали_на_складеTableAdapter.Update(this.database1DataSet1.Детали_на_складе);
        }

        private void добавитьПозициюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Добавить_позицию_заказа form = new Добавить_позицию_заказа(database1DataSet1);
            form.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (накладнаяОтгрузкиBindingSource.Current == null)
                MessageBox.Show("Невозможно удалить пустую строку!", "Erorr");
            else
                накладнаяОтгрузкиBindingSource.RemoveCurrent();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.отгрузкаTableAdapter.Update(this.database1DataSet1.Отгрузка);

        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object current2 = накладнаяОтгрузкиBindingSource.Current;
            DataRow rowData2 = ((DataRowView)(current2)).Row;

            Database1DataSet.Накладная_отгрузкиRow row1 = (Database1DataSet.Накладная_отгрузкиRow)rowData2;

            Редактировать_позицию_заказа form = new Редактировать_позицию_заказа(row1);
            form.Show();
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (отгрузкаBindingSource.Current == null)
                MessageBox.Show("Невозможно удалить пустую строку!", "Erorr");
            else
                отгрузкаBindingSource.RemoveCurrent();
        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.накладная_отгрузкиTableAdapter.Update(this.database1DataSet1.Накладная_отгрузки);
        }

        private void добавитьЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Добавить_заказ form = new Добавить_заказ(database1DataSet1);
            form.ShowDialog();
        }

        private void редактироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            object current2 = отгрузкаBindingSource.Current;
            DataRow rowData2 = ((DataRowView)(current2)).Row;

            Database1DataSet.ОтгрузкаRow row1 = (Database1DataSet.ОтгрузкаRow)rowData2;

            Редактировать_заказ form = new Редактировать_заказ(row1);
            form.Show();
        }
    }
}
