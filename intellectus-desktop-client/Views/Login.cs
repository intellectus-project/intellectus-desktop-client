using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace intellectus_desktop_client.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int reqStatus = 200;
            if(password.Text == "" || username.Text == "")
            {
                requiredText.Visible = true;
            }
            else
            {
                //apiget
                if (reqStatus == 200)
                {
                    EnteringCall enteringCall = new EnteringCall();
                    enteringCall.Show();
                    this.Hide();
                }
                else
                {
                    requiredText.Visible = true;
                }
            }
        }
    }
}
