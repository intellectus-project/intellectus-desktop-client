using NAudio.Wave;
using SoundRecorder.SoundListeners;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoundRecorder.SoundRecorders
{
    public interface ISoundRecorder
    {
        void Configure(int inputDeviceIndex, WaveFormat format);

        WaveFormat GetWaveFormat();

        void AddListener(ISoundListener listener);

        void RemoveListener(ISoundListener listener);

        void Start();

        void Stop();

    }
}
