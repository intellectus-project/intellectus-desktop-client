using EmotionRecognition.Listeners;
using EmotionRecognition.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intellectus_desktop_unit_tests.Mocks
{
    public class VokaturiComparer : IExtractionListener
    {
        private bool first = true;
        private VoiceFeatureExtractionResult firstExtraction;
        private VoiceFeatureExtractionResult secondExtraction;

        public void ExtractionAvailable(VoiceFeatureExtractionResult extraction)
        {
            if (first)
            {
                firstExtraction = extraction;
                first = false;
            }
            else
                secondExtraction = extraction;
        }

        public bool CompareResults()
        {
            return firstExtraction.Equals(secondExtraction);
        }
    }

}
