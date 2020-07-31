using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundRecorder.SoundRecorders
{
    public class RecordingStoppedException : Exception
    {
        public RecordingStoppedException() : base()
        {

        }

        public RecordingStoppedException(string message) : base(message)
        {

        }

        public RecordingStoppedException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
