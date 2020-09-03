using EmotionRecognition.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmotionRecognition.Wrapper
{
    public class VoiceFeatureExtractionResult
    {
        private EmotionsProbabilities probabilities;
        private ExtractionQuality quality;


        public VoiceFeatureExtractionResult(ExtractionQuality quality, EmotionsProbabilities probabilities)
        {
            this.probabilities = probabilities;
            this.quality = quality;
        }

        public EmotionsProbabilities Emotions => probabilities;

        public ExtractionQuality Quality => quality;
        
        public override bool Equals(object obj)
        {
            if (!(obj is VoiceFeatureExtractionResult))
                return false;

            VoiceFeatureExtractionResult result = (VoiceFeatureExtractionResult)obj;

            return probabilities.Equals(result.probabilities) && quality.Equals(result.quality);
        }

        public static VoiceFeatureExtractionResult Null
        {
            get
            {
                var nullQuality = new ExtractionQuality();
                var nullEmotions = new EmotionsProbabilities();
                return new VoiceFeatureExtractionResult(nullQuality, nullEmotions);
            }
        }

        public static VoiceFeatureExtractionResult Average(List<VoiceFeatureExtractionResult> values)
        {
            int amount = values.Count;


            var quality = new ExtractionQuality(1, 0, 0);
            values.ConvertAll(extraction => extraction.quality).ForEach(qualityValue => quality.Add(qualityValue));
            quality.Divide(amount);


            var emotions = new EmotionsProbabilities(0.0, 0.0, 0.0, 0.0, 0.0);
            values.ConvertAll(extraction => extraction.probabilities).ForEach(emotionValue => emotions.Add(emotionValue));
            emotions.Divide(amount);

            return new VoiceFeatureExtractionResult(quality, emotions);
        }

        public override int GetHashCode()
        {
            int hashCode = 59757167;
            hashCode = hashCode * -1521134295 + probabilities.GetHashCode();
            hashCode = hashCode * -1521134295 + quality.GetHashCode();
            return hashCode;
        }
    }
}
