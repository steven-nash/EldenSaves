using System;
using System.Windows.Forms;
using System.IO;
using EldenSaves.Properties;
using System.Configuration;

namespace EldenSaves
{
    // Form for the user to set their backup folder and game save folder
    public partial class Form1 : Form
    {
        private readonly FolderBrowserDialog _backupFolderDialog;
        private readonly FolderBrowserDialog _saveFolderDialog;
        private readonly string _defaultSaveFolder;
        private string _backupPath;
        private string _savePath;
        
        public Form1()
        {
            InitializeComponent();

            //Windows.Storage.ApplicationDataContainer localSettings =
                //Windows.Storage.ApplicationData.Current.LocalSettings;
            
            _backupFolderDialog = new FolderBrowserDialog();
            _saveFolderDialog = new FolderBrowserDialog();
            continueButton.Enabled = false;

            // Try to set a default game save folder
            _defaultSaveFolder = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\EldenRing";
            // Get all subdirectories
            var subdirs = Directory.GetDirectories(_defaultSaveFolder, "*", SearchOption.AllDirectories);
            if (subdirs.Length == 1) // Check if the default folder only has one subdirectory (which would be the game's primary save folder)
                _defaultSaveFolder = subdirs[0]; // Set it to the default directory
            
            // Verify that the folder exists and save
            if(Directory.Exists(_defaultSaveFolder))
                _savePath = _defaultSaveFolder;

            // Set text fields
            backupFolderText.Text = _backupPath ?? "Not Selected";
            saveFolderText.Text = _savePath ?? "Not Selected";

        }

        // Show the dialog for the user to select the backup folder where saves will be kept
        private void SetBackupFolder(object sender, EventArgs e)
        {
            var documentsPath = @"C:\Users\" + Environment.UserName + @"\Documents";
            
            // Set Documents folder to default if located 
            if (Directory.Exists(documentsPath))
                _backupFolderDialog.SelectedPath = documentsPath;
            
            // Get backup folder from dialog
            var backupFolder = _backupFolderDialog.ShowDialog();
            
            // Abort if no result
            if (backupFolder != DialogResult.OK) return;
                
            // Set the backup folder path to the selected folder
            _backupPath = Path.GetFullPath(_backupFolderDialog.SelectedPath);

            // Update the text box
            backupFolderText.Text = _backupPath;
            
            // If both folders are set, enable the continue button
            if (_savePath != null || _backupPath != null)
                continueButton.Enabled = true;

        }

        // Show the dialog for the user to select the folder where the game's save files are located
        private void saveFolderButton_Click(object sender, EventArgs e)
        {
            // Set initial directory if it exists
            if (Directory.Exists(_defaultSaveFolder))
                _saveFolderDialog.SelectedPath = _defaultSaveFolder;
            
            // Get save folder from dialog
            var saveFolder = _saveFolderDialog.ShowDialog();
            
            // Abort if no result
            if(saveFolder != DialogResult.OK) return;
            
            // Set the save folder
            _savePath = Path.GetFullPath(_saveFolderDialog.SelectedPath);

            // Update the text box
            saveFolderText.Text = _savePath;
            
            // If both folders are set, enable the continue button
            if (_savePath != null || _backupPath != null)
                continueButton.Enabled = true;
        }

        // Save selected folders and continue
        private void continueButton_Click(object sender, EventArgs e)
        {
            // Don't continue if either folder is not selected
            if(_savePath == null || _backupPath == null) return;
            
            // Save paths as default
            //Settings.Default.DefaultSave = _savePath;
            //Settings.Default.Save();
            
            // Close current form
            Hide();
            // Run main form
            var mainForm = new MainForm(_backupPath, _savePath);
            mainForm.Show();
        }
    }
}