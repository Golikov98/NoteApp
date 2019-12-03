namespace NoteAppUI
{
    partial class AboutForm
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
            this.AboutLabelTitle = new System.Windows.Forms.Label();
            this.AboutLabelVersion = new System.Windows.Forms.Label();
            this.AboutLabelAuthor = new System.Windows.Forms.Label();
            this.AboutLabelEmail = new System.Windows.Forms.Label();
            this.AboutLabelGit = new System.Windows.Forms.Label();
            this.AboutLabelYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AboutLabelTitle
            // 
            this.AboutLabelTitle.AutoSize = true;
            this.AboutLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutLabelTitle.Location = new System.Drawing.Point(12, 9);
            this.AboutLabelTitle.Name = "AboutLabelTitle";
            this.AboutLabelTitle.Size = new System.Drawing.Size(92, 24);
            this.AboutLabelTitle.TabIndex = 0;
            this.AboutLabelTitle.Text = "NoteApp";
            // 
            // AboutLabelVersion
            // 
            this.AboutLabelVersion.AutoSize = true;
            this.AboutLabelVersion.Location = new System.Drawing.Point(13, 33);
            this.AboutLabelVersion.Name = "AboutLabelVersion";
            this.AboutLabelVersion.Size = new System.Drawing.Size(43, 13);
            this.AboutLabelVersion.TabIndex = 1;
            this.AboutLabelVersion.Text = "v. 1.0.0";
            // 
            // AboutLabelAuthor
            // 
            this.AboutLabelAuthor.AutoSize = true;
            this.AboutLabelAuthor.Location = new System.Drawing.Point(13, 84);
            this.AboutLabelAuthor.Name = "AboutLabelAuthor";
            this.AboutLabelAuthor.Size = new System.Drawing.Size(106, 13);
            this.AboutLabelAuthor.TabIndex = 2;
            this.AboutLabelAuthor.Text = "Author: Golikov Yuriy";
            // 
            // AboutLabelEmail
            // 
            this.AboutLabelEmail.AutoSize = true;
            this.AboutLabelEmail.Location = new System.Drawing.Point(13, 106);
            this.AboutLabelEmail.Name = "AboutLabelEmail";
            this.AboutLabelEmail.Size = new System.Drawing.Size(145, 13);
            this.AboutLabelEmail.TabIndex = 3;
            this.AboutLabelEmail.Text = "E-mail: you_rock98@inbox.ru";
            // 
            // AboutLabelGit
            // 
            this.AboutLabelGit.AutoSize = true;
            this.AboutLabelGit.Location = new System.Drawing.Point(13, 130);
            this.AboutLabelGit.Name = "AboutLabelGit";
            this.AboutLabelGit.Size = new System.Drawing.Size(198, 13);
            this.AboutLabelGit.TabIndex = 4;
            this.AboutLabelGit.Text = "GitHub: github.com/Golikov98/NoteApp";
            this.AboutLabelGit.Click += new System.EventHandler(this.AboutLabelGit_Click);
            // 
            // AboutLabelYear
            // 
            this.AboutLabelYear.AutoSize = true;
            this.AboutLabelYear.Location = new System.Drawing.Point(12, 264);
            this.AboutLabelYear.Name = "AboutLabelYear";
            this.AboutLabelYear.Size = new System.Drawing.Size(99, 13);
            this.AboutLabelYear.TabIndex = 5;
            this.AboutLabelYear.Text = "2019  Golikov Yuriy";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 286);
            this.Controls.Add(this.AboutLabelYear);
            this.Controls.Add(this.AboutLabelGit);
            this.Controls.Add(this.AboutLabelEmail);
            this.Controls.Add(this.AboutLabelAuthor);
            this.Controls.Add(this.AboutLabelVersion);
            this.Controls.Add(this.AboutLabelTitle);
            this.Name = "AboutForm";
            this.Text = "Справка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutLabelTitle;
        private System.Windows.Forms.Label AboutLabelVersion;
        private System.Windows.Forms.Label AboutLabelAuthor;
        private System.Windows.Forms.Label AboutLabelEmail;
        private System.Windows.Forms.Label AboutLabelGit;
        private System.Windows.Forms.Label AboutLabelYear;
    }
}