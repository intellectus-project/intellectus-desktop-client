using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace intellectus_wpf_client
{
    /// <summary>
    /// Interaction logic for RelaxationWindow.xaml
    /// </summary>
    public partial class RelaxationWindow : Window
    {
        public RelaxationWindow()
        {
            InitializeComponent();

            mediaVideoPlayer.Source = new Uri("/Resources/Relaxation/1.mp4", UriKind.Relative);
            mediaVideoPlayer.Play();
        }

    }
}
