
namespace WindowsFormsApp1
{
    partial class Редактирование_заказчика
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Редактирование_заказчика));
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxnam = new System.Windows.Forms.TextBox();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.textBoxno = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxnam
            // 
            this.textBoxnam.Location = new System.Drawing.Point(30, 64);
            this.textBoxnam.Name = "textBoxnam";
            this.textBoxnam.Size = new System.Drawing.Size(201, 20);
            this.textBoxnam.TabIndex = 1;
            // 
            // textBoxad
            // 
            this.textBoxad.Location = new System.Drawing.Point(30, 119);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(201, 20);
            this.textBoxad.TabIndex = 2;
            // 
            // textBoxno
            // 
            this.textBoxno.Location = new System.Drawing.Point(30, 179);
            this.textBoxno.Name = "textBoxno";
            this.textBoxno.Size = new System.Drawing.Size(201, 20);
            this.textBoxno.TabIndex = 3;
            this.textBoxno.TextChanged += new System.EventHandler(this.textBoxno_TextChanged);
            this.textBoxno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxno_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер телефона";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBoxno);
            this.groupBox1.Controls.Add(this.textBoxad);
            this.groupBox1.Controls.Add(this.textBoxnam);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(25, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 365);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактировать";
            // 
            // Редактирование_заказчика
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 390);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Редактирование_заказчика";
            this.Text = "Редактирование заказчика";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxnam;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.TextBox textBoxno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}