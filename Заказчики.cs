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
    public partial class Заказчики : Form
    {
        public static string connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Database1.mdb";
        private OleDbConnection myConnection;
        public Заказчики()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void Заказчики_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Заказчики". При необходимости она может быть перемещена или удалена.
            this.заказчикиTableAdapter.Fill(this.database1DataSet.Заказчики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Заказчики". При необходимости она может быть перемещена или удалена.
            this.заказчикиTableAdapter.Fill(this.database1DataSet.Заказчики);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Добавить_заказчика form = new Добавить_заказчика(database1DataSet);
            form.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            if (заказчикиBindingSource.Current == null)
                MessageBox.Show("Невозможно удалить пустую строку!", "Erorr");
            else
                заказчикиBindingSource.RemoveCurrent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.заказчикиTableAdapter.Update(this.database1DataSet.Заказчики);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            заказчикиBindingSource.Filter = $"Наименования_заказчика like'{toolStripTextBox1.Text}%'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object current2 = заказчикиBindingSource.Current;
            DataRow rowData2 = ((DataRowView)(current2)).Row;

            Database1DataSet.ЗаказчикиRow row1 = (Database1DataSet.ЗаказчикиRow)rowData2;

            Редактирование_заказчика form = new Редактирование_заказчика(row1);
            form.Show();

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (заказчикиBindingSource.Current == null)
                MessageBox.Show("Невозможно удалить пустую строку!", "Erorr");
            else
                заказчикиBindingSource.RemoveCurrent();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.заказчикиTableAdapter.Update(this.database1DataSet.Заказчики);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Добавить_заказчика form = new Добавить_заказчика(database1DataSet);
            form.ShowDialog();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object current2 = заказчикиBindingSource.Current;
            DataRow rowData2 = ((DataRowView)(current2)).Row;

            Database1DataSet.ЗаказчикиRow row1 = (Database1DataSet.ЗаказчикиRow)rowData2;

            Редактирование_заказчика form = new Редактирование_заказчика(row1);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            Close();
        }

        private void Заказчики_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
        
        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {
            заказчикиBindingSource.Filter = $"Наименования_заказчика like'{toolStripTextBox1.Text}%'";
        }
    }
}
