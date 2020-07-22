using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoundRecorder.SoundListeners
{
    public class SoundFileWriter : ISoundListener
    {
        private WaveFileWriter writer;

        public SoundFileWriter(string path, WaveFormat format)
        {
            writer = new WaveFileWriter(path, format);
        }

        public void ProcessSample(float[] sample)
        {
            writer.WriteSamples(sample, 0, sample.Length);
            writer.Flush();
        }

        public void Start() { }

        public void Stop()
        {
            writer.Dispose();
        }
    }
}
