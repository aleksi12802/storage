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
    public partial class Добавить_заказчика : Form
    {
        private Database1DataSet Table;
        public Добавить_заказчика(Database1DataSet tabel)
        {
            InitializeComponent();
            Table = tabel;
        }

        private void Добавить_заказчика_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] NotEmptyTextBoxes = new TextBox[]
        {
                nom,imi,ad
        };

            foreach (TextBox tb in NotEmptyTextBoxes)
            {
                if (tb.Text.Trim() == "")
                {
                    MessageBox.Show($"Заполните все поля! {tb.Tag} ");
                    return;
                }
            }

            Database1DataSet.ЗаказчикиRow detail = Table.Заказчики.NewЗаказчикиRow();
            detail.Наименования_заказчика = imi.Text;
            detail.Адрес = ad.Text;
            detail.Номер_телефона = nom.Text;

            Table.Заказчики.AddЗаказчикиRow(detail);

            заказчикиTableAdapter1.Update(Table.Заказчики);
            заказчикиTableAdapter1.Fill(Table.Заказчики);
            detail = Table.Заказчики.Last();
            Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nom_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
