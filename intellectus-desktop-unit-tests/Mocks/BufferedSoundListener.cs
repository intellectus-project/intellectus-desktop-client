using NAudio.Wave;
using SoundRecorder.SoundListeners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intellectus_desktop_unit_tests.Mocks
{
    class BufferedSoundListener : ISoundListener
    {
        private BufferedWaveProvider buffer;

        public BufferedSoundListener(WaveFormat format, int length)
        {
            buffer = new BufferedWaveProvider(format);
            buffer.BufferLength = length;
            buffer.ReadFully = false;
        }

        public void ProcessSamples(byte[] samples, int bytesFilled)
        {
            buffer.AddSamples(samples, 0, bytesFilled);
        }

        public byte[] ReadAll()
        {
            byte[] content = new byte[buffer.BufferLength];
            buffer.Read(content, 0, content.Length);
            return content;
        }
    }
}
