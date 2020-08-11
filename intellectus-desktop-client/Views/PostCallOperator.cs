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
                //mock
                UserOperator.Call.ConsultantStats = new Stats
                {
                    Anger=0,
                    Fear=1,
                    Happiness=1,
                    Sadness=5,
                    Neutrality = 7.4F
                };

                UserOperator.Call.OperatorStats = new Stats
                {
                    Anger = 10,
                    Fear = 3,
                    Happiness = 4,
                    Sadness = 3.7F,
                    Neutrality = 10.4F
                };
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
