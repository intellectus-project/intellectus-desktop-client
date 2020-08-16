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
        public double neutrality;
        public double happiness;
        public double sadness;
        public double anger;
        public double fear;


        internal EmotionsProbabilities(double n, double h, double s, double a, double f)
        {
            neutrality = n;
            happiness = h;
            sadness = s;
            anger = a;
            fear = f;
        }

        internal void Add(EmotionsProbabilities other)
        {
            neutrality += other.neutrality;
            happiness += other.happiness;
            sadness += other.sadness;
            anger += other.anger;
            fear += other.fear;
        }

        internal void Divide(int number)
        {
            neutrality /= number;
            happiness /= number;
            sadness /= number;
            anger /= number;
            fear /= number;
        }

        internal IntPtr ToPointer()
        {
            var pointer = StructConverter.ConvertToPointer(this);
            return pointer;
        }

        internal static IntPtr CreatePointer()
        {
            return StructConverter.CreatePointer(typeof(EmotionsProbabilities));
        }

        internal static EmotionsProbabilities FromPointer(IntPtr pointer)
        {
            return StructConverter.FromPointer<EmotionsProbabilities>(pointer);
        }

    }
}
