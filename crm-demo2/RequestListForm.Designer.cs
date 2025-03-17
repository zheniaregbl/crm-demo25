namespace crm_demo2
{
    partial class RequestListForm
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
            searchField = new TextBox();
            statusField = new ComboBox();
            requestDataGridView = new DataGridView();
            changeButton = new Button();
            removeButton = new Button();
            searchButton = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)requestDataGridView).BeginInit();
            SuspendLayout();
            // 
            // searchField
            // 
            searchField.Font = new Font("Segoe UI", 12F);
            searchField.Location = new Point(12, 38);
            searchField.Name = "searchField";
            searchField.Size = new Size(203, 29);
            searchField.TabIndex = 0;
            // 
            // statusField
            // 
            statusField.DropDownStyle = ComboBoxStyle.DropDownList;
            statusField.Font = new Font("Segoe UI", 12F);
            statusField.FormattingEnabled = true;
            statusField.Items.AddRange(new object[] { "любой", "новая", "в процессе ремонта", "готова к выдаче" });
            statusField.Location = new Point(221, 39);
            statusField.Name = "statusField";
            statusField.Size = new Size(186, 29);
            statusField.TabIndex = 1;
            // 
            // requestDataGridView
            // 
            requestDataGridView.AllowUserToAddRows = false;
            requestDataGridView.AllowUserToDeleteRows = false;
            requestDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            requestDataGridView.BackgroundColor = SystemColors.Control;
            requestDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestDataGridView.GridColor = SystemColors.Info;
            requestDataGridView.Location = new Point(12, 85);
            requestDataGridView.Name = "requestDataGridView";
            requestDataGridView.ReadOnly = true;
            requestDataGridView.Size = new Size(1091, 457);
            requestDataGridView.TabIndex = 2;
            // 
            // changeButton
            // 
            changeButton.Font = new Font("Segoe UI", 12F);
            changeButton.Location = new Point(12, 557);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(141, 32);
            changeButton.TabIndex = 3;
            changeButton.Text = "Редактировать";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // removeButton
            // 
            removeButton.Font = new Font("Segoe UI", 12F);
            removeButton.Location = new Point(159, 557);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(108, 32);
            removeButton.TabIndex = 4;
            removeButton.Text = "Удалить";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Segoe UI", 12F);
            searchButton.Location = new Point(410, 39);
            searchButton.Margin = new Padding(0);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(127, 29);
            searchButton.TabIndex = 5;
            searchButton.Text = "Поиск";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(98, 19);
            label1.TabIndex = 6;
            label1.Text = "Номер заявки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(221, 16);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 7;
            label2.Text = "Статус";
            // 
            // RequestListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 609);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(searchButton);
            Controls.Add(removeButton);
            Controls.Add(changeButton);
            Controls.Add(requestDataGridView);
            Controls.Add(statusField);
            Controls.Add(searchField);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RequestListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список заявок";
            Load += RequestListForm_Load;
            ((System.ComponentModel.ISupportInitialize)requestDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchField;
        private ComboBox statusField;
        private DataGridView requestDataGridView;
        private Button changeButton;
        private Button removeButton;
        private Button searchButton;
        private Label label1;
        private Label label2;
    }
}