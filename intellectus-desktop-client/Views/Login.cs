using intellectus_desktop_client.Models;
using intellectus_desktop_client.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
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
            if(password.Text == "" || username.Text == "")
            {
                requiredText.Visible = true;
            }
            else
            {
                bool ok = API.Login(username.Text, password.Text);
                if (ok)
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
