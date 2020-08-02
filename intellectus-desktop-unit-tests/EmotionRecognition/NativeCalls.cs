using EmotionRecognition.Wrapper;
using intellectus_desktop_unit_tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoundRecorder.SoundRecorders;
using System;
using System.IO;

namespace intellectus_desktop_unit_tests.EmotionRecognition
{

    [TestClass]
    public class NativeCalls
    {
        [TestMethod]
        public void VersionAndLicenseAreFound()
        {
            string version = VersionAndLicense.GetVersionAndLicenseString();
            Assert.IsNotNull(version);
        }

        [TestMethod]
        public void VoiceLifeCycle()
        {
            Voice voice = new Voice(44100, 441000);
            short shorty = 0;
            for (int index = 0; index < 441000; index++)
                voice.Fill(shorty);
            
            var result = voice.Extract();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void VoiceFromFile()
        {
            var sourcePath = Path.Combine(SoundBank.Instance.PathToSoundBank, SoundBank.Instance.SoundFiles[1]);
            var input = new MockedSoundRecorder(sourcePath, 0.5f);
            input.Configure(0, null);

            var waveFormat = input.GetWaveFormat();
            var sampleCount = input.SampleCount;

            Voice voice = new Voice(waveFormat.SampleRate, (int)sampleCount);

            CallbackSoundListener callbackListener = new CallbackSoundListener((samples) =>
            {
                voice.Fill(samples);
            });

            input.AddListener(callbackListener);

            input.Start();


            var result = voice.Extract();

            Assert.IsNotNull(result);
        }
    }
}
