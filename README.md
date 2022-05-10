# EldenSaves
## Elden Saves is a Windows application for creating and managing Elden Ring save copies.

### Backup Folder
The backup folder is the directory where save copies will be stored and read from.
Backups saves will be created in new folders within this directory, and are named according to the
date and time they are created.

### Save Folder
The save folder is the directory of the Elden Ring's game save files. This is automatically created
by the game, and is defaulted to C:\Users\(current user)\AppData\Roaming\EldenRing.
In the normal circumstance that there is only one save folder in this location, it is set as the default.
This should look something like: C:\Users\user1\AppData\Roaming\EldenRing\76561198035474619

![Select Folders Form](https://github.com/steven-nash/EldenSaves/blob/main/EldenSaves_Form1.PNG)

### Creating a Save Copy/Backup
Choosing to create a backup simply copies the game's current save files in the selected save directory 
into a new backup folder in the backup directory. This will not overwrite files in the target directory.

### Restoring a Backup Save
Choosing to restore a backup save takes the currently selected save backup in the list and copies it
into the selected save directory (ideally the game's save folder). Before overwriting the game's
current save, a backup of it is first created in the backup directory.

![Main Form](https://github.com/steven-nash/EldenSaves/blob/main/EldenSaves_Main.PNG)
