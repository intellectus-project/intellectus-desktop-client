using intellectus_desktop_client.Models;
using intellectus_desktop_client.Services;
using System;
using System.Windows.Forms;

namespace intellectus_desktop_client.Views.Suggestions
{
    public partial class PostCallOperator : Form
    {
       
        public PostCallOperator()
        {
            
            InitializeComponent();
        }

        private void PostCall_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (emotion.SelectedItems.Count > 0)
            {
                User.Call.Emotion = emotion.SelectedItem.ToString();
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
