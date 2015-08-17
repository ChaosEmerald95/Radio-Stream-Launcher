using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Radio_Stream_Launcher
{
    class StreamList
    {
        private string _pfad = "";
        private int _cursor = 0;
        private DataTable _dt;
        private DataRow _row;

        /// <summary>
        /// Erstellt eine neue Instanz von StreamList
        /// </summary>
        /// <param name="dateipfad">Der Pfad zur Streamdatei</param>
        public StreamList(string dateipfad)
        {
            _pfad = dateipfad;
            _dt = new DataTable();
            PrepareDataTable();
        }

        /// <summary>
        /// Ruft den Dateipfad ab oder legt diesen fest
        /// </summary>
        public string Dateipfad
        {
            get { return _pfad; }
            set { _pfad = value;  }
        }

        /// <summary>
        /// Erstellt die Spalten für die DataTable
        /// </summary>
        private void PrepareDataTable()
        {
            _dt.Columns.Add("Streamname");
            _dt.Columns.Add("Stream-URL");
            _dt.Columns.Add("Gruppe");
            _dt.Columns.Add("Favorite");
        }

        /// <summary>
        /// Lädt die Daten aus der Datei für die Verarbeitung
        /// </summary>
        /// <returns></returns>
        public void LoadData()
        {
            if (File.Exists(_pfad ) == false)
            {
                return;
            }
            _dt.Rows.Clear();
            //Daten werden geladen
            int linecount = GetLines(_pfad); //Gibt die Anzahl der Zeilen zurück
            StreamReader sr = new StreamReader(_pfad); //Streamreader wird geöffnet
            int i, j;
            //Daten werden geladen
            for (i = 0; i < linecount; i++)
            {
                _row = _dt.NewRow();
                string[] streamdata = sr.ReadLine().Split(";".ToCharArray(),StringSplitOptions.None); //Streamdaten getrennt
                for (j = 0; j < streamdata.Length; j++ )
                {
                    _row[j] = streamdata[j];
                }
                _dt.Rows.Add(_row);
            }
            sr.Close();
            DetectOldVersion();
        }

        /// <summary>
        /// Gibt die Anzahl der Zeilen in einer Datei zurück
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        private int GetLines(string FileName)
        {
            string[] lines = File.ReadAllText(FileName, System.Text.Encoding.Default).Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            return lines.Length;
        }

        /// <summary>
        /// Ruft die Anzahl der Zeilen in der DataTable ab
        /// </summary>
        public int RecordCount
        {
            get { return _dt.Rows.Count; }
        }

        /// <summary>
        /// Ruft die Anzahl der Spalten in der DataTable ab
        /// </summary>
        public int ColumnCount
        {
            get { return _dt.Columns.Count; }
        }

        /// <summary>
        /// Fügt einen neuen Stream hinzu
        /// </summary>
        /// <param name="streamname">Der Name des Streams</param>
        /// <param name="streamurl">Die StreamURL</param>
        public void AddEntry(string streamname, string streamurl, string gruppe, string favorite)
        {
            _row = _dt.NewRow();
            _row[0] = streamname;
            _row[1] = streamurl;
            _row[2] = gruppe;
            _row[3] = favorite; 
            _dt.Rows.Add(_row);
        }

        /// <summary>
        /// Löscht den angegebenen Stream und gibt das Ergebnis zurück
        /// </summary>
        /// <param name="streamname">Der Name des Streams</param>
        /// <returns></returns>
        public bool DeleteStream(string streamname)
        {
            int i;
            for (i = 0; i < RecordCount; i++)
            {
                if (GetValueExt(i,0) == streamname)
                {
                    _dt.Rows.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Löscht den angegebenen Stream und gibt das Ergebnis zurück
        /// </summary>
        /// <param name="streamname">Der Name des Streams</param>
        /// <param name="group">Der Name der Gruppe</param>
        /// <returns></returns>
        public bool DeleteStream(string streamname, string group)
        {
            int i;
            for (i = 0; i < RecordCount; i++)
            {
                if (GetValueExt(i, 0) == streamname && GetValueExt(i,2) == group)
                {
                    _dt.Rows.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Setzt den DataRow-Cursor auf die folgende Zeile
        /// </summary>
        /// <param name="rowindex">Der null-basierte Index der Zeile</param>
        private void MoveTo(int rowindex)
        {
            if (rowindex > RecordCount - 1)
            {
                _row = _dt.Rows[RecordCount - 1];
                _cursor = RecordCount - 1;
            }
            else if (rowindex < 0)
            {
                _row = _dt.Rows[0];
                _cursor = 0;
            }
            else
            {
                _row = _dt.Rows[rowindex];
                _cursor = rowindex; 
            }
             
        }

        /// <summary>
        /// Gibt den Wert aus der jeweiligen Zeile und Spalte zurück
        /// </summary>
        /// <param name="columnindex">Der null-basierte Index der Spalte</param>
        /// <returns></returns>
        private string GetValue(int columnindex)
        {
            if (columnindex > ColumnCount - 1)
            {
                return _row[ColumnCount - 1].ToString();
            }
            else if (columnindex < 0)
            {
                return _row[0].ToString();
            }
            else
            {
                return _row[columnindex].ToString();
            }
        }

        /// <summary>
        /// Gibt den Wert aus der jeweiligen Zeile und Spalte zurück
        /// </summary>
        /// <param name="rowindex">Der null-basierte Index der Zeile</param>
        /// <param name="columnindex">Der null-basierte Index der Spalte</param>
        /// <returns></returns>
        public string GetValueExt(int rowindex, int columnindex)
        {
            MoveTo(rowindex);
            return GetValue(columnindex);
        }

        /// <summary>
        /// Schreibt die Daten in die jeweilige Spalte des Datensatzes
        /// </summary>
        /// <param name="columnindex">Der null-basierte Index der Spalte</param>
        /// <param name="value">Der zu speichernde Wert</param>
        private void WriteRowData(int columnindex, string value)
        {
            if (columnindex > ColumnCount - 1)
            {
                _row[ColumnCount - 1] = value;
            }
            else if (columnindex < 0)
            {
                _row[0] = value;
            }
            else
            {
                _row[columnindex] = value;
            }
        }

        /// <summary>
        /// Schreibt die Daten in die jeweilige Spalte des Datensatzes
        /// </summary>
        /// <param name="columnindex">Der null-basierte Index der Spalte</param>
        /// <param name="value">Der zu speichernde Wert</param>
        public void WriteRowDataExt(int rowindex, int columnindex, string value)
        {
            MoveTo(rowindex);
            WriteRowData(columnindex, value);
        }

        /// <summary>
        /// Schreibt die Daten in die Datei
        /// </summary>
        /// <returns></returns>
        public bool WriteToFile()
        {
            StreamWriter sw = new StreamWriter(_pfad);
            int i, j;
            for (i = 0; i < RecordCount; i++)
            {
                string sstring = string.Empty;
                _row = _dt.Rows[i];
                for (j = 0; j < ColumnCount; j++)
                {
                    if (j == 0)
                    {
                        sstring = _row[j].ToString();
                    }
                    else
                    {
                        sstring = sstring + ";" + _row[j].ToString();
                    }
                }
                sw.WriteLine(sstring);
            }
            sw.Close();
            return true;
        }

        /// <summary>
        /// Gilt dann ab Version 1.2 von Radio Stream Launcher. Wenn die Streamliste dem alten Format entspricht, wird es geupdated
        /// </summary>
        private void DetectOldVersion()
        {
            _row = _dt.Rows[0]; //es wird über den ersten Eintrag überprüft, ob geupdated werden muss
            if (_row[3].ToString() == "")
            {
                MessageBox.Show("Die Streamliste wird für die Verwendung geupdated");
                int i;
                for (i = 0; i < RecordCount; i++)
                {
                    WriteRowDataExt(i, 3, "n"); //Kein Eintrag wird mit Favorit versehen
                }
                WriteToFile(); //Neue Daten in Datei schreiben
            }
        }
    }
}
