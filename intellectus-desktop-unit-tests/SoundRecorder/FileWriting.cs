using intellectus_desktop_unit_tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NAudio.Wave;
using SoundRecorder.SoundListeners;
using SoundRecorder.SoundRecorders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace intellectus_desktop_unit_tests
{

    [TestClass]
    public class FileWriting
    {
        [TestMethod]
        public void WritingFileFromMock()
        {
            var sourcePath = Path.Combine(SoundBank.Instance.PathToSoundBank, SoundBank.Instance.SoundFiles[0]);
            var destinationPath = Path.Combine(SoundBank.Instance.PathToTemp, "writing-file-from-mock.wav");

            var input = new FileSoundSource(sourcePath);

            global::SoundRecorder.SoundListeners.SoundFileWriter fileWriterListener = new global::SoundRecorder.SoundListeners.SoundFileWriter(destinationPath, input.GetWaveFormat());

            input.AddListener(fileWriterListener);
            input.Start();

            Assert.IsTrue(File.Exists(destinationPath), "Read and written files are different");

            fileWriterListener.Close();

            File.Delete(destinationPath);
        }



        [TestMethod]
        public void WritingSameDataFromMock()
        {
            var sourcePath = Path.Combine(SoundBank.Instance.PathToSoundBank, SoundBank.Instance.SoundFiles[0]);
            var destinationPath = Path.Combine(SoundBank.Instance.PathToTemp, "writing-samples-from-mock.wav");

            var input = new FileSoundSource(sourcePath);

            var length = input.FileSize;

            BufferedSoundListener buffer = new BufferedSoundListener(input.GetWaveFormat(), (int)length);
            SoundFileWriter fileWriter = new SoundFileWriter(destinationPath, input.GetWaveFormat());

            input.AddListener(buffer);
            input.AddListener(fileWriter);
            input.Start();

            fileWriter.Close();

            // Read the written file

            var writtenInput = new FileSoundSource(destinationPath);
            BufferedSoundListener secondBuffer = new BufferedSoundListener(input.GetWaveFormat(), (int)writtenInput.FileSize);

            writtenInput.AddListener(secondBuffer);
            writtenInput.Start();

            File.Delete(destinationPath);

            // Assertion

            bool lengthComparison = writtenInput.FileSize == input.FileSize;

            Assert.IsTrue(lengthComparison);

            var first = buffer.ReadAll();
            var second = secondBuffer.ReadAll();

            bool contentComparison = first.SequenceEqual(second);

            Assert.IsTrue(contentComparison);
        }

    }
}
