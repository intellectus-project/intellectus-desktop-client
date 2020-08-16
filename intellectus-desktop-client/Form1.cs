using System;
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
using EmotionRecognition.Listeners;
using EmotionRecognition.Wrapper;

namespace intellectus_desktop_client
{
    public partial class Form1 : Form
    {
        private ISoundSource recorder;
        private ISoundListener voice;
        private IExtractionListener extractor;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (cmbRecorder.SelectedIndex == 0)
            {
                var recorder = new InputSoundSource(new NAudio.Wave.WaveFormat(44100, 1), 0);
                recorder.RecordingStoppedEvent += Recorder_RecordingStoppedEvent;
                this.recorder = recorder;
            }
            else
                recorder = new OutputSoundSource();

            if (voice == null)
            {
                var voiceListener = new VoiceListener(recorder.GetWaveFormat(), 5f);
                extractor = new VokaturiListener(this);
                voiceListener.Subscribe(extractor);
                voice = voiceListener;
            }

            recorder.AddListener(voice);


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
            folderDialog.ShowDialog();
        }

        private void folderDialog_HelpRequest(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        delegate void SetEmotionsCallback(EmotionsProbabilities emotions);

        public void SetEmotions(EmotionsProbabilities emotions)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (lstEmotions.InvokeRequired)
            {
                SetEmotionsCallback d = new SetEmotionsCallback(SetEmotions);
                Invoke(d, emotions);
            }
            else
            {
                lstEmotions.Clear();
                lstEmotions.Items.AddRange(
                    new ListViewItem[5]
                    {
                        new ListViewItem("Happiness: " + Percent(emotions.happiness)),
                        new ListViewItem("Neutrality: " + Percent(emotions.neutrality)),
                        new ListViewItem("Fear: " + Percent(emotions.fear)),
                        new ListViewItem("Anger: " + Percent(emotions.anger)),
                        new ListViewItem("Sadness: " + Percent(emotions.sadness)),
                    });
            }
        }

        private static int Percent(double value)
        {
            return (int)Math.Round(value * 100.0);
        }

        public class VokaturiListener : IExtractionListener
        {
            private Form1 form;

            public VokaturiListener(Form1 form)
            {
                this.form = form;
            }

            public void ExtractionAvailable(VoiceFeatureExtractionResult extraction)
            {
                form.SetEmotions(extraction.Emotions);
            }
        }
    }
}
