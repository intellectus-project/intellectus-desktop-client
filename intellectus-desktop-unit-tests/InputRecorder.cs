using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using SoundRecorder.SoundRecorders;
using SoundRecorder.SoundListeners;

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

            MemoryWriterListener listener = new MemoryWriterListener(88200);

            input.AddListener(listener);

            input.Start();

            Thread.Sleep(2000);

            input.Stop();

            Assert.AreEqual(listener.Used, 88200);
        }
    }
}
