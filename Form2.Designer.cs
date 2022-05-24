
namespace BD_6
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.db22207DataSet1 = new BD_6.db22207DataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tblSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db22207DataSet11 = new BD_6.db22207DataSet1();
            this.db22207DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSubjectTableAdapter = new BD_6.db22207DataSet1TableAdapters.tblSubjectTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.teachers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.db22207DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db22207DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db22207DataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(21, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название предмета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(21, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата проведения";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(21, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "ФИО преподавателя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(21, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Тема урока";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(370, 242);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(418, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.topic);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(27, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 63);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сохранить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.sending);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(298, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 63);
            this.button2.TabIndex = 10;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.otmena);
            // 
            // db22207DataSet1
            // 
            this.db22207DataSet1.DataSetName = "db22207DataSet";
            this.db22207DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tblSubjectBindingSource;
            this.comboBox1.DisplayMember = "txtSubjectName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(370, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(418, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tblSubjectBindingSource
            // 
            this.tblSubjectBindingSource.DataMember = "tblSubject";
            this.tblSubjectBindingSource.DataSource = this.db22207DataSet11;
            // 
            // db22207DataSet11
            // 
            this.db22207DataSet11.DataSetName = "db22207DataSet1";
            this.db22207DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db22207DataSet1BindingSource
            // 
            this.db22207DataSet1BindingSource.DataSource = this.db22207DataSet1;
            this.db22207DataSet1BindingSource.Position = 0;
            // 
            // tblSubjectTableAdapter
            // 
            this.tblSubjectTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(370, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(418, 22);
            this.textBox1.TabIndex = 13;
            // 
            // teachers
            // 
            this.teachers.DataSource = this.tblSubjectBindingSource;
            this.teachers.DisplayMember = "txtSubjectName";
            this.teachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teachers.FormattingEnabled = true;
            this.teachers.Location = new System.Drawing.Point(370, 317);
            this.teachers.Name = "teachers";
            this.teachers.Size = new System.Drawing.Size(418, 24);
            this.teachers.TabIndex = 14;
            this.teachers.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 495);
            this.Controls.Add(this.teachers);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db22207DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db22207DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db22207DataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private db22207DataSet db22207DataSet1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource db22207DataSet1BindingSource;
        private db22207DataSet1 db22207DataSet11;
        private System.Windows.Forms.BindingSource tblSubjectBindingSource;
        private db22207DataSet1TableAdapters.tblSubjectTableAdapter tblSubjectTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox teachers;
    }
}