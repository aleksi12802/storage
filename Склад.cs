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
    public partial class Склад : Form
    {
        public static string connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Database1.mdb";
        private OleDbConnection myConnection;
        public Склад()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Детали_на_складе". При необходимости она может быть перемещена или удалена.
            this.детали_на_складеTableAdapter.Fill(this.database1DataSet.Детали_на_складе);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (деталиНаСкладеBindingSource.Current == null)
                MessageBox.Show("Невозможно удалить пустую строку!", "Erorr");
            else
                деталиНаСкладеBindingSource.RemoveCurrent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.детали_на_складеTableAdapter.Update(this.database1DataSet.Детали_на_складе);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            деталиНаСкладеBindingSource.Filter = $"Наименование_детали like '{textBox1.Text}%'";
           // деталиНаСкладеBindingSource.Filter = $"Наименование_детали like'{textBox1.Text}%'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Добавить_деталь form = new Добавить_деталь(database1DataSet);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object current2 = деталиНаСкладеBindingSource.Current;
            DataRow rowData2 = ((DataRowView)(current2)).Row;

            Database1DataSet.Детали_на_складеRow row1 = (Database1DataSet.Детали_на_складеRow)rowData2;

            Редактирование_детали form = new Редактирование_детали(row1);
            form.Show();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object current2 = деталиНаСкладеBindingSource.Current;
            DataRow rowData2 = ((DataRowView)(current2)).Row;

            Database1DataSet.Детали_на_складеRow row1 = (Database1DataSet.Детали_на_складеRow)rowData2;

            Редактирование_детали form = new Редактирование_детали(row1);
            form.Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (деталиНаСкладеBindingSource.Current == null)
                MessageBox.Show("Невозможно удалить пустую строку!", "Erorr");
            else
                деталиНаСкладеBindingSource.RemoveCurrent();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.детали_на_складеTableAdapter.Update(this.database1DataSet.Детали_на_складе);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Добавить_деталь form = new Добавить_деталь(database1DataSet);
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            Close();
        }
    }
}
