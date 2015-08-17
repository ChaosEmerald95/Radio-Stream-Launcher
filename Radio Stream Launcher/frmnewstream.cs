using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InputBoxSharp;

namespace Radio_Stream_Launcher
{
    public partial class frmnewstream : Form
    {
        public string streamname, streamurl;
        public bool changes = false;
        public bool newgroup = false;
        public string gruppe, favorit;

        public frmnewstream(string[] grouplist)
        {
            InitializeComponent();
            int i;
            for (i = 0; i < grouplist.Length; i++)
            {
                cbgruppe.Items.Add(grouplist[i]);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtstreamname.Text == "" || txtstreamurl.Text == "")
            {
                MessageBox.Show("Bitte Streamname und StreamURL eingeben!");
                return;
            }
            streamname = txtstreamname.Text;
            streamurl = txtstreamurl.Text;
            if (cbfavorit.Checked == true) favorit = "j"; else favorit = "n";
            changes = true;
            this.Close();
        }

        private void cbgruppe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbgruppe.Text == "")
            {
                MessageBox.Show("Gruppe auswählen oder neue Gruppe erstellen!");
                return;
            }

            if (cbgruppe.Text == "<Neu>") //Wenn eine neue Gruppe erstellt werden soll
            {
                gruppe = InputBoxSharpClass.InputBox("Gruppenname", "Neue Gruppe");
                if (gruppe == "") //Wenn gar keine Gruppe erstellt wurde
                {
                    return;
                }
                cbgruppe.Items.Add(gruppe);
                cbgruppe.Text = gruppe;
                newgroup = true;
            }
            else //Wenn eine Gruppe ausgewählt wurde
            {
                gruppe = cbgruppe.Text;
                newgroup = false;
            }
        }


    }
}
