using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suggestions.Systems
{
    public class BaseSuggestionsSystem : SuggestionsSystem
    {

        public static List<Suggestion> Suggestions = new List<Suggestion>(3)
        {
            new Suggestion("Felicidad"),
            new Suggestion("Enojo"),
            new Suggestion("Neutralidad"),
            new Suggestion("Tristeza"),
            new Suggestion("Miedo")
        };


        public BaseSuggestionsSystem() : base()
        {
            Vertex a = new Vertex('a', new Suggestion(""));
            Vertex b = new Vertex('b', Suggestions[0]);
            Vertex c = new Vertex('c', Suggestions[1]);
            Vertex d = new Vertex('d', Suggestions[2]);
            Vertex e = new Vertex('e', Suggestions[3]);
            Vertex f = new Vertex('f', Suggestions[4]);

            Edge e1 = new Edge(b, new List<EmotionRange>() { new EmotionRange(0.8, 1.0, EmotionRange.Emotion.HAPPINESS) });
            Edge e2 = new Edge(c, new List<EmotionRange>() { new EmotionRange(0.8, 1.0, EmotionRange.Emotion.ANGER) });
            Edge e3 = new Edge(d, new List<EmotionRange>() { new EmotionRange(0.8, 1.0, EmotionRange.Emotion.NEUTRALITY) });
            Edge e4 = new Edge(e, new List<EmotionRange>() { new EmotionRange(0.8, 1.0, EmotionRange.Emotion.SADNESS) });
            Edge e5 = new Edge(f, new List<EmotionRange>() { new EmotionRange(0.8, 1.0, EmotionRange.Emotion.FEAR) });

            a.Edges = new List<Edge>() { e1, e2, e3, e4, e5 };
            b.Edges = new List<Edge>() { e1, e2, e3, e4, e5 };
            c.Edges = new List<Edge>() { e1, e2, e3, e4, e5 };
            d.Edges = new List<Edge>() { e1, e2, e3, e4, e5 };
            e.Edges = new List<Edge>() { e1, e2, e3, e4, e5 };
            f.Edges = new List<Edge>() { e1, e2, e3, e4, e5 };

            Initialize(a);
        }
    }
}
