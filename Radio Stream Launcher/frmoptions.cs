﻿using System;
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
        private string _stream;
        private string _irc;
        private bool _player;

        private bool _proxyon;
        private string _proxyname;
        private int _proxyport;
        private bool _proxybypass;
        public bool changes = false;

        public frmoptions(string streampfad, string ircpfad, bool player, bool proxyon, string proxyname, int proxyport, bool proxybypass)
        {
            InitializeComponent();
            _stream = streampfad;
            _irc = ircpfad;
            _player = player;
            _proxyon = proxyon;
            _proxyname = proxyname;
            _proxyport = proxyport;
            _proxybypass = proxybypass;
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

        public string IRCPfad
        {
            get { return _irc; }
        }

        public string StreamPfad
        {
            get { return _stream; }
        }

        public bool ExternerPlayer
        {
            get { return _player; }
        }

        public bool ProxyOn
        {
            get { return _proxyon; }
        }

        public string ProxyName
        {
            get { return _proxyname; }
        }

        public int ProxyPort
        {
            get { return _proxyport; }
        }

        public bool ProxyBypass
        {
            get { return _proxybypass; }
        }

        private void txtpfadstream_TextChanged(object sender, EventArgs e)
        {
            _stream = txtpfadstream.Text; 
        }

        private void txtpfadirc_TextChanged(object sender, EventArgs e)
        {
            _irc = txtpfadirc.Text; 
        }

        private void rbintern_CheckedChanged(object sender, EventArgs e)
        {
            _player = false;
        }

        private void rbextern_CheckedChanged(object sender, EventArgs e)
        {
            _player = true;
        }

        private void btnaccept_Click(object sender, EventArgs e)
        {
            changes = true;
            this.Close();
        }

        private void frmoptions_Load(object sender, EventArgs e)
        {
            txtpfadirc.Text = _irc;
            txtpfadstream.Text = _stream;
            txtproxyadresse.Text = _proxyname;
            txtproxyport.Text = _proxyport.ToString();
            cbproxyenabled.Checked = _proxyon;
            cbproxybypass.Checked = _proxybypass;

            //RadioButton
            if (_player == true) rbextern.Checked = true;
            if (_player == false) rbintern.Checked = true;

            SetProxyTab();
        }

        private void cbproxyenabled_CheckedChanged(object sender, EventArgs e)
        {
            _proxyon = cbproxyenabled.Checked;
            SetProxyTab();
        }

        private void txtproxyadresse_TextChanged(object sender, EventArgs e)
        {
            _proxyname = txtproxyadresse.Text; 
        }

        private void txtproxyport_TextChanged(object sender, EventArgs e)
        {
            _proxyport = Convert.ToInt32(txtproxyport.Text);
        }

        private void cbproxybypass_CheckedChanged(object sender, EventArgs e)
        {
            _proxybypass = cbproxybypass.Checked; 
        }

        private void SetProxyTab()
        {
            if (_proxyon )
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
