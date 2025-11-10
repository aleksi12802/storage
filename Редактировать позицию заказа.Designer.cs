
namespace WindowsFormsApp1
{
    partial class Редактировать_позицию_заказа
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxc = new System.Windows.Forms.TextBox();
            this.textBoxk = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.отгрузкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.деталиНаСкладеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new WindowsFormsApp1.Database1DataSet();
            this.накладная_отгрузкиTableAdapter1 = new WindowsFormsApp1.Database1DataSetTableAdapters.Накладная_отгрузкиTableAdapter();
            this.отгрузкаTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.ОтгрузкаTableAdapter();
            this.детали_на_складеTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.Детали_на_складеTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отгрузкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиНаСкладеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(48, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактировать";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Номер накладной";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Деталь";
            // 
            // textBoxc
            // 
            this.textBoxc.Location = new System.Drawing.Point(44, 211);
            this.textBoxc.Name = "textBoxc";
            this.textBoxc.Size = new System.Drawing.Size(213, 20);
            this.textBoxc.TabIndex = 3;
            this.textBoxc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxc_KeyPress);
            // 
            // textBoxk
            // 
            this.textBoxk.Location = new System.Drawing.Point(44, 156);
            this.textBoxk.Name = "textBoxk";
            this.textBoxk.Size = new System.Drawing.Size(213, 20);
            this.textBoxk.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.отгрузкаBindingSource;
            this.comboBox2.DisplayMember = "Номер накладной";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(44, 102);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(214, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "Код отгрузки";
            // 
            // отгрузкаBindingSource
            // 
            this.отгрузкаBindingSource.DataMember = "Отгрузка";
            this.отгрузкаBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.деталиНаСкладеBindingSource;
            this.comboBox1.DisplayMember = "Наименование детали";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Код_детали";
            // 
            // деталиНаСкладеBindingSource
            // 
            this.деталиНаСкладеBindingSource.DataMember = "Детали на складе";
            this.деталиНаСкладеBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // накладная_отгрузкиTableAdapter1
            // 
            this.накладная_отгрузкиTableAdapter1.ClearBeforeFill = true;
            // 
            // отгрузкаTableAdapter
            // 
            this.отгрузкаTableAdapter.ClearBeforeFill = true;
            // 
            // детали_на_складеTableAdapter
            // 
            this.детали_на_складеTableAdapter.ClearBeforeFill = true;
            // 
            // Редактировать_позицию_заказа
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 466);
            this.Controls.Add(this.groupBox1);
            this.Name = "Редактировать_позицию_заказа";
            this.Text = "Редактировать позицию заказа";
            this.Load += new System.EventHandler(this.Редактировать_позицию_заказа_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отгрузкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиНаСкладеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxc;
        private System.Windows.Forms.TextBox textBoxk;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Database1DataSet database1DataSet1;
        private Database1DataSetTableAdapters.Накладная_отгрузкиTableAdapter накладная_отгрузкиTableAdapter1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource отгрузкаBindingSource;
        private Database1DataSetTableAdapters.ОтгрузкаTableAdapter отгрузкаTableAdapter;
        private System.Windows.Forms.BindingSource деталиНаСкладеBindingSource;
        private Database1DataSetTableAdapters.Детали_на_складеTableAdapter детали_на_складеTableAdapter;
    }
}