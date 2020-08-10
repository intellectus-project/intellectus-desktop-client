using SoundRecorder.SoundListeners;
using SoundRecorder.SoundRecorders;
using System;
using System.Collections.Generic;
using System.Text;

namespace intellectus_desktop_client.Services
{
    public static class Recording
    {
        public static ISoundRecorder OperatorRecorder;
        public static ISoundRecorder ConsultantRecorder;
        public static string operatorName = "Pablo Fernandez";
        public static ISoundListener operatorWriter;
        public static ISoundListener consultantWriter;

        public static void StartRecording()
        {
            InitializeOperatorRecorder();
            InitializeConsultantRecorder();
            ConsultantRecorder.Start();
            OperatorRecorder.Start();
        }


        public static void StopRecording()
        {
            ConsultantRecorder.Stop();
            OperatorRecorder.Stop();
        }

        private static void InitializeOperatorRecorder()
        {
            OperatorRecorder = new InputSoundRecorder();
            OperatorRecorder.Configure(0, new NAudio.Wave.WaveFormat(44100, 1));
            operatorWriter = new SoundFileWriterListener(string.Format("{0}/Grabaciones/operator_{1}_{2}.wav", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), operatorName, DateTime.Now.ToFileTimeUtc()), OperatorRecorder.GetWaveFormat());
            OperatorRecorder.AddListener(operatorWriter);
        }
        private static void InitializeConsultantRecorder()
        {
            ConsultantRecorder = new OutputSoundRecorder();
            ConsultantRecorder.Configure(0, new NAudio.Wave.WaveFormat(44100, 1));
            consultantWriter = new SoundFileWriterListener(string.Format("{0}/Grabaciones/consultant_{1}_{2}.wav", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), operatorName, DateTime.Now.ToFileTimeUtc()), ConsultantRecorder.GetWaveFormat());
            ConsultantRecorder.AddListener(consultantWriter);
        }
    }
}
