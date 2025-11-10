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
    public partial class Редактировать_позицию_заказа : Form
    {
        private Database1DataSet.Накладная_отгрузкиRow Row;
        public Редактировать_позицию_заказа(Database1DataSet.Накладная_отгрузкиRow selectedrow)
        {
            InitializeComponent();
            Row = selectedrow;
            textBoxc.Text = selectedrow.Цена_за_еденицу;
            textBoxk.Text = selectedrow.Количество.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] NotEmptyTextBoxes = new TextBox[]
      {
                textBoxc,textBoxk
      };

            foreach (TextBox tb in NotEmptyTextBoxes)
            {
                if (tb.Text.Trim() == "")
                {
                    MessageBox.Show($"Заполните значения {tb.Tag} ");
                    return;
                }
                
                Row.деталь = (int)comboBox1.SelectedValue;
                Row.Номер_накладной = (int)comboBox2.SelectedValue;
                Row.Цена_за_еденицу = textBoxc.Text;
                Row.Количество = textBoxk.Text;  
                Row.Сумма = Convert.ToString(int.Parse(textBoxk.Text) * int.Parse(textBoxc.Text));

                this.Close();


            }

        }

        private void Редактировать_позицию_заказа_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Детали_на_складе". При необходимости она может быть перемещена или удалена.
            this.детали_на_складеTableAdapter.Fill(this.database1DataSet.Детали_на_складе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Отгрузка". При необходимости она может быть перемещена или удалена.
            this.отгрузкаTableAdapter.Fill(this.database1DataSet.Отгрузка);
            this.накладная_отгрузкиTableAdapter1.Fill(this.database1DataSet.Накладная_отгрузки);

        }

        private void textBoxc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBoxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
