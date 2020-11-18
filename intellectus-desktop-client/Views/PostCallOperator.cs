using intellectus_desktop_client.Models;
using intellectus_desktop_client.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace intellectus_desktop_client.Views.Suggestions
{
    public partial class PostCallOperator : MaterialSkin.Controls.MaterialForm
    {
       
        public PostCallOperator()
        {
            
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink400, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey50, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void PostCall_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (emotion.SelectedItems.Count > 0)
            {
                Domain.CurrentUser.Call.Emotion = emotion.SelectedIndex;
                if (API.EndCall())
                {
                    goToPostCall();
                }
                lblErrorCreateCall.Visible = true;
            }
            else
            {
                requiredText.Visible = true;
            }

        }

        private void goToPostCall()
        {
            float rating = Domain.CurrentUser.Call.CallRating;
            if (Domain.CurrentUser.Call.BreakAssigned)
            {
                TakeABreak tab = new TakeABreak(true);
                tab.Show();
                this.Close();
                return;
            }

            if(rating > 0.60)
            {
                PostCallWindow pcw = new PostCallWindow();
                pcw.Show();
                this.Close();
            }
            if (rating > 0.40 && rating <= 0.60)
            {
                PNL pnl = new PNL();
                pnl.Show();
                this.Close();
                return;
            }
            if (rating > 0.30 && rating <= 0.40)
            {
                Domain.CurrentUser.Call.MinutesDuration = 10;
                TakeABreak tab = new TakeABreak(false);
                tab.Show();
                this.Close();
                return;
            }
            if (rating > 0.20 && rating <= 0.30)
            {
                Domain.CurrentUser.Call.MinutesDuration = 15;
                TakeABreak tab = new TakeABreak(false);
                tab.Show();
                this.Close();
                return;
            }
            if (rating > 0.10 && rating <= 0.20)
            {
                Domain.CurrentUser.Call.MinutesDuration = 20;
                TakeABreak tab = new TakeABreak(true);
                tab.Show();
                this.Close();
                return;
            }
            if (rating <= 0.10)
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
