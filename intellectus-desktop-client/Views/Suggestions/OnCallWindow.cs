using intellectus_desktop_client.Models;
using intellectus_desktop_client.Services;
using intellectus_desktop_client.Views.Suggestions;
using SoundRecorder.SoundRecorders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace intellectus_desktop_client
{
    public partial class OnCallWindow : Form
    {
        public static Stopwatch TranscurredTime= new Stopwatch();
        private SuggestionListenerController SuggestionListenerController { get; set; }

        public OnCallWindow()
        {
            InitializeComponent();
            timer1.Start();
            TranscurredTime.Start();
            SuggestionListenerController = new SuggestionListenerController(suggestionsList);
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            Recording.StopRecording();
            timer1.Stop();
            TranscurredTime.Stop();
            var call = Domain.CurrentUser.Call;
            call.EndTime = DateTime.UtcNow;
            call.ConsultantStats = Recording.ExtractConsultantEmotions();
            call.OperatorStats = Recording.ExtractOperatorEmotions();
            call.CallRating = Recording.Rating;
            call.OperatorLastStats = Recording.OperatorLastStats;

            PostCallOperator postCall = new PostCallOperator();
            postCall.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTranscurredTime.Text = TranscurredTime.Elapsed.ToString("hh':'mm':'ss");
        }

        private void OnCallWindow_Load(object sender, EventArgs e)
        {
            Recording.StartRecording(SuggestionListenerController);
            API.StartCall();
        }


    }
}
