using System;
using System.Collections.Generic;
using System.Text;

namespace SoundRecorder.SoundListeners
{
    public class MemoryWriterListener : ISoundListener
    {
        private float[] array;
        private long capacity;
        private long used;


        public MemoryWriterListener(long capacity)
        {
            array = new float[capacity];
            this.capacity = capacity;
            used = 0;
        }

        public void Start()
        {
            used = 0;
        }

        public void ProcessSample(float[] sample)
        {
            if ((used + sample.Length) > capacity)
                throw new Exception("Out of memory in writer");
            sample.CopyTo(array, used);
            used += sample.Length;
        }

        public long Used => used;

        public float[] Buffer => array;

        public void Stop()
        {

        }
    }
}
