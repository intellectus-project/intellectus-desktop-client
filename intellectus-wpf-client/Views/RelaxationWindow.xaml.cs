using System;
using System.IO;
using System.Windows;
using System.Windows.Shapes;

namespace intellectus_wpf_client
{
    /// <summary>
    /// Interaction logic for RelaxationWindow.xaml
    /// </summary>
    public partial class RelaxationWindow : Window
    {
        private const string RelaxationVideosRelativePath = @"\Resources\Relaxation\";
        private const string RelaxationVideosFileType = ".mp4";
        
        private bool Paused = false;


        public RelaxationWindow()
        {
            InitializeComponent();


            var pathToExecuting = Directory.GetCurrentDirectory().ToString();
            var totalPath = pathToExecuting + RelaxationVideosRelativePath;
            var files = Directory.GetFiles(totalPath);


            Random random = new Random();
            var index = random.Next(0, files.Length);
            
            Uri outUri;
            Uri.TryCreate(files[index], UriKind.Relative, out outUri);
            mediaVideoPlayer.Source = outUri;
            mediaVideoPlayer.Play();
        }


        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            EnteringCallWindow enteringCall = new EnteringCallWindow();
            enteringCall.Show();
            Close();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            Paused = !Paused;
            if(Paused)
            {
                mediaVideoPlayer.Pause();
                btnStop.Content = "Reproducir";
            }
            else
            {
                mediaVideoPlayer.Play();
                btnStop.Content = "Pausar";
            }
            
        }
    }
}
