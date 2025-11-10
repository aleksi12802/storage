
namespace WindowsFormsApp1
{
    partial class Добавить_позицию_поставки
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.деталиНаСкладеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.поставкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.детали_на_складеTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.Детали_на_складеTableAdapter();
            this.поставкиTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.ПоставкиTableAdapter();
            this.накладная_поставокTableAdapter1 = new WindowsFormsApp1.Database1DataSetTableAdapters.Накладная_поставокTableAdapter();
            this.накладнаяПоставокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикиTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.ПоставщикиTableAdapter();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.деталиНаСкладеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяПоставокBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 461);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить позицию";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(55, 156);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(268, 20);
            this.textBox3.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(129, 422);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 33);
            this.button3.TabIndex = 10;
            this.button3.Text = "Отменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(55, 295);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(268, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Деталь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер накладной";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить деталь";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.деталиНаСкладеBindingSource;
            this.comboBox2.DisplayMember = "Наименование детали";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(55, 101);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(268, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "Код_детали";
            // 
            // деталиНаСкладеBindingSource
            // 
            this.деталиНаСкладеBindingSource.DataMember = "Детали на складе";
            this.деталиНаСкладеBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.поставкиBindingSource;
            this.comboBox1.DisplayMember = "номер накладной";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(268, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Код_поставки";
            // 
            // поставкиBindingSource
            // 
            this.поставкиBindingSource.DataMember = "Поставки";
            this.поставкиBindingSource.DataSource = this.database1DataSet;
            // 
            // детали_на_складеTableAdapter
            // 
            this.детали_на_складеTableAdapter.ClearBeforeFill = true;
            // 
            // поставкиTableAdapter
            // 
            this.поставкиTableAdapter.ClearBeforeFill = true;
            // 
            // накладная_поставокTableAdapter1
            // 
            this.накладная_поставокTableAdapter1.ClearBeforeFill = true;
            // 
            // накладнаяПоставокBindingSource
            // 
            this.накладнаяПоставокBindingSource.DataMember = "Накладная поставок";
            this.накладнаяПоставокBindingSource.DataSource = this.database1DataSet;
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.database1DataSet;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Количество";
            // 
            // Добавить_позицию_поставки
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 506);
            this.Controls.Add(this.groupBox1);
            this.Name = "Добавить_позицию_поставки";
            this.Text = "Добавить позицию поставки";
            this.Load += new System.EventHandler(this.Добавить_позицию_поставки_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.деталиНаСкладеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяПоставокBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource деталиНаСкладеBindingSource;
        private Database1DataSetTableAdapters.Детали_на_складеTableAdapter детали_на_складеTableAdapter;
        private System.Windows.Forms.BindingSource поставкиBindingSource;
        private Database1DataSetTableAdapters.ПоставкиTableAdapter поставкиTableAdapter;
        private Database1DataSetTableAdapters.Накладная_поставокTableAdapter накладная_поставокTableAdapter1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource накладнаяПоставокBindingSource;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private Database1DataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
    }
}