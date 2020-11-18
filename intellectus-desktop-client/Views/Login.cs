using intellectus_desktop_client.Services.API;
using System;
using System.Net;

namespace intellectus_desktop_client.Views
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink400, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey50, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(password.Text == "" || username.Text == "")
            {

                requiredText.Text = "*Usuario/Contraseña incorrecta";
                requiredText.Visible = true;
            }
            else
            {
                try
                {
                    API.Login(username.Text, password.Text);
                    EnteringCall enteringCall = new EnteringCall();
                    enteringCall.Show();
                    this.Hide();
                }
                catch (HttpResponseMessageException exception)
                {
                    switch (exception.Code)
                    {
                        case HttpStatusCode.BadRequest:
                        case HttpStatusCode.NotFound:
                            requiredText.Text = "Error enviando datos";
                            break;
                        case HttpStatusCode.InternalServerError:
                            requiredText.Text = "Error en el servidor";
                            break;
                        case HttpStatusCode.Unauthorized:
                        case HttpStatusCode.Forbidden:
                            requiredText.Text = "*Usuario/Contraseña incorrecta";
                            break;
                        default:
                            requiredText.Text = "Error inesperado";
                            break;
                    }
                    requiredText.Visible = true;
                }
            }
        }

    }
}
