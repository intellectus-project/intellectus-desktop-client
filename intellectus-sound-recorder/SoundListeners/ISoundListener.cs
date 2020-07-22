using System;
using System.Collections.Generic;
using System.Text;

namespace SoundRecorder.SoundListeners
{
    public interface ISoundListener
    {
        void ProcessSample(float[] sample);

        void Start();

        void Stop();
    }
}
