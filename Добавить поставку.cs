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
    public partial class Добавить_поставку : Form
    {
        private Database1DataSet Table;
        public Добавить_поставку(Database1DataSet table)
        {
            InitializeComponent();
            Table = table;
        }

        private void Добавить_поставку_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Поставки". При необходимости она может быть перемещена или удалена.
            this.поставкиTableAdapter.Fill(this.database1DataSet.Поставки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Накладная_поставок". При необходимости она может быть перемещена или удалена.
            this.накладная_поставокTableAdapter.Fill(this.database1DataSet.Накладная_поставок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.database1DataSet.Поставщики);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox[] NotEmptyTextBoxes = new TextBox[]
             {
                textBox1,
             };

            foreach (TextBox tb in NotEmptyTextBoxes)
            {
                if (string.IsNullOrWhiteSpace(tb.Text.Trim()))
                {
                    MessageBox.Show($"Заполните все поля! {tb.Tag} ");
                    return;
                }
            }

            Database1DataSet.ПоставкиRow detail = Table.Поставки.NewПоставкиRow();
            detail.Номер_накладной = textBox1.Text;
            detail.Поставщик = (int)comboBox1.SelectedValue;
            detail.Дата_поставки = dateTimePicker1.Value.Date;

            Table.Поставки.AddПоставкиRow(detail);
            

            поставкиTableAdapter.Update(Table.Поставки);
            поставкиTableAdapter.Fill(Table.Поставки);
            detail = Table.Поставки.Last();

            накладная_поставокTableAdapter.Update(Table.Накладная_поставок);
            поставщикиTableAdapter.Update(Table.Поставщики);
            Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Добавить_поставщика form = new Добавить_поставщика(database1DataSet);
            form.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
