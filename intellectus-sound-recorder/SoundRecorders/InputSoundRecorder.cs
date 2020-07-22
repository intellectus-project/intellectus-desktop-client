using System;
using System.Collections.Generic;
using System.Text;
using NAudio.Wave;
using SoundRecorder.SoundListeners;

namespace SoundRecorder.SoundRecorders
{
    public class InputSoundRecorder : ISoundRecorder
    {
        private WaveInEvent waveIn;
        private List<ISoundListener> listeners;

        public InputSoundRecorder()
        {
            waveIn = new WaveInEvent();
            listeners = new List<ISoundListener>();
        }

        public void AddListener(ISoundListener listener)
        {
            listeners.Add(listener);
        }

        public void Configure(int inputDeviceIndex, WaveFormat format)
        {
            waveIn.WaveFormat = format;
            waveIn.DeviceNumber = inputDeviceIndex;
            waveIn.DataAvailable += DataAvailable;
        }

        public WaveFormat GetWaveFormat()
        {
            return waveIn.WaveFormat;
        }

        public void RemoveListener(ISoundListener listener)
        {
            listeners.Remove(listener);
        }

        public void Start()
        {
            listeners.ForEach(listener => listener.Start());
            waveIn.StartRecording();
        }

        public void Stop()
        {
            waveIn.StopRecording();
            listeners.ForEach(listener => listener.Stop());
        }

        private void DataAvailable(object sender, WaveInEventArgs e)
        {
            var remapped = RemapBuffer(e.Buffer);
            listeners.ForEach(listener => listener.ProcessSample(remapped));
        }

        private float[] RemapBuffer(byte[] buffer)
        {
            var remapped = new float[buffer.Length / (waveIn.WaveFormat.BitsPerSample / 8)];

            for (int index = 0; index < buffer.Length; index += 2)
            {
                Int16 integer = BitConverter.ToInt16(new byte[] { buffer[index], buffer[index + 1] }, 0);
                remapped[index / 2] = FromIntSample(integer);
            }
            return remapped;
        }

        private float FromIntSample(Int16 sample)
        {
            float f;
            f = ((float)sample) / (float)32768;
            f = Math.Min(Math.Max(-1f, f), f);
            return f;
        }

        ~InputSoundRecorder()
        {
            waveIn.Dispose();
        }
    }
}
