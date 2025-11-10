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
    public partial class Добавить_деталь : Form
    {
        private Database1DataSet Table;
        public Добавить_деталь(Database1DataSet tabel)
        {
            InitializeComponent();
            Table = tabel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] NotEmptyTextBoxes = new TextBox[]
         {
                textBoxN,textBoxM,textBoxV
         };


            foreach (TextBox tb in NotEmptyTextBoxes)
            {
                if (tb.Text.Trim() == "")
                {
                    MessageBox.Show($"Заполните все поля! {tb.Tag} ");
                    return;
                }
            }
            Database1DataSet.Детали_на_складеRow detail = Table.Детали_на_складе.NewДетали_на_складеRow();
            detail.Наименование_детали = textBoxN.Text;
            detail.Металл = textBoxM.Text;
            detail.Вес = textBoxV.Text;



            Table.Детали_на_складе.AddДетали_на_складеRow(detail);

            детали_на_складеTableAdapter1.Update(Table.Детали_на_складе);
            детали_на_складеTableAdapter1.Fill(Table.Детали_на_складе);
            detail = Table.Детали_на_складе.Last();

            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxV_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBoxV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
