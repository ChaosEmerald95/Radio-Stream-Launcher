using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InputBoxSharp
{
    partial class InputBoxSharp : Form
    {
        string _defaultresponse = "";
        string _response;

        /// <summary>
        /// Erstellt eine neue Instanz von InputBoxSharp
        /// </summary>
        public InputBoxSharp(string prompt, string title, string defaultresponse)
        {
            InitializeComponent();
            txtinput.Text = "";
            _response = _defaultresponse;
            description = prompt;
            this.title = title;
            this.defaultresponse = defaultresponse;
        }

        /// <summary>
        /// Erstellt eine neue Instanz von InputBoxSharp
        /// </summary>
        public InputBoxSharp(string prompt, string title, string defaultresponse, bool pwchar)
        {
            InitializeComponent();
            txtinput.Text = "";
            _response = _defaultresponse;
            description = prompt;
            this.title = title;
            this.defaultresponse = defaultresponse;
            //Passwordchar
            if (pwchar == true) txtinput.PasswordChar = '*';
            if (pwchar == false) txtinput.PasswordChar = ' ';
        }

        /// <summary>
        /// Erstellt eine neue Instanz von InputBoxSharp
        /// </summary>
        public InputBoxSharp(string prompt, string title, string defaultresponse, bool pwchar, int XPos, int YPos)
        {
            InitializeComponent();
            txtinput.Text = "";
            _response = _defaultresponse;
            description = prompt;
            this.title = title;
            this.defaultresponse = defaultresponse;
            //Passwordchar
            if (pwchar == true) txtinput.PasswordChar = '*';
            if (pwchar == false) txtinput.PasswordChar = ' ';
            this.Location = new Point(XPos, YPos); 
        }

        /// <summary>
        /// Legt den Title des Fensters fest
        /// </summary>
        public string title
        {
            set 
            {
                if (value == "")
                {
                    this.Text = System.Reflection.Assembly.GetExecutingAssembly().FullName;
                }
                else
                {
                    this.Text = value;
                }
            } 
        }

        /// <summary>
        /// Legt die Beschreibung der InputBox fest
        /// </summary>
        public string description
        {
            set 
            {
                lbdescription.Text = "";
                string[] lines = value.Split(System.Text.Encoding.ASCII.GetChars(new byte[] {13,10}));
                int i;
                for (i = 0; i < lines.Length; i++)
                {
                    lbdescription.Text = lbdescription.Text + lines[i] + Environment.NewLine;
                }
            }
        }


        /// <summary>
        /// Legt den Standardrückgabewert fest
        /// </summary>
        public string defaultresponse
        {
            set { txtinput.Text = value; }
        }

        private void btnabort_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        
        /// <summary>
        /// Gibt die Antwort aus der InputBox zurück
        /// </summary>
        /// <returns></returns>
        public string Response()
        {
            return _response; 
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            _response = txtinput.Text;
            this.Close(); 
        }
    }
}
