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
    public partial class Редактировать_позицию_поставки : Form
    {
        private Database1DataSet.Накладная_поставокRow Row;
        public Редактировать_позицию_поставки(Database1DataSet.Накладная_поставокRow selectedrow)
        {
            InitializeComponent();
            Row = selectedrow;
            textBox1.Text = selectedrow.Количество;
            textBox2.Text = selectedrow.Цена_за_еденицу;
            
            comboBox1.Text = selectedrow.Деталь.ToString();
            comboBox2.Text = selectedrow.номер_накладной.ToString();
        }

        private void Редактировать_позицию_поставки_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Поставки". При необходимости она может быть перемещена или удалена.
            this.поставкиTableAdapter.Fill(this.database1DataSet.Поставки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Детали_на_складе". При необходимости она может быть перемещена или удалена.
            this.детали_на_складеTableAdapter.Fill(this.database1DataSet.Детали_на_складе);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] NotEmptyTextBoxes = new TextBox[]
             {

                  textBox1,textBox2

             };

            foreach (TextBox tb in NotEmptyTextBoxes)
            {
                if (tb.Text.Trim() == "")
                {
                    MessageBox.Show($"Заполните значения {tb.Tag} ");
                    return;
                }


                Row.Деталь = (int)comboBox1.SelectedValue;
                Row.номер_накладной = (int)comboBox2.SelectedValue;
                Row.Количество= textBox1.Text;
                //Row.Сума = textBox3.Text;
                Row.Цена_за_еденицу =textBox2.Text ;
                Row.Сума = Convert.ToString(int.Parse(textBox1.Text) * int.Parse(textBox2.Text));
                

                this.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
