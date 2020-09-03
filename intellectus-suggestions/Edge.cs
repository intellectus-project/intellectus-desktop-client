using EmotionRecognition.Wrapper;
using Suggestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suggestions
{
    public class Edge
    {
        private List<EmotionRange> emotionRanges;
        private List<char> vertexIDs;
        private Vertex vertex;


        public Edge(Vertex vertex, List<EmotionRange> ranges) : this(vertex, ranges, null) { }

        public Edge(Vertex vertex, List<EmotionRange> ranges, List<char> vertexIDs)
        {
            this.vertex = vertex;
            this.emotionRanges = ranges;
            this.vertexIDs = vertexIDs;
        }

        public Vertex Next => vertex;

        internal bool Matches(EmotionsProbabilities probabilities, Stack<Vertex> stack)
        {
            return MatchesEmotionRanges(probabilities) && MatchesStack(stack);
        }

        private bool MatchesEmotionRanges(EmotionsProbabilities probabilities)
        {
            return emotionRanges.TrueForAll(emotionRange => emotionRange.Contains(probabilities));
        }

        private bool MatchesStack(Stack<Vertex> stack)
        {
            if (vertexIDs == null)
                return true;
            else
            {
                int vertexCount = vertexIDs.Count;
                if (stack.Count >= vertexCount)
                {
                    var lastN = stack.Take(vertexCount).ToList();
                    return Enumerable.SequenceEqual(lastN.ConvertAll(element => element.ID), vertexIDs);
                }
                else
                    return false;
            }
        }
    }
}
