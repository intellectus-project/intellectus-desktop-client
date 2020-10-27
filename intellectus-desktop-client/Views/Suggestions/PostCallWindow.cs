using intellectus_desktop_client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace intellectus_desktop_client.Views.Suggestions
{
    public partial class PostCallWindow : MaterialSkin.Controls.MaterialForm
    {
        
        public PostCallWindow()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink400, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey50, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void btnBackEC_Click(object sender, EventArgs e)
        {
            EnteringCall ec = new EnteringCall();
            ec.Show();
            OnCallWindow.TranscurredTime.Reset();
            this.Close();
        }

        private void helpButton_click(object sender, EventArgs e)
        {
            //obtener promedio emocional
            int emotionAvg = 30;
            switch (emotionAvg)
            {
                case var n when n>=0 && n<=60:
                    //obtener pnl
                    break;
                case var n when n > 60 && n <= 70:
                    //ofrecer descanso 5'
                    break;
                case var n when n > 70 && n <= 80:
                    //ofrecer descanso 10'
                    break;
                case var n when n > 80 && n <= 90:
                    //indicar descanso 20'
                    break;
                case var n when n > 90 && n <= 100:
                    //indicar descanso 30'
                    break;

            }
        }
    }
}
