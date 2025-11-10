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
    public partial class Редактирование_детали : Form
    {
        private Database1DataSet.Детали_на_складеRow Row;
        public Редактирование_детали(Database1DataSet.Детали_на_складеRow SelectedRow)
        {
            InitializeComponent();
            Row = SelectedRow;
            metal.Text = SelectedRow.Металл;
            detail.Text = SelectedRow.Наименование_детали;
            ves.Text = SelectedRow.Вес;
            kol.Text = SelectedRow.Количество_на_складе;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] NotEmptyTextBoxes = new TextBox[]
       {
                metal,detail,ves,kol
       };
            foreach (TextBox tb in NotEmptyTextBoxes)
            {
                if (tb.Text.Trim() == "")
                {
                    MessageBox.Show($"Заполните значения {tb.Tag} ");
                    return;
                }
            }

            Row.Наименование_детали = detail.Text;
            Row.Металл = metal.Text;
            Row.Количество_на_складе = kol.Text;
            Row.Вес = ves.Text;

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metal_TextChanged(object sender, EventArgs e)
        {

        }

        private void metal_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void ves_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void kol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
