using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_Stream_Launcher
{
    public static class ConfigData
    {
        public struct ConfigurationData
        {
            //Konfigurationsvariablen
            public string _ircpfad;
            public string _streampfad;
            public bool _externplayer; //false=Interner Player, true=Externer Player (welcher die m3u-Datei standardmäßig öffnet)

            //Proxy Settings
            public bool _proxyon;
            public string _proxyname;
            public int _proxyport;
            public bool _proxybypass;
        }
    }
}
