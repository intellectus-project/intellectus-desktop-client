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
        private Stopwatch transcurredTime= new Stopwatch();


        public OnCallWindow()
        {
            InitializeComponent();
            lblTranscurredTimeName.Text = "Tiempo transcurrido:";
            timer1.Start();
            transcurredTime.Start();
            lblTranscurredTime.Text = "00:00";
           
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            Recording.StopRecording();
            timer1.Stop();
            transcurredTime.Reset();
            PostCallOperator postCall = new PostCallOperator();
            postCall.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTranscurredTime.Text = string.Format("{0}:{1}:{2}",transcurredTime.Elapsed.Hours, transcurredTime.Elapsed.Minutes,transcurredTime.Elapsed.Seconds);
                TimeSpan.FromSeconds(Convert.ToDouble(transcurredTime.ElapsedMilliseconds) / 1000).ToString();
        }
    }
}
