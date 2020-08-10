using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace intellectus_desktop_client.Views.Suggestions
{
    public partial class PostCallWindow : Form
    {
        public PostCallWindow()
        {
            InitializeComponent();
            transcurredTime.Text = string.Format("{0}:{1}:{2}", OnCallWindow.TranscurredTime.Elapsed.Hours, OnCallWindow.TranscurredTime.Elapsed.Minutes, OnCallWindow.TranscurredTime.Elapsed.Seconds);
        }

    }
}
