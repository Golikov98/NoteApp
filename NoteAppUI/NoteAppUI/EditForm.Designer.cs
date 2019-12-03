namespace NoteAppUI
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.EditFormEditDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EditCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.EditNameLabel = new System.Windows.Forms.Label();
            this.EditTimeLabel = new System.Windows.Forms.Label();
            this.EditNoteCategoryLabel = new System.Windows.Forms.Label();
            this.EditFormNoteTextLabel = new System.Windows.Forms.Label();
            this.EditNameTextBox = new System.Windows.Forms.TextBox();
            this.EditNoteTextTextBox = new System.Windows.Forms.TextBox();
            this.EditFormOkButton = new System.Windows.Forms.Button();
            this.EditFormCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditFormEditDateDateTimePicker
            // 
            this.EditFormEditDateDateTimePicker.Enabled = false;
            this.EditFormEditDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.EditFormEditDateDateTimePicker.Location = new System.Drawing.Point(264, 65);
            this.EditFormEditDateDateTimePicker.Name = "EditFormEditDateDateTimePicker";
            this.EditFormEditDateDateTimePicker.Size = new System.Drawing.Size(165, 22);
            this.EditFormEditDateDateTimePicker.TabIndex = 0;
            this.EditFormEditDateDateTimePicker.ValueChanged += new System.EventHandler(this.EditFormEditDateDateTimePicker_ValueChanged);
            // 
            // EditCategoryComboBox
            // 
            this.EditCategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.EditCategoryComboBox.FormattingEnabled = true;
            this.EditCategoryComboBox.Location = new System.Drawing.Point(623, 65);
            this.EditCategoryComboBox.Name = "EditCategoryComboBox";
            this.EditCategoryComboBox.Size = new System.Drawing.Size(165, 24);
            this.EditCategoryComboBox.TabIndex = 1;
            this.EditCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.EditCategoryComboBox_SelectedIndexChanged);
            // 
            // EditNameLabel
            // 
            this.EditNameLabel.AutoSize = true;
            this.EditNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditNameLabel.Location = new System.Drawing.Point(7, 16);
            this.EditNameLabel.Name = "EditNameLabel";
            this.EditNameLabel.Size = new System.Drawing.Size(111, 24);
            this.EditNameLabel.TabIndex = 6;
            this.EditNameLabel.Text = "Название:";
            // 
            // EditTimeLabel
            // 
            this.EditTimeLabel.AutoSize = true;
            this.EditTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EditTimeLabel.Location = new System.Drawing.Point(8, 65);
            this.EditTimeLabel.Name = "EditTimeLabel";
            this.EditTimeLabel.Size = new System.Drawing.Size(250, 20);
            this.EditTimeLabel.TabIndex = 3;
            this.EditTimeLabel.Text = "Дата редактирования заметки:";
            // 
            // EditNoteCategoryLabel
            // 
            this.EditNoteCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditNoteCategoryLabel.AutoSize = true;
            this.EditNoteCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EditNoteCategoryLabel.Location = new System.Drawing.Point(457, 65);
            this.EditNoteCategoryLabel.Name = "EditNoteCategoryLabel";
            this.EditNoteCategoryLabel.Size = new System.Drawing.Size(160, 20);
            this.EditNoteCategoryLabel.TabIndex = 4;
            this.EditNoteCategoryLabel.Text = "Категория заметки:";
            // 
            // EditFormNoteTextLabel
            // 
            this.EditFormNoteTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditFormNoteTextLabel.AutoSize = true;
            this.EditFormNoteTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.EditFormNoteTextLabel.Location = new System.Drawing.Point(301, 136);
            this.EditFormNoteTextLabel.Name = "EditFormNoteTextLabel";
            this.EditFormNoteTextLabel.Size = new System.Drawing.Size(204, 24);
            this.EditFormNoteTextLabel.TabIndex = 5;
            this.EditFormNoteTextLabel.Text = "Содержание заметки";
            // 
            // EditNameTextBox
            // 
            this.EditNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.EditNameTextBox.Location = new System.Drawing.Point(124, 12);
            this.EditNameTextBox.Multiline = true;
            this.EditNameTextBox.Name = "EditNameTextBox";
            this.EditNameTextBox.Size = new System.Drawing.Size(664, 32);
            this.EditNameTextBox.TabIndex = 6;
            this.EditNameTextBox.TextChanged += new System.EventHandler(this.EditNameTextBox_TextChanged);
            // 
            // EditNoteTextTextBox
            // 
            this.EditNoteTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditNoteTextTextBox.Location = new System.Drawing.Point(11, 163);
            this.EditNoteTextTextBox.Multiline = true;
            this.EditNoteTextTextBox.Name = "EditNoteTextTextBox";
            this.EditNoteTextTextBox.Size = new System.Drawing.Size(777, 235);
            this.EditNoteTextTextBox.TabIndex = 7;
            this.EditNoteTextTextBox.TextChanged += new System.EventHandler(this.EditNoteTextTextBox_TextChanged);
            // 
            // EditFormOkButton
            // 
            this.EditFormOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditFormOkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditFormOkButton.ForeColor = System.Drawing.SystemColors.Window;
            this.EditFormOkButton.Image = ((System.Drawing.Image)(resources.GetObject("EditFormOkButton.Image")));
            this.EditFormOkButton.Location = new System.Drawing.Point(12, 404);
            this.EditFormOkButton.Name = "EditFormOkButton";
            this.EditFormOkButton.Size = new System.Drawing.Size(35, 34);
            this.EditFormOkButton.TabIndex = 8;
            this.EditFormOkButton.UseVisualStyleBackColor = false;
            this.EditFormOkButton.Click += new System.EventHandler(this.EditFormOkButton_Click);
            // 
            // EditFormCancelButton
            // 
            this.EditFormCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditFormCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditFormCancelButton.ForeColor = System.Drawing.SystemColors.Window;
            this.EditFormCancelButton.Image = ((System.Drawing.Image)(resources.GetObject("EditFormCancelButton.Image")));
            this.EditFormCancelButton.Location = new System.Drawing.Point(753, 404);
            this.EditFormCancelButton.Name = "EditFormCancelButton";
            this.EditFormCancelButton.Size = new System.Drawing.Size(35, 34);
            this.EditFormCancelButton.TabIndex = 9;
            this.EditFormCancelButton.UseVisualStyleBackColor = false;
            this.EditFormCancelButton.Click += new System.EventHandler(this.EditFormCancelButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditFormCancelButton);
            this.Controls.Add(this.EditFormOkButton);
            this.Controls.Add(this.EditNoteTextTextBox);
            this.Controls.Add(this.EditNameTextBox);
            this.Controls.Add(this.EditFormNoteTextLabel);
            this.Controls.Add(this.EditNoteCategoryLabel);
            this.Controls.Add(this.EditTimeLabel);
            this.Controls.Add(this.EditNameLabel);
            this.Controls.Add(this.EditCategoryComboBox);
            this.Controls.Add(this.EditFormEditDateDateTimePicker);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker EditFormEditDateDateTimePicker;
        private System.Windows.Forms.ComboBox EditCategoryComboBox;
        private System.Windows.Forms.Label EditNameLabel;
        private System.Windows.Forms.Label EditTimeLabel;
        private System.Windows.Forms.Label EditNoteCategoryLabel;
        private System.Windows.Forms.Label EditFormNoteTextLabel;
        private System.Windows.Forms.TextBox EditNameTextBox;
        private System.Windows.Forms.TextBox EditNoteTextTextBox;
        private System.Windows.Forms.Button EditFormOkButton;
        private System.Windows.Forms.Button EditFormCancelButton;
    }
}