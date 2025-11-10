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
    public partial class Добавить_позицию_заказа : Form
    {
        private Database1DataSet Table;
        public Добавить_позицию_заказа(Database1DataSet tabel)
        {
            InitializeComponent();
            Table = tabel;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] NotEmptyTextBoxes = new TextBox[]
            {
                textBoxk,textBoxc
            };

            foreach (TextBox tb in NotEmptyTextBoxes)
            {
                if (tb.Text.Trim() == "")
                {
                    MessageBox.Show($"Заполните все поля! {tb.Tag} ");
                    return;
                }
            }

            Database1DataSet.Накладная_отгрузкиRow detail = Table.Накладная_отгрузки.NewНакладная_отгрузкиRow();
            detail.Количество = textBoxk.Text;
            detail.Цена_за_еденицу = textBoxc.Text;
            detail.деталь = (int)comboBox1.SelectedValue;
            detail.Номер_накладной = (int)comboBox2.SelectedValue;
            detail.Сумма = Convert.ToString( int.Parse(textBoxc.Text) * int.Parse(textBoxk.Text));
            if (int.Parse(detail.Детали_на_складеRow.Количество_на_складе) < int.Parse(textBoxk.Text))
            {
                MessageBox.Show("Не хватает деталей на складе");
                return;
            }
           detail.Детали_на_складеRow.Количество_на_складе = Convert.ToString(int.Parse(detail.Детали_на_складеRow.Количество_на_складе) - int.Parse(textBoxk.Text));


            Table.Накладная_отгрузки.AddНакладная_отгрузкиRow(detail);

            накладная_отгрузкиTableAdapter1.Update(Table.Накладная_отгрузки);
            накладная_отгрузкиTableAdapter1.Fill(Table.Накладная_отгрузки);
            detail = Table.Накладная_отгрузки.Last();

            отгрузкаTableAdapter1.Update(Table.Отгрузка);
            детали_на_складеTableAdapter1.Update(Table.Детали_на_складе);
            детали_на_складеTableAdapter1.Adapter.Update(Table.Детали_на_складе);
           
            
            Close();



        }

        private void Добавить_позицию_заказа_Load(object sender, EventArgs e)
        {
            this.накладная_отгрузкиTableAdapter1.Fill(database1DataSet1.Накладная_отгрузки);
            this.детали_на_складеTableAdapter1.Fill(database1DataSet1.Детали_на_складе);
            this.отгрузкаTableAdapter1.Fill(database1DataSet1.Отгрузка);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Добавить_деталь form = new Добавить_деталь(database1DataSet1);
            form.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxc.Text) * int.Parse(textBoxk.Text);
            textBox1.Text = n.ToString();

        }

        private void textBoxc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBoxk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
