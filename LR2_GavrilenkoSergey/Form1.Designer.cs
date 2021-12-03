namespace LR2_GavrilenkoSergey
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.суммаРядаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.арифметическаяЗадачкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.суммаРядаToolStripMenuItem,
            this.арифметическаяЗадачкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.файлToolStripMenuItem.Text = "Табулирование функции";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.Zad1);
            // 
            // суммаРядаToolStripMenuItem
            // 
            this.суммаРядаToolStripMenuItem.Name = "суммаРядаToolStripMenuItem";
            this.суммаРядаToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.суммаРядаToolStripMenuItem.Text = "Сумма ряда";
            this.суммаРядаToolStripMenuItem.Click += new System.EventHandler(this.Zad2);
            // 
            // арифметическаяЗадачкаToolStripMenuItem
            // 
            this.арифметическаяЗадачкаToolStripMenuItem.Name = "арифметическаяЗадачкаToolStripMenuItem";
            this.арифметическаяЗадачкаToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.арифметическаяЗадачкаToolStripMenuItem.Text = "Арифметическая задачка";
            this.арифметическаяЗадачкаToolStripMenuItem.Click += new System.EventHandler(this.Zad3);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Лабораторная работа №2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(620, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тема: Изучение алгоритмов циклической структуры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 70);
            this.label3.TabIndex = 3;
            this.label3.Text = "Выполнил:Студент группы ИСТ-115Б\r\nГавриленко Сергей\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 178);
            this.Controls.Add(this.label3);
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

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem суммаРядаToolStripMenuItem;
        private ToolStripMenuItem арифметическаяЗадачкаToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}