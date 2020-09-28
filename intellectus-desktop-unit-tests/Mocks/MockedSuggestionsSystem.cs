using Suggestions;
using Suggestions.Systems;
using System.Collections.Generic;

namespace intellectus_desktop_unit_tests.Mocks
{
    public class MockedSuggestionsSystem : SuggestionsSystem
    {
        public static List<Suggestion> Suggestions = new List<Suggestion>(3)
        {
            new Suggestion("Vas bien"),
            new Suggestion("Muy bien"),
            new Suggestion("Excelente")
        };


        public MockedSuggestionsSystem() : base()
        {
            Vertex a = new Vertex('a', new Suggestion(""));
            Vertex b = new Vertex('b', Suggestions[0]);
            Vertex c = new Vertex('c', Suggestions[1]);
            Vertex d = new Vertex('d', Suggestions[2]);

            Edge e1 = new Edge(b, new List<EmotionRange>() { new EmotionRange(0, 0.7, EmotionRange.Emotion.HAPPINESS) });
            Edge e2 = new Edge(c, new List<EmotionRange>() { new EmotionRange(0, 0.2, EmotionRange.Emotion.HAPPINESS) });
            Edge e3 = new Edge(d, new List<EmotionRange>() 
            {
                new EmotionRange(0, 0.2, EmotionRange.Emotion.FEAR),
                new EmotionRange(0.8, 1.0, EmotionRange.Emotion.HAPPINESS)
            }, new List<char>() { 'c', 'c' });

            a.Edges = new List<Edge>() { e1 };
            b.Edges = new List<Edge>() { e2 };
            c.Edges = new List<Edge>() { e3 };

            Initialize(a);
        }
    }
}
