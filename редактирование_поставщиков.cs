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
    public partial class редактирование_поставщиков : Form
    {
        private Database1DataSet.ПоставщикиRow Row;
        public редактирование_поставщиков(Database1DataSet.ПоставщикиRow SelectedRow)
        {
            InitializeComponent();
            Row = SelectedRow;
            textBoxA.Text = SelectedRow.Адрес;
            textBoxN.Text = SelectedRow.Наименования;
            textBoxT.Text = SelectedRow.номер;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] NotEmptyTextBoxes = new TextBox[]
        {
                textBoxA,textBoxN,textBoxT
        };

            foreach (TextBox tb in NotEmptyTextBoxes)
            {
                if (tb.Text.Trim() == "")
                {
                    MessageBox.Show($"Заполните значения {tb.Tag} ");
                    return;
                }
            }

            Row.Наименования = textBoxN.Text;
            Row.Адрес = textBoxA.Text;
            Row.номер = textBoxT.Text;
            

            this.Close();
        }

        private void textBoxT_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
