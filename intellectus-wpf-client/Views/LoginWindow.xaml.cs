using intellectus_desktop_client.Models;
using intellectus_desktop_client.Services.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace intellectus_wpf_client
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password.Equals("") || txtUser.Text.Equals(""))
            {
                txtRequiredText.Content = "*Usuario/Contraseña incorrecta";
                txtRequiredText.Visibility = Visibility.Visible;
            }
            else
            {
                try
                {
                    API.Login(txtUser.Text, txtPassword.Password);
                    EnteringCallWindow window = new EnteringCallWindow();
                    this.Close();
                    window.Show();
                }
                catch (HttpResponseMessageException exception)
                {
                    switch (exception.Code)
                    {
                        case HttpStatusCode.BadRequest:
                        case HttpStatusCode.NotFound:
                            txtRequiredText.Content = "Error enviando datos";
                            break;
                        case HttpStatusCode.InternalServerError:
                            txtRequiredText.Content = "Error en el servidor";
                            break;
                        case HttpStatusCode.Unauthorized:
                        case HttpStatusCode.Forbidden:
                            txtRequiredText.Content = "*Usuario/Contraseña incorrecta";
                            break;
                        default:
                            txtRequiredText.Content = "Error inesperado";
                            break;
                    }
                    txtRequiredText.Visibility = Visibility.Visible;
                }
            }
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            /*
            Domain.CurrentUser = new Operator();
            Domain.CurrentUser.Call = new Call();
            Domain.CurrentUser.Call.MinutesDuration = 1;
            BreakWindow breakWindow = new BreakWindow();
            breakWindow.Show();
            Close();*/
            RelaxationWindow relaxationWindow = new RelaxationWindow();
            relaxationWindow.Show();
            Close();
        }
    }
}
