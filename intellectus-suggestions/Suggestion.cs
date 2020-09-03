using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suggestions
{
    public class Suggestion
    {
        private string text;

        public Suggestion(string text)
        {
            this.text = text;
        }

        public string Text => text;

    }
}
