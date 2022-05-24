
namespace BD_6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Предмет = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTeacherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtThemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datLessonDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db22207DataSet = new BD_6.db22207DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.tblLessonTableAdapter = new BD_6.db22207DataSetTableAdapters.tblLessonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db22207DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Предмет,
            this.txtTeacherNameDataGridViewTextBoxColumn,
            this.txtThemeDataGridViewTextBoxColumn,
            this.datLessonDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblLessonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1104, 595);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Предмет
            // 
            this.Предмет.DataPropertyName = "txtSubjectName";
            this.Предмет.HeaderText = "Название предмета";
            this.Предмет.MinimumWidth = 6;
            this.Предмет.Name = "Предмет";
            this.Предмет.ReadOnly = true;
            this.Предмет.Width = 125;
            // 
            // txtTeacherNameDataGridViewTextBoxColumn
            // 
            this.txtTeacherNameDataGridViewTextBoxColumn.DataPropertyName = "txtTeacherName";
            this.txtTeacherNameDataGridViewTextBoxColumn.HeaderText = "Преподаватель";
            this.txtTeacherNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.txtTeacherNameDataGridViewTextBoxColumn.Name = "txtTeacherNameDataGridViewTextBoxColumn";
            this.txtTeacherNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.txtTeacherNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // txtThemeDataGridViewTextBoxColumn
            // 
            this.txtThemeDataGridViewTextBoxColumn.DataPropertyName = "txtTheme";
            this.txtThemeDataGridViewTextBoxColumn.HeaderText = "Тема";
            this.txtThemeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.txtThemeDataGridViewTextBoxColumn.Name = "txtThemeDataGridViewTextBoxColumn";
            this.txtThemeDataGridViewTextBoxColumn.ReadOnly = true;
            this.txtThemeDataGridViewTextBoxColumn.Width = 200;
            // 
            // datLessonDateDataGridViewTextBoxColumn
            // 
            this.datLessonDateDataGridViewTextBoxColumn.DataPropertyName = "datLessonDate";
            this.datLessonDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.datLessonDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datLessonDateDataGridViewTextBoxColumn.Name = "datLessonDateDataGridViewTextBoxColumn";
            this.datLessonDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.datLessonDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblLessonBindingSource
            // 
            this.tblLessonBindingSource.DataMember = "tblLesson";
            this.tblLessonBindingSource.DataSource = this.db22207DataSet;
            // 
            // db22207DataSet
            // 
            this.db22207DataSet.DataSetName = "db22207DataSet";
            this.db22207DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 625);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить урок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Adding);
            // 
            // tblLessonTableAdapter
            // 
            this.tblLessonTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 684);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db22207DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private db22207DataSet db22207DataSet;
        private System.Windows.Forms.BindingSource tblLessonBindingSource;
        private db22207DataSetTableAdapters.tblLessonTableAdapter tblLessonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Предмет;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTeacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtThemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datLessonDateDataGridViewTextBoxColumn;
    }
}

