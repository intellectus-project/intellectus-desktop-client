using intellectus_desktop_client.Models;
using intellectus_desktop_client.Services;
using intellectus_wpf_client.Views.Suggestions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            SuggestionsListenerController suggestionsController = new SuggestionsListenerController(lstSuggestions);
            Recording.StartRecording(suggestionsController);

            TranscurredTime = new Stopwatch();
            Timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Render, Timer_Tick, lblTime.Dispatcher);

            TranscurredTime.Start();
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Content = TranscurredTime.Elapsed.ToString("hh':'mm':'ss");
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
