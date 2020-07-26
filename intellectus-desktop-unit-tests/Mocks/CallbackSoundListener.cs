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
        private Action<float[]> action;

        public CallbackSoundListener(Action<float[]> action)
        {
            this.action = action;
        }

        public void ProcessSample(float[] sample)
        {
            action.Invoke(sample);
        }

        public void Start()
        {

        }

        public void Stop()
        {

        }
    }
}
