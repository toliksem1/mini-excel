namespace WindowsFormsApp28
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиСтовбецьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиСтовбецьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиРядокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиРядокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жирнийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.підкресленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.знайтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замінитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gridToolStripMenuItem,
            this.styleToolStripMenuItem,
            this.sreaToolStripMenuItem,
            this.проПрограмуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новийToolStripMenuItem,
            this.відкритиToolStripMenuItem,
            this.зберегтиToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // новийToolStripMenuItem
            // 
            this.новийToolStripMenuItem.Name = "новийToolStripMenuItem";
            this.новийToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.новийToolStripMenuItem.Text = "Новий";
            this.новийToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиСтовбецьToolStripMenuItem,
            this.видалитиСтовбецьToolStripMenuItem,
            this.видалитиРядокToolStripMenuItem,
            this.додатиРядокToolStripMenuItem});
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.gridToolStripMenuItem.Text = "Grid";
            // 
            // додатиСтовбецьToolStripMenuItem
            // 
            this.додатиСтовбецьToolStripMenuItem.Name = "додатиСтовбецьToolStripMenuItem";
            this.додатиСтовбецьToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.додатиСтовбецьToolStripMenuItem.Text = "Додати стовбець";
            this.додатиСтовбецьToolStripMenuItem.Click += new System.EventHandler(this.addColumnToolStripMenuItem_Click);
            // 
            // видалитиСтовбецьToolStripMenuItem
            // 
            this.видалитиСтовбецьToolStripMenuItem.Name = "видалитиСтовбецьToolStripMenuItem";
            this.видалитиСтовбецьToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.видалитиСтовбецьToolStripMenuItem.Text = "Видалити стовбець";
            this.видалитиСтовбецьToolStripMenuItem.Click += new System.EventHandler(this.removeColumnToolStripMenuItem_Click);
            // 
            // видалитиРядокToolStripMenuItem
            // 
            this.видалитиРядокToolStripMenuItem.Name = "видалитиРядокToolStripMenuItem";
            this.видалитиРядокToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.видалитиРядокToolStripMenuItem.Text = "Видалити рядок";
            this.видалитиРядокToolStripMenuItem.Click += new System.EventHandler(this.removeRowToolStripMenuItem_Click);
            // 
            // додатиРядокToolStripMenuItem
            // 
            this.додатиРядокToolStripMenuItem.Name = "додатиРядокToolStripMenuItem";
            this.додатиРядокToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.додатиРядокToolStripMenuItem.Text = "Додати рядок";
            this.додатиРядокToolStripMenuItem.Click += new System.EventHandler(this.addRowToolStripMenuItem_Click);
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.жирнийToolStripMenuItem,
            this.курсівToolStripMenuItem,
            this.підкресленняToolStripMenuItem,
            this.шрифтToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // жирнийToolStripMenuItem
            // 
            this.жирнийToolStripMenuItem.Name = "жирнийToolStripMenuItem";
            this.жирнийToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.жирнийToolStripMenuItem.Text = "Жирний";
            this.жирнийToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // курсівToolStripMenuItem
            // 
            this.курсівToolStripMenuItem.Name = "курсівToolStripMenuItem";
            this.курсівToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.курсівToolStripMenuItem.Text = "Курсів";
            this.курсівToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
            // 
            // підкресленняToolStripMenuItem
            // 
            this.підкресленняToolStripMenuItem.Name = "підкресленняToolStripMenuItem";
            this.підкресленняToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.підкресленняToolStripMenuItem.Text = "Підкреслення";
            this.підкресленняToolStripMenuItem.Click += new System.EventHandler(this.underlineToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // sreaToolStripMenuItem
            // 
            this.sreaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.знайтиToolStripMenuItem,
            this.замінитиToolStripMenuItem});
            this.sreaToolStripMenuItem.Name = "sreaToolStripMenuItem";
            this.sreaToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.sreaToolStripMenuItem.Text = "Search";
            // 
            // знайтиToolStripMenuItem
            // 
            this.знайтиToolStripMenuItem.Name = "знайтиToolStripMenuItem";
            this.знайтиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.знайтиToolStripMenuItem.Text = "Знайти";
            this.знайтиToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // замінитиToolStripMenuItem
            // 
            this.замінитиToolStripMenuItem.Name = "замінитиToolStripMenuItem";
            this.замінитиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.замінитиToolStripMenuItem.Text = "Замінити";
            this.замінитиToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(792, 388);
            this.dataGridView1.TabIndex = 1;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.HelpRequest += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sreaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem новийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиСтовбецьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиСтовбецьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиРядокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиРядокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жирнийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem підкресленняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem знайтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замінитиToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
    }
}

