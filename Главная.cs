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
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Склад form = new Склад();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Поставщики form = new Поставщики();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Заказчики form = new Заказчики();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Заказы form = new Заказы();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void Главная_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
