using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Radio_Stream_Launcher
{
    class ExtPlayer
    {
        private string _streamurl = "";
        private string _tmpm3u = Directory.GetCurrentDirectory() + "/stream.m3u";
        Process p;
        private PlayStatus _playstatus;

        /// <summary>
        /// Erstellt eine neue Instanz von ExtPlayer
        /// </summary>
        public ExtPlayer()
        {
            p = new Process();
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
                p.StartInfo.FileName = _tmpm3u ;
            }
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
            if (_streamurl == "") return false; //Es muss eine Stream-URL angegeben sein

            try
            {
                //Stream-URL wird in temporäre Datei geschrieben
                StreamWriter sw = new StreamWriter(_tmpm3u);
                sw.WriteLine(_streamurl );
                sw.Close();

                //Prozess wird gestartet. Dabei wird der Player gestartet, der auf die Erweiterung m3u assoziiert ist
                p.Start();
                return true;
            }
            catch
            {
                return false; //Wenn ein Fehler unterlaufen ist
            }
        }

        /// <summary>
        /// Stoppt den Stream und gibt das Result zurück
        /// </summary>
        /// <returns></returns>
        public bool Stop()
        {
            //Aktuellen Status des Streams prüfen
            if (_playstatus == PlayStatus.Play || _playstatus == PlayStatus.Pause)
            {
                try
                {
                    p.Close(); //Der Prozess soll heruntergefahren werden. Falls der Prozess bereits aus ist, ist es nicht schlimm
                }
                catch { }
                _playstatus = PlayStatus.Stop;
                return true;
            }
            else { return false; }
        }

        /// <summary>
        /// Gibt zurück, ob gerade der Stream abgespielt wird
        /// </summary>
        /// <returns></returns>
        public bool IsPlayed()
        {
            if (_playstatus == PlayStatus.Play)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gibt zurück, ob der Prozess noch läuft
        /// </summary>
        /// <returns></returns>
        public bool ProcessAlive()
        {
            p.Refresh(); //Damit die neuesten Informationen vorhanden sind
            try { Process.GetProcessById(p.Id); }
            catch (InvalidOperationException) { return false; }
            catch (ArgumentException) { return false; }
            return true;
        }
    }
}
