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
    public partial class Редактирование_заказчика : Form
    {
        private Database1DataSet.ЗаказчикиRow Row;
        public Редактирование_заказчика(Database1DataSet.ЗаказчикиRow SelectedRow)
        {
            InitializeComponent();
            Row = SelectedRow;
            textBoxad.Text = SelectedRow.Адрес;
            textBoxnam.Text = SelectedRow.Наименования_заказчика;
            textBoxno.Text = SelectedRow.Номер_телефона;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                TextBox[] NotEmptyTextBoxes = new TextBox[]
            {
               textBoxno,textBoxnam,textBoxad
            };

                foreach (TextBox tb in NotEmptyTextBoxes)
                {
                    if (tb.Text.Trim() == "")
                    {
                        MessageBox.Show($"Заполните значения {tb.Tag} ");
                        return;
                    }
                }

                Row.Наименования_заказчика = textBoxnam.Text;
                Row.Адрес = textBoxad.Text;
                Row.Номер_телефона = textBoxno.Text;


                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void textBoxno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
