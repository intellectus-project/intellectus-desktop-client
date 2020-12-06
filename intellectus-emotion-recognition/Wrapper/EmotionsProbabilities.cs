using intellectus_emotion_recognition.Import;
using Newtonsoft.Json;
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
        [JsonProperty("neutrality")]
        public double Neutrality;

        [JsonProperty("happiness")]
        public double Happiness;
        [JsonProperty("sadness")]
        public double Sadness;
        [JsonProperty("anger")]
        public double Anger;
        [JsonProperty("fear")]
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

        public static EmotionsProbabilities Sanitize(EmotionsProbabilities probabilities, double forceSum, int decimals)
        {
            return FromList(GetPerfectRounding(ToList(probabilities), forceSum, decimals));
        }

        public static EmotionsProbabilities Mock(EmotionsProbabilities original)
        {
            var list = ToList(original);
            double max = list.Max();
            int maxIndex = list.IndexOf(max);

            for (int index = 0; index < list.Count; index++)
                list[index] = 0.0;
            list[maxIndex] = 0.99;

            return FromList(list);
        }

        public static List<double> GetPerfectRounding(List<double> original, double forceSum, int decimals)
        {
            var rounded = original.Select(x => Math.Round(x, decimals)).ToList();
            //Debug.Assert(Math.Round(forceSum, decimals) == forceSum);
            var delta = forceSum - rounded.Sum();
            if (delta == 0) return rounded;
            var deltaUnit = Convert.ToDouble(Math.Pow(0.1, decimals)) * Math.Sign(delta);

            List<int> applyDeltaSequence;
            if (delta < 0)
            {
                applyDeltaSequence = original
                    .Zip(Enumerable.Range(0, int.MaxValue), (x, index) => new { x, index })
                    .OrderBy(a => original[a.index] - rounded[a.index])
                    .ThenByDescending(a => a.index)
                    .Select(a => a.index).ToList();
            }
            else
            {
                applyDeltaSequence = original
                    .Zip(Enumerable.Range(0, int.MaxValue), (x, index) => new { x, index })
                    .OrderByDescending(a => original[a.index] - rounded[a.index])
                    .Select(a => a.index).ToList();
            }

            Enumerable.Repeat(applyDeltaSequence, int.MaxValue)
                .SelectMany(x => x)
                .Take(Convert.ToInt32(delta / deltaUnit))
                .ToList()
                .ForEach(index => rounded[index] += deltaUnit);

            return rounded;
        }
        public static List<double> ToList(EmotionsProbabilities probabilities)
        {
            return new List<double>
            {
                probabilities.Neutrality,
                probabilities.Happiness,
                probabilities.Sadness,
                probabilities.Anger,
                probabilities.Fear,
            };
        }
        public static EmotionsProbabilities FromList(List<double> list)
        {
            return new EmotionsProbabilities(list[0], list[1], list[2], list[3], list[4]);
        }

    }
}
