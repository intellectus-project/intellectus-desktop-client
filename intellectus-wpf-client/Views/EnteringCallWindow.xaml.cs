using intellectus_desktop_client.Models;
using intellectus_desktop_client.Services;
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
    /// Interaction logic for EnteringCallWindow.xaml
    /// </summary>
    public partial class EnteringCallWindow : Window
    {
        public EnteringCallWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StartCall();
        }


        private void StartCall()
        {
            if (CallService.CanStartCall())
            {
                try
                {
                    API.StartCall();
                    OnCallWindow onCallWindow = new OnCallWindow();
                    onCallWindow.Show();
                    this.Close();
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
                        // Blocked
                        case (HttpStatusCode)423:
                            var seconds = API.Deserialize<int>(exception.Response);

                            // Create ghost call
                            var call = new Call();
                            call.BreakAssigned = true;
                            call.MinutesDuration = (seconds / 60) + 1;
                            Domain.CurrentUser.Call = call;
                            MessageBox.Show("No se puede iniciar una llamada, se encuentra en un descanso");

                            BreakWindow breakWindow = new BreakWindow();
                            breakWindow.Show();
                            Close();
                            break;
                        default:
                            MessageBox.Show("Error inesperado");
                            break;
                    }

                }
            }
            else
                MessageBox.Show("No se puede iniciar una llamada, se encuentra en un descanso");
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
