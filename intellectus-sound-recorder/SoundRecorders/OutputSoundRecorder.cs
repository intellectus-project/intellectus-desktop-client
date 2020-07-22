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
        private List<ISoundListener> listeners;

        public OutputSoundRecorder()
        {
            capture = new WasapiLoopbackCapture();
            listeners = new List<ISoundListener>();
        }

        public OutputSoundRecorder(MMDevice device)
        {
            capture = new WasapiLoopbackCapture(device);
            listeners = new List<ISoundListener>();
        }

        public void AddListener(ISoundListener listener)
        {
            listeners.Add(listener);
        }

        public void Configure(int inputDeviceIndex, WaveFormat format)
        {
            capture.DataAvailable += DataAvailable;
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
            capture.StartRecording();
        }

        public void Stop()
        {
            capture.StopRecording();
            listeners.ForEach(listener => listener.Stop());
        }

        private void DataAvailable(object sender, WaveInEventArgs e)
        {
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
