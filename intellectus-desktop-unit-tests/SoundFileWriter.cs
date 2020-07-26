using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoundRecorder.SoundListeners;
using SoundRecorder.SoundRecorders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intellectus_desktop_unit_tests
{

    [TestClass]
    public class SoundFileWriter
    {
        [TestMethod]
        public void WritingFileFromMock()
        {
            var sourcePath = Path.Combine(SoundBank.Instance.PathToSoundBank, SoundBank.Instance.SoundFiles[0]);
            var destinationPath = Path.Combine(SoundBank.Instance.PathToTemp, "writing-file-from-mock.wav");

            var input = new MockedSoundRecorder(sourcePath, 0.5f);
            input.Configure(0, null);

            SoundFileWriterListener fileWriterListener = new SoundFileWriterListener(destinationPath, input.GetWaveFormat());

            input.AddListener(fileWriterListener);
            input.Start();

            Assert.IsTrue(File.Exists(destinationPath), "Read and written files are different");

            File.Delete(destinationPath);
        }



        [TestMethod]
        public void WritingSameSamplesFromMock()
        {
            var sourcePath = Path.Combine(SoundBank.Instance.PathToSoundBank, SoundBank.Instance.SoundFiles[0]);
            var destinationPath = Path.Combine(SoundBank.Instance.PathToTemp, "writing-samples-from-mock.wav");

            var input = new MockedSoundRecorder(sourcePath, 0.5f);
            input.Configure(0, null);

            var length = input.FileSize;
            var bufferLength = length / (input.GetWaveFormat().BitsPerSample / 8);
            MemoryWriterListener listener = new MemoryWriterListener(bufferLength);

            SoundFileWriterListener fileWriterListener = new SoundFileWriterListener(destinationPath, input.GetWaveFormat());

            input.AddListener(listener);
            input.AddListener(fileWriterListener);
            input.Start();


            // Read the written file
            var writtenInput = new MockedSoundRecorder(destinationPath, 0.5f);
            writtenInput.Configure(0, null);
            MemoryWriterListener writtenListener = new MemoryWriterListener(bufferLength);
            writtenInput.AddListener(writtenListener);
            writtenInput.Start();

            Assert.IsTrue(CompareFileContents(listener, writtenListener), "Read and written files are different");

            File.Delete(destinationPath);
        }

        private bool CompareFileContents(MemoryWriterListener recordedA, MemoryWriterListener recordedB)
        {
            if (recordedA.Used != recordedB.Used)
                return false;

            var bufferA = recordedA.Buffer;
            var bufferB = recordedB.Buffer;


            for (long index = 0; index < recordedA.Used; index++)
                if (!NearlyEqual(bufferA[index], bufferB[index], 0.001f))
                    return false;

            return true;
        }
        private bool NearlyEqual(float a, float b, float epsilon)
        {
            float absA = Math.Abs(a);
            float absB = Math.Abs(b);
            float diff = Math.Abs(a - b);

            if (a == b)
            { // shortcut, handles infinities
                return true;
            }
            else if (a == 0 || b == 0 || absA + absB < float.MinValue)
            {
                // a or b is zero or both are extremely close to it
                // relative error is less meaningful here
                return diff < (epsilon * float.MinValue);
            }
            else
            { // use relative error
                return diff / (absA + absB) < epsilon;
            }
        }

    }
}
