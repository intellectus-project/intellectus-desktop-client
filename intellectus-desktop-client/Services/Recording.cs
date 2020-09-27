using EmotionRecognition.Listeners;
using EmotionRecognition.Wrapper;
using SoundRecorder.SoundListeners;
using SoundRecorder.SoundRecorders;
using Suggestions;
using Suggestions.Systems;
using System;
using System.Collections.Generic;
using System.Text;

namespace intellectus_desktop_client.Services
{
    public static class Recording
    {
        public static ISoundSource OperatorRecorder;
        public static ISoundSource ConsultantRecorder;
        public static string operatorName = "Pablo Fernandez";
        public static ISoundListener OperatorWriter;
        public static ISoundListener ConsultantWriter;

        public static void StartRecording(ISuggestionsListener suggestionListener)
        {
            InitializeOperatorRecorder(suggestionListener);
            InitializeConsultantRecorder();

            ConsultantRecorder.Start();
            OperatorRecorder.Start();
        }


        public static void StopRecording()
        {
            ConsultantRecorder.Stop();
            OperatorRecorder.Stop();
        }

        private static void InitializeOperatorRecorder(ISuggestionsListener suggestionListener)
        {
            var waveFormat = new NAudio.Wave.WaveFormat(44100, 1);
            OperatorRecorder = new InputSoundSource(waveFormat, 0);
            OperatorWriter = new SoundFileWriter(FormatPath("/Grabaciones/operator", operatorName), waveFormat);
            var voiceListener = new VoiceListener(waveFormat, 10f);

            OperatorRecorder.AddListener(OperatorWriter);
            OperatorRecorder.AddListener(voiceListener);
            

            var suggestionsSystem = new BaseSuggestionsSystem();
            voiceListener.Subscribe(suggestionsSystem);

            suggestionsSystem.Subscribe(suggestionListener);
        }

        private static void InitializeConsultantRecorder()
        {
            ConsultantRecorder = new OutputSoundSource();
            ConsultantWriter = new SoundFileWriter(FormatPath("/Grabaciones/consultant"), ConsultantRecorder.GetWaveFormat());
            ConsultantRecorder.AddListener(ConsultantWriter);
        }

        public static EmotionsProbabilities ExtractOperatorEmotions()
        {
            string sourcePath = FormatPath("/Grabaciones/operator", operatorName);
            var input = new FileSoundSource(sourcePath);

            float seconds = (float)input.FileSize / input.GetWaveFormat().AverageBytesPerSecond;

            VoiceListener listener = new VoiceListener(input.GetWaveFormat(), seconds);

            var extractor = new VokaturiSingleExtractor();
            listener.Subscribe(extractor);

            input.AddListener(listener);
            input.Start();
            input.Stop();

            return extractor.Extraction.Emotions;
        }

        public static EmotionsProbabilities ExtractConsultantEmotions()
        {
            string sourcePath = FormatPath("/Grabaciones/consultant");
            var input = new FileSoundSource(sourcePath);

            float seconds = (float)input.FileSize / input.GetWaveFormat().AverageBytesPerSecond;

            VoiceListener listener = new VoiceListener(input.GetWaveFormat(), seconds);

            var extractor = new VokaturiSingleExtractor();
            listener.Subscribe(extractor);

            input.AddListener(listener);
            input.Start();
            input.Stop();

            return extractor.Extraction.Emotions;
        }



        private static string FormatPath(string basePath)
        {
            return string.Format("{0}" + basePath + "_{1}.wav", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), DateTime.Now.ToFileTimeUtc());
        }

        private static string FormatPath(string basePath, string name)
        {
            return string.Format("{0}" + basePath + "_{1}_{2}.wav", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), name, DateTime.Now.ToFileTimeUtc());
        }


    }
}
