namespace Radio_Stream_Launcher
{
    partial class frmnewstream
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
            this.txtstreamurl = new System.Windows.Forms.TextBox();
            this.txtstreamname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbgruppe = new System.Windows.Forms.ComboBox();
            this.cbfavorit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtstreamurl
            // 
            this.txtstreamurl.Location = new System.Drawing.Point(84, 33);
            this.txtstreamurl.Name = "txtstreamurl";
            this.txtstreamurl.Size = new System.Drawing.Size(188, 20);
            this.txtstreamurl.TabIndex = 2;
            // 
            // txtstreamname
            // 
            this.txtstreamname.Location = new System.Drawing.Point(84, 6);
            this.txtstreamname.Name = "txtstreamname";
            this.txtstreamname.Size = new System.Drawing.Size(188, 20);
            this.txtstreamname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stream-URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Streamname";
            // 
            // btnadd
            // 
            this.btnadd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnadd.Location = new System.Drawing.Point(131, 107);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(141, 38);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "Übernehmen";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gruppe";
            // 
            // cbgruppe
            // 
            this.cbgruppe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbgruppe.FormattingEnabled = true;
            this.cbgruppe.Items.AddRange(new object[] {
            "<Neu>"});
            this.cbgruppe.Location = new System.Drawing.Point(84, 59);
            this.cbgruppe.Name = "cbgruppe";
            this.cbgruppe.Size = new System.Drawing.Size(188, 21);
            this.cbgruppe.TabIndex = 6;
            this.cbgruppe.SelectedIndexChanged += new System.EventHandler(this.cbgruppe_SelectedIndexChanged);
            // 
            // cbfavorit
            // 
            this.cbfavorit.AutoSize = true;
            this.cbfavorit.Location = new System.Drawing.Point(197, 86);
            this.cbfavorit.Name = "cbfavorit";
            this.cbfavorit.Size = new System.Drawing.Size(75, 17);
            this.cbfavorit.TabIndex = 7;
            this.cbfavorit.Text = "Als Favorit";
            this.cbfavorit.UseVisualStyleBackColor = true;
            // 
            // frmnewstream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 157);
            this.Controls.Add(this.cbfavorit);
            this.Controls.Add(this.cbgruppe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtstreamurl);
            this.Controls.Add(this.txtstreamname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmnewstream";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Neuer Stream...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtstreamurl;
        private System.Windows.Forms.TextBox txtstreamname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbgruppe;
        private System.Windows.Forms.CheckBox cbfavorit;
    }
}