using EmotionRecognition.Wrapper;
using System.Collections.Generic;
using System.Linq;

namespace Suggestions
{
    public class Vertex
    {
        private char id;
        private Suggestion suggestion;

        public Vertex(char id, Suggestion suggestion)
        {
            this.id = id;
            this.suggestion = suggestion;
        }

        public List<Edge> Edges { get; set; }

        public Suggestion Suggestion => suggestion;

        public Vertex FindNext(EmotionsProbabilities probabilities, Stack<Vertex> stack)
        {
            var edgeFound = Edges.FirstOrDefault(edge => edge.Matches(probabilities, stack));
            return edgeFound?.Next ?? this;
        }

        public char ID => id;

        public override bool Equals(object otherObject)
        {
            var vertex = otherObject as Vertex;

            if (vertex == null)
                return false;

            return vertex.id.Equals(id);
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
    }
}
