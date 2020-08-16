using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using SoundRecorder.SoundRecorders;
using SoundRecorder.SoundListeners;
using System;
using intellectus_desktop_unit_tests.Mocks;
using System.IO;
using System.Collections.Generic;
using System.Linq;

using System.Runtime.InteropServices;
using System.Security.Principal;

namespace intellectus_desktop_unit_tests
{

    [TestClass]
    public class OutputRecorder
    {
        [TestMethod]
        public void CallbackBeingCalled()
        {
            var output = new OutputSoundSource();

            bool called = false;

            CallbackSoundListener listener = new CallbackSoundListener((samples, bytesUsed) =>
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
