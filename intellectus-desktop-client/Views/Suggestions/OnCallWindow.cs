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
        public Operator UserOperator;
        public OnCallWindow(Operator user)
        {
            UserOperator = user;
            InitializeComponent();
            lblTranscurredTimeName.Text = "Tiempo transcurrido:";
            timer1.Start();
            TranscurredTime.Start();
            lblTranscurredTime.Text = "00:00";
           
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            Recording.StopRecording();
            timer1.Stop();
            TranscurredTime.Stop();
            PostCallOperator postCall = new PostCallOperator();
            postCall.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTranscurredTime.Text = string.Format("{0}:{1}:{2}",TranscurredTime.Elapsed.Hours, TranscurredTime.Elapsed.Minutes,TranscurredTime.Elapsed.Seconds);
        }

        public void Suggest(string suggestion)
        {
            suggestionLast.Text = suggestionOld.Text;
            suggestionOld.Text = suggestionActual.Text;
            suggestionActual.Text = suggestion;
        }

    }
}
