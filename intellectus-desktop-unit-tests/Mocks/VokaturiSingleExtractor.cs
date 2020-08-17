using EmotionRecognition.Listeners;
using EmotionRecognition.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intellectus_desktop_unit_tests.Mocks
{
    public class VokaturiSingleExtractor : IExtractionListener
    {
        private VoiceFeatureExtractionResult result;

        public void ExtractionAvailable(VoiceFeatureExtractionResult extraction)
        {
            result = extraction;
        }

        public VoiceFeatureExtractionResult Extraction => result;
    }
}
