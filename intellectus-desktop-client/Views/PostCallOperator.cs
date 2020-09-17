using intellectus_desktop_client.Models;
using intellectus_desktop_client.Services;
using System;
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
                Domain.CurrentUser.Call.Emotion = emotion.SelectedItem.ToString();
                if (API.EndCall())
                {
                    PostCallWindow postCallWindow = new PostCallWindow();
                    postCallWindow.Show();
                    this.Hide();
                }
                lblErrorCreateCall.Visible = true;
            }
            else
            {
                requiredText.Visible = true;
            }

        }
    }
}
