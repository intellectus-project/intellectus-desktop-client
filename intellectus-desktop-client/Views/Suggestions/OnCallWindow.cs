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
    public partial class OnCallWindow : MaterialSkin.Controls.MaterialForm
    {
        public static Stopwatch TranscurredTime= new Stopwatch();
        private SuggestionListenerController SuggestionListenerController { get; set; }

        public OnCallWindow()
        {
            InitializeComponent();
            startCall();
           
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink400, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey50, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            timer1.Start();
            TranscurredTime.Start();
            
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            Recording.StopRecording();
            timer1.Stop();
            TranscurredTime.Stop();
            var call = Domain.CurrentUser.Call;
            call.EndTime = DateTime.UtcNow;
            if (Recording.SoundProcessed)
            {
                call.OperatorLastStats = Recording.OperatorLastStats;
                call.ConsultantStats = Recording.ExtractConsultantEmotions();
                call.OperatorStats = Recording.ExtractOperatorEmotions();
                call.CallRating = Recording.Rating;
            }

            PostCallOperator postCall = new PostCallOperator();
            postCall.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTranscurredTime.Text = TranscurredTime.Elapsed.ToString("hh':'mm':'ss");
        }

        private void OnCallWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void startCall()
        {
            if (API.StartCall())
            {
                SuggestionListenerController = new SuggestionListenerController(suggestionsList, (a, b) => { Invoke(a, b); }) ;
                Recording.StartRecording(SuggestionListenerController);
            }
        }

    }
}
