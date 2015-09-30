using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics; 

namespace Radio_Stream_Launcher
{
    public partial class frmabout : Form
    {
        public frmabout()
        {
            InitializeComponent();
        }

        private DateTime RetrieveLinkerTimestamp(string filePath)
        {
            const int PeHeaderOffset = 60;
            const int LinkerTimestampOffset = 8;

            byte[] b = new byte[2048];
            Stream s = Stream.Null;
            try
            {
                s = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                s.Read(b, 0, 2048);
            }
            finally
            {
                if ((s != null)) s.Close();
            }

            int i = BitConverter.ToInt32(b, PeHeaderOffset);

            int SecondsSince1970 = BitConverter.ToInt32(b, i + LinkerTimestampOffset);
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0);
            dt = dt.AddSeconds(SecondsSince1970);
            dt = dt.AddHours(TimeZone.CurrentTimeZone.GetUtcOffset(dt).Hours);
            return dt;
        }

        private void frmabout_Load(object sender, EventArgs e)
        {
            FileVersionInfo fvm = FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
            lbversion.Text = "Version " + fvm.ProductVersion.ToString();
            lbbuild.Text = "Build " + RetrieveLinkerTimestamp(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString().Substring(0, 10);
            lbcopyright.Text = fvm.LegalCopyright;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
