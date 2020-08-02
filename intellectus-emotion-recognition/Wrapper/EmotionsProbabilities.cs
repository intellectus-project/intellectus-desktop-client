using intellectus_emotion_recognition.Import;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmotionRecognition.Wrapper
{
    [StructLayout(LayoutKind.Sequential)]
    public struct EmotionsProbabilities
    {
        double neutrality;
        double happiness;
        double sadness;
        double anger;
        double fear;


        public IntPtr ToPointer()
        {
            var pointer = StructConverter.ConvertToPointer(this);
            return pointer;
        }
        public static IntPtr CreatePointer()
        {
            return StructConverter.CreatePointer(typeof(EmotionsProbabilities));
        }

        public static EmotionsProbabilities FromPointer(IntPtr pointer)
        {
            return StructConverter.FromPointer<EmotionsProbabilities>(pointer);
        }
    }
}
