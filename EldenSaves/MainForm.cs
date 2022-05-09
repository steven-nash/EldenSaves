using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace EldenSaves
{
    public partial class MainForm : Form
    {
        private readonly string _backupPath;
        private readonly string _savePath;
        
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
            savePathLabel.Text = savePath;
        }
        
        // Backup current game saves
        private void Backup(object sender, EventArgs e)
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
        }
        
        // On click for changeFoldersButton
        private void changeFolderButton_Click(object sender, EventArgs e)
        {
            ChangeFolders();
        }
        
        // Change back to Form1 to change folders
        private void ChangeFolders()
        {
            Hide();
            var form1 = new Form1();
            form1.Show();
        }
    }
}