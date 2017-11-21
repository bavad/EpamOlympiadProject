namespace EpamOlymp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТренераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьОлимпиадуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьУчастиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тренерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.олимпиадыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.добавитьToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСтудентаToolStripMenuItem,
            this.добавитьТренераToolStripMenuItem,
            this.добавитьОлимпиадуToolStripMenuItem,
            this.добавитьУчастиеToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // добавитьСтудентаToolStripMenuItem
            // 
            this.добавитьСтудентаToolStripMenuItem.Name = "добавитьСтудентаToolStripMenuItem";
            this.добавитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.добавитьСтудентаToolStripMenuItem.Text = "Добавить студента";
            this.добавитьСтудентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьСтудентаToolStripMenuItem_Click);
            // 
            // добавитьТренераToolStripMenuItem
            // 
            this.добавитьТренераToolStripMenuItem.Name = "добавитьТренераToolStripMenuItem";
            this.добавитьТренераToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.добавитьТренераToolStripMenuItem.Text = "Добавить тренера";
            this.добавитьТренераToolStripMenuItem.Click += new System.EventHandler(this.добавитьТренераToolStripMenuItem_Click);
            // 
            // добавитьОлимпиадуToolStripMenuItem
            // 
            this.добавитьОлимпиадуToolStripMenuItem.Name = "добавитьОлимпиадуToolStripMenuItem";
            this.добавитьОлимпиадуToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.добавитьОлимпиадуToolStripMenuItem.Text = "Добавить олимпиаду";
            this.добавитьОлимпиадуToolStripMenuItem.Click += new System.EventHandler(this.добавитьОлимпиадуToolStripMenuItem_Click);
            // 
            // добавитьУчастиеToolStripMenuItem
            // 
            this.добавитьУчастиеToolStripMenuItem.Name = "добавитьУчастиеToolStripMenuItem";
            this.добавитьУчастиеToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.добавитьУчастиеToolStripMenuItem.Text = "Добавить участие";
            this.добавитьУчастиеToolStripMenuItem.Click += new System.EventHandler(this.добавитьУчастиеToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентыToolStripMenuItem,
            this.тренерыToolStripMenuItem,
            this.олимпиадыToolStripMenuItem});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.студентыToolStripMenuItem.Text = "Студенты";
            this.студентыToolStripMenuItem.Click += new System.EventHandler(this.студентыToolStripMenuItem_Click);
            // 
            // тренерыToolStripMenuItem
            // 
            this.тренерыToolStripMenuItem.Name = "тренерыToolStripMenuItem";
            this.тренерыToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.тренерыToolStripMenuItem.Text = "Тренеры";
            this.тренерыToolStripMenuItem.Click += new System.EventHandler(this.тренерыToolStripMenuItem_Click);
            // 
            // олимпиадыToolStripMenuItem
            // 
            this.олимпиадыToolStripMenuItem.Name = "олимпиадыToolStripMenuItem";
            this.олимпиадыToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.олимпиадыToolStripMenuItem.Text = "Олимпиады";
            this.олимпиадыToolStripMenuItem.Click += new System.EventHandler(this.олимпиадыToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добро пожаловать!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Для работы используйте контекстное меню";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 141);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтудентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТренераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьОлимпиадуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьУчастиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тренерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem олимпиадыToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

