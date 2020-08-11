﻿using intellectus_desktop_client.Models;
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
            timer1.Start();
            TranscurredTime.Start();

        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            Recording.StopRecording();
            timer1.Stop();
            TranscurredTime.Stop();
            UserOperator.Call.EndTime = DateTime.UtcNow;
            PostCallOperator postCall = new PostCallOperator(UserOperator);
            postCall.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTranscurredTime.Text = TranscurredTime.Elapsed.ToString("hh':'mm':'ss");
        }

        public void Suggest(string suggestion)
        {
            suggestionLast.Text = suggestionOld.Text;
            suggestionOld.Text = suggestionActual.Text;
            suggestionActual.Text = suggestion;
        }

    }
}
