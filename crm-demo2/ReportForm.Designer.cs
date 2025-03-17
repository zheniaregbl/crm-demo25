namespace crm_demo2
{
    partial class ReportForm
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
            dataGridView1 = new DataGridView();
            createReportButton = new Button();
            toDatePicker = new DateTimePicker();
            fromDatePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(812, 309);
            dataGridView1.TabIndex = 3;
            // 
            // createReportButton
            // 
            createReportButton.Font = new Font("Segoe UI", 12F);
            createReportButton.Location = new Point(296, 424);
            createReportButton.Name = "createReportButton";
            createReportButton.Size = new Size(175, 29);
            createReportButton.TabIndex = 4;
            createReportButton.Text = "Сформировать";
            createReportButton.UseVisualStyleBackColor = true;
            createReportButton.Click += createReportButton_Click;
            // 
            // toDatePicker
            // 
            toDatePicker.CalendarFont = new Font("Segoe UI", 12F);
            toDatePicker.Location = new Point(39, 69);
            toDatePicker.Name = "toDatePicker";
            toDatePicker.Size = new Size(200, 23);
            toDatePicker.TabIndex = 1;
            // 
            // fromDatePicker
            // 
            fromDatePicker.CalendarFont = new Font("Segoe UI", 12F);
            fromDatePicker.Location = new Point(38, 40);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.Size = new Size(200, 23);
            fromDatePicker.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 2;
            label1.Text = "Период заявок";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(29, 21);
            label2.TabIndex = 3;
            label2.Text = "От";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 69);
            label3.Name = "label3";
            label3.Size = new Size(30, 21);
            label3.TabIndex = 4;
            label3.Text = "До";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(fromDatePicker);
            panel1.Controls.Add(toDatePicker);
            panel1.Location = new Point(12, 327);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 126);
            panel1.TabIndex = 2;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 465);
            Controls.Add(createReportButton);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Формирование отчета";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button createReportButton;
        private DateTimePicker toDatePicker;
        private DateTimePicker fromDatePicker;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
    }
}