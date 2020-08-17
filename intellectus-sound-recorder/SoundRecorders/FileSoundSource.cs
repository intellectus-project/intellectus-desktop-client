using NAudio.Wave;
using SoundRecorder.SoundListeners;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SoundRecorder.SoundRecorders
{
    public class FileSoundSource : ISoundSource
    {
        private AudioFileReader fileReader;
        private List<ISoundListener> listeners;

        public FileSoundSource(string path)
        {
            fileReader = new AudioFileReader(path);
            listeners = new List<ISoundListener>();
        }


        public void Start()
        {
            Read();
        }

        private void Read()
        {
            byte[] readBytes = new byte[fileReader.Length];
            int read = fileReader.Read(readBytes, 0, readBytes.Length);
            if (read != readBytes.Length)
                throw new Exception("Error reading file");
            listeners.ForEach(listener => listener.ProcessSamples(readBytes, read));
            Stop();
        }


        public long FileSize => fileReader.Length;

        public void AddListener(ISoundListener listener)
        {
            listeners.Add(listener);
        }

        public long SampleCount
        {
            get
            {
                var bps = GetWaveFormat().BitsPerSample;
                return (fileReader.Length) / (bps / 8);
            }
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
            fileReader.Close();
        }

        ~FileSoundSource()
        {
            listeners.Clear();
            fileReader.Dispose();
        }
    }
}
