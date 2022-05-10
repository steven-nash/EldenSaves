using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace EldenSaves
{
    public partial class MainForm : Form
    {
        // Steven Nash 2022
        // Form where the main functionality occurs
        // The user can create backups and select them to restore as the game's save file
        
        private readonly string _backupPath;
        private readonly string _savePath;
        private string[] _backups;
        
        public MainForm(string backupPath, string savePath)
        {
            InitializeComponent();
            
            // Redirect to folder selection if either folder is null
            if (!Directory.Exists(backupPath) || !Directory.Exists(savePath))
                ChangeFolders();

            // Set fields
            _backupPath = backupPath;
            _savePath = savePath;
            
            // Set label text for game save folder
            savePathLabel.Text = "From: " + savePath;

            // Set label for the listbox title
            listTitle.Text = "Saving in: " + _backupPath;

            // Add backup folders to listbox
            
            GetBackups();
            savesList.DataSource = _backups;
        }

        // Backup current game saves
        private void Backup()
        {
            // New subfolder for backup
            var destination = _backupPath + @"\" + DateTime.Now.ToString("yy-MM-dd HH-mm-ss") + @"\";
            Console.WriteLine(destination);
            Directory.CreateDirectory(destination);
            
            // Check if new directory was created
            if (!Directory.Exists(destination))
            {
                DisplayError(Properties.Resources.DirectoryError);
                return;
            }

                // Get save files from the game save directory
            var saveFiles = Directory.EnumerateFiles(_savePath, "*.*", SearchOption.TopDirectoryOnly).Where(s => s.EndsWith(".sl2") || s.EndsWith(".sl2.bak") || s.EndsWith(".vdf")).ToArray();
            
            // Output message and abort if no save files are found in the selected folder
            if (saveFiles.Length == 0)
            {
                newBackupLabel.Text = Properties.Resources.NoFiles;
                return;
            }
            
            // Copy saves into new subdirectory
            foreach (var saveFile in saveFiles)
            {
                try
                {
                    File.Copy(saveFile, $"{destination}{Path.GetFileName(saveFile)}", false);
                }
                // Notify user of denied overwrite attempt
                catch (IOException copyError)
                {
                    Console.WriteLine(copyError.Message);
                    DisplayError(Properties.Resources.CopyError);
                    return;
                }
            }

            // Display message informing the user where the backup was saved
            newBackupLabel.Text = Properties.Resources.BackupMessage + destination;
            
            // Refresh listbox
            GetBackups();
            savesList.DataSource = _backups;
        }
        
        // Change back to Form1 to change folders
        private void ChangeFolders()
        {
            Hide();
            var form1 = new Form1();
            form1.Show();
        }
        
        // Add all save backup subdirectories into the listbox
        private void GetBackups()
        {
            _backups = Directory.GetDirectories(_backupPath);
        }
        
        // Display error message in popout window
        private static void DisplayError(string error)
        {
            // Make sure error message exists in Resources
            if(error == null) return;
            
            MessageBox.Show(error,
                Properties.Resources.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        // On click for backupButton
        private void backupButton_Click(object sender, EventArgs e)
        {
            Backup();
        }
        
        // On click for changeFoldersButton
        private void changeFolderButton_Click(object sender, EventArgs e)
        {
            ChangeFolders();
        }

        // Open the user's backup folder in Explorer
        private void viewBackupsButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", _backupPath);
        }

        // Restore a selected backup save into the game's save folder
        private void restoreButton_Click(object sender, EventArgs e)
        {
            // Get the selected save
            var selectedItem = savesList.GetItemText(savesList.SelectedItem);
            
            // Append a backslash to destination path
            var destination = _savePath + @"\";
            
            // Return if no backup is selected in the listbox, or if the save path is missing
            if(savesList.SelectedItem == null || !Directory.Exists(_savePath)) return;
            
            // Display error message if the selected item has been moved or deleted
            if (!Directory.Exists(selectedItem))
            {
                DisplayError(Properties.Resources.ItemNotFound);
                
                // Update listbox
                GetBackups();
                savesList.DataSource = _backups;
                
                return;
            }

                // Create backup of current save
            Backup();

            // Get the files in the selected backup folder
            var backupFiles = Directory.GetFiles(selectedItem);

            // Overwrite the game's save with the selected backup from the listbox
            foreach (var backupFile in backupFiles)
            {
                try
                {
                    File.Copy(backupFile, $"{destination}{Path.GetFileName(backupFile)}", true);
                }
                // Notify user of copy error
                catch (IOException copyError)
                {
                    Console.WriteLine(copyError);
                    DisplayError(Properties.Resources.CopyError);
                    return;
                }
            }
            
            // Output message confirming backup restoration
            restoreLabel.Text = Properties.Resources.RestoreMessage;
        }
    }
}