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
            this.btnBackEC = new MaterialSkin.Controls.MaterialRaisedButton();
            this.helpButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(260, 112);
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
            this.materialLabel2.Location = new System.Drawing.Point(167, 182);
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
            this.transcurredTime.Location = new System.Drawing.Point(395, 182);
            this.transcurredTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.transcurredTime.Name = "transcurredTime";
            this.transcurredTime.Size = new System.Drawing.Size(65, 19);
            this.transcurredTime.TabIndex = 3;
            this.transcurredTime.Text = "00:00:00";
            // 
            // btnBackEC
            // 
            this.btnBackEC.Depth = 0;
            this.btnBackEC.Location = new System.Drawing.Point(568, 307);
            this.btnBackEC.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackEC.Name = "btnBackEC";
            this.btnBackEC.Primary = true;
            this.btnBackEC.Size = new System.Drawing.Size(75, 23);
            this.btnBackEC.TabIndex = 4;
            this.btnBackEC.Text = "Volver";
            this.btnBackEC.UseVisualStyleBackColor = true;
            this.btnBackEC.Click += new System.EventHandler(this.btnBackEC_Click);
            // 
            // helpButton
            // 
            this.helpButton.Depth = 0;
            this.helpButton.Location = new System.Drawing.Point(291, 289);
            this.helpButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpButton.Name = "helpButton";
            this.helpButton.Primary = true;
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "HELP";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // PostCallWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.btnBackEC);
            this.Controls.Add(this.transcurredTime);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "PostCallWindow";
            this.Text = "PostCallWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel transcurredTime;
        private MaterialSkin.Controls.MaterialRaisedButton btnBackEC;
        private MaterialSkin.Controls.MaterialRaisedButton helpButton;
    }
}