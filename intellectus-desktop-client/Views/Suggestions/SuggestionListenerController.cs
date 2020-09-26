﻿using Suggestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intellectus_desktop_client.Views.Suggestions
{
    class SuggestionListenerController : ISuggestionsListener
    {
        private ListView View { get; set; }

        public SuggestionListenerController(ListView view)
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
            if (View.InvokeRequired)
            {
                SuggestCallback callback = new SuggestCallback(Suggest);
                callback.Invoke(suggestion);
            }
            else
            {
                ListViewItem item = new ListViewItem(suggestion);
                View.Items.Insert(0, item);
                View.Items.Remove(View.Items[3]);
            }
        }

    }
}
