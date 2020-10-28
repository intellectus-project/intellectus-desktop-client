using EmotionRecognition.Listeners;
using EmotionRecognition.Wrapper;
using SoundRecorder.SoundListeners;
using SoundRecorder.SoundRecorders;
using Suggestions;
using Suggestions.Systems;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace intellectus_desktop_client.Services
{
    public static class Recording
    {
        private readonly static string RecordingsPath = "/Grabaciones/";

        public static ISoundSource OperatorRecorder;
        public static ISoundSource ConsultantRecorder;
        public static string operatorName = "Pablo Fernandez";

        public static SoundFileWriter OperatorWriter;
        public static SoundFileWriter ConsultantWriter;

        private static string operatorTimestamp;
        private static string consultantTimestamp;

        private static SuggestionsSystem suggestionsSystem;
        private static VokaturiSingleExtractor operatorSingleExtractor; 

        public static void StartRecording(ISuggestionsListener suggestionListener)
        {
            CreateRecordingsPath();

            InitializeOperatorRecorder(suggestionListener);
            InitializeConsultantRecorder();

            ConsultantRecorder.Start();
            OperatorRecorder.Start();
        }


        public static void StopRecording()
        {
            ConsultantRecorder.Stop();
            OperatorRecorder.Stop();
            OperatorWriter.Close();
            ConsultantWriter.Close();
        }

        private static void InitializeOperatorRecorder(ISuggestionsListener suggestionListener)
        {
            var waveFormat = new NAudio.Wave.WaveFormat(44100, 1);
            OperatorRecorder = new InputSoundSource(waveFormat, 0);

            operatorTimestamp = DateTime.Now.ToFileTimeUtc().ToString();
            OperatorWriter = new SoundFileWriter(FormatPath("operator", operatorName, operatorTimestamp), waveFormat);
            var voiceListener = new VoiceListener(waveFormat, 10f);

            OperatorRecorder.AddListener(OperatorWriter);
            OperatorRecorder.AddListener(voiceListener);

            operatorSingleExtractor = new VokaturiSingleExtractor();
            suggestionsSystem = new BaseSuggestionsSystem();

            voiceListener.Subscribe(suggestionsSystem);
            voiceListener.Subscribe(operatorSingleExtractor);

            suggestionsSystem.Subscribe(suggestionListener);
        }

        private static void InitializeConsultantRecorder()
        {
            ConsultantRecorder = new OutputSoundSource();

            consultantTimestamp = DateTime.Now.ToFileTimeUtc().ToString();
            ConsultantWriter = new SoundFileWriter(FormatPath("consultant", consultantTimestamp), ConsultantRecorder.GetWaveFormat());
            ConsultantRecorder.AddListener(ConsultantWriter);
        }

        public static EmotionsProbabilities ExtractOperatorEmotions()
        {
            string sourcePath = FormatPath("operator", operatorName, operatorTimestamp);
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
            string sourcePath = FormatPath("consultant", consultantTimestamp);
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

        private static void CreateRecordingsPath()
        {
            var path = DirectoryPath();
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        private static string DirectoryPath() => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + RecordingsPath;

        public static float Rating => suggestionsSystem.Rating();

        public static EmotionsProbabilities OperatorLastStats => operatorSingleExtractor.Extraction.Emotions;

        private static string FormatPath(string baseFileName, string timestamp)
        {
            return string.Format("{0}{1}_{2}.wav", DirectoryPath(), baseFileName, timestamp);
        }

        private static string FormatPath(string baseFileName, string name, string timestamp)
        {
            return string.Format("{0}{1}_{2}_{3}.wav",  DirectoryPath(), baseFileName, name, timestamp);
        }



    }
}
