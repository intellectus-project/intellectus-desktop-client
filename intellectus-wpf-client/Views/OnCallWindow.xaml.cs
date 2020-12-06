using intellectus_desktop_client.Models;
using intellectus_desktop_client.Services;
using intellectus_desktop_client.Services.API;
using intellectus_wpf_client.Views.Suggestions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace intellectus_wpf_client
{
    /// <summary>
    /// Interaction logic for OnCallWindow.xaml
    /// </summary>
    public partial class OnCallWindow : Window
    {
        private DispatcherTimer Timer;
        private Stopwatch TranscurredTime;
        private SuggestionsListenerController suggestionsController;

        public OnCallWindow()
        {
            InitializeComponent();

            suggestionsController = new SuggestionsListenerController(lstSuggestions);
            suggestionsController.label = lblTest;
            Recording.StartRecording(suggestionsController);

            TranscurredTime = new Stopwatch();
            Timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Render, Timer_Tick, lblTime.Dispatcher);

            TranscurredTime.Start();
            Timer.Start();
        }

        private string ja = "";

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Content = lblTime.Tag.ToString() + TranscurredTime.Elapsed.ToString("hh':'mm':'ss");

            lblTest.Content = string.Join(" ", Recording.suggestionsSystem.stack.Select(st => st.ID));
            var l = Recording.suggestionsSystem.Last;
            if(l != null)
            {
                var j = new
                {
                    Anger = string.Format("{0:0.00}", l.probabilities.Anger),
                    Fear = string.Format("{0:0.00}", l.probabilities.Fear),
                    Happiness = string.Format("{0:0.00}", l.probabilities.Happiness),
                    Neutrality = string.Format("{0:0.00}", l.probabilities.Neutrality),
                    Sadness = string.Format("{0:0.00}", l.probabilities.Sadness),
                };
                lblTest.Content += "\n" + API.Serialize(Recording.suggestionsSystem.Last.Quality);
                lblTest.Content += "\n" + API.Serialize(j);
            }
            

            if(!ja.Equals(lblTest.Content))
                Trace.WriteLine(lblTest.Content);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StopTime();
            EndCall();
        }

        private void StopTime()
        {
            TranscurredTime.Stop();
            Recording.StopRecording();
            Timer.Stop();
        }

        private void EndCall()
        {

            var call = Domain.CurrentUser.Call;
            call.EndTime = DateTime.UtcNow;
            Recording.PerformExtraction();

            if (Recording.SoundProcessed)
            {
                call.OperatorLastStats = Recording.OperatorLastStats;
                call.ConsultantStats = Recording.ConsultantProbabilities;
                call.OperatorStats = Recording.OperatorProbabilities;
                call.CallRating = Recording.Rating;
            }

            PostCallOperatorWindow postCall = new PostCallOperatorWindow();
            postCall.Show();
            Close();
        }
    }
}
