using System;
using System.Collections.Generic;
using System.Text;

namespace SoundRecorder.SoundListeners
{
    public interface ISoundListener
    {
        void ProcessSamples(byte[] samples, int bytesFilled);
    }
}
