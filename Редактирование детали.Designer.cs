
namespace WindowsFormsApp1
{
    partial class Редактирование_детали
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kol = new System.Windows.Forms.TextBox();
            this.metal = new System.Windows.Forms.TextBox();
            this.ves = new System.Windows.Forms.TextBox();
            this.detail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Металл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Вес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Наименование";
            // 
            // kol
            // 
            this.kol.Location = new System.Drawing.Point(55, 207);
            this.kol.Name = "kol";
            this.kol.Size = new System.Drawing.Size(198, 20);
            this.kol.TabIndex = 12;
            this.kol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kol_KeyPress);
            // 
            // metal
            // 
            this.metal.Location = new System.Drawing.Point(55, 104);
            this.metal.Name = "metal";
            this.metal.Size = new System.Drawing.Size(198, 20);
            this.metal.TabIndex = 11;
            this.metal.TextChanged += new System.EventHandler(this.metal_TextChanged);
            this.metal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metal_KeyPress);
            // 
            // ves
            // 
            this.ves.Location = new System.Drawing.Point(55, 158);
            this.ves.Name = "ves";
            this.ves.Size = new System.Drawing.Size(198, 20);
            this.ves.TabIndex = 10;
            this.ves.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ves_KeyPress);
            // 
            // detail
            // 
            this.detail.Location = new System.Drawing.Point(55, 43);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(198, 20);
            this.detail.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.kol);
            this.groupBox1.Controls.Add(this.metal);
            this.groupBox1.Controls.Add(this.ves);
            this.groupBox1.Controls.Add(this.detail);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 378);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактирование";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 34);
            this.button2.TabIndex = 17;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Редактирование_детали
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 402);
            this.Controls.Add(this.groupBox1);
            this.Name = "Редактирование_детали";
            this.Text = "Редактирование детали";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kol;
        private System.Windows.Forms.TextBox metal;
        private System.Windows.Forms.TextBox ves;
        private System.Windows.Forms.TextBox detail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
    }
}