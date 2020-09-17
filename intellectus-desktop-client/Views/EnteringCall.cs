using intellectus_desktop_client.Models;
using intellectus_desktop_client.Services;
using SoundRecorder.SoundListeners;
using SoundRecorder.SoundRecorders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace intellectus_desktop_client
{
    public partial class EnteringCall : MaterialSkin.Controls.MaterialForm
    {
       
        public EnteringCall()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink400, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey50, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }

        private void btnStartCall_Click(object sender, EventArgs e)
        {
            Recording.StartRecording();
            API.StartCall();
            OnCallWindow onCallWindow = new OnCallWindow();
            onCallWindow.Show();
            this.Hide();
        }
    }

}
