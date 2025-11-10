using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Добавить_позицию_поставки : Form
    {
        private Database1DataSet Table;
        public Добавить_позицию_поставки(Database1DataSet table)
        {
            InitializeComponent();
            Table = table;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Добавить_деталь form = new Добавить_деталь(database1DataSet);
            form.ShowDialog();
        }

        private void Добавить_позицию_поставки_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.database1DataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Поставки". При необходимости она может быть перемещена или удалена.
            this.поставкиTableAdapter.Fill(database1DataSet.Поставки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Детали_на_складе". При необходимости она может быть перемещена или удалена.
            this.детали_на_складеTableAdapter.Fill(database1DataSet.Детали_на_складе);
            this.накладная_поставокTableAdapter1.Fill(database1DataSet.Накладная_поставок);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox[] NotEmptyTextBoxes = new TextBox[]
           {
                textBox1,textBox2
           };

            foreach (TextBox tb in NotEmptyTextBoxes)
            {
                if (tb.Text.Trim() == "")
                {
                    MessageBox.Show($"Заполните все поля! {tb.Tag} ");
                    return;
                }
            }

            Database1DataSet.Накладная_поставокRow detail = Table.Накладная_поставок.NewНакладная_поставокRow();
            detail.Количество = textBox1.Text;
            detail.Цена_за_еденицу = textBox2.Text;
            detail.Деталь = (int)comboBox2.SelectedValue;
            detail.номер_накладной = (int)comboBox1.SelectedValue;
            detail.Сума = Convert.ToString(int.Parse(textBox1.Text) * int.Parse(textBox2.Text));



            detail.Детали_на_складеRow.Количество_на_складе = Convert.ToString(int.Parse(detail.Детали_на_складеRow.Количество_на_складе) + int.Parse(textBox1.Text));


            Table.Накладная_поставок.AddНакладная_поставокRow(detail);

            накладная_поставокTableAdapter1.Update(Table.Накладная_поставок);
            накладная_поставокTableAdapter1.Fill(Table.Накладная_поставок);
            detail = Table.Накладная_поставок.Last();

            поставкиTableAdapter.Update(Table.Поставки);
            детали_на_складеTableAdapter.Update(Table.Детали_на_складе);
            детали_на_складеTableAdapter.Adapter.Update(Table.Детали_на_складе);



            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
