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
    public partial class frmstreammanager : Form
    {
        StreamList sl;
        private int groupindex, entryindex, dbentry;

        public frmstreammanager(string streamlistpfad)
        {
            InitializeComponent();
            sl = new StreamList(streamlistpfad);
            sl.LoadData();
        }

        private void frmstreammanager_Load(object sender, EventArgs e)
        {
            tvstream.Nodes.Clear(); //Das nur der Anfang noch da ist
            int i;
            for (i = 0; i < sl.RecordCount; i++)
            {
                if (TVSearchGroupExists(sl.GetValueExt(i,2)) == false)
                {
                    TVAddGroup(sl.GetValueExt(i, 2));
                }
                TVAddEntry(sl.GetValueExt(i, 0), sl.GetValueExt(i, 2));
            }
            SetComboBox(cbgruppe);
        }

        private void tvstream_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Datensatz mit den Daten zu dem ausgewählten Stream ermitteln
            int i;
            for (i = 0; i < sl.RecordCount; i++)
            {
                if (sl.GetValueExt(i, 0) == e.Node.Text && sl.GetValueExt(i, 2) == e.Node.Parent.Text)
                {
                    txtstreamname.Text = sl.GetValueExt(i, 0);
                    txtstreamurl.Text = sl.GetValueExt(i, 1);
                    cbgruppe.Text = sl.GetValueExt(i, 2);
                    if (sl.GetValueExt(i, 3) == "j") cbfavorit.Checked = true; else cbfavorit.Checked = false;
                    groupindex = e.Node.Parent.Index;
                    entryindex = e.Node.Index;
                    dbentry = i;
                    return;
                }
            }
        }

        private void btnnewstream_Click(object sender, EventArgs e)
        {
            //Array mit Liste aller Gruppen erstellen
            int i;
            string[] groups = new string[tvstream.Nodes.Count];
            for (i = 0; i < tvstream.Nodes.Count; i++)
            {
                groups[i] = tvstream.Nodes[i].Text; 
            }

            frmnewstream frm = new frmnewstream(groups);
            if (frm.ShowDialog() == DialogResult.OK )
            {
                sl.AddEntry(frm.streamname, frm.streamurl, frm.gruppe, frm.favorit);
                if (frm.newgroup == true )
                {
                    TVAddGroup(frm.gruppe);
                }
                TVAddEntry(frm.streamname, frm.gruppe);
            }
            sl.WriteToFile();
            frmstreammanager_Load(this, null);
        }

        private void btndeletestream_Click(object sender, EventArgs e)
        {
            TVDeleteEntry(txtstreamname.Text, groupindex);
            if (tvstream.Nodes[groupindex ].Nodes.Count  == 0)
            {
                TVDeleteGroup(tvstream.Nodes[groupindex].Text);
            }
        }

        private void btneditstream_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < sl.RecordCount; i++)
            {
                if (txtstreamname.Text == sl.GetValueExt(i,0) && sl.GetValueExt(i,2) == tvstream.Nodes[groupindex].Text)
                {
                    tvstream.Nodes[groupindex].Nodes[entryindex].Remove();
                    TVAddEntry(txtstreamname.Text, cbgruppe.Text);
                    sl.WriteRowDataExt(i, 0, txtstreamname.Text);
                    sl.WriteRowDataExt(i, 1, txtstreamurl.Text);
                    sl.WriteRowDataExt(i, 2, cbgruppe.Text);
                    sl.WriteRowDataExt(i, 3, BoolToString(cbfavorit.Checked));
                    ShowData(txtstreamname.Text, cbgruppe.Text, GetGroupIndex(cbgruppe.Text), tvstream.Nodes[GetGroupIndex(cbgruppe.Text)].Nodes.Count - 1);
                    return;
                }
            }
        }

        private void btnsearchstream_Click(object sender, EventArgs e)
        {
            string search = InputBoxSharp.InputBoxSharpClass.InputBox("Suchbegriff:", "Streamsuche");
            int i;
            for (i = 0; i < sl.RecordCount; i++)
            {
                if (sl.GetValueExt(i,0).Contains(search ) == true || sl.GetValueExt(i,1).Contains(search ) == true)
                {
                    txtstreamname.Text = sl.GetValueExt(i, 0);
                    txtstreamurl.Text = sl.GetValueExt(i, 1);
                    cbgruppe.Text = sl.GetValueExt(i, 2);
                    if (sl.GetValueExt(i, 3) == "j") cbfavorit.Checked = true; else cbfavorit.Checked = false;
                    entryindex = GetEntryIndex(txtstreamname.Text, cbgruppe.Text);
                    groupindex = GetGroupIndex(cbgruppe.Text);
                    return;
                }
            }
        }

        private void frmstreammanager_FormClosing(object sender, FormClosingEventArgs e)
        {
            sl.WriteToFile();
        }


        #region  Treeview-Nodes-Funktionen
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

        private void TVDeleteEntry(string streamname, int groupindex)
        {
            sl.DeleteStream(streamname, tvstream.Nodes[groupindex].Text);
            int j;
            for (j = 0; j < tvstream.Nodes[groupindex].Nodes.Count; j++)
            {
                if (tvstream.Nodes[groupindex].Nodes[j].Text == streamname)
                {
                    tvstream.Nodes[groupindex].Nodes[j].Remove();
                    return;
                }
            }
        }

        private void TVDeleteGroup(string gruppe)
        {
            int i, j;
            for (i = 0; i < tvstream.Nodes.Count; i++)
            {
                if (tvstream.Nodes[i].Text == gruppe )
                {
                    for (j = 0; j < tvstream.Nodes[i].Nodes.Count; j++)
                    {
                        TVDeleteEntry(tvstream.Nodes[i].Nodes[j].Text, i);
                    }
                    tvstream.Nodes[i].Remove();
                }
            }
        }
        #endregion

        /// <summary>
        /// Füllt die ComboBox mit den Namen der Gruppen und wählt die Gruppe aus, in welcher sich der Stream befindet
        /// </summary>
        /// <param name="cb">Die ComboBox, die befüllt werden soll</param>
        /// <param name="gruppe">Der Name der Gruppe</param>
        private void SetComboBox(ComboBox cb)
        {
            cb.Items.Clear();
            int i;
            for (i = 0; i < tvstream.Nodes.Count; i++)
            {
                cb.Items.Add(tvstream.Nodes[i].Text);
            }
        }

        private void ShowData(string streamname, string streamgruppe, int gindex, int eindex)
        {
            //Datensatz mit den Daten zu dem ausgewählten Stream ermitteln
            int i;
            for (i = 0; i < sl.RecordCount; i++)
            {
                if (sl.GetValueExt(i, 0) == streamname && sl.GetValueExt(i, 2) == streamgruppe)
                {
                    txtstreamname.Text = sl.GetValueExt(i, 0);
                    txtstreamurl.Text = sl.GetValueExt(i, 1);
                    cbgruppe.Text = sl.GetValueExt(i,2);
                    if (sl.GetValueExt(i, 3) == "j") cbfavorit.Checked = true; else cbfavorit.Checked = false;
                    groupindex = gindex;
                    entryindex = eindex;
                    dbentry = i;
                    return;
                }
            }
        }

        /// <summary>
        /// Gibt den Index der Gruppe in der TreeView zurück
        /// </summary>
        /// <param name="groupname">Der Name der Gruppe</param>
        /// <returns></returns>
        private int GetGroupIndex(string groupname)
        {
            int i;
            for (i = 0; i < tvstream.Nodes.Count; i++)
            {
                if (tvstream.Nodes[i].Text == groupname)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Gibt den Index des Eintrags in der TreeView zurück
        /// </summary>
        /// <param name="streamname">Der Name des Streams</param> 
        /// <param name="groupname">Der Name der Gruppe</param>
        /// <returns></returns>
        private int GetEntryIndex(string streamname, string groupname)
        {
            int i;
            for (i = 0; i < tvstream.Nodes[GetGroupIndex(groupname )].Nodes.Count; i++)
            {
                if (tvstream.Nodes[GetGroupIndex(groupname )].Nodes[i].Text == streamname )
                {
                    return i;
                }
            }
            return -1;
        }

        private string BoolToString(bool value)
        {
            if (value == true) return "j"; else return "n";
        }
    }
}
