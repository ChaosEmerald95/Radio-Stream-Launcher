using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Radio_Stream_Launcher
{
    class Backup
    {
        /// <summary>
        /// Erstellt ein Backup an dem angegebenen Pfad
        /// </summary>
        public static void BackupFiles()
        {
            System.Windows.Forms.SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Zip-Archiv (*.zip)|*.zip";
            sfd.Title = "Backup erstellen";
            sfd.InitialDirectory = Directory.GetCurrentDirectory();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ZipArchive zip = ZipFile.Open(sfd.FileName, ZipArchiveMode.Create);
                string[] files = new string[2]; 
                files[0] = Directory.GetCurrentDirectory() + "/streams.rsls";
                files[1] = Directory.GetCurrentDirectory() + "/config.ini";
                int i;
                for (i = 0; i < 2; i++)
                {
                    zip.CreateEntryFromFile(files[i], Path.GetFileName(files[i]), CompressionLevel.Optimal);
                }
                zip.Dispose();
            }
        }

        /// <summary>
        /// Stellt das Backup wieder her
        /// </summary>
        public static void RestoreFiles()
        {
            System.Windows.Forms.OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Zip-Archiv (*.zip)|*.zip";
            ofd.Title = "Sicherung wiederherstellen";
            ofd.Multiselect = false;
            ofd.InitialDirectory = Directory.GetCurrentDirectory();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ZipFile.ExtractToDirectory(ofd.FileName, Directory.GetCurrentDirectory());
                if (MessageBox.Show("Soll das backup gelöscht werden?", "Meldung", MessageBoxButtons.YesNo) == DialogResult.Yes) File.Delete(ofd.FileName);
            }
        }
    }
}
