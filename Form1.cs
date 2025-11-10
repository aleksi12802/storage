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
    public partial class Form1 : Form
    {
        public static string connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Database1.mdb";
        private OleDbConnection myConnection;
        public Form1()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Детали_на_складе". При необходимости она может быть перемещена или удалена.
            this.детали_на_складеTableAdapter.Fill(this.database1DataSet.Детали_на_складе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Накладная_поставок". При необходимости она может быть перемещена или удалена.
            this.накладная_поставокTableAdapter.Fill(this.database1DataSet.Накладная_поставок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.database1DataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Поставки". При необходимости она может быть перемещена или удалена.
            this.поставкиTableAdapter.Fill(this.database1DataSet.Поставки);
           
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DataError_2(object sender, DataGridViewDataErrorEventArgs e)
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

        private void dataGridView2_DragEnter(object sender, DragEventArgs e)
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Добавить_деталь form = new Добавить_деталь(database1DataSet);
            form.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Добавить_поставщика form = new Добавить_поставщика(database1DataSet);
            form.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (поставкиBindingSource.Current == null)
                MessageBox.Show("Невозможно удалить пустую строку!", "Erorr");
            else
                поставкиBindingSource.RemoveCurrent();
        }


        /*
          Database1DataSet.Накладная_отгрузкиRow detail = Table.Накладная_отгрузки.NewНакладная_отгрузкиRow();
             detail.Количество = textBoxk.Text;
             detail.Цена_за_еденицу = textBoxc.Text;
             detail.деталь = (int)comboBox1.SelectedValue;
             detail.Номер_накладной = (int)comboBox2.SelectedValue;
             detail.Сумма = Convert.ToString( int.Parse(textBoxc.Text) * int.Parse(textBoxk.Text));



             Table.Накладная_отгрузки.AddНакладная_отгрузкиRow(detail);

             накладная_отгрузкиTableAdapter1.Update(Table.Накладная_отгрузки);
             накладная_отгрузкиTableAdapter1.Fill(Table.Накладная_отгрузки);
             detail = Table.Накладная_отгрузки.Last();

             отгрузкаTableAdapter1.Update(Table.Отгрузка);
             детали_на_складеTableAdapter1.Update(Table.Детали_на_складе);
             Close();
        */

        private void button3_Click(object sender, EventArgs e)
        {
            this.поставкиTableAdapter.Update(this.database1DataSet.Поставки);
            this.поставщикиTableAdapter.Update(this.database1DataSet.Поставщики);
            
            //this.накладная_поставокTableAdapter.Update(this.database1DataSet.Накладная_поставок);
            
            this.детали_на_складеTableAdapter.Update(this.database1DataSet.Детали_на_складе);
     /*       Database1DataSet.Детали_на_складеRow detail = database1DataSet.Детали_на_складе.NewДетали_на_складеRow();
            foreach (var prop in database1DataSet.Детали_на_складе)
            {
                var tmp = database1DataSet.Накладная_поставок.Where(p => p.Деталь.Equals(prop.Код_детали)).Sum(d => long.Parse(d.Количество));
                detail.Количество_на_складе = prop.Количество_на_складе;

            }
            database1DataSet.Детали_на_складе.AddДетали_на_складеRow(detail);

            детали_на_складеTableAdapter.Update(database1DataSet.Детали_на_складе);
            детали_на_складеTableAdapter.Fill(database1DataSet.Детали_на_складе);

            детали_на_складеTableAdapter.Update(database1DataSet.Детали_на_складе);

            // var records2 = */
            //  var count2 = records2.Sum(p => Convert.ToInt64(p.Количество));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (накладнаяПоставокBindingSource.Current == null)
                MessageBox.Show("Невозможно удалить пустую строку!", "Erorr");
            else
                накладнаяПоставокBindingSource.RemoveCurrent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            поставкиBindingSource.Filter = "[Поставщик] = " + toolStripTextBox1.Text;
            //сделать сортировку
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            накладнаяПоставокBindingSource.Filter = $"номер_накладной like'{toolStripTextBox1.Text}%'";
            //сделать сортировку
        }


        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Добавить_поставку form = new Добавить_поставку(database1DataSet);
            form.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void добавитьПоставкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Добавить_поставку form = new Добавить_поставку(database1DataSet);
            form.ShowDialog();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.поставкиTableAdapter.Update(this.database1DataSet.Поставки);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (поставкиBindingSource.Current == null)
                MessageBox.Show("Невозможно удалить пустую строку!", "Erorr");
            else
                поставкиBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Добавить_позицию_поставки form = new Добавить_позицию_поставки(database1DataSet);
            form.ShowDialog();

        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object current2 = поставкиBindingSource.Current;
            DataRow rowData2 = ((DataRowView)(current2)).Row;

            Database1DataSet.ПоставкиRow row1 = (Database1DataSet.ПоставкиRow)rowData2;

            Редактировать_поставку form = new Редактировать_поставку(row1);
            form.Show();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Добавить_позицию_поставки form = new Добавить_позицию_поставки(database1DataSet);
            form.ShowDialog();
        }

        private void редактироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            object current3 = накладнаяПоставокBindingSource.Current;
            DataRow rowData3 = ((DataRowView)(current3)).Row;

             Database1DataSet.Накладная_поставокRow row1 = (Database1DataSet.Накладная_поставокRow)rowData3;

            Редактировать_позицию_поставки form = new Редактировать_позицию_поставки(row1);
            form.Show();
          

        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (накладнаяПоставокBindingSource.Current == null)
                MessageBox.Show("Невозможно удалить пустую строку!", "Erorr");
            else
                накладнаяПоставокBindingSource.RemoveCurrent();
        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.поставкиTableAdapter.Update(this.database1DataSet.Поставки);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}



