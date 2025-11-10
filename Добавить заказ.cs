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
    public partial class Добавить_заказ : Form
    {
        private Database1DataSet Table;
        public Добавить_заказ(Database1DataSet table)
        {
            InitializeComponent();
            Table = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Добавить_заказчика form = new Добавить_заказчика(database1DataSet);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //combobox1
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

            Database1DataSet.ОтгрузкаRow detail = Table.Отгрузка.NewОтгрузкаRow();
            detail.Номер_накладной = textBox1.Text;
            detail.Заказчик = (int)comboBox1.SelectedValue;
            detail.Дата_отгрузки = dateTimePicker1.Value.Date;

            Table.Отгрузка.AddОтгрузкаRow(detail);

            отгрузкаTableAdapter1.Update(Table.Отгрузка);
            отгрузкаTableAdapter1.Fill(Table.Отгрузка);
            detail = Table.Отгрузка.Last();
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
    }
}
