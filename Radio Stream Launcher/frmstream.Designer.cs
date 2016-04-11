namespace Radio_Stream_Launcher
{
    partial class frmstream
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmstream));
            this.tvstream = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamlisteLadenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamlisteLadenVonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sicherungErstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sicherungWiederherstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iRCClientStartenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtstream = new System.Windows.Forms.TextBox();
            this.txtstreamurl = new System.Windows.Forms.TextBox();
            this.btnstream = new System.Windows.Forms.Button();
            this.statustimer = new System.Windows.Forms.Timer(this.components);
            this.wwwbrowser = new System.Windows.Forms.WebBrowser();
            this.hscrollvolume = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.volumetimer = new System.Windows.Forms.Timer(this.components);
            this.btnmute = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnweb = new System.Windows.Forms.Button();
            this.tiptool = new System.Windows.Forms.ToolTip(this.components);
            this.btnrecord = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvstream
            // 
            this.tvstream.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvstream.Location = new System.Drawing.Point(0, 24);
            this.tvstream.Name = "tvstream";
            this.tvstream.Size = new System.Drawing.Size(168, 149);
            this.tvstream.TabIndex = 0;
            this.tvstream.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvstream_NodeMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.streamToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.extrasToolStripMenuItem,
            this.überToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.streamlisteLadenToolStripMenuItem,
            this.streamlisteLadenVonToolStripMenuItem,
            this.streamManagerToolStripMenuItem,
            this.toolStripSeparator1,
            this.beendenToolStripMenuItem});
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.streamToolStripMenuItem.Text = "Stream";
            // 
            // streamlisteLadenToolStripMenuItem
            // 
            this.streamlisteLadenToolStripMenuItem.Name = "streamlisteLadenToolStripMenuItem";
            this.streamlisteLadenToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.streamlisteLadenToolStripMenuItem.Text = "Streamliste neu laden";
            this.streamlisteLadenToolStripMenuItem.Click += new System.EventHandler(this.streamlisteLadenToolStripMenuItem_Click);
            // 
            // streamlisteLadenVonToolStripMenuItem
            // 
            this.streamlisteLadenVonToolStripMenuItem.Name = "streamlisteLadenVonToolStripMenuItem";
            this.streamlisteLadenVonToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.streamlisteLadenVonToolStripMenuItem.Text = "Streamliste laden von...";
            this.streamlisteLadenVonToolStripMenuItem.Click += new System.EventHandler(this.streamlisteLadenVonToolStripMenuItem_Click);
            // 
            // streamManagerToolStripMenuItem
            // 
            this.streamManagerToolStripMenuItem.Name = "streamManagerToolStripMenuItem";
            this.streamManagerToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.streamManagerToolStripMenuItem.Text = "Stream-Manager";
            this.streamManagerToolStripMenuItem.Click += new System.EventHandler(this.streamManagerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sicherungErstellenToolStripMenuItem,
            this.sicherungWiederherstellenToolStripMenuItem});
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // sicherungErstellenToolStripMenuItem
            // 
            this.sicherungErstellenToolStripMenuItem.Name = "sicherungErstellenToolStripMenuItem";
            this.sicherungErstellenToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.sicherungErstellenToolStripMenuItem.Text = "Sicherung erstellen";
            this.sicherungErstellenToolStripMenuItem.Click += new System.EventHandler(this.sicherungErstellenToolStripMenuItem_Click);
            // 
            // sicherungWiederherstellenToolStripMenuItem
            // 
            this.sicherungWiederherstellenToolStripMenuItem.Name = "sicherungWiederherstellenToolStripMenuItem";
            this.sicherungWiederherstellenToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.sicherungWiederherstellenToolStripMenuItem.Text = "Sicherung wiederherstellen";
            this.sicherungWiederherstellenToolStripMenuItem.Click += new System.EventHandler(this.sicherungWiederherstellenToolStripMenuItem_Click);
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iRCClientStartenToolStripMenuItem,
            this.optionenToolStripMenuItem});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.extrasToolStripMenuItem.Text = "Extras";
            // 
            // iRCClientStartenToolStripMenuItem
            // 
            this.iRCClientStartenToolStripMenuItem.Name = "iRCClientStartenToolStripMenuItem";
            this.iRCClientStartenToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.iRCClientStartenToolStripMenuItem.Text = "IRC-Client starten";
            this.iRCClientStartenToolStripMenuItem.Click += new System.EventHandler(this.iRCClientStartenToolStripMenuItem_Click);
            // 
            // optionenToolStripMenuItem
            // 
            this.optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
            this.optionenToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.optionenToolStripMenuItem.Text = "Optionen";
            this.optionenToolStripMenuItem.Click += new System.EventHandler(this.optionenToolStripMenuItem_Click);
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.überToolStripMenuItem.Text = "Über";
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stream:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stream-URL:";
            // 
            // txtstream
            // 
            this.txtstream.Location = new System.Drawing.Point(244, 38);
            this.txtstream.Name = "txtstream";
            this.txtstream.ReadOnly = true;
            this.txtstream.Size = new System.Drawing.Size(333, 20);
            this.txtstream.TabIndex = 4;
            // 
            // txtstreamurl
            // 
            this.txtstreamurl.Location = new System.Drawing.Point(244, 64);
            this.txtstreamurl.Name = "txtstreamurl";
            this.txtstreamurl.ReadOnly = true;
            this.txtstreamurl.Size = new System.Drawing.Size(333, 20);
            this.txtstreamurl.TabIndex = 4;
            // 
            // btnstream
            // 
            this.btnstream.Location = new System.Drawing.Point(176, 94);
            this.btnstream.Name = "btnstream";
            this.btnstream.Size = new System.Drawing.Size(118, 41);
            this.btnstream.TabIndex = 6;
            this.btnstream.Text = "Stream starten";
            this.btnstream.UseVisualStyleBackColor = true;
            this.btnstream.Click += new System.EventHandler(this.btnstream_Click);
            // 
            // statustimer
            // 
            this.statustimer.Tick += new System.EventHandler(this.statustimer_Tick);
            // 
            // wwwbrowser
            // 
            this.wwwbrowser.Location = new System.Drawing.Point(168, 174);
            this.wwwbrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wwwbrowser.Name = "wwwbrowser";
            this.wwwbrowser.Size = new System.Drawing.Size(421, 192);
            this.wwwbrowser.TabIndex = 8;
            this.wwwbrowser.Visible = false;
            // 
            // hscrollvolume
            // 
            this.hscrollvolume.Location = new System.Drawing.Point(303, 111);
            this.hscrollvolume.Maximum = 109;
            this.hscrollvolume.Name = "hscrollvolume";
            this.hscrollvolume.Size = new System.Drawing.Size(150, 20);
            this.hscrollvolume.TabIndex = 9;
            this.tiptool.SetToolTip(this.hscrollvolume, "Lautstärke anpassen");
            this.hscrollvolume.ValueChanged += new System.EventHandler(this.hscrollvolume_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lautstärke";
            // 
            // volumetimer
            // 
            this.volumetimer.Interval = 5;
            this.volumetimer.Tick += new System.EventHandler(this.volumetimer_Tick);
            // 
            // btnmute
            // 
            this.btnmute.Location = new System.Drawing.Point(467, 99);
            this.btnmute.Name = "btnmute";
            this.btnmute.Size = new System.Drawing.Size(33, 30);
            this.btnmute.TabIndex = 11;
            this.btnmute.Text = "<))";
            this.tiptool.SetToolTip(this.btnmute, "Stumm schalten");
            this.btnmute.UseVisualStyleBackColor = true;
            this.btnmute.Click += new System.EventHandler(this.btnmute_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Image")));
            this.btnrefresh.Location = new System.Drawing.Point(506, 99);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(33, 30);
            this.btnrefresh.TabIndex = 12;
            this.tiptool.SetToolTip(this.btnrefresh, "Serverstatus aktualisieren");
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnweb
            // 
            this.btnweb.Image = ((System.Drawing.Image)(resources.GetObject("btnweb.Image")));
            this.btnweb.Location = new System.Drawing.Point(545, 99);
            this.btnweb.Name = "btnweb";
            this.btnweb.Size = new System.Drawing.Size(33, 30);
            this.btnweb.TabIndex = 13;
            this.tiptool.SetToolTip(this.btnweb, "Serverstatus anzeigen");
            this.btnweb.UseVisualStyleBackColor = true;
            this.btnweb.Click += new System.EventHandler(this.btnweb_Click);
            // 
            // btnrecord
            // 
            this.btnrecord.BackColor = System.Drawing.Color.Gainsboro;
            this.btnrecord.Image = ((System.Drawing.Image)(resources.GetObject("btnrecord.Image")));
            this.btnrecord.Location = new System.Drawing.Point(467, 135);
            this.btnrecord.Name = "btnrecord";
            this.btnrecord.Size = new System.Drawing.Size(33, 30);
            this.btnrecord.TabIndex = 11;
            this.tiptool.SetToolTip(this.btnrecord, "Aufnehmen des Sounds\r\nWARNUNG!: Es wird auch der Sound von den anderen Anwendung " +
        "mit aufgezeichnet");
            this.btnrecord.UseVisualStyleBackColor = false;
            this.btnrecord.Click += new System.EventHandler(this.btnrecord_Click);
            // 
            // frmstream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 173);
            this.Controls.Add(this.btnweb);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnrecord);
            this.Controls.Add(this.btnmute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hscrollvolume);
            this.Controls.Add(this.wwwbrowser);
            this.Controls.Add(this.btnstream);
            this.Controls.Add(this.txtstreamurl);
            this.Controls.Add(this.txtstream);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvstream);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmstream";
            this.Text = "Radio Stream Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmstream_FormClosing);
            this.Load += new System.EventHandler(this.frmstream_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvstream;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamlisteLadenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtstream;
        private System.Windows.Forms.TextBox txtstreamurl;
        private System.Windows.Forms.Button btnstream;
        private System.Windows.Forms.ToolStripMenuItem streamlisteLadenVonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer statustimer;
        private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iRCClientStartenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.WebBrowser wwwbrowser;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sicherungErstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sicherungWiederherstellenToolStripMenuItem;
        private System.Windows.Forms.HScrollBar hscrollvolume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer volumetimer;
        private System.Windows.Forms.Button btnmute;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnweb;
        private System.Windows.Forms.ToolTip tiptool;
        private System.Windows.Forms.Button btnrecord;
    }
}

