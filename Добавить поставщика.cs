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
    public partial class Добавить_поставщика : Form
    {
        private Database1DataSet Table;
        public Добавить_поставщика(Database1DataSet tabel)
        {
            InitializeComponent();
            Table = tabel;
        }

        private void Добавить_поставщика_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            TextBox[] NotEmptyTextBoxes = new TextBox[]
         {
                name,Adres,Tel
         };


            foreach (TextBox tb in NotEmptyTextBoxes)
            {
                if (tb.Text.Trim() == "")
                {
                    MessageBox.Show($"Заполните все поля! {tb.Tag} ");
                    return;
                }
            }
            Database1DataSet.ПоставщикиRow detail = Table.Поставщики.NewПоставщикиRow();
            detail.Наименования = name.Text;
            detail.Адрес = Adres.Text;
            detail.номер = Tel.Text;
            
            

            Table.Поставщики.AddПоставщикиRow(detail);

            поставщикиTableAdapter1.Update(Table.Поставщики);
            поставщикиTableAdapter1.Fill(Table.Поставщики);
            detail = Table.Поставщики.Last();

            Close();
        }

        private void Tel_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
