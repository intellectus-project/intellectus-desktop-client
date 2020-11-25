using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Suggestions.Systems
{
    public class BaseSuggestionsSystem : SuggestionsSystem
    {

        public static List<Suggestion> Suggestions = new List<Suggestion>
        {
            new Suggestion(HttpUtility.HtmlDecode("La verdadera compasi&oacute;n no significa s&oacute;lo sentir el dolor de otra persona, sino estar motivado a eliminarlo")),
            new Suggestion(HttpUtility.HtmlDecode("Exhal&aacute; lentamente")),
            new Suggestion(HttpUtility.HtmlDecode("No tengas miedo de tus miedos, no est&aacute;n ah&iacute; para asustar. Est&aacute;n para luchar con ellos")),
            new Suggestion(HttpUtility.HtmlDecode("Inhal&aacute; lenta y profundamente, inflando el pecho")),
            new Suggestion(HttpUtility.HtmlDecode("Manten&eacute; la respiraci&oacute;n durante un par de segundos"))
        };


        public BaseSuggestionsSystem() : base()
        {
            Suggestion emptySuggestion = new Suggestion("");

            Vertex a = new Vertex('a', emptySuggestion);
            Vertex b = new Vertex('b', emptySuggestion);
            Vertex c = new Vertex('c', Suggestions[0]);
            Vertex d = new Vertex('d', emptySuggestion);
            Vertex e = new Vertex('e', Suggestions[1]);
            Vertex f = new Vertex('f', emptySuggestion);
            Vertex g = new Vertex('g', Suggestions[2]);
            Vertex h = new Vertex('h', Suggestions[3]);
            Vertex i = new Vertex('i', Suggestions[4]);
            Vertex j = new Vertex('j', emptySuggestion);
            Vertex k = new Vertex('k', emptySuggestion);


            var onlyHappiness = Only(EmotionRange.Emotion.HAPPINESS);
            var onlyNeutrality = Only(EmotionRange.Emotion.NEUTRALITY);
            var onlyAnger = Only(EmotionRange.Emotion.ANGER);
            var onlyFear = Only(EmotionRange.Emotion.FEAR);
            var onlySadness= Only(EmotionRange.Emotion.SADNESS);

            Edge e1 = new Edge(b, onlyHappiness);
            Edge e2 = new Edge(d, onlySadness);
            Edge e3 = new Edge(f, onlyFear);
            Edge e4 = new Edge(h, onlyAnger);
            Edge e5 = new Edge(j, onlyNeutrality);
            Edge e6 = new Edge(c, onlyHappiness, new List<char>{ 'b', 'b' });
            Edge e7 = new Edge(e, onlySadness, new List<char>{ 'd', 'd' });
            Edge e8 = new Edge(g, onlyFear, new List<char>{ 'f', 'f' });
            Edge e9 = new Edge(i, onlyAnger, new List<char>{ 'h', 'h' });
            Edge e10 = new Edge(k, onlyNeutrality, new List<char>{ 'j', 'j' });


            a.Edges = new List<Edge>{ e1, e2, e3, e4, e5 };
            b.Edges = new List<Edge>{ e2, e3, e4, e5, e6 };
            d.Edges = new List<Edge>{ e1, e3, e4, e5, e7 };
            f.Edges = new List<Edge>{ e1, e2, e4, e5, e8 };
            h.Edges = new List<Edge>{ e1, e2, e3, e5, e9 };
            j.Edges = new List<Edge>{ e1, e2, e3, e4, e10 };

            c.Edges = new List<Edge>{ e2, e3, e4, e5 };
            e.Edges = new List<Edge>{ e1, e3, e4, e5 };
            g.Edges = new List<Edge>{ e1, e2, e4, e5 };
            i.Edges = new List<Edge>{ e1, e2, e3, e5 };
            k.Edges = new List<Edge>{ e1, e2, e3, e4 };

            Initialize(a);
        }

        private List<EmotionRange> Only(EmotionRange.Emotion emotion)
        {
            List<EmotionRange> range = new List<EmotionRange>();
            int length = Enum.GetNames(typeof(EmotionRange.Emotion)).Length;
            for (int index = 0; index < length; index++)
                if (((int)emotion) == index)
                    range.Add(new EmotionRange(0.7, 1.0, emotion));
                else
                    range.Add(new EmotionRange(0.0, 0.3, (EmotionRange.Emotion)index));
            return range;
        }

        public override float Rating()
        {
            var list = stack.ToList();

            var superHappyCount = list.Count(IsSuperHappy);

            var negativeCount = list.Count(IsNegative);

            var count = list.Count;

            float superHappyFactor = Clamp(superHappyCount - 2) / count;
            float negativityFactor = Clamp(negativeCount - 1) / count;

            return 1f - (negativityFactor + superHappyCount);
        }

        private float Clamp(float value)
        {
            return Math.Min(Math.Max(value, 1f), 0f);
        }

        private bool IsSuperHappy(Vertex vertex)
        {
            return vertex.ID.Equals('c');
        }
        private bool IsNegative(Vertex vertex)
        {
            return vertex.ID.Equals('e') ||
                vertex.ID.Equals('g') ||
                vertex.ID.Equals('i');
        }

    }
}
