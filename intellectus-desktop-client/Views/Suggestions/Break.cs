using intellectus_desktop_client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intellectus_desktop_client.Views.Suggestions
{
    public partial class Break : MaterialSkin.Controls.MaterialForm
    {
         public static DateTime  target = DateTime.Now.AddMinutes(30);
        public Break()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink400, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey50, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            timer1.Start();
            target = DateTime.Now.AddMinutes(30);
            lblTimeLeft.Text = string.Format("00:{0}:00", Domain.CurrentUser.Call.MinutesDuration);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan diff = target - DateTime.Now;
            if (diff.TotalSeconds <= 0)
            {
                timer1.Stop();
                EnteringCall ec = new EnteringCall();
                ec.Show();
                this.Close();
            }
            else
            {
                lblTimeLeft.Text = diff.ToString("hh':'mm':'ss");
            }
        }
        
    }
}
