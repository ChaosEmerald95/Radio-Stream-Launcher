namespace Radio_Stream_Launcher
{
    partial class frmstreammanager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tvstream = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtstreamname = new System.Windows.Forms.TextBox();
            this.txtstreamurl = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btneditstream = new System.Windows.Forms.Button();
            this.btnsearchstream = new System.Windows.Forms.Button();
            this.btndeletestream = new System.Windows.Forms.Button();
            this.btnnewstream = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbgruppe = new System.Windows.Forms.ComboBox();
            this.cbfavorit = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvstream
            // 
            this.tvstream.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvstream.Location = new System.Drawing.Point(0, 0);
            this.tvstream.Name = "tvstream";
            this.tvstream.Size = new System.Drawing.Size(139, 228);
            this.tvstream.TabIndex = 0;
            this.tvstream.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvstream_NodeMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Streamname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stream-URL";
            // 
            // txtstreamname
            // 
            this.txtstreamname.Location = new System.Drawing.Point(218, 10);
            this.txtstreamname.Name = "txtstreamname";
            this.txtstreamname.Size = new System.Drawing.Size(188, 20);
            this.txtstreamname.TabIndex = 2;
            // 
            // txtstreamurl
            // 
            this.txtstreamurl.Location = new System.Drawing.Point(218, 37);
            this.txtstreamurl.Name = "txtstreamurl";
            this.txtstreamurl.Size = new System.Drawing.Size(188, 20);
            this.txtstreamurl.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btneditstream);
            this.groupBox2.Controls.Add(this.btnsearchstream);
            this.groupBox2.Controls.Add(this.btndeletestream);
            this.groupBox2.Controls.Add(this.btnnewstream);
            this.groupBox2.Location = new System.Drawing.Point(148, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 107);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aufgaben";
            // 
            // btneditstream
            // 
            this.btneditstream.Location = new System.Drawing.Point(130, 19);
            this.btneditstream.Name = "btneditstream";
            this.btneditstream.Size = new System.Drawing.Size(120, 33);
            this.btneditstream.TabIndex = 0;
            this.btneditstream.Text = "Stream bearbeiten";
            this.btneditstream.UseVisualStyleBackColor = true;
            this.btneditstream.Click += new System.EventHandler(this.btneditstream_Click);
            // 
            // btnsearchstream
            // 
            this.btnsearchstream.Location = new System.Drawing.Point(130, 58);
            this.btnsearchstream.Name = "btnsearchstream";
            this.btnsearchstream.Size = new System.Drawing.Size(120, 33);
            this.btnsearchstream.TabIndex = 0;
            this.btnsearchstream.Text = "Stream suchen";
            this.btnsearchstream.UseVisualStyleBackColor = true;
            this.btnsearchstream.Click += new System.EventHandler(this.btnsearchstream_Click);
            // 
            // btndeletestream
            // 
            this.btndeletestream.Location = new System.Drawing.Point(6, 58);
            this.btndeletestream.Name = "btndeletestream";
            this.btndeletestream.Size = new System.Drawing.Size(120, 33);
            this.btndeletestream.TabIndex = 0;
            this.btndeletestream.Text = "Stream löschen";
            this.btndeletestream.UseVisualStyleBackColor = true;
            this.btndeletestream.Click += new System.EventHandler(this.btndeletestream_Click);
            // 
            // btnnewstream
            // 
            this.btnnewstream.Location = new System.Drawing.Point(6, 19);
            this.btnnewstream.Name = "btnnewstream";
            this.btnnewstream.Size = new System.Drawing.Size(120, 33);
            this.btnnewstream.TabIndex = 0;
            this.btnnewstream.Text = "Neuer Stream";
            this.btnnewstream.UseVisualStyleBackColor = true;
            this.btnnewstream.Click += new System.EventHandler(this.btnnewstream_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gruppe";
            // 
            // cbgruppe
            // 
            this.cbgruppe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbgruppe.FormattingEnabled = true;
            this.cbgruppe.Location = new System.Drawing.Point(218, 64);
            this.cbgruppe.Name = "cbgruppe";
            this.cbgruppe.Size = new System.Drawing.Size(188, 21);
            this.cbgruppe.TabIndex = 5;
            // 
            // cbfavorit
            // 
            this.cbfavorit.AutoSize = true;
            this.cbfavorit.Location = new System.Drawing.Point(331, 91);
            this.cbfavorit.Name = "cbfavorit";
            this.cbfavorit.Size = new System.Drawing.Size(75, 17);
            this.cbfavorit.TabIndex = 6;
            this.cbfavorit.Text = "Als Favorit";
            this.cbfavorit.UseVisualStyleBackColor = true;
            // 
            // frmstreammanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 228);
            this.Controls.Add(this.cbfavorit);
            this.Controls.Add(this.cbgruppe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtstreamurl);
            this.Controls.Add(this.txtstreamname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvstream);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmstreammanager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Stream Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmstreammanager_FormClosing);
            this.Load += new System.EventHandler(this.frmstreammanager_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvstream;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtstreamname;
        private System.Windows.Forms.TextBox txtstreamurl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btneditstream;
        private System.Windows.Forms.Button btnsearchstream;
        private System.Windows.Forms.Button btndeletestream;
        private System.Windows.Forms.Button btnnewstream;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbgruppe;
        private System.Windows.Forms.CheckBox cbfavorit;
    }
}