namespace InputBoxSharp
{
    partial class InputBoxSharp
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
            this.lbdescription = new System.Windows.Forms.Label();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btnabort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbdescription
            // 
            this.lbdescription.Location = new System.Drawing.Point(12, 9);
            this.lbdescription.Name = "lbdescription";
            this.lbdescription.Size = new System.Drawing.Size(272, 70);
            this.lbdescription.TabIndex = 0;
            this.lbdescription.Text = "lbdescription";
            this.lbdescription.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(12, 88);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(272, 20);
            this.txtinput.TabIndex = 1;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(290, 56);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnabort
            // 
            this.btnabort.Location = new System.Drawing.Point(290, 85);
            this.btnabort.Name = "btnabort";
            this.btnabort.Size = new System.Drawing.Size(75, 23);
            this.btnabort.TabIndex = 2;
            this.btnabort.Text = "Abbrechen";
            this.btnabort.UseVisualStyleBackColor = true;
            this.btnabort.Click += new System.EventHandler(this.btnabort_Click);
            // 
            // InputBoxSharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 121);
            this.Controls.Add(this.btnabort);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.lbdescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputBoxSharp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdescription;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnabort;
    }
}

