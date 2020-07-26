using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoundRecorder.SoundListeners
{
    public class SoundFileWriterListener : ISoundListener
    {
        private WaveFileWriter writer;

        public SoundFileWriterListener(string path, WaveFormat format)
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
            writer.Close();
            writer.Dispose();
        }
    }
}
