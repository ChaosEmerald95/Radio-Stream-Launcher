using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Stream_Launcher
{
    public partial class frmoptions : Form
    {
        public ConfigData.ConfigurationData d;

        public frmoptions(ConfigData.ConfigurationData data)
        {
            InitializeComponent();
            d = data; //Daten werden kopiert
        }

        private void btnsearchstream_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Radio Stream Launcher Streams (*.rsls)|*.rsls";
            ofd.Title ="Stream-Datei auswählen";
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtpfadstream.Text  = ofd.FileName; 
            }
        }

        private void btnsearchirc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Anwendungen (*.exe)|*.exe|Alle Dateien (*.*)|*.*";
            ofd.Title = "IRC-Client auswählen";
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtpfadirc.Text  = ofd.FileName;
            }
        }

        private void txtpfadstream_TextChanged(object sender, EventArgs e)
        {
            d._streampfad  = txtpfadstream.Text; 
        }

        private void txtpfadirc_TextChanged(object sender, EventArgs e)
        {
            d._ircpfad  = txtpfadirc.Text; 
        }

        private void rbintern_CheckedChanged(object sender, EventArgs e)
        {
            d._externplayer  = false;
        }

        private void rbextern_CheckedChanged(object sender, EventArgs e)
        {
            d._externplayer  = true;
        }

        private void btnaccept_Click(object sender, EventArgs e)
        {
            Close();
        }

        public ConfigData.ConfigurationData Data()
        {
            return d;
        }

        private void frmoptions_Load(object sender, EventArgs e)
        {
            txtpfadirc.Text = d._ircpfad ;
            txtpfadstream.Text = d._streampfad ;
            txtproxyadresse.Text = d._proxyname ;
            txtproxyport.Text = d._proxyport .ToString();
            cbproxyenabled.Checked = d._proxyon ;
            cbproxybypass.Checked = d._proxybypass;

            //RadioButton
            if (d._externplayer  == true) rbextern.Checked = true;
            if (d._externplayer  == false) rbintern.Checked = true;

            SetProxyTab();
        }

        private void cbproxyenabled_CheckedChanged(object sender, EventArgs e)
        {
            d._proxyon = cbproxyenabled.Checked;
            SetProxyTab();
        }

        private void txtproxyadresse_TextChanged(object sender, EventArgs e)
        {
            d._proxyname = txtproxyadresse.Text; 
        }

        private void txtproxyport_TextChanged(object sender, EventArgs e)
        {
            d._proxyport = Convert.ToInt32(txtproxyport.Text);
        }

        private void cbproxybypass_CheckedChanged(object sender, EventArgs e)
        {
            d._proxybypass = cbproxybypass.Checked; 
        }

        private void SetProxyTab()
        {
            if (d._proxyon )
            {
                txtproxyadresse.Enabled = true;
                txtproxyport.Enabled = true;
                cbproxybypass.Enabled = true;
            }
            else
            {
                txtproxyadresse.Enabled = false;
                txtproxyport.Enabled = false;
                cbproxybypass.Enabled = false;
            }
        }
    }
}
