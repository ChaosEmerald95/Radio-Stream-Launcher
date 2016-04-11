namespace Radio_Stream_Launcher
{
    partial class frmabout
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
            this.lbversion = new System.Windows.Forms.Label();
            this.lbbuild = new System.Windows.Forms.Label();
            this.lbcopyright = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radio Stream Launcher";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbversion
            // 
            this.lbversion.AutoSize = true;
            this.lbversion.Location = new System.Drawing.Point(12, 48);
            this.lbversion.Name = "lbversion";
            this.lbversion.Size = new System.Drawing.Size(49, 13);
            this.lbversion.TabIndex = 1;
            this.lbversion.Text = "lbversion";
            // 
            // lbbuild
            // 
            this.lbbuild.AutoSize = true;
            this.lbbuild.Location = new System.Drawing.Point(12, 71);
            this.lbbuild.Name = "lbbuild";
            this.lbbuild.Size = new System.Drawing.Size(37, 13);
            this.lbbuild.TabIndex = 1;
            this.lbbuild.Text = "lbbuild";
            // 
            // lbcopyright
            // 
            this.lbcopyright.AutoSize = true;
            this.lbcopyright.Location = new System.Drawing.Point(12, 95);
            this.lbcopyright.Name = "lbcopyright";
            this.lbcopyright.Size = new System.Drawing.Size(58, 13);
            this.lbcopyright.TabIndex = 1;
            this.lbcopyright.Text = "lbcopyright";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(161, 116);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(127, 36);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // frmabout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 164);
            this.ControlBox = false;
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.lbcopyright);
            this.Controls.Add(this.lbbuild);
            this.Controls.Add(this.lbversion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmabout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Über Radio Stream Launcher";
            this.Load += new System.EventHandler(this.frmabout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbversion;
        private System.Windows.Forms.Label lbbuild;
        private System.Windows.Forms.Label lbcopyright;
        private System.Windows.Forms.Button btnok;
    }
}