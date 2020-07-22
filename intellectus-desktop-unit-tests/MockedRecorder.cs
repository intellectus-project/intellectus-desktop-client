using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoundRecorder.SoundRecorders;
using SoundRecorder.SoundListeners;

namespace intellectus_desktop_unit_tests
{
    //[TestClass]
    public class MockedRecorder
    {
        //[TestMethod]
        public void CallbackBeingCalled()
        {
            var input = new MockedSoundRecorder(@"path-to-file.wav", 0.5f);
            input.Configure(0, null);

            MemoryWriterListener listener = new MemoryWriterListener(88200);

            input.AddListener(listener);

            input.Start();

            input.Stop();

            Assert.AreEqual(listener.Used, 88200);
        }
    }
    

}
