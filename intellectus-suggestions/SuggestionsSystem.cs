using EmotionRecognition.Listeners;
using EmotionRecognition.Wrapper;
using System.Collections.Generic;

namespace Suggestions
{
    public class SuggestionsSystem : IExtractionListener
    {
        private Stack<Vertex> stack;
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
            var past = stack.Peek();
            var next = past.FindNext(extraction.Emotions, stack);

            if (!next.Equals(past))
                listeners.ForEach(listener => listener.SuggestionAvailable(next.Suggestion));

            stack.Push(next);
        }

    }
}
