
namespace WindowsFormsApp1
{
    partial class Добавить_заказчика
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
            this.database1DataSet1 = new WindowsFormsApp1.Database1DataSet();
            this.заказчикиTableAdapter1 = new WindowsFormsApp1.Database1DataSetTableAdapters.ЗаказчикиTableAdapter();
            this.imi = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказчикиTableAdapter1
            // 
            this.заказчикиTableAdapter1.ClearBeforeFill = true;
            // 
            // imi
            // 
            this.imi.Location = new System.Drawing.Point(25, 32);
            this.imi.Name = "imi";
            this.imi.Size = new System.Drawing.Size(246, 20);
            this.imi.TabIndex = 1;
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(25, 97);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(246, 20);
            this.ad.TabIndex = 2;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(25, 166);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(246, 20);
            this.nom.TabIndex = 3;
            this.nom.TextChanged += new System.EventHandler(this.nom_TextChanged);
            this.nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nom_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "номер";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nom);
            this.groupBox1.Controls.Add(this.ad);
            this.groupBox1.Controls.Add(this.imi);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(30, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 332);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить";
            // 
            // Добавить_заказчика
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 355);
            this.Controls.Add(this.groupBox1);
            this.Name = "Добавить_заказчика";
            this.Text = "Добавить заказчика";
            this.Load += new System.EventHandler(this.Добавить_заказчика_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Database1DataSet database1DataSet1;
        private Database1DataSetTableAdapters.ЗаказчикиTableAdapter заказчикиTableAdapter1;
        private System.Windows.Forms.TextBox imi;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}