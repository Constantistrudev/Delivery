
namespace Graphic_Dilivery
{
    partial class Menu
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
            this.button7 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСДнёмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курьерыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.списокКурьеровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прочееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.смотретьСтатистикуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(725, 537);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 54);
            this.button7.TabIndex = 6;
            this.button7.Text = "Закрыть";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.работаСДнёмToolStripMenuItem,
            this.прочееToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1,
            this.openToolStripMenuItem1,
            this.сохранитьToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.createToolStripMenuItem1.Text = "Создать";
            this.createToolStripMenuItem1.Click += new System.EventHandler(this.createToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.openToolStripMenuItem1.Text = "Открыть";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // работаСДнёмToolStripMenuItem
            // 
            this.работаСДнёмToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.курьерыToolStripMenuItem1});
            this.работаСДнёмToolStripMenuItem.Name = "работаСДнёмToolStripMenuItem";
            this.работаСДнёмToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.работаСДнёмToolStripMenuItem.Text = "Работа с днём";
            // 
            // курьерыToolStripMenuItem1
            // 
            this.курьерыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокКурьеровToolStripMenuItem});
            this.курьерыToolStripMenuItem1.Name = "курьерыToolStripMenuItem1";
            this.курьерыToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.курьерыToolStripMenuItem1.Text = "Курьеры";
            // 
            // списокКурьеровToolStripMenuItem
            // 
            this.списокКурьеровToolStripMenuItem.Name = "списокКурьеровToolStripMenuItem";
            this.списокКурьеровToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.списокКурьеровToolStripMenuItem.Text = "Список курьеров";
            this.списокКурьеровToolStripMenuItem.Click += new System.EventHandler(this.списокКурьеровToolStripMenuItem_Click);
            // 
            // прочееToolStripMenuItem
            // 
            this.прочееToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.смотретьСтатистикуToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.прочееToolStripMenuItem.Name = "прочееToolStripMenuItem";
            this.прочееToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.прочееToolStripMenuItem.Text = "Прочее";
            // 
            // смотретьСтатистикуToolStripMenuItem
            // 
            this.смотретьСтатистикуToolStripMenuItem.Name = "смотретьСтатистикуToolStripMenuItem";
            this.смотретьСтатистикуToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.смотретьСтатистикуToolStripMenuItem.Text = "Смотреть статистику";
            this.смотретьСтатистикуToolStripMenuItem.Click += new System.EventHandler(this.смотретьСтатистикуToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(818, 358);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 603);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem прочееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem смотретьСтатистикуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСДнёмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курьерыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокКурьеровToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

