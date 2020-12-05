using EmotionRecognition.Listeners;
using EmotionRecognition.Wrapper;
using intellectus_desktop_client.Models;
using SoundRecorder.SoundListeners;
using SoundRecorder.SoundRecorders;
using Suggestions;
using Suggestions.Systems;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace intellectus_desktop_client.Services
{
    public static class Recording
    {
        private readonly static string RecordingsPath = "/Grabaciones/";

        public static ISoundSource OperatorRecorder;
        public static ISoundSource ConsultantRecorder;
        public static string operatorName = string.Format("{0}{1}",Domain.CurrentUser.LastName,Domain.CurrentUser.Name);

        public static SoundFileWriter OperatorWriter;
        public static SoundFileWriter ConsultantWriter;

        private static string operatorTimestamp;
        private static string consultantTimestamp;

        private static SuggestionsSystem suggestionsSystem;
        private static VokaturiSingleExtractor operatorSingleExtractor;

        public static EmotionsProbabilities OperatorProbabilities { get; private set; }
        public static EmotionsProbabilities ConsultantProbabilities { get; private set; }

        public static EmotionsProbabilities OperatorLastStats { get; private set; }

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
            var voiceListener = new VoiceListener(waveFormat, 5f);

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

        private static EmotionsProbabilities ExtractOperatorEmotions()
        {
            string sourcePath = FormatPath("operator", operatorName, operatorTimestamp);
            var input = new FileSoundSource(sourcePath);

            VoiceListener listener = new VoiceListener(input.GetWaveFormat(), (int)input.FileSize);

            var extractor = new VokaturiSingleExtractor();
            listener.Subscribe(extractor);

            input.AddListener(listener);
            input.Start();
            input.Stop();


            return extractor.Extraction.Emotions;
        }

        private static EmotionsProbabilities ExtractConsultantEmotions()
        {
            string sourcePath = FormatPath("consultant", consultantTimestamp);
            var input = new FileSoundSource(sourcePath);

            VoiceListener listener = new VoiceListener(input.GetWaveFormat(), (int)input.FileSize);

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

        public static bool SoundProcessed => operatorSingleExtractor.Extracted;


        private static string FormatPath(string baseFileName, string timestamp)
        {
            return string.Format("{0}{1}_{2}.wav", DirectoryPath(), baseFileName, timestamp);
        }

        private static string FormatPath(string baseFileName, string name, string timestamp)
        {
            return string.Format("{0}{1}_{2}_{3}.wav",  DirectoryPath(), baseFileName, name, timestamp);
        }


        public static void PerformExtraction()
        {
            if(SoundProcessed)
            {
                OperatorProbabilities = ExtractOperatorEmotions();
                ConsultantProbabilities = ExtractConsultantEmotions();
                OperatorLastStats = operatorSingleExtractor.Extraction.Emotions;

                OperatorProbabilities = Sanitize(OperatorProbabilities);
                ConsultantProbabilities = Sanitize(ConsultantProbabilities);
                OperatorLastStats = Sanitize(OperatorLastStats);
            }
        }

        private static EmotionsProbabilities Sanitize(EmotionsProbabilities probabilities)
        {
            double sum = probabilities.Neutrality + probabilities.Happiness + probabilities.Sadness + probabilities.Anger + probabilities.Fear;

            probabilities.Neutrality = Sanitize(probabilities.Neutrality, 5);
            probabilities.Happiness = Sanitize(probabilities.Happiness, 5);
            probabilities.Sadness = Sanitize(probabilities.Sadness, 5);
            probabilities.Anger = Sanitize(probabilities.Anger, 5);
            probabilities.Fear = Sanitize(probabilities.Fear, 5);

            if (AreNear(sum, 0.0))
                probabilities.Neutrality = Math.Max(1.0 - sum, 1.0); 
                
            probabilities = EmotionsProbabilities.Sanitize(probabilities, 1.0, 5);
            
            return probabilities;
        }

        private static double Sanitize(double input, int decimals)
        {
            var part = Convert.ToDouble("0." + new string('0', decimals - 1) + "1");
            return Math.Max(Math.Min((input < part) ? part : input, 1.0), 0.0);
        }

        private static bool AreNear(double value, double otherValue)
        {
            return (Math.Abs(value - otherValue) < 0.0000001);
        }

    }
}
