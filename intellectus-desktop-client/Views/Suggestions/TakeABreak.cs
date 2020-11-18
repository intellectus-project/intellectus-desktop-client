using intellectus_desktop_client.Models;
using intellectus_desktop_client.Services;
using intellectus_desktop_client.Services.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intellectus_desktop_client.Views.Suggestions
{
    public partial class TakeABreak : MaterialSkin.Controls.MaterialForm
    {
        public TakeABreak(bool obligatory)
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink400, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey50, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            setWindow(obligatory);
        }

        private void setWindow(bool obligatory)
        {
            if (!obligatory)
            {
                this.msg.Text = String.Format("Notamos que está emocionalmente inestable para continuar \r\n¿Desea tomarse un descanso de {0} minutos?", Domain.CurrentUser.Call.MinutesDuration.ToString());
            }
            else
            {
                if (Domain.CurrentUser.Call.BreakAssigned)
                {
                    this.msg.Text = String.Format("Su supervisor notó que está emocionalmente inestable para continuar.\r\n Tomese un descanso de {0} minutos", Domain.CurrentUser.Call.MinutesDuration.ToString());

                }
                this.msg.Text = String.Format("Notamos que está emocionalmente inestable para continuar.\r\n Tomese un descanso de {0} minutos", Domain.CurrentUser.Call.MinutesDuration.ToString());
                this.returnEC.Visible = false;
            }
        }

        private void returnEC_Click(object sender, EventArgs e)
        {
            EnteringCall ec = new EnteringCall();
            ec.Show();
            OnCallWindow.TranscurredTime.Reset();
            this.Close();
        }

        private void btnTakeABreak_Click(object sender, EventArgs e)
        {
            try
            {
                API.TakeABreak();
                EnteringCall ec = new EnteringCall();
                ec.Show();
                OnCallWindow.TranscurredTime.Reset();
                this.Close();
            }
            catch(HttpResponseMessageException exception)
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
    }
}
