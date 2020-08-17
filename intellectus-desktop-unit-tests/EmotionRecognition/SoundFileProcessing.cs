using EmotionRecognition.Listeners;
using EmotionRecognition.Wrapper;
using intellectus_desktop_unit_tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoundRecorder.SoundRecorders;
using System.Collections.Generic;
using System.IO;

namespace intellectus_desktop_unit_tests.EmotionRecognition
{
    [TestClass]
    public class SoundFileProcessing
    {


        [TestMethod]
        public void ProcessAudioStereo()
        {
            var sourcePath = Path.Combine(SoundBank.Instance.PathToSoundBank, SoundBank.Instance.SoundFiles[8]);
            var input = new FileSoundSource(sourcePath);

            float seconds = (float)input.FileSize / input.GetWaveFormat().AverageBytesPerSecond;

            VoiceListener listener = new VoiceListener(input.GetWaveFormat(), seconds);

            var extractor = new VokaturiSingleExtractor();
            listener.Subscribe(extractor);

            input.AddListener(listener);
            input.Start();

            var extraction = extractor.Extraction;

            Assert.IsNotNull(extraction);
        }

        [TestMethod]
        public void ProcessAudioMono()
        {
            var sourcePath = Path.Combine(SoundBank.Instance.PathToSoundBank, SoundBank.Instance.SoundFiles[9]);
            var input = new FileSoundSource(sourcePath);

            float seconds = (float)input.FileSize / input.GetWaveFormat().AverageBytesPerSecond;

            VoiceListener listener = new VoiceListener(input.GetWaveFormat(), seconds);

            var extractor = new VokaturiSingleExtractor();
            listener.Subscribe(extractor);

            input.AddListener(listener);
            input.Start();

            var extraction = extractor.Extraction;

            Assert.IsNotNull(extraction);
        }

        [TestMethod]
        public void ProcessAudioRealTime()
        {
            var sourcePath = Path.Combine(SoundBank.Instance.PathToSoundBank, SoundBank.Instance.SoundFiles[8]);
            var input = new FileSoundSource(sourcePath);

            VoiceListener listener = new VoiceListener(input.GetWaveFormat(), 5);

            var extractor = new VokaturiAverage();
            listener.Subscribe(extractor);

            input.AddListener(listener);
            input.Start();

            var extraction = extractor.Average();

            Assert.IsNotNull(extraction);
        }


        [TestMethod]
        public void MonoAndStereoExtractionIsSame()
        {
            var sourcePathMono = Path.Combine(SoundBank.Instance.PathToSoundBank, SoundBank.Instance.SoundFiles[3]);
            var sourcePathStereo = Path.Combine(SoundBank.Instance.PathToSoundBank, SoundBank.Instance.SoundFiles[4]);

            var inputMono = new FileSoundSource(sourcePathMono);
            var inputStereo = new FileSoundSource(sourcePathStereo);

            float seconds = (float)inputMono.FileSize / inputMono.GetWaveFormat().AverageBytesPerSecond;

            var firstVoice = new VoiceListener(inputMono.GetWaveFormat(), seconds);
            var secondVoice = new VoiceListener(inputStereo.GetWaveFormat(), seconds);

            inputMono.AddListener(firstVoice);
            inputStereo.AddListener(secondVoice);

            VokaturiComparer comparer = new VokaturiComparer();
            firstVoice.Subscribe(comparer);
            secondVoice.Subscribe(comparer);

            inputMono.Start();
            inputStereo.Start();

            Assert.IsTrue(comparer.CompareResults());
        }



    }
}
