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

        private void helpButton_Click(object sender, EventArgs e)
        {
           int emotionAvg = 65;

            if (Domain.CurrentUser.Call.BreakAssigned)
            {
                TakeABreak tab = new TakeABreak(true);
                tab.Show();
                this.Close();
                return;
            }
           
           if (emotionAvg <=60) {
                PNL pnl = new PNL();
                pnl.Show();
                this.Close();
                return;
           }
           if (emotionAvg>60 && emotionAvg <= 70)
           {
                Domain.CurrentUser.Call.MinutesDuration = 10;
                TakeABreak tab = new TakeABreak(false);
                tab.Show();
                this.Close();
                return;
           }
           if (emotionAvg > 70 && emotionAvg <= 80)
           {
                Domain.CurrentUser.Call.MinutesDuration = 15;
                TakeABreak tab = new TakeABreak(false);
                tab.Show();
                this.Close();
                return;
            }
            if (emotionAvg > 80 && emotionAvg <= 90)
            {
                Domain.CurrentUser.Call.MinutesDuration = 20;
                TakeABreak tab = new TakeABreak(true);
                tab.Show();
                this.Close();
                return;
            }
            if (emotionAvg > 90)
            {
                Domain.CurrentUser.Call.MinutesDuration = 30;
                TakeABreak tab = new TakeABreak(true);
                tab.Show();
                this.Close(); 
                return;
            }
        }
    }
}
