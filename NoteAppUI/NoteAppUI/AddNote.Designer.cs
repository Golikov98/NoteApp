namespace NoteAppUI
{
    partial class AddNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNote));
            this.AddOKButton = new System.Windows.Forms.Button();
            this.AddCANCELButton = new System.Windows.Forms.Button();
            this.AddCreateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddNameTextBox = new System.Windows.Forms.TextBox();
            this.AddTextNoteTextBox = new System.Windows.Forms.TextBox();
            this.AddNameLabel = new System.Windows.Forms.Label();
            this.CreationTimeLabel = new System.Windows.Forms.Label();
            this.AddCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.NoteCategoryLabel = new System.Windows.Forms.Label();
            this.AddNoteTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddOKButton
            // 
            this.AddOKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddOKButton.BackColor = System.Drawing.SystemColors.Window;
            this.AddOKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOKButton.ForeColor = System.Drawing.SystemColors.Window;
            this.AddOKButton.Image = ((System.Drawing.Image)(resources.GetObject("AddOKButton.Image")));
            this.AddOKButton.Location = new System.Drawing.Point(12, 404);
            this.AddOKButton.Name = "AddOKButton";
            this.AddOKButton.Size = new System.Drawing.Size(35, 34);
            this.AddOKButton.TabIndex = 0;
            this.AddOKButton.UseVisualStyleBackColor = false;
            this.AddOKButton.Click += new System.EventHandler(this.AddOKButton_Click);
            // 
            // AddCANCELButton
            // 
            this.AddCANCELButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCANCELButton.BackColor = System.Drawing.SystemColors.Window;
            this.AddCANCELButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCANCELButton.ForeColor = System.Drawing.SystemColors.Window;
            this.AddCANCELButton.Image = ((System.Drawing.Image)(resources.GetObject("AddCANCELButton.Image")));
            this.AddCANCELButton.Location = new System.Drawing.Point(753, 404);
            this.AddCANCELButton.Name = "AddCANCELButton";
            this.AddCANCELButton.Size = new System.Drawing.Size(35, 34);
            this.AddCANCELButton.TabIndex = 1;
            this.AddCANCELButton.UseVisualStyleBackColor = false;
            this.AddCANCELButton.Click += new System.EventHandler(this.AddCANCELButton_Click);
            // 
            // AddCreateDateTimePicker
            // 
            this.AddCreateDateTimePicker.Enabled = false;
            this.AddCreateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCreateDateTimePicker.Location = new System.Drawing.Point(209, 65);
            this.AddCreateDateTimePicker.Name = "AddCreateDateTimePicker";
            this.AddCreateDateTimePicker.Size = new System.Drawing.Size(165, 22);
            this.AddCreateDateTimePicker.TabIndex = 2;
            this.AddCreateDateTimePicker.ValueChanged += new System.EventHandler(this.AddCreateDateTimePicker_ValueChanged);
            // 
            // AddNameTextBox
            // 
            this.AddNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNameTextBox.Location = new System.Drawing.Point(124, 12);
            this.AddNameTextBox.Multiline = true;
            this.AddNameTextBox.Name = "AddNameTextBox";
            this.AddNameTextBox.Size = new System.Drawing.Size(664, 32);
            this.AddNameTextBox.TabIndex = 4;
            this.AddNameTextBox.TextChanged += new System.EventHandler(this.AddNameTextBox_TextChanged);
            // 
            // AddTextNoteTextBox
            // 
            this.AddTextNoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTextNoteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTextNoteTextBox.Location = new System.Drawing.Point(11, 163);
            this.AddTextNoteTextBox.Multiline = true;
            this.AddTextNoteTextBox.Name = "AddTextNoteTextBox";
            this.AddTextNoteTextBox.Size = new System.Drawing.Size(777, 235);
            this.AddTextNoteTextBox.TabIndex = 5;
            this.AddTextNoteTextBox.TextChanged += new System.EventHandler(this.AddTextNoteTextBox_TextChanged);
            // 
            // AddNameLabel
            // 
            this.AddNameLabel.AutoSize = true;
            this.AddNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNameLabel.Location = new System.Drawing.Point(7, 16);
            this.AddNameLabel.Name = "AddNameLabel";
            this.AddNameLabel.Size = new System.Drawing.Size(111, 24);
            this.AddNameLabel.TabIndex = 6;
            this.AddNameLabel.Text = "Название:";
            // 
            // CreationTimeLabel
            // 
            this.CreationTimeLabel.AutoSize = true;
            this.CreationTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreationTimeLabel.Location = new System.Drawing.Point(8, 65);
            this.CreationTimeLabel.Name = "CreationTimeLabel";
            this.CreationTimeLabel.Size = new System.Drawing.Size(195, 20);
            this.CreationTimeLabel.TabIndex = 7;
            this.CreationTimeLabel.Text = "Дата создания заметки:";
            // 
            // AddCategoryComboBox
            // 
            this.AddCategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCategoryComboBox.FormattingEnabled = true;
            this.AddCategoryComboBox.Location = new System.Drawing.Point(623, 65);
            this.AddCategoryComboBox.Name = "AddCategoryComboBox";
            this.AddCategoryComboBox.Size = new System.Drawing.Size(165, 24);
            this.AddCategoryComboBox.TabIndex = 9;
            this.AddCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.AddCategoryComboBox_SelectedIndexChanged);
            // 
            // NoteCategoryLabel
            // 
            this.NoteCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteCategoryLabel.AutoSize = true;
            this.NoteCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteCategoryLabel.Location = new System.Drawing.Point(457, 65);
            this.NoteCategoryLabel.Name = "NoteCategoryLabel";
            this.NoteCategoryLabel.Size = new System.Drawing.Size(160, 20);
            this.NoteCategoryLabel.TabIndex = 10;
            this.NoteCategoryLabel.Text = "Категория заметки:";
            // 
            // AddNoteTextLabel
            // 
            this.AddNoteTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNoteTextLabel.AutoSize = true;
            this.AddNoteTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNoteTextLabel.Location = new System.Drawing.Point(301, 136);
            this.AddNoteTextLabel.Name = "AddNoteTextLabel";
            this.AddNoteTextLabel.Size = new System.Drawing.Size(204, 24);
            this.AddNoteTextLabel.TabIndex = 11;
            this.AddNoteTextLabel.Text = "Содержание заметки";
            // 
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddNoteTextLabel);
            this.Controls.Add(this.NoteCategoryLabel);
            this.Controls.Add(this.AddCategoryComboBox);
            this.Controls.Add(this.CreationTimeLabel);
            this.Controls.Add(this.AddNameLabel);
            this.Controls.Add(this.AddTextNoteTextBox);
            this.Controls.Add(this.AddNameTextBox);
            this.Controls.Add(this.AddCreateDateTimePicker);
            this.Controls.Add(this.AddCANCELButton);
            this.Controls.Add(this.AddOKButton);
            this.Name = "AddNote";
            this.Text = "AddNote";
            this.Load += new System.EventHandler(this.AddNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddOKButton;
        private System.Windows.Forms.Button AddCANCELButton;
        private System.Windows.Forms.DateTimePicker AddCreateDateTimePicker;
        private System.Windows.Forms.TextBox AddNameTextBox;
        private System.Windows.Forms.TextBox AddTextNoteTextBox;
        private System.Windows.Forms.Label AddNameLabel;
        private System.Windows.Forms.Label CreationTimeLabel;
        private System.Windows.Forms.ComboBox AddCategoryComboBox;
        private System.Windows.Forms.Label NoteCategoryLabel;
        private System.Windows.Forms.Label AddNoteTextLabel;
    }
}