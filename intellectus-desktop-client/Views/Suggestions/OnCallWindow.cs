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
        private ISoundRecorder operatorRecorder;
        private ISoundRecorder consultantRecorder;
        public OnCallWindow(ISoundRecorder operatorRecorder, ISoundRecorder consultantRecorder)
        {
            InitializeComponent();
            lblTranscurredTimeName.Text = "Tiempo transcurrido:";
            setRecorders(operatorRecorder, consultantRecorder);
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            this.operatorRecorder.Stop();
            this.consultantRecorder.Stop();
        }

        private void setRecorders(ISoundRecorder operatorRecorder, ISoundRecorder consultantRecorder)
        {
            this.operatorRecorder = operatorRecorder;
            this.consultantRecorder = consultantRecorder;
        }
    }
}
