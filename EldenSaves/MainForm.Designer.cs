using System.ComponentModel;

namespace EldenSaves
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.backupButton = new System.Windows.Forms.Button();
            this.savePathLabel = new System.Windows.Forms.Label();
            this.newBackupLabel = new System.Windows.Forms.Label();
            this.changeFoldersButton = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.TextBox();
            this.viewBackupsButton = new System.Windows.Forms.Button();
            this.savesList = new System.Windows.Forms.ListBox();
            this.restoreButton = new System.Windows.Forms.Button();
            this.restoreLabel = new System.Windows.Forms.Label();
            this.listTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backupButton
            // 
            this.backupButton.BackColor = System.Drawing.SystemColors.Window;
            this.backupButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.backupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupButton.Location = new System.Drawing.Point(12, 252);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(151, 67);
            this.backupButton.TabIndex = 0;
            this.backupButton.Text = "Backup\r\nGame Save";
            this.backupButton.UseVisualStyleBackColor = false;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // savePathLabel
            // 
            this.savePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePathLabel.Location = new System.Drawing.Point(12, 47);
            this.savePathLabel.Name = "savePathLabel";
            this.savePathLabel.Size = new System.Drawing.Size(776, 23);
            this.savePathLabel.TabIndex = 1;
            this.savePathLabel.Text = "No Game Saves";
            // 
            // newBackupLabel
            // 
            this.newBackupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBackupLabel.Location = new System.Drawing.Point(12, 372);
            this.newBackupLabel.Name = "newBackupLabel";
            this.newBackupLabel.Size = new System.Drawing.Size(776, 23);
            this.newBackupLabel.TabIndex = 2;
            this.newBackupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeFoldersButton
            // 
            this.changeFoldersButton.BackColor = System.Drawing.SystemColors.Window;
            this.changeFoldersButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changeFoldersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeFoldersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeFoldersButton.Location = new System.Drawing.Point(12, 73);
            this.changeFoldersButton.Name = "changeFoldersButton";
            this.changeFoldersButton.Size = new System.Drawing.Size(151, 36);
            this.changeFoldersButton.TabIndex = 3;
            this.changeFoldersButton.Text = "Change Folders";
            this.changeFoldersButton.UseVisualStyleBackColor = false;
            this.changeFoldersButton.Click += new System.EventHandler(this.changeFolderButton_Click);
            // 
            // titleText
            // 
            this.titleText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.titleText.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(0, 0);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(800, 44);
            this.titleText.TabIndex = 4;
            this.titleText.Text = "Elden Saves";
            this.titleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // viewBackupsButton
            // 
            this.viewBackupsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBackupsButton.Location = new System.Drawing.Point(12, 323);
            this.viewBackupsButton.Name = "viewBackupsButton";
            this.viewBackupsButton.Size = new System.Drawing.Size(151, 36);
            this.viewBackupsButton.TabIndex = 5;
            this.viewBackupsButton.Text = "View Backups";
            this.viewBackupsButton.UseVisualStyleBackColor = true;
            this.viewBackupsButton.Click += new System.EventHandler(this.viewBackupsButton_Click);
            // 
            // savesList
            // 
            this.savesList.FormattingEnabled = true;
            this.savesList.Location = new System.Drawing.Point(351, 107);
            this.savesList.Name = "savesList";
            this.savesList.Size = new System.Drawing.Size(437, 212);
            this.savesList.TabIndex = 6;
            // 
            // restoreButton
            // 
            this.restoreButton.Location = new System.Drawing.Point(351, 323);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(437, 36);
            this.restoreButton.TabIndex = 7;
            this.restoreButton.Text = "Restore";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // restoreLabel
            // 
            this.restoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreLabel.Location = new System.Drawing.Point(12, 414);
            this.restoreLabel.Name = "restoreLabel";
            this.restoreLabel.Size = new System.Drawing.Size(776, 23);
            this.restoreLabel.TabIndex = 8;
            this.restoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listTitle
            // 
            this.listTitle.BackColor = System.Drawing.SystemColors.Control;
            this.listTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTitle.Location = new System.Drawing.Point(351, 86);
            this.listTitle.Name = "listTitle";
            this.listTitle.Size = new System.Drawing.Size(437, 23);
            this.listTitle.TabIndex = 9;
            this.listTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listTitle);
            this.Controls.Add(this.restoreLabel);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.savesList);
            this.Controls.Add(this.viewBackupsButton);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.changeFoldersButton);
            this.Controls.Add(this.newBackupLabel);
            this.Controls.Add(this.savePathLabel);
            this.Controls.Add(this.backupButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label listTitle;

        private System.Windows.Forms.Label restoreLabel;

        private System.Windows.Forms.Button restoreButton;

        private System.Windows.Forms.ListBox savesList;

        private System.Windows.Forms.Button viewBackupsButton;

        private System.Windows.Forms.TextBox titleText;

        private System.Windows.Forms.Button changeFoldersButton;

        private System.Windows.Forms.Label newBackupLabel;

        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.Label savePathLabel;

        #endregion
    }
}