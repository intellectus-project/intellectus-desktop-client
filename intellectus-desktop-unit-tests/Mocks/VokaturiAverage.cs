using EmotionRecognition.Listeners;
using EmotionRecognition.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intellectus_desktop_unit_tests.Mocks
{
    public class VokaturiAverage : IExtractionListener
    {
        private List<VoiceFeatureExtractionResult> results = new List<VoiceFeatureExtractionResult>();

        public void ExtractionAvailable(VoiceFeatureExtractionResult extraction)
        {
            results.Add(extraction);
        }

        public VoiceFeatureExtractionResult Average()
        {
            return VoiceFeatureExtractionResult.Average(results);
        }

        public List<EmotionsProbabilities> EmotionsProbabilities => results.ConvertAll(result => result.Emotions);

    }

}
