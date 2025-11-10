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
    public partial class Редактировать_заказ : Form
    {
        private Database1DataSet.ОтгрузкаRow Row;
        public Редактировать_заказ(Database1DataSet.ОтгрузкаRow selectedr)
        {
            InitializeComponent();
            Row = selectedr;
            textBox1.Text = selectedr.Номер_накладной;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] NotEmptyTextBoxes = new TextBox[]
              {
                
                  textBox1

              };

            foreach (TextBox tb in NotEmptyTextBoxes)
            {
                if (tb.Text.Trim() == "")
                {
                    MessageBox.Show($"Заполните значения {tb.Tag} ");
                    return;
                }

                
                    Row.Заказчик = (int)comboBox1.SelectedValue;
                    Row.Номер_накладной = textBox1.Text;
                    Row.Дата_отгрузки = Convert.ToDateTime(dateTimePicker1.Text);

                    this.Close();


                }
        }

        private void Редактировать_заказ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Накладная_отгрузки". При необходимости она может быть перемещена или удалена.
            this.накладная_отгрузкиTableAdapter.Fill(this.database1DataSet.Накладная_отгрузки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Отгрузка". При необходимости она может быть перемещена или удалена.
            this.отгрузкаTableAdapter.Fill(this.database1DataSet.Отгрузка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Заказчики". При необходимости она может быть перемещена или удалена.
            this.заказчикиTableAdapter.Fill(this.database1DataSet.Заказчики);

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
