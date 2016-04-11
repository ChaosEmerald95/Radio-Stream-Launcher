namespace Radio_Stream_Launcher
{
    partial class frmoptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpfadstream = new System.Windows.Forms.TextBox();
            this.txtpfadirc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbextern = new System.Windows.Forms.RadioButton();
            this.rbintern = new System.Windows.Forms.RadioButton();
            this.btnsearchstream = new System.Windows.Forms.Button();
            this.btnsearchirc = new System.Windows.Forms.Button();
            this.btnaccept = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbproxybypass = new System.Windows.Forms.CheckBox();
            this.txtproxyport = new System.Windows.Forms.TextBox();
            this.txtproxyadresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbproxyenabled = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stream-Pfad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "IRC-Pfad";
            // 
            // txtpfadstream
            // 
            this.txtpfadstream.Location = new System.Drawing.Point(79, 6);
            this.txtpfadstream.Name = "txtpfadstream";
            this.txtpfadstream.Size = new System.Drawing.Size(277, 20);
            this.txtpfadstream.TabIndex = 1;
            this.txtpfadstream.TextChanged += new System.EventHandler(this.txtpfadstream_TextChanged);
            // 
            // txtpfadirc
            // 
            this.txtpfadirc.Location = new System.Drawing.Point(79, 35);
            this.txtpfadirc.Name = "txtpfadirc";
            this.txtpfadirc.Size = new System.Drawing.Size(277, 20);
            this.txtpfadirc.TabIndex = 1;
            this.txtpfadirc.TextChanged += new System.EventHandler(this.txtpfadirc_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbextern);
            this.groupBox1.Controls.Add(this.rbintern);
            this.groupBox1.Location = new System.Drawing.Point(7, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player";
            // 
            // rbextern
            // 
            this.rbextern.AutoSize = true;
            this.rbextern.Location = new System.Drawing.Point(6, 52);
            this.rbextern.Name = "rbextern";
            this.rbextern.Size = new System.Drawing.Size(96, 17);
            this.rbextern.TabIndex = 0;
            this.rbextern.TabStop = true;
            this.rbextern.Text = "Externer Player";
            this.rbextern.UseVisualStyleBackColor = true;
            this.rbextern.CheckedChanged += new System.EventHandler(this.rbextern_CheckedChanged);
            // 
            // rbintern
            // 
            this.rbintern.AutoSize = true;
            this.rbintern.Location = new System.Drawing.Point(6, 29);
            this.rbintern.Name = "rbintern";
            this.rbintern.Size = new System.Drawing.Size(93, 17);
            this.rbintern.TabIndex = 0;
            this.rbintern.TabStop = true;
            this.rbintern.Text = "Interner Player";
            this.rbintern.UseVisualStyleBackColor = true;
            this.rbintern.CheckedChanged += new System.EventHandler(this.rbintern_CheckedChanged);
            // 
            // btnsearchstream
            // 
            this.btnsearchstream.Location = new System.Drawing.Point(362, 6);
            this.btnsearchstream.Name = "btnsearchstream";
            this.btnsearchstream.Size = new System.Drawing.Size(24, 19);
            this.btnsearchstream.TabIndex = 3;
            this.btnsearchstream.Text = "...";
            this.btnsearchstream.UseVisualStyleBackColor = true;
            this.btnsearchstream.Click += new System.EventHandler(this.btnsearchstream_Click);
            // 
            // btnsearchirc
            // 
            this.btnsearchirc.Location = new System.Drawing.Point(362, 35);
            this.btnsearchirc.Name = "btnsearchirc";
            this.btnsearchirc.Size = new System.Drawing.Size(24, 19);
            this.btnsearchirc.TabIndex = 3;
            this.btnsearchirc.Text = "...";
            this.btnsearchirc.UseVisualStyleBackColor = true;
            this.btnsearchirc.Click += new System.EventHandler(this.btnsearchirc_Click);
            // 
            // btnaccept
            // 
            this.btnaccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnaccept.Location = new System.Drawing.Point(281, 3);
            this.btnaccept.Name = "btnaccept";
            this.btnaccept.Size = new System.Drawing.Size(116, 38);
            this.btnaccept.TabIndex = 4;
            this.btnaccept.Text = "Übernehmen";
            this.btnaccept.UseVisualStyleBackColor = true;
            this.btnaccept.Click += new System.EventHandler(this.btnaccept_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(401, 254);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtpfadstream);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnsearchirc);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnsearchstream);
            this.tabPage1.Controls.Add(this.txtpfadirc);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(393, 228);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Allgemein";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbproxybypass);
            this.tabPage2.Controls.Add(this.txtproxyport);
            this.tabPage2.Controls.Add(this.txtproxyadresse);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cbproxyenabled);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(393, 228);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Proxy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbproxybypass
            // 
            this.cbproxybypass.AutoSize = true;
            this.cbproxybypass.Location = new System.Drawing.Point(37, 62);
            this.cbproxybypass.Name = "cbproxybypass";
            this.cbproxybypass.Size = new System.Drawing.Size(221, 17);
            this.cbproxybypass.TabIndex = 3;
            this.cbproxybypass.Text = "Proxyserver für lokale Adressen umgehen";
            this.cbproxybypass.UseVisualStyleBackColor = true;
            this.cbproxybypass.CheckedChanged += new System.EventHandler(this.cbproxybypass_CheckedChanged);
            // 
            // txtproxyport
            // 
            this.txtproxyport.Location = new System.Drawing.Point(229, 36);
            this.txtproxyport.Name = "txtproxyport";
            this.txtproxyport.Size = new System.Drawing.Size(86, 20);
            this.txtproxyport.TabIndex = 2;
            this.txtproxyport.TextChanged += new System.EventHandler(this.txtproxyport_TextChanged);
            // 
            // txtproxyadresse
            // 
            this.txtproxyadresse.Location = new System.Drawing.Point(62, 36);
            this.txtproxyadresse.Name = "txtproxyadresse";
            this.txtproxyadresse.Size = new System.Drawing.Size(107, 20);
            this.txtproxyadresse.TabIndex = 2;
            this.txtproxyadresse.TextChanged += new System.EventHandler(this.txtproxyadresse_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adresse:";
            // 
            // cbproxyenabled
            // 
            this.cbproxyenabled.AutoSize = true;
            this.cbproxyenabled.Location = new System.Drawing.Point(9, 7);
            this.cbproxyenabled.Name = "cbproxyenabled";
            this.cbproxyenabled.Size = new System.Drawing.Size(108, 17);
            this.cbproxyenabled.TabIndex = 0;
            this.cbproxyenabled.Text = "Proxy verwenden";
            this.cbproxyenabled.UseVisualStyleBackColor = true;
            this.cbproxyenabled.CheckedChanged += new System.EventHandler(this.cbproxyenabled_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnaccept);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 45);
            this.panel1.TabIndex = 6;
            // 
            // frmoptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 254);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmoptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Optionen";
            this.Load += new System.EventHandler(this.frmoptions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpfadstream;
        private System.Windows.Forms.TextBox txtpfadirc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbextern;
        private System.Windows.Forms.RadioButton rbintern;
        private System.Windows.Forms.Button btnsearchstream;
        private System.Windows.Forms.Button btnsearchirc;
        private System.Windows.Forms.Button btnaccept;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbproxybypass;
        private System.Windows.Forms.TextBox txtproxyport;
        private System.Windows.Forms.TextBox txtproxyadresse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbproxyenabled;
        private System.Windows.Forms.Panel panel1;
    }
}