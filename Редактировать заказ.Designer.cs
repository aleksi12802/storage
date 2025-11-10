
namespace WindowsFormsApp1
{
    partial class Редактировать_заказ
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.заказчикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.заказчикиTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.ЗаказчикиTableAdapter();
            this.отгрузкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отгрузкаTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.ОтгрузкаTableAdapter();
            this.накладнаяОтгрузкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.накладная_отгрузкиTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.Накладная_отгрузкиTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отгрузкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяОтгрузкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(32, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактирование";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 197);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата отгрузки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер накладной";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Заказчик";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.заказчикиBindingSource;
            this.comboBox1.DisplayMember = "Наименования заказчика";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Код_заказчика";
            // 
            // заказчикиBindingSource
            // 
            this.заказчикиBindingSource.DataMember = "Заказчики";
            this.заказчикиBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // заказчикиTableAdapter
            // 
            this.заказчикиTableAdapter.ClearBeforeFill = true;
            // 
            // отгрузкаBindingSource
            // 
            this.отгрузкаBindingSource.DataMember = "Отгрузка";
            this.отгрузкаBindingSource.DataSource = this.database1DataSet;
            // 
            // отгрузкаTableAdapter
            // 
            this.отгрузкаTableAdapter.ClearBeforeFill = true;
            // 
            // накладнаяОтгрузкиBindingSource
            // 
            this.накладнаяОтгрузкиBindingSource.DataMember = "Накладная отгрузки";
            this.накладнаяОтгрузкиBindingSource.DataSource = this.database1DataSet;
            // 
            // накладная_отгрузкиTableAdapter
            // 
            this.накладная_отгрузкиTableAdapter.ClearBeforeFill = true;
            // 
            // Редактировать_заказ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 431);
            this.Controls.Add(this.groupBox1);
            this.Name = "Редактировать_заказ";
            this.Text = "Редактировать заказ";
            this.Load += new System.EventHandler(this.Редактировать_заказ_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отгрузкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяОтгрузкиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource заказчикиBindingSource;
        private Database1DataSetTableAdapters.ЗаказчикиTableAdapter заказчикиTableAdapter;
        private System.Windows.Forms.BindingSource отгрузкаBindingSource;
        private Database1DataSetTableAdapters.ОтгрузкаTableAdapter отгрузкаTableAdapter;
        private System.Windows.Forms.BindingSource накладнаяОтгрузкиBindingSource;
        private Database1DataSetTableAdapters.Накладная_отгрузкиTableAdapter накладная_отгрузкиTableAdapter;
    }
}