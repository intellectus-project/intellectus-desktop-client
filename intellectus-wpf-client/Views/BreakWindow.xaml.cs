using intellectus_desktop_client.Models;
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
using System.Windows.Threading;

namespace intellectus_wpf_client
{
    /// <summary>
    /// Interaction logic for BreakWindow.xaml
    /// </summary>
    public partial class BreakWindow : Window
    {
        private DispatcherTimer timer;

        private DateTime target;


        public BreakWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Render, Timer_Tick, lblTitle.Dispatcher);

            int minutes = Domain.CurrentUser.Call.MinutesDuration;
            target = DateTime.Now.AddMinutes(minutes);
            lblTimeRemaining.Content = string.Format("00:{0}:00", minutes);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan difference = target - DateTime.Now;
            if (difference.TotalSeconds <= 0)
            {
                timer.Stop();
                EnteringCallWindow window = new EnteringCallWindow();
                window.Show();
                Close();
            }
            else
                lblTimeRemaining.Content = difference.ToString("hh':'mm':'ss");
        }
    }
}
