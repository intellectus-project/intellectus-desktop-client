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
                if (!View.Items.Contains(suggestion))
                { 
                    View.Items.Insert(0, suggestion);
                    View.Items.Remove(View.Items[3]);
                }                
            }
            else
            {
                SuggestCallback callback = new SuggestCallback(Suggest);
                View.Dispatcher.Invoke(callback, suggestion);
            }
        }

    }
}
