using NAudio.Wave;

namespace SoundRecorder.SoundListeners
{
    public class SoundFileWriter : ISoundListener
    {
        private WaveFileWriter writer;

        public SoundFileWriter(string path, WaveFormat format)
        {
            writer = new WaveFileWriter(path, format);
        }

        public void ProcessSamples(byte[] samples, int bytesUsed)
        {
            writer.Write(samples, 0, bytesUsed);
            writer.Flush();
        }

        public void Close()
        {
            writer.Dispose();
        }
    }
}
