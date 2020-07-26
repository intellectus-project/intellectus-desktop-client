using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using SoundRecorder.SoundRecorders;
using SoundRecorder.SoundListeners;
using System;
using intellectus_desktop_unit_tests.Mocks;

namespace intellectus_desktop_unit_tests
{

    [TestClass]
    public class InputRecorder
    {
        [TestMethod]
        public void CallbackBeingCalled()
        {
            var input = new InputSoundRecorder();
            input.Configure(0, new NAudio.Wave.WaveFormat(44100, 1));

            bool called = false;

            CallbackSoundListener listener = new CallbackSoundListener((samples) =>
            {
                called = true;
                input.Stop();
            });

            input.AddListener(listener);

            input.Start();

            Thread.Sleep(500);

            if(!called)
                input.Stop();

            Assert.IsTrue(called);
        }
    }
}
