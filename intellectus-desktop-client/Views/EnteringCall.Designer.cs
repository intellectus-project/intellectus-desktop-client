using intellectus_desktop_client.Models;
using System;

namespace intellectus_desktop_client
{
    partial class EnteringCall
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
            this.lblError = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnStartCall = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWeather = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblOpName = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(247, 261);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(181, 13);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Ocurrió un error. Intente nuevamente";
            this.lblError.Visible = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(271, 128);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(125, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Llamada entrante";
            // 
            // btnStartCall
            // 
            this.btnStartCall.Depth = 0;
            this.btnStartCall.Location = new System.Drawing.Point(295, 197);
            this.btnStartCall.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartCall.Name = "btnStartCall";
            this.btnStartCall.Primary = true;
            this.btnStartCall.Size = new System.Drawing.Size(75, 23);
            this.btnStartCall.TabIndex = 10;
            this.btnStartCall.Text = "Atender";
            this.btnStartCall.UseVisualStyleBackColor = true;
            this.btnStartCall.Click += new System.EventHandler(this.btnStartCall_Click);
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
            this.panel1.TabIndex = 1;
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
            this.lblOpName.Location = new System.Drawing.Point(517, 75);
            this.lblOpName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOpName.Name = "lblOpName";
            this.lblOpName.Size = new System.Drawing.Size(0, 19);
            this.lblOpName.TabIndex = 12;
            this.lblOpName.Text = string.Concat(Domain.CurrentUser.Name, " ", Domain.CurrentUser.LastName);
            // 
            // EnteringCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.lblOpName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStartCall);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblError);
            this.Name = "EnteringCall";
            this.Text = "EnteringCall";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblError;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnStartCall;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel lblOpName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblWeather;
    }
}