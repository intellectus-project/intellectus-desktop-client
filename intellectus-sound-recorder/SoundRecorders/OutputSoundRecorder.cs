using NAudio.CoreAudioApi;
using NAudio.Wave;
using SoundRecorder.SoundListeners;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoundRecorder.SoundRecorders
{
    public class OutputSoundRecorder : ISoundRecorder
    {
        private WasapiLoopbackCapture capture;

        // We play silence, for our capture device to keep outputting data
        // without interruptions. Other solutions require to use flags and
        // buffers that NAudio doesn't implement
        private WaveOutEvent silenceWave;

        private List<ISoundListener> listeners;

        private List<AudioClient> clints = new List<AudioClient>();

        public OutputSoundRecorder()
        {
            capture = new WasapiLoopbackCapture();
            silenceWave = new WaveOutEvent();
            listeners = new List<ISoundListener>();
        }

        public OutputSoundRecorder(MMDevice device)
        {
            capture = new WasapiLoopbackCapture(device);
            silenceWave = new WaveOutEvent();
            listeners = new List<ISoundListener>();
        }

        public void AddListener(ISoundListener listener)
        {
            listeners.Add(listener);
        }

        public void Configure(int inputDeviceIndex, WaveFormat format)
        {
            capture.DataAvailable += DataAvailable;
            silenceWave.Init(new SilenceProvider(capture.WaveFormat));
        }

        public WaveFormat GetWaveFormat()
        {
            return capture.WaveFormat;
        }

        public void RemoveListener(ISoundListener listener)
        {
            listeners.Remove(listener);
        }

        public void Start()
        {
            listeners.ForEach(listener => listener.Start());
            silenceWave.Play();
            capture.StartRecording();
        }

        public void Stop()
        {
            capture.StopRecording();
            silenceWave.Stop();
            listeners.ForEach(listener => listener.Stop());
        }

        private List<int> bytes = new List<int>();
        private List<int> buffers = new List<int>();
        private void DataAvailable(object sender, WaveInEventArgs e)
        {
            bytes.Add(e.BytesRecorded);
            buffers.Add(e.Buffer.Length);
            var remapped = RemapBuffer(e.BytesRecorded, e.Buffer);
            listeners.ForEach(listener => listener.ProcessSample(remapped));
        }

        private float[] RemapBuffer(int recorded, byte[] buffer)
        {
            int sampleLength = capture.WaveFormat.BitsPerSample / 8;
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
    }
}
