
namespace WindowsFormsApp2
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поверхВсехОконToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выдёргиватьОтовсюдуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начинаетсяС79ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начинаетсяС89ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F);
            this.button1.Location = new System.Drawing.Point(180, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 49);
            this.textBox1.MaxLength = 0;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(316, 432);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(381, 49);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(316, 432);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F);
            this.label1.Location = new System.Drawing.Point(25, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Стало:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F);
            this.label2.Location = new System.Drawing.Point(25, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Было:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F);
            this.label3.Location = new System.Drawing.Point(25, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(444, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Удалил: ";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(385, 576);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "Скопировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1287, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // опцииToolStripMenuItem
            // 
            this.опцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поверхВсехОконToolStripMenuItem,
            this.выдёргиватьОтовсюдуToolStripMenuItem});
            this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            this.опцииToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.опцииToolStripMenuItem.Text = "Опции";
            // 
            // поверхВсехОконToolStripMenuItem
            // 
            this.поверхВсехОконToolStripMenuItem.Name = "поверхВсехОконToolStripMenuItem";
            this.поверхВсехОконToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.поверхВсехОконToolStripMenuItem.Text = "Поверх всех окон";
            this.поверхВсехОконToolStripMenuItem.Click += new System.EventHandler(this.поверхВсехОконToolStripMenuItem_Click);
            // 
            // выдёргиватьОтовсюдуToolStripMenuItem
            // 
            this.выдёргиватьОтовсюдуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начинаетсяС79ToolStripMenuItem,
            this.начинаетсяС89ToolStripMenuItem});
            this.выдёргиватьОтовсюдуToolStripMenuItem.Name = "выдёргиватьОтовсюдуToolStripMenuItem";
            this.выдёргиватьОтовсюдуToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.выдёргиватьОтовсюдуToolStripMenuItem.Text = "Выдёргивать отовсюду";
            // 
            // начинаетсяС79ToolStripMenuItem
            // 
            this.начинаетсяС79ToolStripMenuItem.Name = "начинаетсяС79ToolStripMenuItem";
            this.начинаетсяС79ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.начинаетсяС79ToolStripMenuItem.Text = "Начинается с \"79\"";
            this.начинаетсяС79ToolStripMenuItem.Click += new System.EventHandler(this.начинаетсяС79ToolStripMenuItem_Click);
            // 
            // начинаетсяС89ToolStripMenuItem
            // 
            this.начинаетсяС89ToolStripMenuItem.Name = "начинаетсяС89ToolStripMenuItem";
            this.начинаетсяС89ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.начинаетсяС89ToolStripMenuItem.Text = "Начинается с \"89\"";
            this.начинаетсяС89ToolStripMenuItem.Click += new System.EventHandler(this.начинаетсяС89ToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(746, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(316, 432);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1287, 648);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem опцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поверхВсехОконToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выдёргиватьОтовсюдуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начинаетсяС79ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начинаетсяС89ToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
    }
}

