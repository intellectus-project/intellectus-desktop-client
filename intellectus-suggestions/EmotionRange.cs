using EmotionRecognition.Wrapper;

namespace Suggestions
{
    public class EmotionRange
    {
        public enum Emotion
        {
            HAPPINESS,
            FEAR,
            ANGER,
            SADNESS,
            NEUTRALITY
        }

        private Emotion type;
        private double min;
        private double max;

        public EmotionRange(double min, double max, Emotion type)
        {
            this.min = min;
            this.max = max;
            this.type = type;
        }

        public bool Contains(EmotionsProbabilities probabilities)
        {
            double value;
            switch(type)
            {
                case Emotion.ANGER:
                    value = probabilities.Anger;
                    break;
                case Emotion.HAPPINESS:
                    value = probabilities.Happiness;
                    break;
                case Emotion.FEAR:
                    value = probabilities.Fear;
                    break;
                case Emotion.NEUTRALITY:
                    value = probabilities.Neutrality;
                    break;
                default:
                case Emotion.SADNESS:
                    value = probabilities.Sadness;
                    break;
            }
            return value >= min && value <= max;
        }
    }
}