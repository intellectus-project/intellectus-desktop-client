using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NAudio.Wave;
using SoundRecorder.SoundListeners;

namespace SoundRecorder.SoundRecorders
{
    public class InputSoundSource : ISoundSource
    {
        public WaveInEvent waveIn;
        
        public event EventHandler<RecordingStoppedException> RecordingStoppedEvent;

        private List<ISoundListener> listeners;
        
        private bool recording;

        public InputSoundSource(WaveFormat format, int deviceIndex)
        {
            SetWaveIn(format, deviceIndex);
            listeners = new List<ISoundListener>();
            recording = false;
        }

        private void RecordingStopped(object sender, StoppedEventArgs e)
        {
            if (recording)
            {
                recording = false;
                ResetWaveIn();
                var exception = new RecordingStoppedException("The input recording has stopped", e.Exception);
                if (RecordingStoppedEvent == null)
                    throw exception;
                else
                    RecordingStoppedEvent.Invoke(this, exception);
            }
        }

        public WaveFormat GetWaveFormat()
        {
            return waveIn.WaveFormat;
        }


        public void AddListener(ISoundListener listener)
        {
            listeners.Add(listener);
        }

        public void RemoveListener(ISoundListener listener)
        {
            listeners.Remove(listener);
        }

        public void Start()
        {
            recording = true;
            waveIn.StartRecording();
        }

        public void Stop()
        {
            recording = false;
            waveIn.StopRecording();
            ResetWaveIn();
        }

        private void ResetWaveIn()
        {
            var format = waveIn.WaveFormat;
            var device = waveIn.DeviceNumber;
            waveIn.Dispose();
            SetWaveIn(format, device);
        }

        private void SetWaveIn(WaveFormat format, int deviceNumber)
        {
            waveIn = new WaveInEvent();
            waveIn.WaveFormat = format;
            waveIn.DeviceNumber = deviceNumber;
            waveIn.DataAvailable += DataAvailable;
            waveIn.RecordingStopped += RecordingStopped;
        }

        private void DataAvailable(object sender, WaveInEventArgs e)
        {
            //var buffer = new byte[e.BytesRecorded];
            //Array.Copy(e.Buffer, buffer, e.BytesRecorded);

            listeners.ForEach(listener => listener.ProcessSamples(e.Buffer, e.BytesRecorded));
        }

        ~InputSoundSource()
        {
            waveIn.Dispose();
        }
    }
}
