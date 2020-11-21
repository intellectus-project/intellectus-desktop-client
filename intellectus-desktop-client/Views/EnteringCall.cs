using intellectus_desktop_client.Models;
using intellectus_desktop_client.Services;
using intellectus_desktop_client.Services.API;
using SoundRecorder.SoundListeners;
using SoundRecorder.SoundRecorders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace intellectus_desktop_client
{
    public partial class EnteringCall : MaterialSkin.Controls.MaterialForm
    {
       
        public EnteringCall()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink400, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey50, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

            if (!Services.CallService.CanStartCall())
            {
                this.btnStartCall.Visible = false;
                this.materialLabel1.Visible = false;
                this.lblOnABreak.Visible = true;
            }
        }


        private void btnStartCall_Click(object sender, EventArgs e)
        {
            startCall();
        }

        private void startCall()
        {
            if (Services.CallService.CanStartCall())
            {
                try
                {
                    API.StartCall();
                    OnCallWindow onCallWindow = new OnCallWindow();
                    onCallWindow.Show();
                    this.Close();
                }
                catch(HttpResponseMessageException exception)
                {
                    switch(exception.Code)
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
                            MessageBox.Show("No se puede iniciar una llamada, se encuentra en un descanso");
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
    }

}
