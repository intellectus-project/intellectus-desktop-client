using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoundRecorder.SoundRecorders;
using SoundRecorder.SoundListeners;
using System.IO;
using intellectus_desktop_unit_tests.Mocks;

namespace intellectus_desktop_unit_tests
{
    [TestClass]
    public class MockedRecorder
    {
        [TestMethod]
        public void CallbackBeingCalled()
        {
            var sourcePath = Path.Combine(SoundBank.Instance.PathToSoundBank, SoundBank.Instance.SoundFiles[0]);

            var input = new FileSoundSource(sourcePath);

            bool called = false;

            CallbackSoundListener listener = new CallbackSoundListener((samples, bytesUsed) =>
            {
                called = true;
            });

            input.AddListener(listener);
            input.Start();

            Assert.IsTrue(called);
        }
    }
    

}
