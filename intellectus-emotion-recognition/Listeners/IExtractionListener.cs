using EmotionRecognition.Wrapper;

namespace EmotionRecognition.Listeners
{
    public interface IExtractionListener
    {
        void ExtractionAvailable(VoiceFeatureExtractionResult extraction);
    }
}