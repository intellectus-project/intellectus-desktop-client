using EmotionRecognition.Listeners;
using EmotionRecognition.Wrapper;
using intellectus_desktop_unit_tests.Mocks;
using SoundRecorder.SoundRecorders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intellectus_emotion_recognition_testbed
{
    class SoundThread
    {
        private string path;
        private Action<EmotionsProbabilities> offlineCallback, realtimeCallback;

        public SoundThread(string path, Action<EmotionsProbabilities> offlineCallback, Action<EmotionsProbabilities> realtimeCallback)
        {
            this.path = path;
            this.offlineCallback = offlineCallback;
            this.realtimeCallback = realtimeCallback;
        }

        public void Process()
        {
            FileSoundSource source = new FileSoundSource(path);

            float seconds = (float)source.FileSize / source.GetWaveFormat().AverageBytesPerSecond;

            var listener = new VoiceListener(source.GetWaveFormat(), (int)source.FileSize);
            var rtListener = new VoiceListener(source.GetWaveFormat(), 5f);

            var extractor = new VokaturiSingleExtractor();
            var rtExtractor = new VokaturiAverage();
            listener.Subscribe(extractor);
            rtListener.Subscribe(rtExtractor);

            source.AddListener(listener);
            source.AddListener(rtListener);
            source.Start();

            listener.FlushExtract();
            rtListener.FlushExtract();

            offlineCallback.Invoke(extractor.Extraction.Emotions);
            realtimeCallback.Invoke(rtExtractor.Average().Emotions);
        }


    }
}
