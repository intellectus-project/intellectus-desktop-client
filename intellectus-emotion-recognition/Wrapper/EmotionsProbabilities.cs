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
        public double Neutrality;
        public double Happiness;
        public double Sadness;
        public double Anger;
        public double Fear;


        internal EmotionsProbabilities(double neutrality, double happiness, double sadness, double anger, double fear)
        {
            Neutrality = neutrality;
            Happiness = happiness;
            Sadness = sadness;
            Anger = anger;
            Fear = fear;
        }

        internal void Add(EmotionsProbabilities other)
        {
            Neutrality += other.Neutrality;
            Happiness += other.Happiness;
            Sadness += other.Sadness;
            Anger += other.Anger;
            Fear += other.Fear;
        }

        internal void Divide(int number)
        {
            Neutrality /= number;
            Happiness /= number;
            Sadness /= number;
            Anger /= number;
            Fear /= number;
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
