using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace intellectus_desktop_client
{
    public partial class pruebas : Form
    {
        public pruebas()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            OnCallWindow onCallWindow = (OnCallWindow)Application.OpenForms["OnCallWindow"];
            onCallWindow.Suggest(sugerencia.Text);
        }
    }
}
