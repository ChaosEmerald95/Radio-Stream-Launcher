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

namespace Radio_Stream_Launcher
{
    public partial class frmstream : Form
    {
        const int maxheight = 375;
        const int minheight = 182;

        //Die Klassen
        StreamList sl;
        configuration cfg;
        WMPlayer wmpl;
        ExtPlayer expl; //Für das Abspielen über den externen Player
        
        public frmstream()
        {
            InitializeComponent();
            cfg = new configuration();
            cfg.LoadConfiguration();
            sl = new StreamList(cfg.StreamPfad);
            wmpl = new WMPlayer();
            expl = new ExtPlayer();
        }

        private void frmstream_Load(object sender, EventArgs e)
        {
            streamlisteLadenToolStripMenuItem_Click(streamlisteLadenToolStripMenuItem, null);
            ConfigWMPProxy();
            hscrollvolume.Value = wmpl.Volume; //Damit das Volume einen Startwert hat.
            volumetimer.Start();

            //Gespeicherte Einstellungen wenn verfügbar nutzen
            if (File.Exists(Directory.GetCurrentDirectory() + "/volset.tmp") == true) LoadVolTmp();
        }

        private void streamlisteLadenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Laden der Liste in TreeView und Objekt
            sl.LoadData();
            int i;
            tvstream.Nodes.Clear(); 
            for (i = 0; i < sl.RecordCount; i++)
            {
                if (TVSearchGroupExists(sl.GetValueExt(i,2)) == false)
                {
                    TVAddGroup(sl.GetValueExt(i, 2));
                }
                TVAddEntry(sl.GetValueExt(i, 0), sl.GetValueExt(i, 2));
            }
        }

        private void streamlisteLadenVonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ein OpenFileDialog wird geöffnet, wo dann die Streamliste ausgewählt wird. Gespeichert muss es dann in cfg und sl
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Radio Stream Launcher Streams (*.rsls)|*.rsls";
            ofd.Title ="Streamliste laden";
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sl.Dateipfad = ofd.FileName;
                cfg.StreamPfad = ofd.FileName;
                cfg.WriteConfig();
                streamlisteLadenToolStripMenuItem_Click(streamlisteLadenToolStripMenuItem, null);
            }
        }

        private void streamManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstreammanager frm = new frmstreammanager(sl.Dateipfad);
            frm.ShowDialog();
            streamlisteLadenToolStripMenuItem_Click(streamlisteLadenToolStripMenuItem, null);
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tvstream_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (wmpl.IsPlayed() == true || expl.IsPlayed() == true )
            {
                return;
            }

            //Datensatz mit den Daten zu dem ausgewählten Stream ermitteln
            int i;
            for (i = 0; i < sl.RecordCount; i++)
            {
                if (sl.GetValueExt(i,0) == e.Node.Text)
                {
                    txtstream.Text = sl.GetValueExt(i, 0);
                    txtstreamurl.Text = sl.GetValueExt(i, 1);
                    return;
                }
            }
        }

        private void btnstream_Click(object sender, EventArgs e)
        {
            if (wmpl.IsPlayed() == false || expl.IsPlayed() == false )
            {
                if (cfg.ExternerPlayer == true)
                {
                    wmpl.Streamurl = txtstreamurl.Text;
                    if (wmpl.Play() == true)
                    {
                        btnstream.Text = "Stream stoppen";
                        statustimer.Enabled = true;
                        statustimer.Start();
                    }
                }
                else
                {
                    expl.Streamurl = txtstreamurl.Text;
                    if (expl.Play() == true)
                    {
                        btnstream.Text = "Stream stoppen";
                        statustimer.Enabled = true;
                        statustimer.Start();
                    }
                }
            }
            else
            {
                if (cfg.ExternerPlayer == true )
                {
                    if (expl.Stop() == true)
                    {
                        btnstream.Text = "Stream starten";
                        statustimer.Stop();
                        statustimer.Enabled = false;
                        int w = this.Size.Width;
                        this.Size = new Size(w, minheight);
                        this.Text = "Radio Stream Launcher";
                    }
                }
                else
                {
                    if (wmpl.Stop() == true)
                    {
                        btnstream.Text = "Stream starten";
                        statustimer.Stop();
                        statustimer.Enabled = false;
                        int w = this.Size.Width;
                        this.Size = new Size(w, minheight);
                        this.Text = "Radio Stream Launcher";
                    }
                }
            }
        }

        private void statustimer_Tick(object sender, EventArgs e)
        {
            this.Text = "Radio Stream Launcher - " + wmpl.status;
            if (wmpl.status == "Bereit")
            {
                if (wmpl.Stop() == true)
                {
                    btnstream.Text = "Stream starten";
                    statustimer.Stop();
                    statustimer.Enabled = false;
                    int w = this.Size.Width;
                    this.Size = new Size(w, minheight);
                    this.Text = "Radio Stream Launcher";
                }
            }

            //Wenn Der Prozess beim externen Player nicht mehr da ist
            if (cfg.ExternerPlayer == true && expl.ProcessAlive() == false)
            {
                if (expl.Stop() == true)
                {
                    btnstream.Text = "Stream starten";
                    statustimer.Stop();
                    statustimer.Enabled = false;
                    int w = this.Size.Width;
                    this.Size = new Size(w, minheight);
                    this.Text = "Radio Stream Launcher";
                }
            }
        }

        private void optionenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmoptions frm = new frmoptions(cfg.StreamPfad, cfg.IRCPfad, cfg.ExternerPlayer, cfg.ProxyOn,cfg.ProxyName,cfg.ProxyPort, cfg.ProxyBypass);
            frm.ShowDialog();
            if (frm.changes == true)
            {
                cfg.IRCPfad = frm.IRCPfad;
                cfg.StreamPfad = frm.StreamPfad;
                cfg.ExternerPlayer = frm.ExternerPlayer;
                cfg.ProxyOn = frm.ProxyOn;
                cfg.ProxyName = frm.ProxyName;
                cfg.ProxyPort = frm.ProxyPort;
                cfg.ProxyBypass = frm.ProxyBypass;
                cfg.WriteConfig();
                ConfigWMPProxy();
                sl.Dateipfad = frm.StreamPfad;
                streamlisteLadenToolStripMenuItem_Click(streamlisteLadenToolStripMenuItem, null);
            }
        }

        private void iRCClientStartenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Vorher Pfad überprüfen, um Fehler zu vermeiden
            if (cfg.IRCPfad.Trim() == "")
            {
                MessageBox.Show("Der IRC-Pfad ist leer!");
                return;
            }

            if (File.Exists(cfg.IRCPfad) == false)
            {
                MessageBox.Show("Der IRC-Client existiert nicht! Überprüfen Sie nochmal den Pfad");
                return;
            }

            try
            {
                System.Diagnostics.Process.Start(cfg.IRCPfad);
            }
            catch
            {
                MessageBox.Show("Fehler beim Starten des IRC-Clients!");
            }
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmabout frm = new frmabout();
            frm.ShowDialog();
        }

#region Treeview-Nodes-Funktionen
        private void TVAddGroup(string groupname)
        {
            tvstream.Nodes.Add(groupname);
        }

        private void TVAddEntry(string value, string groupname)
        {
            int i;
            for (i = 0; i < tvstream.Nodes.Count; i++)
            {
                if (tvstream.Nodes[i].Text == groupname)
                {
                    TreeNode tn = new TreeNode(value);
                    tvstream.Nodes[i].Nodes.Add(tn);
                }
            }
        }

        private bool TVSearchGroupExists(string group)
        {
            int i;
            for (i = 0; i < tvstream.Nodes.Count; i++)
            {
                if (tvstream.Nodes[i].Text == group)
                {
                    return true;
                }
            }
            return false;
        }
#endregion

        public void ConfigWMPProxy()
        {
            if (cfg.ProxyOn == true)
            {
                wmpl.SetProxySettings = WMPlayer.ProxySetting.ManualSettings;
                wmpl.ProxyBypassForLocal = cfg.ProxyBypass;
                wmpl.ProxyName = cfg.ProxyName;
                wmpl.ProxyPort = cfg.ProxyPort; 
            }
            if (cfg.ProxyOn == false) wmpl.SetProxySettings = WMPlayer.ProxySetting.NoProxy;
        }

        private void sicherungErstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup.BackupFiles();
        }

        private void sicherungWiederherstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup.RestoreFiles();
            cfg.LoadConfiguration();
            sl.Dateipfad = cfg.StreamPfad;
            streamlisteLadenToolStripMenuItem_Click(streamlisteLadenToolStripMenuItem, null);
            ConfigWMPProxy();
        }

        private void hscrollvolume_ValueChanged(object sender, EventArgs e)
        {
            wmpl.Volume = hscrollvolume.Value; //Damit sich die Volume ändert
        }

        private void volumetimer_Tick(object sender, EventArgs e)
        {
            //Status des Volumes aktualisieren, da auch mit dem Soundmixer die Lautstärke eingestellt werden kann
            hscrollvolume.Value = wmpl.Volume;
 
            //Es soll aktualisiert werden, ob von außerhalb der Ton stummgeschalten wurde
            if (wmpl.Mute == true) btnmute.Text = "<";
            if (wmpl.Mute == false) btnmute.Text = "<))";
        }

        private void btnmute_Click(object sender, EventArgs e)
        {
            //Stellt ein, ob Mute oder nicht
            if (wmpl.Mute == true) wmpl.Mute = false;
            else wmpl.Mute = true;
        }

        private void SaveVolTmp()
        {
            StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "/volset.tmp");
            sw.WriteLine(wmpl.Volume.ToString());
            sw.WriteLine(wmpl.Mute.ToString());
            sw.Close();
        }

        private void LoadVolTmp()
        {
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/volset.tmp");
            wmpl.Volume = Convert.ToInt32(sr.ReadLine());
            string mute = sr.ReadLine();
            sr.Close(); //Stream kann schon geschlossen werden
            if (mute == "True") wmpl.Mute = true;
            if (mute == "False") wmpl.Mute = false;
            File.Delete(Directory.GetCurrentDirectory() + "/volset.tmp"); //Tmp-Datei wird vernichtet
        }

        private void frmstream_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveVolTmp(); //Soll die letzten Volume-Einstellungen cachen, damit diese beim nächsten Start verwendet werden können
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            wwwbrowser.Refresh(); //Aktualisiert die Seite
        }

        private void btnweb_Click(object sender, EventArgs e)
        {
            if (this.Size.Height == minheight )
            {
                if (txtstreamurl.Text == "")
                {
                    return;
                }

                Uri uri = new Uri(txtstreamurl.Text.Substring(0, txtstreamurl.Text.IndexOf("/", 8) + 1));
                wwwbrowser.Url = uri;
                wwwbrowser.Visible = true;
                int w = this.Size.Width;
                this.Size = new Size(w, maxheight);
            }
            else
            {
                Uri uri = new Uri("about:blank");
                wwwbrowser.Url = uri;
                wwwbrowser.Visible = false;
                int w = this.Size.Width;
                this.Size = new Size(w, minheight);
            }
        }
    }
}
