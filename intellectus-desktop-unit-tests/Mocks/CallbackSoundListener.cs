using SoundRecorder.SoundListeners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intellectus_desktop_unit_tests.Mocks
{
    class CallbackSoundListener : ISoundListener
    {
        private Action<byte[], int> action;

        public CallbackSoundListener(Action<byte[], int> action)
        {
            this.action = action;
        }

        public void ProcessSamples(byte[] samples, int bytesUsed)
        {
            action.Invoke(samples, bytesUsed);
        }

    }
}
