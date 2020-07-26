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
        private ISoundRecorder operatorRecorder;
        private ISoundRecorder consultantRecorder;
        private string operatorName="Pablo Fernandez";
        private ISoundListener operatorWriter;
        private ISoundListener consultantWriter;

        public EnteringCall()
        {
            InitializeComponent();
        }

        private void EnteringCalll_Load(object sender, EventArgs e)
        {

        }

        private void btnStartCall_Click(object sender, EventArgs e)
        {
            this.startRecording();
        }
        
        private void startRecording()
        {
            this.initializeOperatorRecorder();
            this.initializeConsultantRecorder();
            consultantRecorder.Start();
            operatorRecorder.Start();
            OnCallWindow onCallWindow = new OnCallWindow(operatorRecorder, consultantRecorder);
            onCallWindow.Show();
            this.Hide();
        }

        private void initializeOperatorRecorder()
        {
            operatorRecorder = new InputSoundRecorder();
            operatorRecorder.Configure(0, new NAudio.Wave.WaveFormat(44100, 1));
            operatorWriter = new SoundFileWriter(string.Format("{0}/Grabaciones/operator_{1}_{2}.wav", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), operatorName, DateTime.Now.ToFileTimeUtc()), operatorRecorder.GetWaveFormat());
            operatorRecorder.AddListener(operatorWriter);
        }
        private void initializeConsultantRecorder()
        {
            consultantRecorder = new OutputSoundRecorder();
            consultantRecorder.Configure(0, new NAudio.Wave.WaveFormat(44100, 1));
            consultantWriter = new SoundFileWriter(string.Format("{0}/Grabaciones/consultant_{1}_{2}.wav", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), operatorName, DateTime.Now.ToFileTimeUtc()), consultantRecorder.GetWaveFormat());
            consultantRecorder.AddListener(consultantWriter);
        }
    }

}
