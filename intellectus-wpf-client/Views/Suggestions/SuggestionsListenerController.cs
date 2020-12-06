using intellectus_desktop_client.Services;
using intellectus_desktop_client.Services.API;
using Suggestions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Threading;

namespace intellectus_wpf_client.Views.Suggestions
{
    class SuggestionsListenerController : ISuggestionsListener
    {
        public Label label;
        private ListView View { get; set; }

        public SuggestionsListenerController(ListView view)
        {
            View = view;
        }

        public void SuggestionAvailable(Suggestion suggestion)
        {
            Suggest(suggestion.Text);
        }


        delegate void SuggestCallback(string suggestion);

        public void Suggest(string suggestion)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (View.Dispatcher.Thread.Equals(Thread.CurrentThread))
            {

                View.Items.Insert(0, suggestion);
                View.Items.Remove(View.Items[3]);
                label.Content = string.Join(" ", Recording.suggestionsSystem.stack.Select(st => st.ID));
                var l = Recording.suggestionsSystem.Last;
                var j = new
                {
                    Anger = string.Format("{0:0.00}", l.probabilities.Anger),
                    Fear = string.Format("{0:0.00}", l.probabilities.Fear),
                    Happiness = string.Format("{0:0.00}", l.probabilities.Happiness),
                    Neutrality = string.Format("{0:0.00}", l.probabilities.Neutrality),
                    Sadness = string.Format("{0:0.00}", l.probabilities.Sadness),
                };
                label.Content += "\n" + API.Serialize(Recording.suggestionsSystem.Last.Quality);
                label.Content += "\n" + API.Serialize(j);

                Trace.WriteLine(label.Content);
            }
            else
            {
                SuggestCallback callback = new SuggestCallback(Suggest);
                View.Dispatcher.Invoke(callback, suggestion);
            }
        }

    }
}
