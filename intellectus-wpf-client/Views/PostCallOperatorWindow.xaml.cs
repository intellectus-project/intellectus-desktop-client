using intellectus_desktop_client.Models;
using intellectus_desktop_client.Services.API;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace intellectus_wpf_client
{
    /// <summary>
    /// Interaction logic for PostCallOperatorWindow.xaml
    /// </summary>
    public partial class PostCallOperatorWindow : Window
    {
        public PostCallOperatorWindow()
        {
            InitializeComponent();
        }

        private void btnEndCall_Click(object sender, RoutedEventArgs e)
        {
            if (rdbNeutrality.IsChecked ?? false)
                Domain.CurrentUser.Call.Emotion = 3;
            else if (rdbFear.IsChecked ?? false)
                Domain.CurrentUser.Call.Emotion = 2;
            else if (rdbSadness.IsChecked ?? false)
                Domain.CurrentUser.Call.Emotion = 0;
            else if (rdbHappiness.IsChecked ?? false)
                Domain.CurrentUser.Call.Emotion = 1;
            else if (rdbAnger.IsChecked ?? false)
                Domain.CurrentUser.Call.Emotion = 4;
            else
            {
                lblError.Content = "Error, seleccioná una opción";
                lblError.Visibility = Visibility.Visible;
                return;
            }

            try
            {
                API.EndCall();
                PostCall();
            }
            catch (HttpResponseMessageException exception)
            {
                lblError.Content = "Error inesperado";
                lblError.Visibility = Visibility.Visible;
            }
        }

        
        private void PostCall()
        {
            float rating = Domain.CurrentUser.Call.CallRating;
            if (Domain.CurrentUser.Call.BreakAssigned)
            {
                BreakWindow tab = new BreakWindow();
                tab.Show();
                Close();
                return;
            }
            
            if (rating > 0.60)
            {
                EnteringCallWindow enteringCall = new EnteringCallWindow();
                enteringCall.Show();
                Close();
                return;
            }
            if (rating <= 0.60 && rating > 0.40)
            {
                RelaxationWindow relaxation = new RelaxationWindow();
                relaxation.Show();
                Close();
                return;
            }
            if (rating <= 0.40 && rating > 0.30)
            {
                TakeABreak(10, false);
                return;
            }
            if (rating <= 0.30 && rating > 0.20)
            {
                TakeABreak(15, false);
                return;
            }
            if (rating <= 0.20 && rating > 0.10)
            {
                TakeABreak(20, true);
                return;
            }
            if (rating <= 0.10)
            {
                TakeABreak(30, true);
                return;
            }
        }

        private void TakeABreak(int minutesDuration, bool mandatory)
        {
            Domain.CurrentUser.Call.MinutesDuration = minutesDuration;
            TakeABreakWindow tab = new TakeABreakWindow();
            tab.Mandatory = mandatory;
            tab.Show();
            Close();
        }
    }
}
