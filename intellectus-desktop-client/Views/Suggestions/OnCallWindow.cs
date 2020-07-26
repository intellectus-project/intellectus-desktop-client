using intellectus_desktop_client.Services;
using SoundRecorder.SoundRecorders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace intellectus_desktop_client
{
    public partial class OnCallWindow : Form
    {
      
        public OnCallWindow()
        {
            InitializeComponent();
            lblTranscurredTimeName.Text = "Tiempo transcurrido:";
           
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            Recording.StopRecording();
        }

    }
}
