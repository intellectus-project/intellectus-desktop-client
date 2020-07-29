using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
                //Guardar emoción operador
                Console.WriteLine(emotion.SelectedIndex);
                Console.WriteLine(emotion.SelectedItem);


                PostCallWindow postCallWindow = new PostCallWindow();
                postCallWindow.Show();
                this.Hide();
            }
            else
            {
                requiredText.Visible = true;
            }

        }
    }
}
