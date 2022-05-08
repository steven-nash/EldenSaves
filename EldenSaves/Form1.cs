using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EldenSaves
{
    // Form for the user to set their backup folder and game save folder
    public partial class Form1 : Form
    {
        private FolderBrowserDialog backupFolderDialog;
        private FolderBrowserDialog saveFolderDialog;
        private DialogResult backupFolder;
        private DialogResult saveFolder;
        private string defaultSaveFolder;
        private string backupPath;
        private string savePath;
        
        public Form1()
        {
            InitializeComponent();
            backupFolderDialog = new FolderBrowserDialog();
            saveFolderDialog = new FolderBrowserDialog();
            
            // Try to set a default game save folder
            defaultSaveFolder = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\EldenRing";

            // Set text fields if no folders are selected
            if (backupPath == null)
                backupFolderText.Text = "Not Selected";
            else
                backupFolderText.Text = backupPath;

            if (savePath == null)
                saveFolderText.Text = "Not Selected";
            else
                saveFolderText.Text = savePath;

        }

        // Show the dialog for the user to select the backup folder where saves will be kept
        private void setBackupFolder(object sender, EventArgs e)
        {
            // Get backup folder from dialog
            backupFolder = backupFolderDialog.ShowDialog();
            
            // Abort if no result
            if (backupFolder != DialogResult.OK) return;
                
            // Set the backup folder path to the selected folder
            backupPath = Path.GetFullPath(backupFolderDialog.SelectedPath);

            // Update the text box
            backupFolderText.Text = backupPath;
        }

        // Show the dialog for the user to select the folder where the game's save files are located
        private void saveFolderButton_Click(object sender, EventArgs e)
        {
            // Set initial directory if it exists
            if (defaultSaveFolder != null)
                saveFolderDialog.SelectedPath = defaultSaveFolder;
            
            // Get save folder from dialog
            saveFolder = saveFolderDialog.ShowDialog();
            
            // Abort if no result
            if(saveFolder != DialogResult.OK) return;
            
            // Set the save folder
            savePath = Path.GetFullPath(saveFolderDialog.SelectedPath);

            // Update the text box
            saveFolderText.Text = savePath;
        }

        // Save selected folders and continue
        private void continueButton_Click(object sender, EventArgs e)
        {
            // Don't continue if either folder is not selected
            if(savePath == null || backupPath == null) return;
            
            // Close current form
            Hide();
            // Run main form
            Application.Run(new MainForm(backupPath, savePath));
        }
    }
}