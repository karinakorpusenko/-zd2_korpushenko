namespace pr2_up
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            menuStrip1 = new MenuStrip();
            gervToolStripMenuItem = new ToolStripMenuItem();
            показатьВсеКонтактыToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            редактироватьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьВФайлToolStripMenuItem = new ToolStripMenuItem();
            поискПоИмениToolStripMenuItem = new ToolStripMenuItem();
            выйтиToolStripMenuItem = new ToolStripMenuItem();
            listBox1 = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 24);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 112);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Телефон";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(37, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gervToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(706, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // gervToolStripMenuItem
            // 
            gervToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { показатьВсеКонтактыToolStripMenuItem, добавитьToolStripMenuItem, удалитьToolStripMenuItem, редактироватьToolStripMenuItem, сохранитьВФайлToolStripMenuItem, поискПоИмениToolStripMenuItem, выйтиToolStripMenuItem });
            gervToolStripMenuItem.Name = "gervToolStripMenuItem";
            gervToolStripMenuItem.Size = new Size(40, 24);
            gervToolStripMenuItem.Text = ". . .";
            // 
            // показатьВсеКонтактыToolStripMenuItem
            // 
            показатьВсеКонтактыToolStripMenuItem.Name = "показатьВсеКонтактыToolStripMenuItem";
            показатьВсеКонтактыToolStripMenuItem.Size = new Size(248, 26);
            показатьВсеКонтактыToolStripMenuItem.Text = "показать все контакты";
            показатьВсеКонтактыToolStripMenuItem.Click += показатьВсеКонтактыToolStripMenuItem_Click;
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(248, 26);
            добавитьToolStripMenuItem.Text = "добавить";
            добавитьToolStripMenuItem.Click += добавитьToolStripMenuItem_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(248, 26);
            удалитьToolStripMenuItem.Text = "удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // редактироватьToolStripMenuItem
            // 
            редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            редактироватьToolStripMenuItem.Size = new Size(248, 26);
            редактироватьToolStripMenuItem.Text = "редактировать";
            редактироватьToolStripMenuItem.Click += редактироватьToolStripMenuItem_Click;
            // 
            // сохранитьВФайлToolStripMenuItem
            // 
            сохранитьВФайлToolStripMenuItem.Name = "сохранитьВФайлToolStripMenuItem";
            сохранитьВФайлToolStripMenuItem.Size = new Size(248, 26);
            сохранитьВФайлToolStripMenuItem.Text = "сохранить в файл";
            сохранитьВФайлToolStripMenuItem.Click += сохранитьВФайлToolStripMenuItem_Click;
            // 
            // поискПоИмениToolStripMenuItem
            // 
            поискПоИмениToolStripMenuItem.Name = "поискПоИмениToolStripMenuItem";
            поискПоИмениToolStripMenuItem.Size = new Size(248, 26);
            поискПоИмениToolStripMenuItem.Text = "поиск по имени";
            поискПоИмениToolStripMenuItem.Click += поискПоИмениToolStripMenuItem_Click;
            // 
            // выйтиToolStripMenuItem
            // 
            выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            выйтиToolStripMenuItem.Size = new Size(248, 26);
            выйтиToolStripMenuItem.Text = "выйти";
            выйтиToolStripMenuItem.Click += выйтиToolStripMenuItem_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(282, 31);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(313, 184);
            listBox1.TabIndex = 13;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 411);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem gervToolStripMenuItem;
        private ToolStripMenuItem показатьВсеКонтактыToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private ToolStripMenuItem сохранитьВФайлToolStripMenuItem;
        private ToolStripMenuItem поискПоИмениToolStripMenuItem;
        private ToolStripMenuItem выйтиToolStripMenuItem;
        private ListBox listBox1;
    }
}
