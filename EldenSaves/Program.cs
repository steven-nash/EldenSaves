using System;
using System.IO;
using System.Windows.Forms;
using EldenSaves.Properties;

namespace EldenSaves
{
    static class Program
    {
        // Steven Nash 2022
        // Elden Saves is a Windows application for creating and managing Elden Ring save copies.

        // The main entry point for the application.
        // If the user doesn't have saved defaults for the backup and game save directories, they are sent
        // to the folder selection form. Otherwise, they are sent to the main form.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Settings.Default.Reset();
            
            // If the folders have previously been set, go straight into the MainForm
            if(Directory.Exists(Settings.Default.DefaultBackup) && Directory.Exists(Settings.Default.DefaultSave)) 
                Application.Run(new MainForm(Settings.Default.DefaultBackup, Settings.Default.DefaultSave));
            // Otherwise start the form that allows the user to set the folders
            else
                Application.Run(new Form1());
        }
    }
}