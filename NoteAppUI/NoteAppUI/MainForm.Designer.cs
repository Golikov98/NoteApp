namespace NoteAppUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьНовуюЗаметкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьТекущуюЗаметкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТекущуюЗаметкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleListBox
            // 
            this.TitleListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TitleListBox.BackColor = System.Drawing.Color.White;
            this.TitleListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleListBox.FormattingEnabled = true;
            this.TitleListBox.Location = new System.Drawing.Point(12, 77);
            this.TitleListBox.Name = "TitleListBox";
            this.TitleListBox.Size = new System.Drawing.Size(176, 368);
            this.TitleListBox.TabIndex = 0;
            this.TitleListBox.SelectedIndexChanged += new System.EventHandler(this.TitleListBox_SelectedIndexChanged);
            this.TitleListBox.SelectedValueChanged += new System.EventHandler(this.TitleListBox_SelectedIndexChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.BackColor = System.Drawing.Color.White;
            this.NameTextBox.Enabled = false;
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
            this.NoteTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextTextBox.BackColor = System.Drawing.Color.White;
            this.NoteTextTextBox.Enabled = false;
            this.NoteTextTextBox.Location = new System.Drawing.Point(194, 137);
            this.NoteTextTextBox.Multiline = true;
            this.NoteTextTextBox.Name = "NoteTextTextBox";
            this.NoteTextTextBox.Size = new System.Drawing.Size(594, 308);
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
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
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
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            this.HeadNoteCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HeadNoteCategoryComboBox.FormattingEnabled = true;
            this.HeadNoteCategoryComboBox.Location = new System.Drawing.Point(12, 43);
            this.HeadNoteCategoryComboBox.Name = "HeadNoteCategoryComboBox";
            this.HeadNoteCategoryComboBox.Size = new System.Drawing.Size(176, 21);
            this.HeadNoteCategoryComboBox.TabIndex = 8;
            this.HeadNoteCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.HeadNoteCategoryComboBox_SelectedIndexChanged);
            // 
            // HeadCreationTimeLabel
            // 
            this.HeadCreationTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.HeadModifiedTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeadModifiedTimeLabel.AutoSize = true;
            this.HeadModifiedTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeadModifiedTimeLabel.Location = new System.Drawing.Point(527, 80);
            this.HeadModifiedTimeLabel.Name = "HeadModifiedTimeLabel";
            this.HeadModifiedTimeLabel.Size = new System.Drawing.Size(118, 16);
            this.HeadModifiedTimeLabel.TabIndex = 10;
            this.HeadModifiedTimeLabel.Text = "Дата изменения:";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.сохранитьToolStripMenuItem.Text = "Выйти";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовуюЗаметкуToolStripMenuItem,
            this.редактироватьТекущуюЗаметкуToolStripMenuItem,
            this.удалитьТекущуюЗаметкуToolStripMenuItem});
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // создатьНовуюЗаметкуToolStripMenuItem
            // 
            this.создатьНовуюЗаметкуToolStripMenuItem.Name = "создатьНовуюЗаметкуToolStripMenuItem";
            this.создатьНовуюЗаметкуToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.создатьНовуюЗаметкуToolStripMenuItem.Text = "Создать новую заметку";
            this.создатьНовуюЗаметкуToolStripMenuItem.Click += new System.EventHandler(this.createNewNoteToolStripMenuItem_Click);
            // 
            // редактироватьТекущуюЗаметкуToolStripMenuItem
            // 
            this.редактироватьТекущуюЗаметкуToolStripMenuItem.Name = "редактироватьТекущуюЗаметкуToolStripMenuItem";
            this.редактироватьТекущуюЗаметкуToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.редактироватьТекущуюЗаметкуToolStripMenuItem.Text = "Редактировать текущую заметку";
            this.редактироватьТекущуюЗаметкуToolStripMenuItem.Click += new System.EventHandler(this.editCurrentNoteToolStripMenuItem_Click);
            // 
            // удалитьТекущуюЗаметкуToolStripMenuItem
            // 
            this.удалитьТекущуюЗаметкуToolStripMenuItem.Name = "удалитьТекущуюЗаметкуToolStripMenuItem";
            this.удалитьТекущуюЗаметкуToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.удалитьТекущуюЗаметкуToolStripMenuItem.Text = "Удалить текущую заметку";
            this.удалитьТекущуюЗаметкуToolStripMenuItem.Click += new System.EventHandler(this.deleteCurrentNoteToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеF1ToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеF1ToolStripMenuItem
            // 
            this.оПрограммеF1ToolStripMenuItem.Name = "оПрограммеF1ToolStripMenuItem";
            this.оПрограммеF1ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.оПрограммеF1ToolStripMenuItem.Text = "О программе- F1";
            this.оПрограммеF1ToolStripMenuItem.Click += new System.EventHandler(this.aboutF1ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryTextBox.BackColor = System.Drawing.Color.White;
            this.CategoryTextBox.Enabled = false;
            this.CategoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryTextBox.Location = new System.Drawing.Point(194, 103);
            this.CategoryTextBox.Multiline = true;
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(594, 28);
            this.CategoryTextBox.TabIndex = 12;
            this.CategoryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CategoryTextBox);
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
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.NoteApp_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HeadForm_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьНовуюЗаметкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьТекущуюЗаметкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьТекущуюЗаметкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеF1ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox CategoryTextBox;
    }
}

