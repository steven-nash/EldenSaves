using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace EldenSaves
{
    public partial class MainForm : Form
    {
        private readonly string _backupPath;
        private readonly string _savePath;
        private BindingSource _src = new BindingSource();
        private string[] _backups;

        // Form where the main functionality occurs
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
            _src.DataSource = _backups;
            savesList.DataSource = _src;
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
                Console.WriteLine(Properties.Resources.DirectoryError);
                MessageBox.Show(Properties.Resources.DirectoryError,
                    Properties.Resources.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(Properties.Resources.CopyError,
                        Properties.Resources.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Display message informing the user where the backup was saved
            newBackupLabel.Text = Properties.Resources.BackupMessage + destination;
            
            // Refresh listbox
            GetBackups();
            _src.ResetBindings(false);
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
            // Return if no backup is selected in the listbox
            if(savesList.SelectedItem == null) return;
            
            // Append a backslash to destination path
            var destination = _savePath + @"\";
            
            // Create backup of current save
            Backup();

            savePathLabel.Text = savesList.GetItemText(savesList.SelectedItem);
            
            // Get the files in the selected backup folder
            var backupFiles = Directory.GetFiles(savesList.GetItemText(savesList.SelectedItem));

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
                    Console.WriteLine(copyError.Message);
                    MessageBox.Show(Properties.Resources.CopyError,
                        Properties.Resources.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
            // Output message confirming backup restoration
            restoreLabel.Text = Properties.Resources.RestoreMessage;
        }
    }
}