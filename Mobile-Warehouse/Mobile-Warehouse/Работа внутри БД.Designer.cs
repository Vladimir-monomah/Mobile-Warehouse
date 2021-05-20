namespace Mobile_Warehouse
{
    partial class Работа_внутри_БД
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Работа_внутри_БД));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сменитьАккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменаПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.карточкиПоставщиковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.товарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.брендыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ведомостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ведомостьОПоставкахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.pbProvider = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.labelLib = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьАккаунтToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.ведомостиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сменитьАккаунтToolStripMenuItem
            // 
            this.сменитьАккаунтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменаПользователяToolStripMenuItem});
            this.сменитьАккаунтToolStripMenuItem.Name = "сменитьАккаунтToolStripMenuItem";
            this.сменитьАккаунтToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.сменитьАккаунтToolStripMenuItem.Text = "Сменить аккаунт";
            // 
            // сменаПользователяToolStripMenuItem
            // 
            this.сменаПользователяToolStripMenuItem.Image = global::Mobile_Warehouse.Properties.Resources.customer_vector_3;
            this.сменаПользователяToolStripMenuItem.Name = "сменаПользователяToolStripMenuItem";
            this.сменаПользователяToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.сменаПользователяToolStripMenuItem.Text = "Смена пользователя";
            this.сменаПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменаПользователяToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.карточкиПоставщиковToolStripMenuItem,
            this.toolStripMenuItem1,
            this.товарToolStripMenuItem,
            this.toolStripMenuItem2,
            this.брендыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // карточкиПоставщиковToolStripMenuItem
            // 
            this.карточкиПоставщиковToolStripMenuItem.Name = "карточкиПоставщиковToolStripMenuItem";
            this.карточкиПоставщиковToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.карточкиПоставщиковToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.карточкиПоставщиковToolStripMenuItem.Text = "Карточки поставщиков";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(292, 6);
            // 
            // товарToolStripMenuItem
            // 
            this.товарToolStripMenuItem.Name = "товарToolStripMenuItem";
            this.товарToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.товарToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.товарToolStripMenuItem.Text = "Товар";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(292, 6);
            // 
            // брендыToolStripMenuItem
            // 
            this.брендыToolStripMenuItem.Name = "брендыToolStripMenuItem";
            this.брендыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.брендыToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.брендыToolStripMenuItem.Text = "Бренды";
            // 
            // ведомостиToolStripMenuItem
            // 
            this.ведомостиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ведомостьОПоставкахToolStripMenuItem});
            this.ведомостиToolStripMenuItem.Name = "ведомостиToolStripMenuItem";
            this.ведомостиToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.ведомостиToolStripMenuItem.Text = "Ведомости";
            // 
            // ведомостьОПоставкахToolStripMenuItem
            // 
            this.ведомостьОПоставкахToolStripMenuItem.Name = "ведомостьОПоставкахToolStripMenuItem";
            this.ведомостьОПоставкахToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.ведомостьОПоставкахToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.ведомостьОПоставкахToolStripMenuItem.Text = "Ведомость о поставках";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.toolStripMenuItem3,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(233, 6);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.pbProvider);
            this.panel.Location = new System.Drawing.Point(0, 31);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 53);
            this.panel.TabIndex = 5;
            // 
            // pbProvider
            // 
            this.pbProvider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbProvider.Image = global::Mobile_Warehouse.Properties.Resources.no_photo_girl;
            this.pbProvider.Location = new System.Drawing.Point(12, 4);
            this.pbProvider.Name = "pbProvider";
            this.pbProvider.Size = new System.Drawing.Size(45, 45);
            this.pbProvider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProvider.TabIndex = 0;
            this.pbProvider.TabStop = false;
            this.pbProvider.Click += new System.EventHandler(this.AddTabControl);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.Location = new System.Drawing.Point(0, 90);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 307);
            this.tabControl.TabIndex = 6;
            this.tabControl.Visible = false;
            this.tabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseClick);
            // 
            // labelLib
            // 
            this.labelLib.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLib.AutoSize = true;
            this.labelLib.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLib.Location = new System.Drawing.Point(8, 417);
            this.labelLib.Name = "labelLib";
            this.labelLib.Size = new System.Drawing.Size(64, 24);
            this.labelLib.TabIndex = 7;
            this.labelLib.Text = "label1";
            // 
            // Работа_внутри_БД
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLib);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Работа_внутри_БД";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobile Warehouse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Работа_внутри_БД_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сменитьАккаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ведомостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменаПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem карточкиПоставщиковToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem товарToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem брендыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ведомостьОПоставкахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pbProvider;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label labelLib;
    }
}

