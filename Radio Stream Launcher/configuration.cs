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
        ConfigData.ConfigurationData d;

        /// <summary>
        /// Erstellt eine neue Instanz von Konfiguration
        /// </summary>
        /// <param name="configpfad"></param>
        public configuration()
        {
            _inipfad = Directory.GetCurrentDirectory() + "/config.ini";
            if (File.Exists(_inipfad) == false) GenerateConfig();
            d = new ConfigData.ConfigurationData();
        }

        /// <summary>
        /// Erstellt eine neue Instanz von Konfiguration
        /// </summary>
        /// <param name="configpfad">Der Pfad zur Konfigurationsdatei</param>
        public configuration(string configpfad)
        {
            _inipfad = configpfad;
            if (File.Exists(_inipfad) == false) GenerateConfig();
            d = new ConfigData.ConfigurationData();
        }

        /// <summary>
        /// Erstellt die Konfigurationsdatei neu mit den Standardeinstellungen
        /// </summary>
        public void GenerateConfig()
        {
            StreamWriter sw = new StreamWriter(_inipfad);
            sw.WriteLine("IRC-Pfad =  ");
            sw.WriteLine("Streams = " + Directory.GetCurrentDirectory() + @"\streams.rsls");
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
            IRCPfad = GetValue(sr.ReadLine()).Trim();
            StreamPfad = GetValue(sr.ReadLine()).Trim();
            ExternerPlayer = IntToBool(Convert.ToInt32(GetValue(sr.ReadLine())));
            ProxyOn = IntToBool(Convert.ToInt32(GetValue(sr.ReadLine())));
            ProxyName = GetValue(sr.ReadLine()).Trim();
            ProxyPort = Convert.ToInt32(GetValue(sr.ReadLine()));
            ProxyBypass = IntToBool(Convert.ToInt32(GetValue(sr.ReadLine())));
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
            get { return d._ircpfad; }
            set { d._ircpfad = value; }
        }

        /// <summary>
        /// Ruft den Wert des Stream-Pfads ab oder legt diesen fest
        /// </summary>
        public string StreamPfad
        {
            get { return d._streampfad; }
            set { d._streampfad = value; }
        }

        /// <summary>
        /// Ruft den Wert ab, was für ein Player verwendet werden soll, oder legt diesen fest
        /// </summary>
        public bool ExternerPlayer
        {
            get { return d._externplayer; }
            set { d._externplayer = value; }
        }

        /// <summary>
        /// Ruft den Wert ab, ob ein Proxy verwendet werden soll, oder legt diesen fest
        /// </summary>
        public bool ProxyOn
        {
            get { return d._proxyon; }
            set { d._proxyon = value; }
        }

        /// <summary>
        /// Ruft den Proxy-Namen ab oder legt diesen fest
        /// </summary>
        public string ProxyName
        {
            get { return d._proxyname; }
            set { d._proxyname = value; }
        }

        /// <summary>
        /// Ruft den Proxy-Port ab oder legt diesen fest
        /// </summary>
        public int ProxyPort
        {
            get { return d._proxyport; }
            set { d._proxyport = value; }
        }

        /// <summary>
        /// Ruft den Wert ab, ob der Proxy die lokalen Adressen umgehen soll, oder legt diesen fest
        /// </summary>
        public bool ProxyBypass
        {
            get { return d._proxybypass; }
            set { d._proxybypass = value; }
        }

        /// <summary>
        /// Schreibt die Konfiguration in die Datei
        /// </summary>
        public void WriteConfig()
        {
            StreamWriter sw = new StreamWriter(_inipfad);
            sw.WriteLine("IRC-Pfad = " + IRCPfad);
            sw.WriteLine("Streams = " + StreamPfad);
            sw.WriteLine("Player = " + Convert.ToString(BoolToInt(ExternerPlayer)));
            sw.WriteLine("Proxy-Enabled = " + Convert.ToString(BoolToInt(ProxyOn)));
            sw.WriteLine("Proxy-Name = " + ProxyName);
            sw.WriteLine("Proxy-Port = " + Convert.ToString(ProxyPort));
            sw.WriteLine("Proxy-Bypass = " + Convert.ToString(BoolToInt(ProxyBypass)));
            sw.Close();
        }

        /// <summary>
        /// Gibt die aktuelle Konfiguration zurück
        /// </summary>
        /// <returns></returns>
        public ConfigData.ConfigurationData GetConfigData()
        {
            return d;
        }

        /// <summary>
        /// Konfiguration wird überschrieben
        /// </summary>
        /// <param name="Data">Das Objekt vom Typ ConfigurationData mit der Konfiguration</param>
        public void SetConfigData(ConfigData.ConfigurationData Data)
        {
            d = Data;
            WriteConfig();
        }
    }
}