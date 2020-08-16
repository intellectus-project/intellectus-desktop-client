using EmotionRecognition.Wrapper;
using intellectus_desktop_unit_tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
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
        public void VoiceCallbackBeingCalled()
        {
            var sourcePath = Path.Combine(SoundBank.Instance.PathToSoundBank, SoundBank.Instance.SoundFiles[2]);
            var input = new FileSoundSource(sourcePath);

            var waveFormat = input.GetWaveFormat();
            var sampleCount = input.SampleCount;

            Voice voice = new Voice(waveFormat.SampleRate, (int)sampleCount);

            BufferedWaveProvider buffer = new BufferedWaveProvider(waveFormat);
            buffer.BufferLength = (int)input.FileSize;
            buffer.ReadFully = false;
            WaveToSampleProvider sampler = new WaveToSampleProvider(buffer);

            CallbackSoundListener callbackListener = new CallbackSoundListener((samples, bytes) =>
            {
                buffer.AddSamples(samples, 0, bytes);

                float[] floatSamples = new float[bytes / 4];
                int read = sampler.Read(floatSamples, 0, floatSamples.Length);
                if (read != floatSamples.Length)
                    throw new Exception("Length mismatch");
                voice.Fill(floatSamples);
            });

            input.AddListener(callbackListener);
            input.Start();

            var result = voice.Extract();

            Assert.IsNotNull(result);
        }

    }
}
