using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Radio_Stream_Launcher
{
    class configuration
    {
        private string _inipfad;
        
        //Konfigurationsvariablen
        private string _ircpfad = string.Empty;
        private string _streampfad = string.Empty;
        private bool _externplayer = false; //false=Interner Player, true=Externer Player (welcher die m3u-Datei standardmäßig öffnet)
        
        //Proxy Settings
        private bool _proxyon = false;
        private string _proxyname = string.Empty;
        private int _proxyport = 0;
        private bool _proxybypass = false;

        /// <summary>
        /// Erstellt eine neue Instanz von Konfiguration
        /// </summary>
        /// <param name="configpfad"></param>
        public configuration()
        {
            _inipfad = Directory.GetCurrentDirectory() + "/config.ini";
            if (File.Exists(_inipfad ) == false) GenerateConfig();
        }

        /// <summary>
        /// Erstellt eine neue Instanz von Konfiguration
        /// </summary>
        /// <param name="configpfad">Der Pfad zur Konfigurationsdatei</param>
        public configuration(string configpfad)
        {
            _inipfad = configpfad;
            if (File.Exists(_inipfad ) == false) GenerateConfig();
        }

        /// <summary>
        /// Erstellt die Konfigurationsdatei neu mit den Standardeinstellungen
        /// </summary>
        public void GenerateConfig()
        {
            StreamWriter sw = new StreamWriter(_inipfad);
            sw.WriteLine("IRC-Pfad =  ");
            sw.WriteLine("Streams = "+Directory.GetCurrentDirectory() + @"\streams.rsls");
            sw.WriteLine("Player = 0");
            sw.WriteLine("Proxy-Enabled = 0");
            sw.WriteLine("Proxy-Name =  ");
            sw.WriteLine("Proxy-Port = 0");
            sw.WriteLine("Proxy-Bypass = 0");
            sw.Close();
        }

        /// <summary>
        /// Lädt die Konfiguration und schreibt diese in die Variablen
        /// </summary>
        public void LoadConfiguration()
        {
            StreamReader sr = new StreamReader(_inipfad);
            _ircpfad = GetValue(sr.ReadLine()).Trim();
            _streampfad = GetValue(sr.ReadLine()).Trim();
            _externplayer = IntToBool(Convert.ToInt32(GetValue(sr.ReadLine())));
            _proxyon = IntToBool(Convert.ToInt32(GetValue(sr.ReadLine())));
            _proxyname = GetValue(sr.ReadLine()).Trim();
            _proxyport = Convert.ToInt32(GetValue(sr.ReadLine()));
            _proxybypass = IntToBool(Convert.ToInt32(GetValue(sr.ReadLine())));
            sr.Close(); 
        }

        /// <summary>
        /// Wandelt einen Wert vom Typ Bool in den Typ Integer um
        /// </summary>
        /// <param name="value">Der zu umwandelnde Wert</param>
        /// <returns></returns>
        private int BoolToInt(bool value)
        {
            if (value == true)
                return 1;
            else
                return 0;            
        }

        /// <summary>
        /// Wandelt einen Wert vom Typ Integer in den Typ Bool um
        /// </summary>
        /// <param name="value">Der zu umwandelnde Wert</param>
        /// <returns></returns>
        private bool IntToBool(int value)
        {
            if (value == 1)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Gibt den Value aus der Zeile aus
        /// </summary>
        /// <param name="configvalue">Die Zeile, wo der Wert enthalten ist</param>
        /// <returns></returns>
        private string GetValue(string configvalue)
        {
            string h = configvalue;
            return h.Substring(h.IndexOf("=") + 2);
        }

        /// <summary>
        /// Ruft den Wert des IRC-Pfads ab oder legt diesen fest
        /// </summary>
        public string IRCPfad
        {
            get { return _ircpfad; }
            set { _ircpfad = value; }
        }

        /// <summary>
        /// Ruft den Wert des Stream-Pfads ab oder legt diesen fest
        /// </summary>
        public string StreamPfad
        {
            get { return _streampfad; }
            set { _streampfad = value; }
        }

        /// <summary>
        /// Ruft den Wert ab, was für ein Player verwendet werden soll, oder legt diesen fest
        /// </summary>
        public bool ExternerPlayer
        {
            get { return _externplayer; }
            set { _externplayer = value; }
        }

        /// <summary>
        /// Ruft den Wert ab, ob ein Proxy verwendet werden soll, oder legt diesen fest
        /// </summary>
        public bool ProxyOn
        {
            get { return _proxyon; }
            set { _proxyon = value; }
        }

        /// <summary>
        /// Ruft den Proxy-Namen ab oder legt diesen fest
        /// </summary>
        public string ProxyName
        {
            get { return _proxyname; }
            set { _proxyname = value; }
        }

        /// <summary>
        /// Ruft den Proxy-Port ab oder legt diesen fest
        /// </summary>
        public int ProxyPort
        {
            get { return _proxyport; }
            set { _proxyport = value; }
        }

        /// <summary>
        /// Ruft den Wert ab, ob der Proxy die lokalen Adressen umgehen soll, oder legt diesen fest
        /// </summary>
        public bool ProxyBypass
        {
            get { return _proxybypass; }
            set { _proxybypass = value; }
        }

        /// <summary>
        /// Schreibt die Konfiguration in die Datei
        /// </summary>
        public void WriteConfig()
        {
            StreamWriter sw = new StreamWriter(_inipfad);
            sw.WriteLine("IRC-Pfad = " + _ircpfad);
            sw.WriteLine("Streams = "+ _streampfad);
            sw.WriteLine("Player = " + Convert.ToString(BoolToInt(_externplayer)));
            sw.WriteLine("Proxy-Enabled = "+Convert.ToString(BoolToInt(_proxyon )));
            sw.WriteLine("Proxy-Name = "+_proxyname );
            sw.WriteLine("Proxy-Port = "+ Convert.ToString(_proxyport ));
            sw.WriteLine("Proxy-Bypass = "+Convert.ToString(BoolToInt(_proxybypass)));
            sw.Close();
        }
    }
}