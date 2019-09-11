namespace NoteAppUI
{
    partial class HeadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeadForm));
            this.TitleListBox = new System.Windows.Forms.ListBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NoteTextTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CreateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HeadNoteCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.HeadCreationTimeLabel = new System.Windows.Forms.Label();
            this.HeadModifiedTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleListBox
            // 
            this.TitleListBox.BackColor = System.Drawing.Color.White;
            this.TitleListBox.FormattingEnabled = true;
            this.TitleListBox.Location = new System.Drawing.Point(12, 70);
            this.TitleListBox.Name = "TitleListBox";
            this.TitleListBox.Size = new System.Drawing.Size(176, 368);
            this.TitleListBox.TabIndex = 0;
            this.TitleListBox.SelectedIndexChanged += new System.EventHandler(this.TitleListBox_SelectedIndexChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.White;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(337, 31);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(451, 40);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NoteTextTextBox
            // 
            this.NoteTextTextBox.BackColor = System.Drawing.Color.White;
            this.NoteTextTextBox.Location = new System.Drawing.Point(194, 103);
            this.NoteTextTextBox.Multiline = true;
            this.NoteTextTextBox.Name = "NoteTextTextBox";
            this.NoteTextTextBox.Size = new System.Drawing.Size(594, 335);
            this.NoteTextTextBox.TabIndex = 2;
            this.NoteTextTextBox.TextChanged += new System.EventHandler(this.NoteTextTextBox_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.SystemColors.Window;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(194, 31);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(35, 40);
            this.AddButton.TabIndex = 3;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.Window;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.ForeColor = System.Drawing.SystemColors.Window;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.Location = new System.Drawing.Point(235, 31);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(36, 40);
            this.EditButton.TabIndex = 4;
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.Window;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(277, 31);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(36, 40);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // CreateDateTimePicker
            // 
            this.CreateDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.CreateDateTimePicker.Enabled = false;
            this.CreateDateTimePicker.Location = new System.Drawing.Point(337, 77);
            this.CreateDateTimePicker.Name = "CreateDateTimePicker";
            this.CreateDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.CreateDateTimePicker.TabIndex = 6;
            this.CreateDateTimePicker.ValueChanged += new System.EventHandler(this.CreateDateTimePicker_ValueChanged);
            // 
            // ModifiedDateTimePicker
            // 
            this.ModifiedDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifiedDateTimePicker.Enabled = false;
            this.ModifiedDateTimePicker.Location = new System.Drawing.Point(651, 77);
            this.ModifiedDateTimePicker.Name = "ModifiedDateTimePicker";
            this.ModifiedDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.ModifiedDateTimePicker.TabIndex = 7;
            this.ModifiedDateTimePicker.ValueChanged += new System.EventHandler(this.ModifiedDateTimePicker_ValueChanged);
            // 
            // HeadNoteCategoryComboBox
            // 
            this.HeadNoteCategoryComboBox.BackColor = System.Drawing.Color.White;
            this.HeadNoteCategoryComboBox.FormattingEnabled = true;
            this.HeadNoteCategoryComboBox.Location = new System.Drawing.Point(12, 43);
            this.HeadNoteCategoryComboBox.Name = "HeadNoteCategoryComboBox";
            this.HeadNoteCategoryComboBox.Size = new System.Drawing.Size(176, 21);
            this.HeadNoteCategoryComboBox.TabIndex = 8;
            this.HeadNoteCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.HeadNoteCategoryComboBox_SelectedIndexChanged);
            // 
            // HeadCreationTimeLabel
            // 
            this.HeadCreationTimeLabel.AutoSize = true;
            this.HeadCreationTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeadCreationTimeLabel.Location = new System.Drawing.Point(223, 80);
            this.HeadCreationTimeLabel.Name = "HeadCreationTimeLabel";
            this.HeadCreationTimeLabel.Size = new System.Drawing.Size(108, 16);
            this.HeadCreationTimeLabel.TabIndex = 9;
            this.HeadCreationTimeLabel.Text = "Дата создания:";
            // 
            // HeadModifiedTimeLabel
            // 
            this.HeadModifiedTimeLabel.AutoSize = true;
            this.HeadModifiedTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeadModifiedTimeLabel.Location = new System.Drawing.Point(527, 80);
            this.HeadModifiedTimeLabel.Name = "HeadModifiedTimeLabel";
            this.HeadModifiedTimeLabel.Size = new System.Drawing.Size(118, 16);
            this.HeadModifiedTimeLabel.TabIndex = 10;
            this.HeadModifiedTimeLabel.Text = "Дата изменения:";
            // 
            // HeadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HeadModifiedTimeLabel);
            this.Controls.Add(this.HeadCreationTimeLabel);
            this.Controls.Add(this.HeadNoteCategoryComboBox);
            this.Controls.Add(this.ModifiedDateTimePicker);
            this.Controls.Add(this.CreateDateTimePicker);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NoteTextTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.TitleListBox);
            this.Name = "HeadForm";
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.NoteApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TitleListBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox NoteTextTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DateTimePicker CreateDateTimePicker;
        private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker;
        private System.Windows.Forms.ComboBox HeadNoteCategoryComboBox;
        private System.Windows.Forms.Label HeadCreationTimeLabel;
        private System.Windows.Forms.Label HeadModifiedTimeLabel;
    }
}

