namespace EldenSaves
{
    partial class Form1
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
            this.setBackupFolderButton = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.TextBox();
            this.saveFolderButton = new System.Windows.Forms.Button();
            this.backupLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFolderLabel = new System.Windows.Forms.Label();
            this.backupFolderLabel = new System.Windows.Forms.Label();
            this.backupFolderText = new System.Windows.Forms.Label();
            this.saveFolderText = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setBackupFolderButton
            // 
            this.setBackupFolderButton.AccessibleName = "";
            this.setBackupFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.setBackupFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setBackupFolderButton.Location = new System.Drawing.Point(608, 190);
            this.setBackupFolderButton.Name = "setBackupFolderButton";
            this.setBackupFolderButton.Size = new System.Drawing.Size(164, 33);
            this.setBackupFolderButton.TabIndex = 0;
            this.setBackupFolderButton.Text = "Set Backup Folder";
            this.setBackupFolderButton.UseVisualStyleBackColor = true;
            this.setBackupFolderButton.Click += new System.EventHandler(this.setBackupFolder);
            // 
            // titleText
            // 
            this.titleText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.titleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleText.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(0, 0);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(784, 37);
            this.titleText.TabIndex = 1;
            this.titleText.Text = "Elden Saves";
            this.titleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveFolderButton
            // 
            this.saveFolderButton.AccessibleName = "";
            this.saveFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFolderButton.Location = new System.Drawing.Point(608, 316);
            this.saveFolderButton.Name = "saveFolderButton";
            this.saveFolderButton.Size = new System.Drawing.Size(164, 33);
            this.saveFolderButton.TabIndex = 4;
            this.saveFolderButton.Text = "Select Save Folder";
            this.saveFolderButton.UseVisualStyleBackColor = true;
            this.saveFolderButton.Click += new System.EventHandler(this.saveFolderButton_Click);
            // 
            // backupLabel
            // 
            this.backupLabel.Location = new System.Drawing.Point(12, 167);
            this.backupLabel.Name = "backupLabel";
            this.backupLabel.Size = new System.Drawing.Size(268, 23);
            this.backupLabel.TabIndex = 7;
            this.backupLabel.Text = "This is the folder where the save copies will be stored";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "This is the existing save folder where the game stores its saves";
            // 
            // saveFolderLabel
            // 
            this.saveFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFolderLabel.Location = new System.Drawing.Point(12, 316);
            this.saveFolderLabel.Name = "saveFolderLabel";
            this.saveFolderLabel.Size = new System.Drawing.Size(109, 33);
            this.saveFolderLabel.TabIndex = 9;
            this.saveFolderLabel.Text = "Save folder:";
            this.saveFolderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backupFolderLabel
            // 
            this.backupFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupFolderLabel.Location = new System.Drawing.Point(12, 190);
            this.backupFolderLabel.Name = "backupFolderLabel";
            this.backupFolderLabel.Size = new System.Drawing.Size(127, 33);
            this.backupFolderLabel.TabIndex = 10;
            this.backupFolderLabel.Text = "Backup folder:";
            this.backupFolderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backupFolderText
            // 
            this.backupFolderText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backupFolderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupFolderText.Location = new System.Drawing.Point(145, 190);
            this.backupFolderText.Name = "backupFolderText";
            this.backupFolderText.Size = new System.Drawing.Size(457, 33);
            this.backupFolderText.TabIndex = 11;
            this.backupFolderText.Text = "Not Selected";
            this.backupFolderText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveFolderText
            // 
            this.saveFolderText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saveFolderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFolderText.Location = new System.Drawing.Point(127, 316);
            this.saveFolderText.Name = "saveFolderText";
            this.saveFolderText.Size = new System.Drawing.Size(475, 33);
            this.saveFolderText.TabIndex = 12;
            this.saveFolderText.Text = "Not Selected";
            this.saveFolderText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.continueButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.Location = new System.Drawing.Point(0, 512);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(784, 49);
            this.continueButton.TabIndex = 13;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.saveFolderText);
            this.Controls.Add(this.backupFolderText);
            this.Controls.Add(this.backupFolderLabel);
            this.Controls.Add(this.saveFolderLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backupLabel);
            this.Controls.Add(this.saveFolderButton);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.setBackupFolderButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button continueButton;

        private System.Windows.Forms.Label saveFolderText;

        private System.Windows.Forms.Label saveFolderLabel;

        private System.Windows.Forms.Label backupLabel;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Button saveFolderButton;

        private System.Windows.Forms.Label backupFolderText;

        private System.Windows.Forms.Label backupFolderLabel;

        private System.Windows.Forms.Button setBackupFolderButton;

        #endregion
    }
}