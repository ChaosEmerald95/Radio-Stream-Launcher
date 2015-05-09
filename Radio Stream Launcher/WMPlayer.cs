using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Radio_Stream_Launcher
{
    class WMPlayer
    {
        private WMPLib.WindowsMediaPlayer _wmplayer;
        private string _streamurl = "";
        private PlayStatus _playstatus;

        /// <summary>
        /// Erstellt eine neue Instanz von WMPlayer
        /// </summary>
        public WMPlayer()
        {
            _wmplayer = new WMPLib.WindowsMediaPlayer(); //Für den Media Player
            _playstatus = PlayStatus.Stop;  
        }

        /// <summary>
        /// Ruft den Wert der StreamURL ab oder legt diesen fest
        /// </summary>
        public string Streamurl
        {
            get { return _streamurl; }
            set 
            { 
                _streamurl = value;
                _wmplayer.URL = value;
            }
        }

        /// <summary>
        /// Ruft den Status von der WMP-COM ab
        /// </summary>
        public string status
        {
            get { return _wmplayer.status; }
        }

        /// <summary>
        /// Ruft die Lautstärke des Sounds ab oder legt diesen fest
        /// </summary>
        public int Volume
        {
            get { return _wmplayer.settings.volume; }
            set { _wmplayer.settings.volume = value; }
        }

        /// <summary>
        /// Gibt den aktuelen Status des Streams an.
        /// </summary>
        private enum PlayStatus
        {
            Stop = 0,
            Play = 1,
            Pause = 2
        }

        /// <summary>
        /// Startet den Stream und gibt das Result zurück
        /// </summary>
        /// <returns></returns>
        public bool Play()
        {    
            //Prüfen, ob vorher eine Stream-URL festgelegt wurde
            if (_streamurl == "")
            {
                return false;
            }

            //Jetzt soll der Stream abgespielt werden. Bei Fehler abspielen unterbinden
            try
            {
                _wmplayer.controls.play();
                _playstatus = PlayStatus.Play; 
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Es ist ein Fehler aufgetreten
                return false;
            }
        }
           
        /// <summary>
        /// Pausiert den Stream und gibt das Result zurück
        /// </summary>
        /// <returns></returns>
        public bool Pause()
        {
            //Aktuellen Status des Streams prüfen
            if (_playstatus == PlayStatus.Play )
            {
                _wmplayer.controls.pause();
                _playstatus = PlayStatus.Pause;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Stoppt den Stream und gibt das Result zurück
        /// </summary>
        /// <returns></returns>
        public bool Stop()
        {
            //Aktuellen Status des Streams prüfen
            if (_playstatus == PlayStatus.Play || _playstatus == PlayStatus.Pause )
            {
                _wmplayer.controls.stop();
                _playstatus = PlayStatus.Stop ;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gibt zurück, ob gerade der Stream abgespielt wird
        /// </summary>
        /// <returns></returns>
        public bool IsPlayed()
        {
            if(_playstatus == PlayStatus.Play )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region Proxy
        /// <summary>
        /// Bestimmt, ob und wie der Proxy genutzt werden soll (BrowserSettings nur bei HTTP)
        /// </summary>
        public enum ProxySetting
        {
            NoProxy,
            BrowserSettings,
            ManualSettings,
            AutoDetectSettings
        }

        /// <summary>
        /// Ruft den Proxy-Namen des WMP-Objekts ab oder legt diesen fest
        /// </summary>
        public string ProxyName
        {
            get { return _wmplayer.network.getProxyName("HTTP"); }
            set { _wmplayer.network.setProxyName("HTTP", value); }
        }

        /// <summary>
        /// Ruft den Proxy-Port des WMP-Objekts ab oder legt diesen fest
        /// </summary>
        public int ProxyPort
        {
            get { return _wmplayer.network.getProxyPort("HTTP"); }
            set { _wmplayer.network.setProxyPort("HTTP", value); }
        }

        /// <summary>
        /// Ruft den Wert ab, ob beim Proxy das Umgehen von lokalen Adressen aktiviert ist oder legt diesen fest
        /// </summary>
        public bool ProxyBypassForLocal
        {
            get { return _wmplayer.network.getProxyBypassForLocal("HTTP"); }
            set { _wmplayer.network.setProxyBypassForLocal("HTTP", value); }
        }

        /// <summary>
        /// Ruft die ProxySettings für das WMP-Objekt ab
        /// </summary>
        public int GetProxySettings
        {
            get { return _wmplayer.network.getProxySettings("HTTP"); }
        }

        /// <summary>
        /// Legt die ProxySettings für das WMP-Objekt fest
        /// </summary>
        public ProxySetting SetProxySettings
        {
            set
            {
                int v = 0;
                if (value == ProxySetting.NoProxy) v = 0;
                if (value == ProxySetting.BrowserSettings ) v = 1;
                if (value == ProxySetting.ManualSettings ) v = 2;
                if (value == ProxySetting.AutoDetectSettings ) v = 3;
                _wmplayer.network.setProxySettings("HTTP",v); 
            }
        }
        #endregion
    }
}
