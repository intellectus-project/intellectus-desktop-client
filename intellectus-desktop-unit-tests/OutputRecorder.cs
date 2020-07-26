using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using SoundRecorder.SoundRecorders;
using SoundRecorder.SoundListeners;
using System;
using intellectus_desktop_unit_tests.Mocks;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace intellectus_desktop_unit_tests
{

    [TestClass]
    public class OutputRecorder
    {
        [TestMethod]
        public void CallbackBeingCalled()
        {
            var output = new OutputSoundRecorder();
            output.Configure(0, null);

            bool called = false;

            CallbackSoundListener listener = new CallbackSoundListener((samples) =>
            {
                called = true;
                output.Stop();
            });

            output.AddListener(listener);

            output.Start();

            Thread.Sleep(500);

            if (!called)
                output.Stop();

            Assert.IsTrue(called);
        }

    }
}
