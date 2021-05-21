namespace Mobile_Warehouse.Объекты
{
    partial class Объекты
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Объекты));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.брендDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПоступленияТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.реальнаяДатаПривозаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикиЗапросBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mobExpressDataSet = new Mobile_Warehouse.MobExpressDataSet();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.поставщикиЗапросTableAdapter = new Mobile_Warehouse.MobExpressDataSetTableAdapters.ПоставщикиЗапросTableAdapter();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикиTableAdapter = new Mobile_Warehouse.MobExpressDataSetTableAdapters.ПоставщикиTableAdapter();
            this.tabControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиЗапросBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobExpressDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1481, 771);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView);
            this.tabPage3.Controls.Add(this.buttonPrint);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.button11);
            this.tabPage3.Controls.Add(this.buttonExport);
            this.tabPage3.Controls.Add(this.buttonImport);
            this.tabPage3.Controls.Add(this.buttonRefresh);
            this.tabPage3.Controls.Add(this.buttonDelete);
            this.tabPage3.Controls.Add(this.buttonAdd);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1473, 742);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Карточки поставщиков";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.полDataGridViewTextBoxColumn,
            this.брендDataGridViewTextBoxColumn,
            this.датаПоступленияТовараDataGridViewTextBoxColumn,
            this.реальнаяДатаПривозаDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.поставщикиЗапросBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(8, 106);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1457, 628);
            this.dataGridView.TabIndex = 16;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            this.полDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // брендDataGridViewTextBoxColumn
            // 
            this.брендDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.брендDataGridViewTextBoxColumn.DataPropertyName = "Бренд";
            this.брендDataGridViewTextBoxColumn.HeaderText = "Бренд";
            this.брендDataGridViewTextBoxColumn.Name = "брендDataGridViewTextBoxColumn";
            this.брендDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаПоступленияТовараDataGridViewTextBoxColumn
            // 
            this.датаПоступленияТовараDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаПоступленияТовараDataGridViewTextBoxColumn.DataPropertyName = "Дата поступления товара";
            this.датаПоступленияТовараDataGridViewTextBoxColumn.HeaderText = "Дата поступления товара";
            this.датаПоступленияТовараDataGridViewTextBoxColumn.Name = "датаПоступленияТовараDataGridViewTextBoxColumn";
            this.датаПоступленияТовараDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // реальнаяДатаПривозаDataGridViewTextBoxColumn
            // 
            this.реальнаяДатаПривозаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.реальнаяДатаПривозаDataGridViewTextBoxColumn.DataPropertyName = "Реальная дата привоза";
            this.реальнаяДатаПривозаDataGridViewTextBoxColumn.HeaderText = "Реальная дата привоза";
            this.реальнаяДатаПривозаDataGridViewTextBoxColumn.Name = "реальнаяДатаПривозаDataGridViewTextBoxColumn";
            this.реальнаяДатаПривозаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // поставщикиЗапросBindingSource
            // 
            this.поставщикиЗапросBindingSource.DataMember = "ПоставщикиЗапрос";
            this.поставщикиЗапросBindingSource.DataSource = this.mobExpressDataSet;
            // 
            // mobExpressDataSet
            // 
            this.mobExpressDataSet.DataSetName = "MobExpressDataSet";
            this.mobExpressDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.Location = new System.Drawing.Point(1197, 35);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(86, 30);
            this.buttonPrint.TabIndex = 15;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(73, 70);
            this.textBox3.MaxLength = 30;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1354, 30);
            this.textBox3.TabIndex = 12;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Поиск";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(671, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Карточка поставщиков";
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Image = global::Mobile_Warehouse.Properties.Resources.кнопка_3;
            this.button11.Location = new System.Drawing.Point(1433, 70);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(32, 30);
            this.button11.TabIndex = 4;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.Location = new System.Drawing.Point(1289, 35);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(86, 30);
            this.buttonExport.TabIndex = 6;
            this.buttonExport.Text = "Экспорт";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImport.Location = new System.Drawing.Point(1381, 35);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(86, 30);
            this.buttonImport.TabIndex = 6;
            this.buttonImport.Text = "Импорт";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(233, 28);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(102, 30);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Сохранить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Visible = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(120, 28);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(107, 30);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(5, 28);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(109, 30);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // поставщикиЗапросTableAdapter
            // 
            this.поставщикиЗапросTableAdapter.ClearBeforeFill = true;
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.mobExpressDataSet;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // Объекты
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 771);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Объекты";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Объекты";
            this.Load += new System.EventHandler(this.Объекты_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиЗапросBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobExpressDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private MobExpressDataSet mobExpressDataSet;
        private System.Windows.Forms.BindingSource поставщикиЗапросBindingSource;
        private MobExpressDataSetTableAdapters.ПоставщикиЗапросTableAdapter поставщикиЗапросTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn брендDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПоступленияТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn реальнаяДатаПривозаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private MobExpressDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
    }
}