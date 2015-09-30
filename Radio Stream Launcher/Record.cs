using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System.IO;

namespace Radio_Stream_Launcher
{
    class Record
    {
        WaveIn wavein; //TODO: WaveIn nimmt zu leise auf. Lautstärke muss irgendwie erhöhbar sein
        WaveFileWriter writer;
        RecordState rcstate = RecordState.Idle; //Nimmt aktuell nichts auf

        public bool IsRecord()
        {
            if (rcstate == RecordState.Record)
                return true;
            else
                return false; 
        }

        public Record()
        {
            wavein = new WaveIn(WaveCallbackInfo.FunctionCallback());
            wavein.DataAvailable += Wavein_DataAvailable;
        }

        private void Wavein_DataAvailable(object sender, WaveInEventArgs e)
        {
            writer.Write(e.Buffer, 0, e.BytesRecorded);
        }

        public void Start()
        {
            if (rcstate == RecordState.Record)
            {
                System.Windows.Forms.MessageBox.Show("Es wird bereits aufgenommen!");
                return;
            }
            writer = null;
            writer = new WaveFileWriter(Directory.GetCurrentDirectory() + @"\" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + ".wav", wavein.WaveFormat);
            wavein.StartRecording();
            rcstate = RecordState.Record;
        }

        public void Stopp()
        {
            if (rcstate == RecordState.Idle)
            {
                System.Windows.Forms.MessageBox.Show("Es wird aktuell nichts aufgenommen!");
                return;
            }
            wavein.StopRecording();
            writer.Close();
            rcstate = RecordState.Idle;
        }

        ~Record()
        {
            wavein.Dispose();
            wavein = null;
            try //Falls das Objekt existieren sollte (nicht null)
            {
                writer.Close();
                writer.Dispose();
                writer = null;
            }
            catch { }
        }

        private enum RecordState
        {
            Record,
            Idle
        }
    }
}
