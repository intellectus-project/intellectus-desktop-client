using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intellectus_desktop_client.Views.Suggestions
{
    public partial class TakeABreak : MaterialSkin.Controls.MaterialForm
    {
        public TakeABreak(bool obligatory, int time)
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink400, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey50, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            setWindow(obligatory, time);
        }

        private void setWindow(bool obligatory, int time)
        {
            if (!obligatory)
            {
                this.msg.Text = String.Format("Notamos que está emocionalmente inestable para continuar ¿Desea tomarse un descanso de {0} minutos?", time.ToString());
            }
            else
            {
                this.msg.Text = String.Format("Notamos que está emocionalmente inestable para continuar, tomese un descanso de {0} minutos", time.ToString());
            }
        }
    }
}
