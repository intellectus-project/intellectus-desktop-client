using intellectus_desktop_client.Models;
using intellectus_desktop_client.Services;
using System;
using System.Windows.Forms;

namespace intellectus_desktop_client.Views.Suggestions
{
    public partial class PostCallOperator : Form
    {
        public Operator UserOperator;
        public PostCallOperator(Operator user)
        {
            UserOperator = user;
            InitializeComponent();
        }

        private void PostCall_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (emotion.SelectedItems.Count > 0)
            {
                UserOperator.Call.Emotion = emotion.SelectedItem.ToString();
                if (API.EndCall(UserOperator))
                {
                    PostCallWindow postCallWindow = new PostCallWindow(UserOperator);
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
