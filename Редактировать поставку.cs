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
    public partial class Редактировать_поставку : Form
    {
        private Database1DataSet.ПоставкиRow Row;
        public Редактировать_поставку(Database1DataSet.ПоставкиRow selectedrow)
        {
            InitializeComponent();
            Row = selectedrow;
            textBox1.Text = selectedrow.Номер_накладной;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Редактировать_поставку_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Накладная_поставок". При необходимости она может быть перемещена или удалена.
            this.накладная_поставокTableAdapter.Fill(this.database1DataSet.Накладная_поставок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.database1DataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Поставки". При необходимости она может быть перемещена или удалена.
            this.поставкиTableAdapter.Fill(this.database1DataSet.Поставки);

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


                Row.Поставщик = (int)comboBox1.SelectedValue;
                Row.Номер_накладной = textBox1.Text;
                Row.Дата_поставки = Convert.ToDateTime(dateTimePicker1.Text);

                this.Close();


            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
