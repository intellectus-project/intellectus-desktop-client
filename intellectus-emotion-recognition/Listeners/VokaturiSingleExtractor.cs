using EmotionRecognition.Listeners;
using EmotionRecognition.Wrapper;

namespace EmotionRecognition.Listeners
{
    public class VokaturiSingleExtractor : IExtractionListener
    {
        public void ExtractionAvailable(VoiceFeatureExtractionResult extraction)
        {
            Extraction = extraction;
            Extracted = true;
        }

        public VoiceFeatureExtractionResult Extraction { get; private set; }

        public bool Extracted { get; private set; }
    }
}
