
namespace WindowsFormsApp1
{
    partial class Добавить_заказ
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.заказчикиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.заказчикиTableAdapter1 = new WindowsFormsApp1.Database1DataSetTableAdapters.ЗаказчикиTableAdapter();
            this.отгрузкаTableAdapter1 = new WindowsFormsApp1.Database1DataSetTableAdapters.ОтгрузкаTableAdapter();
            this.заказчикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.накладная_отгрузкиTableAdapter1 = new WindowsFormsApp1.Database1DataSetTableAdapters.Накладная_отгрузкиTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 347);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить заказ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Добавить заказчика";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Номер накладной";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Заказчик";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(62, 239);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.заказчикиBindingSource1;
            this.comboBox1.DisplayMember = "Наименования заказчика";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Код_заказчика";
            // 
            // заказчикиBindingSource1
            // 
            this.заказчикиBindingSource1.DataMember = "Заказчики";
            this.заказчикиBindingSource1.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказчикиTableAdapter1
            // 
            this.заказчикиTableAdapter1.ClearBeforeFill = true;
            // 
            // отгрузкаTableAdapter1
            // 
            this.отгрузкаTableAdapter1.ClearBeforeFill = true;
            // 
            // заказчикиBindingSource
            // 
            this.заказчикиBindingSource.DataMember = "Заказчики";
            this.заказчикиBindingSource.DataSource = this.database1DataSet;
            // 
            // накладная_отгрузкиTableAdapter1
            // 
            this.накладная_отгрузкиTableAdapter1.ClearBeforeFill = true;
            // 
            // Добавить_заказ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 385);
            this.Controls.Add(this.groupBox1);
            this.Name = "Добавить_заказ";
            this.Text = "Добавить заказ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Database1DataSetTableAdapters.ЗаказчикиTableAdapter заказчикиTableAdapter1;
        private Database1DataSetTableAdapters.ОтгрузкаTableAdapter отгрузкаTableAdapter1;
        private System.Windows.Forms.Button button2;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource заказчикиBindingSource;
        private System.Windows.Forms.BindingSource заказчикиBindingSource1;
        private Database1DataSetTableAdapters.Накладная_отгрузкиTableAdapter накладная_отгрузкиTableAdapter1;
    }
}