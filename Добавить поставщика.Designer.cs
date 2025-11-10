
namespace WindowsFormsApp1
{
    partial class Добавить_поставщика
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Tel = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.поставщикиTableAdapter1 = new WindowsFormsApp1.Database1DataSetTableAdapters.ПоставщикиTableAdapter();
            this.database1DataSet1 = new WindowsFormsApp1.Database1DataSet();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Tel);
            this.groupBox1.Controls.Add(this.Adres);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(63, 163);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(240, 20);
            this.Tel.TabIndex = 5;
            this.Tel.TextChanged += new System.EventHandler(this.Tel_TextChanged);
            this.Tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tel_KeyPress);
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(63, 101);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(240, 20);
            this.Adres.TabIndex = 4;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(63, 44);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(240, 20);
            this.name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // поставщикиTableAdapter1
            // 
            this.поставщикиTableAdapter1.ClearBeforeFill = true;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Добавить_поставщика
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 384);
            this.Controls.Add(this.groupBox1);
            this.Name = "Добавить_поставщика";
            this.Text = "Добавить поставщика";
            this.Load += new System.EventHandler(this.Добавить_поставщика_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Database1DataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter1;
        private Database1DataSet database1DataSet1;
    }
}