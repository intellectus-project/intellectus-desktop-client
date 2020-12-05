using intellectus_desktop_client.Models;
using intellectus_desktop_client.Services.API;
using System;
using System.Collections.Generic;
using System.Net;
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
    /// Interaction logic for TakeABreakWindow.xaml
    /// </summary>
    public partial class TakeABreakWindow : Window
    {
        private bool mandatory = false;
        public bool Mandatory
        {
            get => mandatory;
            set
            {
                mandatory = value;
                if (!mandatory)
                {
                    lblMessage.Content = String.Format("Notamos que está emocionalmente inestable para continuar \r\n¿Desea tomarse un descanso de {0} minutos?", Domain.CurrentUser.Call.MinutesDuration.ToString());
                    btnReturn.Visibility = Visibility.Visible;
                }
                else if (Domain.CurrentUser.Call.BreakAssigned)
                {
                    lblMessage.Content = String.Format("Su supervisor notó que está emocionalmente inestable para continuar.\r\n Tomese un descanso de {0} minutos", Domain.CurrentUser.Call.MinutesDuration.ToString());
                    ppbLogout.Visibility = Visibility.Hidden;
                    btnReturn.Visibility = Visibility.Collapsed;
                }
                else
                {
                    lblMessage.Content = String.Format("Notamos que está emocionalmente inestable para continuar.\r\n Tomese un descanso de {0} minutos", Domain.CurrentUser.Call.MinutesDuration.ToString());
                    ppbLogout.Visibility = Visibility.Hidden;
                    btnReturn.Visibility = Visibility.Collapsed;
                }
            }
        }

        public TakeABreakWindow()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            EnteringCallWindow enteringCall = new EnteringCallWindow();
            enteringCall.Show();
            Close();
        }

        private void btnBreak_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                API.TakeABreak();
                BreakWindow breakWindow = new BreakWindow();
                breakWindow.Show();
                Close();
            }
            catch (HttpResponseMessageException exception)
            {
                switch (exception.Code)
                {
                    case HttpStatusCode.BadRequest:
                    case HttpStatusCode.NotFound:
                        MessageBox.Show("Error enviando datos");
                        break;
                    case HttpStatusCode.InternalServerError:
                        MessageBox.Show("Error en el servidor");
                        break;
                    default:
                        MessageBox.Show("Error inesperado");
                        break;
                }
            }
            
        }


        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Domain.LogOut();

            LoginWindow login = new LoginWindow();
            login.Show();
            Close();
        }
    }
}
