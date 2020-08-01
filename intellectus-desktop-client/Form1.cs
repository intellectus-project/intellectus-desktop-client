﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoundRecorder.SoundRecorders;
using SoundRecorder.SoundListeners;
using NAudio.CoreAudioApi;
using System.Threading;

namespace intellectus_desktop_client
{
    public partial class Form1 : Form
    {
        private ISoundRecorder recorder;
        private ISoundListener writer;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (cmbRecorder.SelectedIndex == 0)
            {
                var recorder = new InputSoundRecorder();
                recorder.RecordingStoppedEvent += Recorder_RecordingStoppedEvent;
                this.recorder = recorder;
            }
            else
                recorder = new OutputSoundRecorder();

            recorder.Configure(0, new NAudio.Wave.WaveFormat(44100, 1));

            if(writer == null)
                writer = new SoundFileWriterListener(folderDialog.SelectedPath + "/recorded.wav", recorder.GetWaveFormat());

            recorder.AddListener(writer);

            recorder.Start();

            btnStop.Enabled = true;
            button1.Enabled = false;
        }

        private void Recorder_RecordingStoppedEvent(object sender, RecordingStoppedException e)
        {
            MessageBox.Show("Recording stopped due to device disconnection");

            btnStop.Enabled = false;
            button1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            recorder.Stop();

            btnStop.Enabled = false;
            button1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDestination_MouseClick(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            button1.Enabled = true;
            btnDestination.Enabled = false;
            folderDialog.ShowDialog();
        }

        private void folderDialog_HelpRequest(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((SoundFileWriterListener)writer).Close();
        }
    }
}
