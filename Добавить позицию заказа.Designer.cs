
namespace WindowsFormsApp1
{
    partial class Добавить_позицию_заказа
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxc = new System.Windows.Forms.TextBox();
            this.textBoxk = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.отгрузкаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new WindowsFormsApp1.Database1DataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.деталиНаСкладеBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.отгрузкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.деталиНаСкладеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отгрузкаTableAdapter1 = new WindowsFormsApp1.Database1DataSetTableAdapters.ОтгрузкаTableAdapter();
            this.накладная_отгрузкиTableAdapter1 = new WindowsFormsApp1.Database1DataSetTableAdapters.Накладная_отгрузкиTableAdapter();
            this.заказчикиTableAdapter1 = new WindowsFormsApp1.Database1DataSetTableAdapters.ЗаказчикиTableAdapter();
            this.детали_на_складеTableAdapter1 = new WindowsFormsApp1.Database1DataSetTableAdapters.Детали_на_складеTableAdapter();
            this.database1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.накладнаяОтгрузкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отгрузкаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиНаСкладеBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отгрузкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиНаСкладеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяОтгрузкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxc);
            this.groupBox1.Controls.Add(this.textBoxk);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(41, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 445);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить позицию";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Сумма";
            this.label5.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "Добавить деталь";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Номер накладной";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Деталь";
            // 
            // textBoxc
            // 
            this.textBoxc.Location = new System.Drawing.Point(51, 262);
            this.textBoxc.Name = "textBoxc";
            this.textBoxc.Size = new System.Drawing.Size(251, 20);
            this.textBoxc.TabIndex = 3;
            this.textBoxc.TextChanged += new System.EventHandler(this.textBoxc_TextChanged);
            this.textBoxc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxc_KeyPress);
            // 
            // textBoxk
            // 
            this.textBoxk.Location = new System.Drawing.Point(51, 210);
            this.textBoxk.Name = "textBoxk";
            this.textBoxk.Size = new System.Drawing.Size(251, 20);
            this.textBoxk.TabIndex = 2;
            this.textBoxk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxk_KeyPress);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.отгрузкаBindingSource1;
            this.comboBox2.DisplayMember = "Номер накладной";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(51, 148);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(250, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "Код отгрузки";
            // 
            // отгрузкаBindingSource1
            // 
            this.отгрузкаBindingSource1.DataMember = "Отгрузка";
            this.отгрузкаBindingSource1.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.деталиНаСкладеBindingSource1;
            this.comboBox1.DisplayMember = "Наименование детали";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Код_детали";
            // 
            // деталиНаСкладеBindingSource1
            // 
            this.деталиНаСкладеBindingSource1.DataMember = "Детали на складе";
            this.деталиНаСкладеBindingSource1.DataSource = this.database1DataSet1;
            // 
            // отгрузкаTableAdapter1
            // 
            this.отгрузкаTableAdapter1.ClearBeforeFill = true;
            // 
            // накладная_отгрузкиTableAdapter1
            // 
            this.накладная_отгрузкиTableAdapter1.ClearBeforeFill = true;
            // 
            // заказчикиTableAdapter1
            // 
            this.заказчикиTableAdapter1.ClearBeforeFill = true;
            // 
            // детали_на_складеTableAdapter1
            // 
            this.детали_на_складеTableAdapter1.ClearBeforeFill = true;
            // 
            // Добавить_позицию_заказа
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 476);
            this.Controls.Add(this.groupBox1);
            this.Name = "Добавить_позицию_заказа";
            this.Text = "Добавить позицию заказа";
            this.Load += new System.EventHandler(this.Добавить_позицию_заказа_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отгрузкаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиНаСкладеBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отгрузкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиНаСкладеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяОтгрузкиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxc;
        private System.Windows.Forms.TextBox textBoxk;
        private Database1DataSetTableAdapters.ОтгрузкаTableAdapter отгрузкаTableAdapter1;
        private Database1DataSetTableAdapters.Накладная_отгрузкиTableAdapter накладная_отгрузкиTableAdapter1;
        private Database1DataSetTableAdapters.ЗаказчикиTableAdapter заказчикиTableAdapter1;
        private Database1DataSetTableAdapters.Детали_на_складеTableAdapter детали_на_складеTableAdapter1;
        private System.Windows.Forms.BindingSource отгрузкаBindingSource;
        private System.Windows.Forms.BindingSource деталиНаСкладеBindingSource;
        private System.Windows.Forms.BindingSource database1DataSet1BindingSource;
        private System.Windows.Forms.BindingSource накладнаяОтгрузкиBindingSource;
        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.BindingSource деталиНаСкладеBindingSource1;
        private System.Windows.Forms.BindingSource отгрузкаBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}