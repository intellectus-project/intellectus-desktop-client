using EmotionRecognition.Listeners;
using EmotionRecognition.Wrapper;
using intellectus_desktop_unit_tests;
using intellectus_desktop_unit_tests.Mocks;
using SoundRecorder.SoundRecorders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intellectus_emotion_recognition_testbed
{
    public partial class EmotionRecognitionTestbed : Form
    {
        private string directory;
        private Thread threadInstance;
        private SoundThread thread;

        public EmotionRecognitionTestbed()
        {
            InitializeComponent();
        }

        private void EmotionRecognitionTestbed_Load(object sender, EventArgs e)
        {
            directory = SoundBank.Instance.PathToSoundBank;
            var files = Directory.GetFiles(directory).ToList();
            files.ForEach(file => lstFiles.Items.Add(new FileInfo(file).Name));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lstFiles.SelectedIndices.Count == 1)
            {
                button1.Enabled = false;
                ProcessSound(lstFiles.SelectedItems[0].Text);
            }
        }

        private void ProcessSound(string file)
        {
            if (threadInstance != null && threadInstance.IsAlive)
                threadInstance.Abort();

            var path = Path.Combine(directory, file);
            thread = new SoundThread(path, SetEmotions, SetEmotionsRealTime, SetEmotionsRealTimeCollection);
            threadInstance = new Thread(new ThreadStart(thread.Process));
            threadInstance.Start();

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
                        new ListViewItem("Happiness: " + Percent(emotions.Happiness)),
                        new ListViewItem("Neutrality: " + Percent(emotions.Neutrality)),
                        new ListViewItem("Fear: " + Percent(emotions.Fear)),
                        new ListViewItem("Anger: " + Percent(emotions.Anger)),
                        new ListViewItem("Sadness: " + Percent(emotions.Sadness)),
                    });
            }
        }

        delegate void SetEmotionsRealTimeCallback(EmotionsProbabilities emotions);

        public void SetEmotionsRealTime(EmotionsProbabilities emotions)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (lstEmotions.InvokeRequired)
            {
                SetEmotionsRealTimeCallback d = new SetEmotionsRealTimeCallback(SetEmotionsRealTime);
                Invoke(d, emotions);
            }
            else
            {
                lstEmotionsRealTime.Clear();
                lstEmotionsRealTime.Items.AddRange(
                    new ListViewItem[5]
                    {
                        new ListViewItem("Happiness: " + Percent(emotions.Happiness)),
                        new ListViewItem("Neutrality: " + Percent(emotions.Neutrality)),
                        new ListViewItem("Fear: " + Percent(emotions.Fear)),
                        new ListViewItem("Anger: " + Percent(emotions.Anger)),
                        new ListViewItem("Sadness: " + Percent(emotions.Sadness)),
                    });
                button1.Enabled = true;
            }
        }

        delegate void SetEmotionsRealTimeCollectionCallback(List<EmotionsProbabilities> emotions);

        public void SetEmotionsRealTimeCollection(List<EmotionsProbabilities> emotionCollection)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (lstEmotions.InvokeRequired)
            {
                SetEmotionsRealTimeCollectionCallback d = new SetEmotionsRealTimeCollectionCallback(SetEmotionsRealTimeCollection);
                Invoke(d, emotionCollection);
            }
            else
            {
                foreach (var serie in emotionalChart.Series)
                    serie.Points.Clear();

                double x = 0f;
                emotionCollection.ForEach(emotion =>
                {
                    emotionalChart.Series["Happiness"].Points.AddXY(x, Math.Round(emotion.Happiness, 5));
                    emotionalChart.Series["Sadness"].Points.AddXY(x, Math.Round(emotion.Sadness, 5));
                    emotionalChart.Series["Fear"].Points.AddXY(x, Math.Round(emotion.Fear, 5));
                    emotionalChart.Series["Anger"].Points.AddXY(x, Math.Round(emotion.Anger, 5));
                    emotionalChart.Series["Neutrality"].Points.AddXY(x, Math.Round(emotion.Neutrality, 5));
                    x++;
                });
            }
        }

        private static int Percent(double value)
        {
            return (int)Math.Round(value * 100.0);
        }

    }

}
