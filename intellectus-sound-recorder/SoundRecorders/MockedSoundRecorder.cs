using NAudio.Wave;
using SoundRecorder.SoundListeners;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoundRecorder.SoundRecorders
{
    public class MockedSoundRecorder : ISoundRecorder
    {
        private AudioFileReader fileReader;
        private List<ISoundListener> listeners;
        private float interval;
        private int bytesForInterval;
        private long totalBytes;
        private long bytesLeft;
        private int bytesRead;
        private byte[] buffer;

        public MockedSoundRecorder(string path, float interval)
        {
            fileReader = new AudioFileReader(path);
            this.interval = interval;
            bytesForInterval = GenerateBytesForInterval();
            totalBytes = fileReader.Length;
            buffer = new byte[bytesForInterval];
            listeners = new List<ISoundListener>();
        }

        private int GenerateBytesForInterval()
        {
            var format = GetWaveFormat();
            return (int)Math.Ceiling(format.AverageBytesPerSecond * interval);
        }

        public void Start()
        {
            bytesLeft = totalBytes;
            listeners.ForEach(listener => listener.Start());
            Read();
        }

        private void Read()
        {
            int offset = 0;
            bytesRead = bytesLeft > bytesForInterval ? bytesForInterval : (int)bytesLeft;
            bytesLeft -= bytesRead;
            fileReader.Read(buffer, offset, bytesRead);

            float[] remapped = RemapBuffer(bytesRead, buffer);
            listeners.ForEach(listener => listener.ProcessSample(remapped));

            if (bytesLeft == 0)
                Stop();
            else
                Read();
        }

        private void DataAvailable(IAsyncResult result)
        {
            if (result.IsCompleted)
            {
                float[] remapped = RemapBuffer(bytesRead, buffer);
                listeners.ForEach(listener => listener.ProcessSample(remapped));

                if (bytesLeft == 0)
                    Stop();
                else
                    Read();
            }
        }

        private float[] RemapBuffer(int recorded, byte[] buffer)
        {
            int sampleLength = GetWaveFormat().BitsPerSample / 8;
            var remapped = new float[recorded / sampleLength];

            for (int index = 0; index < remapped.Length; index++)
            {
                int mappedIndex = sampleLength * index;
                remapped[index] = FromByteArray(new byte[] { buffer[mappedIndex], buffer[mappedIndex + 1], buffer[mappedIndex + 2], buffer[mappedIndex + 3] });
            }
            return remapped;
        }

        private float FromByteArray(byte[] array)
        {
            return BitConverter.ToSingle(array, 0);
        }

        public void AddListener(ISoundListener listener)
        {
            listeners.Add(listener);
        }

        public void Configure(int inputDeviceIndex, WaveFormat format)
        {

        }

        public WaveFormat GetWaveFormat()
        {
            return fileReader.WaveFormat;
        }

        public void RemoveListener(ISoundListener listener)
        {
            listeners.Remove(listener);
        }

        public void Stop()
        {
            listeners.ForEach(listener => listener.Stop());
        }
    }
}
