namespace crm_demo2
{
    partial class RequestForm
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
            numberField = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            modelField = new TextBox();
            label5 = new Label();
            descriptionField = new TextBox();
            label6 = new Label();
            label7 = new Label();
            phoneField = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            typeField = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            clientField = new ComboBox();
            SuspendLayout();
            // 
            // numberField
            // 
            numberField.Font = new Font("Segoe UI", 12F);
            numberField.Location = new Point(214, 21);
            numberField.Name = "numberField";
            numberField.ReadOnly = true;
            numberField.Size = new Size(476, 29);
            numberField.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 1;
            label1.Text = "Номер заявки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 3;
            label2.Text = "Дата добавления";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 94);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 5;
            label3.Text = "Вид техники";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 129);
            label4.Name = "label4";
            label4.Size = new Size(127, 21);
            label4.TabIndex = 7;
            label4.Text = "Модель техники";
            // 
            // modelField
            // 
            modelField.Font = new Font("Segoe UI", 12F);
            modelField.Location = new Point(214, 126);
            modelField.Name = "modelField";
            modelField.Size = new Size(476, 29);
            modelField.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 234);
            label5.Name = "label5";
            label5.Size = new Size(159, 21);
            label5.TabIndex = 9;
            label5.Text = "Описание проблемы";
            // 
            // descriptionField
            // 
            descriptionField.Font = new Font("Segoe UI", 12F);
            descriptionField.Location = new Point(214, 231);
            descriptionField.Multiline = true;
            descriptionField.Name = "descriptionField";
            descriptionField.Size = new Size(476, 149);
            descriptionField.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 164);
            label6.Name = "label6";
            label6.Size = new Size(107, 21);
            label6.TabIndex = 11;
            label6.Text = "ФИО клиента";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(12, 199);
            label7.Name = "label7";
            label7.Size = new Size(130, 21);
            label7.TabIndex = 13;
            label7.Text = "Номер телефона";
            // 
            // phoneField
            // 
            phoneField.Font = new Font("Segoe UI", 12F);
            phoneField.Location = new Point(214, 196);
            phoneField.Name = "phoneField";
            phoneField.Size = new Size(476, 29);
            phoneField.TabIndex = 5;
            // 
            // saveButton
            // 
            saveButton.FlatStyle = FlatStyle.System;
            saveButton.Font = new Font("Segoe UI", 12F);
            saveButton.Location = new Point(245, 412);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(91, 29);
            saveButton.TabIndex = 14;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.FlatStyle = FlatStyle.System;
            cancelButton.Font = new Font("Segoe UI", 12F);
            cancelButton.Location = new Point(342, 412);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(91, 29);
            cancelButton.TabIndex = 15;
            cancelButton.Text = "Отменить";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // typeField
            // 
            typeField.DropDownStyle = ComboBoxStyle.DropDownList;
            typeField.Font = new Font("Segoe UI", 12F);
            typeField.FormattingEnabled = true;
            typeField.Location = new Point(214, 91);
            typeField.Name = "typeField";
            typeField.Size = new Size(476, 29);
            typeField.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 12F);
            dateTimePicker1.Location = new Point(214, 59);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(476, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // clientField
            // 
            clientField.DropDownStyle = ComboBoxStyle.DropDownList;
            clientField.Font = new Font("Segoe UI", 12F);
            clientField.FormattingEnabled = true;
            clientField.Location = new Point(214, 161);
            clientField.Name = "clientField";
            clientField.Size = new Size(476, 29);
            clientField.TabIndex = 4;
            // 
            // RequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 453);
            Controls.Add(clientField);
            Controls.Add(dateTimePicker1);
            Controls.Add(typeField);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(label7);
            Controls.Add(phoneField);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(descriptionField);
            Controls.Add(label4);
            Controls.Add(modelField);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numberField);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RequestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RequestForm";
            Load += RequestForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numberField;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox modelField;
        private Label label5;
        private TextBox descriptionField;
        private Label label6;
        private Label label7;
        private TextBox phoneField;
        private Button saveButton;
        private Button cancelButton;
        private ComboBox typeField;
        private DateTimePicker dateTimePicker1;
        private ComboBox clientField;
    }
}