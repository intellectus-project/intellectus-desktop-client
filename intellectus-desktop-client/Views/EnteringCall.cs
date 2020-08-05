using intellectus_desktop_client.Models;
using intellectus_desktop_client.Services;
using SoundRecorder.SoundListeners;
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
    public partial class EnteringCall : Form
    {
        Operator UserOperator;
        public EnteringCall(Operator user)
        {
            UserOperator = user;
            InitializeComponent();
        }

        private void EnteringCalll_Load(object sender, EventArgs e)
        {

        }

        private void btnStartCall_Click(object sender, EventArgs e)
        {
            Recording.StartRecording();
            OnCallWindow onCallWindow = new OnCallWindow();
            onCallWindow.Show();
            this.Hide();
        }
    }

}
