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
            this.lblOperatorName = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnStartCall = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lblOperatorName
            // 
            this.lblOperatorName.AccessibleName = "lblOperatorName";
            this.lblOperatorName.AutoSize = true;
            this.lblOperatorName.Location = new System.Drawing.Point(411, 17);
            this.lblOperatorName.Name = "lblOperatorName";
            this.lblOperatorName.Size = new System.Drawing.Size(0, 13);
            this.lblOperatorName.TabIndex = 6;
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
            // EnteringCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.btnStartCall);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblOperatorName);
            this.Name = "EnteringCall";
            this.Text = "EnteringCall";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperatorName;
        private System.Windows.Forms.Label lblError;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnStartCall;
    }
}