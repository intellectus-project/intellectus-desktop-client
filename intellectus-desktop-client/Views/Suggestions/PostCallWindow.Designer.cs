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
            this.weather = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.operatorName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(263, 142);
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
            this.materialLabel2.Location = new System.Drawing.Point(170, 212);
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
            this.transcurredTime.Location = new System.Drawing.Point(398, 212);
            this.transcurredTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.transcurredTime.Name = "transcurredTime";
            this.transcurredTime.Size = new System.Drawing.Size(65, 19);
            this.transcurredTime.TabIndex = 3;
            this.transcurredTime.Text = "00:00:00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.weather);
            this.panel1.Controls.Add(this.materialSingleLineTextField1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 31);
            this.panel1.TabIndex = 16;
            // 
            // weather
            // 
            this.weather.Depth = 0;
            this.weather.Hint = "";
            this.weather.Location = new System.Drawing.Point(464, 5);
            this.weather.MouseState = MaterialSkin.MouseState.HOVER;
            this.weather.Name = "weather";
            this.weather.PasswordChar = '\0';
            this.weather.SelectedText = "";
            this.weather.SelectionLength = 0;
            this.weather.SelectionStart = 0;
            this.weather.Size = new System.Drawing.Size(215, 23);
            this.weather.TabIndex = 1;
            this.weather.Text = "nubes perro";
            this.weather.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(13, 4);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(75, 23);
            this.materialSingleLineTextField1.TabIndex = 0;
            this.materialSingleLineTextField1.Text = "Intellectus";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // operatorName
            // 
            this.operatorName.Depth = 0;
            this.operatorName.Hint = "";
            this.operatorName.Location = new System.Drawing.Point(442, 67);
            this.operatorName.MouseState = MaterialSkin.MouseState.HOVER;
            this.operatorName.Name = "operatorName";
            this.operatorName.PasswordChar = '\0';
            this.operatorName.SelectedText = "";
            this.operatorName.SelectionLength = 0;
            this.operatorName.SelectionStart = 0;
            this.operatorName.Size = new System.Drawing.Size(237, 23);
            this.operatorName.TabIndex = 15;
            this.operatorName.UseSystemPasswordChar = false;
            this.operatorName.Text = string.Concat(Domain.CurrentUser.Name, " ", Domain.CurrentUser.LastName);

            // 
            // PostCallWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.operatorName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.transcurredTime);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "PostCallWindow";
            this.Text = "PostCallWindow";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel transcurredTime;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField weather;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField operatorName;
    }
}