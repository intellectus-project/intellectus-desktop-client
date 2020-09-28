using intellectus_desktop_client.Models;
using System;

namespace intellectus_desktop_client.Views.Suggestions
{
    partial class PostCallWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.transcurredTime = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWeather = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblOpName = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(260, 161);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(134, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Llamada finalizada";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(167, 231);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(153, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Tiempo transcurrido: ";
            // 
            // transcurredTime
            // 
            this.transcurredTime.AutoSize = true;
            this.transcurredTime.Depth = 0;
            this.transcurredTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.transcurredTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.transcurredTime.Location = new System.Drawing.Point(395, 231);
            this.transcurredTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.transcurredTime.Name = "transcurredTime";
            this.transcurredTime.Size = new System.Drawing.Size(65, 19);
            this.transcurredTime.TabIndex = 3;
            this.transcurredTime.Text = "00:00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblWeather);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 31);
            this.panel1.TabIndex = 15;
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Depth = 0;
            this.lblWeather.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblWeather.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWeather.Location = new System.Drawing.Point(487, 5);
            this.lblWeather.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(0, 19);
            this.lblWeather.TabIndex = 3;
            this.lblWeather.Text = Domain.CurrentWeather.Descrption;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(13, 5);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(79, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Intellectus";
            // 
            // lblOpName
            // 
            this.lblOpName.AutoSize = true;
            this.lblOpName.Depth = 0;
            this.lblOpName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOpName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOpName.Location = new System.Drawing.Point(491, 74);
            this.lblOpName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOpName.Name = "lblOpName";
            this.lblOpName.Size = new System.Drawing.Size(0, 19);
            this.lblOpName.TabIndex = 16; 
            this.lblOpName.Text = string.Concat(Domain.CurrentUser.Name, " ", Domain.CurrentUser.LastName);

            // 
            // PostCallWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.lblOpName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.transcurredTime);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "PostCallWindow";
            this.Text = "PostCallWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel transcurredTime;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel lblWeather;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblOpName;
    }
}