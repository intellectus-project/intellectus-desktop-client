using NAudio.Wave;
using SoundRecorder.SoundListeners;
using SoundRecorder.SoundRecorders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundRecorder.SoundRecorders
{
    public class MemorySoundRecorder : ISoundRecorder
    {
        private List<ISoundListener> listeners;
        private float[] samples;
        private WaveFormat format;
        private float interval;
        private int samplesForInterval;
        private long totalSamples, samplesLeft;

        public MemorySoundRecorder(float[] samples, float interval)
        {
            this.samples = samples;
            this.interval = interval;
            totalSamples = samples.Length;
            listeners = new List<ISoundListener>();
        }

        public void AddListener(ISoundListener listener)
        {
            listeners.Add(listener);
        }

        public void Configure(int inputDeviceIndex, WaveFormat format)
        {
            this.format = format;
            samplesForInterval = GenerateSamplesForInterval();
        }

        private int GenerateSamplesForInterval()
        {
            int samplesPerSecond = format.SampleRate * format.Channels;
            return (int)Math.Ceiling(samplesPerSecond * interval);
        }

        public WaveFormat GetWaveFormat()
        {
            return format;
        }

        public void RemoveListener(ISoundListener listener)
        {
            listeners.Remove(listener);
        }

        public void Start()
        {
            samplesLeft = totalSamples;
            Read();
        }

        int count = 0;
        private void Read()
        {
            int samplesToRead = samplesLeft > samplesForInterval ? samplesForInterval : (int)samplesLeft;

            float[] subBuffer = new float[samplesToRead];
            Array.Copy(samples, totalSamples - samplesLeft, subBuffer, 0, samplesToRead);
            samplesLeft -= samplesToRead;

            listeners.ForEach(listener => listener.ProcessSample(subBuffer));
            count++;
            if (samplesLeft == 0)
                Stop();
            else
                Read();
        }

        public void Stop()
        {
            listeners.ForEach(listener => listener.Stop());
        }
    }
}
