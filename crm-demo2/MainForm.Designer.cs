namespace crm_demo2
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            добавитьЗаявкуToolStripMenuItem = new ToolStripMenuItem();
            просмотрЗаявокToolStripMenuItem = new ToolStripMenuItem();
            отчетыToolStripMenuItem = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { добавитьЗаявкуToolStripMenuItem, просмотрЗаявокToolStripMenuItem, отчетыToolStripMenuItem, настройкиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(727, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // добавитьЗаявкуToolStripMenuItem
            // 
            добавитьЗаявкуToolStripMenuItem.Name = "добавитьЗаявкуToolStripMenuItem";
            добавитьЗаявкуToolStripMenuItem.Size = new Size(109, 20);
            добавитьЗаявкуToolStripMenuItem.Text = "Добавить заявку";
            добавитьЗаявкуToolStripMenuItem.Click += добавитьЗаявкуToolStripMenuItem_Click;
            // 
            // просмотрЗаявокToolStripMenuItem
            // 
            просмотрЗаявокToolStripMenuItem.Name = "просмотрЗаявокToolStripMenuItem";
            просмотрЗаявокToolStripMenuItem.Size = new Size(115, 20);
            просмотрЗаявокToolStripMenuItem.Text = "Просмотр заявок";
            просмотрЗаявокToolStripMenuItem.Click += просмотрЗаявокToolStripMenuItem_Click;
            // 
            // отчетыToolStripMenuItem
            // 
            отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            отчетыToolStripMenuItem.Size = new Size(60, 20);
            отчетыToolStripMenuItem.Text = "Отчеты";
            отчетыToolStripMenuItem.Click += отчетыToolStripMenuItem_Click;
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(79, 20);
            настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(221, 21);
            label1.TabIndex = 1;
            label1.Text = "Количество открытых заявок:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(220, 21);
            label2.TabIndex = 2;
            label2.Text = "Количество закрытых заявок:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(13, 160);
            label3.Name = "label3";
            label3.Size = new Size(181, 21);
            label3.TabIndex = 3;
            label3.Text = "Количество заказчиков:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(13, 208);
            label4.Name = "label4";
            label4.Size = new Size(167, 21);
            label4.TabIndex = 4;
            label4.Text = "Количество мастеров:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 331);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаявкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрЗаявокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
