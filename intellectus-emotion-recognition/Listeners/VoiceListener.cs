using EmotionRecognition.Wrapper;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using SoundRecorder.SoundListeners;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmotionRecognition.Listeners
{
    public class VoiceListener : ISoundListener
    {
        private Voice voice;

        private int maxBufferedSamples, remainingSamplesForPeriod;

        private List<IExtractionListener> listeners;

        private BufferedWaveProvider buffer;
        private ISampleProvider provider;
        private int bytesToSampleLength;
        private WaveFormat format;

        public VoiceListener(WaveFormat format, float seconds)
        {
            buffer = new BufferedWaveProvider(format);
            buffer.BufferLength = (int)Math.Ceiling(seconds * format.AverageBytesPerSecond);
            buffer.ReadFully = false;

            bytesToSampleLength = (format.BitsPerSample * format.Channels / 8);

            this.format = format;

            if (this.format.Channels < 2)
                provider = buffer.ToSampleProvider();
            else
                provider = new StereoToMonoSampleProvider(buffer.ToSampleProvider());

            CalculateMaxBufferedSamples(format, seconds);
            
            voice = new Voice(format.SampleRate, maxBufferedSamples);

            listeners = new List<IExtractionListener>();
            remainingSamplesForPeriod = maxBufferedSamples;
        }

        public VoiceListener(WaveFormat format, int totalBytes)
        {
            buffer = new BufferedWaveProvider(format);
            buffer.BufferLength = totalBytes;
            buffer.ReadFully = false;

            bytesToSampleLength = (format.BitsPerSample * format.Channels / 8);

            this.format = format;

            if (this.format.Channels < 2)
                provider = buffer.ToSampleProvider();
            else
                provider = new StereoToMonoSampleProvider(buffer.ToSampleProvider());

            maxBufferedSamples = totalBytes / bytesToSampleLength;

            voice = new Voice(format.SampleRate, maxBufferedSamples);

            listeners = new List<IExtractionListener>();
            remainingSamplesForPeriod = maxBufferedSamples;
        }

        private void CalculateMaxBufferedSamples(WaveFormat format, float seconds)
        {
            maxBufferedSamples = (int)Math.Ceiling(format.SampleRate * seconds);
        }

        public void Subscribe(IExtractionListener listener)
        {
            listeners.Add(listener);
        }

        public void Unsubscribe(IExtractionListener listener)
        {
            listeners.Remove(listener);
        }

        public void ProcessSamples(byte[] samples, int bytesUsed)
        {
            if(bytesUsed > buffer.BufferLength)
            {
                int total = bytesUsed;
                int skip = 0;
                while(total > 0)
                {
                    int next = Math.Min(buffer.BufferLength, total);
                    ProcessSamples(samples.Skip(skip).Take(next).ToArray(), next);
                    total -= buffer.BufferLength;
                    skip += buffer.BufferLength;
                }
            }
            else
            {
                buffer.AddSamples(samples, 0, bytesUsed);
                float[] floatSamples = new float[bytesUsed / bytesToSampleLength];
                int amount = provider.Read(floatSamples, 0, floatSamples.Length);
                if (amount != floatSamples.Length)
                    throw new Exception("Buffer length mismatch");
                buffer.ClearBuffer();
                ProcessSamples(floatSamples);
            }            
        }

        public void FlushExtract()
        {
            if(remainingSamplesForPeriod != maxBufferedSamples)
            {
                Extract();
                remainingSamplesForPeriod = maxBufferedSamples;
            }
        }

        private void ProcessSamples(float[] samples)
        {
            int currentSamples = samples.Length;
            int samplesToPass = Math.Min(currentSamples, remainingSamplesForPeriod);

            remainingSamplesForPeriod -= currentSamples;
            if (remainingSamplesForPeriod < 0)
            {
                float[] firstPart, secondPart;
                Split(samples, samplesToPass, out firstPart, out secondPart);
                voice.Fill(firstPart);
                Extract();
                remainingSamplesForPeriod = maxBufferedSamples;
                ProcessSamples(secondPart);
            }
            else
            {
                voice.Fill(samples);
                if (remainingSamplesForPeriod == 0)
                {
                    Extract();
                    remainingSamplesForPeriod = maxBufferedSamples;
                }
            }
        }

        public void Split<T>(T[] array, int index, out T[] first, out T[] second)
        {
            first = array.Take(index).ToArray();
            second = array.Skip(index).ToArray();
        }

        private void Extract()
        {
            var extraction = voice.Extract();
            listeners.ForEach(listener => listener.ExtractionAvailable(extraction));
            voice.Reset();
        }

        public void Start()
        {
            remainingSamplesForPeriod = maxBufferedSamples;
        }

        public void Stop()
        {
            if(remainingSamplesForPeriod < maxBufferedSamples)
                Extract();
        }
    }
}
