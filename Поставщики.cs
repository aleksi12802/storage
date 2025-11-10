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
    public partial class Поставщики : Form
    {
        public static string connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Database1.mdb";
        private OleDbConnection myConnection;
        public Поставщики()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.database1DataSet1.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.database1DataSet1.Поставщики);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (поставщикиBindingSource1.Current == null)
                MessageBox.Show("Невозможно удалить пустую строку!", "Erorr");
            else
                поставщикиBindingSource1.RemoveCurrent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.поставщикиTableAdapter.Update(this.database1DataSet1.Поставщики);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            поставщикиBindingSource1.Filter = $"Наименования like'{textBox1.Text}%'";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            поставщикиBindingSource1.Filter = $"Адрес like'{textBox2.Text}%'";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Добавить_поставщика form = new Добавить_поставщика(database1DataSet1);
            form.ShowDialog();
        }

        private void Поставщики_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object current2 = поставщикиBindingSource1.Current;
            DataRow rowData2 = ((DataRowView)(current2)).Row;

            Database1DataSet.ПоставщикиRow row1 = (Database1DataSet.ПоставщикиRow)rowData2;

             редактирование_поставщиков form = new редактирование_поставщиков(row1);
            form.Show();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (поставщикиBindingSource1.Current == null)
                MessageBox.Show("Невозможно удалить пустую строку!", "Erorr");
            else
                поставщикиBindingSource1.RemoveCurrent();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.поставщикиTableAdapter.Update(this.database1DataSet1.Поставщики);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Добавить_поставщика form = new Добавить_поставщика(database1DataSet1);
            form.ShowDialog();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object current2 = поставщикиBindingSource1.Current;
            DataRow rowData2 = ((DataRowView)(current2)).Row;

            Database1DataSet.ПоставщикиRow row1 = (Database1DataSet.ПоставщикиRow)rowData2;

            редактирование_поставщиков form = new редактирование_поставщиков(row1);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            Close();
        }
    }
}
