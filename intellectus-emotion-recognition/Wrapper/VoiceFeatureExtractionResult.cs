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


        internal VoiceFeatureExtractionResult(ExtractionQuality quality, EmotionsProbabilities probabilities)
        {
            this.probabilities = probabilities;
            this.quality = quality;
        }

        public EmotionsProbabilities Emotions => probabilities;

        public ExtractionQuality Quality => quality;

    }
}
