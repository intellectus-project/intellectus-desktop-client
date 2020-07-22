using System;
using System.Collections.Generic;
using System.Text;

namespace SoundRecorder.SoundListeners
{
    public class MemoryWriterListener : ISoundListener
    {
        private float[] array;
        private int capacity;
        private int used;


        public MemoryWriterListener(int capacity)
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

        public int Used => used;

        public void Stop()
        {

        }
    }
}
