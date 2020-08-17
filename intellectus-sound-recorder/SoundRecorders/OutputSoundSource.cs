using NAudio.CoreAudioApi;
using NAudio.Wave;
using SoundRecorder.SoundListeners;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoundRecorder.SoundRecorders
{
    public class OutputSoundSource : ISoundSource
    {
        private WasapiLoopbackCapture capture;

        // We play silence, for our capture device to keep outputting data
        // without interruptions. Other solutions require to use flags and
        // buffers that NAudio doesn't implement
        private WaveOutEvent silenceWave;

        private List<ISoundListener> listeners;

        public OutputSoundSource()
        {
            capture = new WasapiLoopbackCapture();
            Initialize();
        }

        public OutputSoundSource(MMDevice device)
        {
            capture = new WasapiLoopbackCapture(device);
            Initialize();
        }

        private void Initialize()
        {
            silenceWave = new WaveOutEvent();
            listeners = new List<ISoundListener>();

            capture.DataAvailable += DataAvailable;
            silenceWave.Init(new SilenceProvider(capture.WaveFormat));
        }

        public void AddListener(ISoundListener listener)
        {
            listeners.Add(listener);
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
            silenceWave.Play();
            capture.StartRecording();
        }

        public void Stop()
        {
            capture.StopRecording();
            silenceWave.Stop();
        }

        private void DataAvailable(object sender, WaveInEventArgs e)
        {
            /*var remapped = RemapBuffer(e.BytesRecorded, e.Buffer);*/
            listeners.ForEach(listener => listener.ProcessSamples(e.Buffer, e.BytesRecorded));
        }

    }
}
