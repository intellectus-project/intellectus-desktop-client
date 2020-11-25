using EmotionRecognition.Listeners;
using EmotionRecognition.Wrapper;
using System.Collections.Generic;

namespace Suggestions.Systems
{
    public class SuggestionsSystem : IExtractionListener
    {
        public Stack<Vertex> stack;
        public VoiceFeatureExtractionResult Last;
        private List<ISuggestionsListener> listeners = new List<ISuggestionsListener>();


        protected SuggestionsSystem()
        {

        }

        public SuggestionsSystem(Vertex first)
        {
            Initialize(first);
        }

        protected void Initialize(Vertex vertex)
        {
            stack = new Stack<Vertex>();
            stack.Push(vertex);
        }

        public void Subscribe(ISuggestionsListener suggestionListener)
        {
            listeners.Add(suggestionListener);
        }

        public void Unsubscribe(ISuggestionsListener suggestionListener)
        {
            listeners.Remove(suggestionListener);
        }

        public void ExtractionAvailable(VoiceFeatureExtractionResult extraction)
        {
            Last = extraction;
            var past = stack.Peek();
            var next = past.FindNext(extraction.Emotions, stack);

            if (!next.Equals(past))
                listeners.ForEach(listener => listener.SuggestionAvailable(next.Suggestion));

            stack.Push(next);
        }

        public virtual float Rating()
        {
            return 1f;
        }

    }
}
