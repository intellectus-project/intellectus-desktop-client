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
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartCall = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
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
            this.lblOperatorName.Text = String.Concat(Domain.CurrentUser.Name, " ", Domain.CurrentUser.LastName);
            // 
            // label2
            // 
            this.label2.AccessibleName = "lblEnteringCall";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Llamada entrante";
            // 
            // btnStartCall
            // 
            this.btnStartCall.AccessibleName = "btnStartCall";
            this.btnStartCall.Location = new System.Drawing.Point(314, 162);
            this.btnStartCall.Name = "btnStartCall";
            this.btnStartCall.Size = new System.Drawing.Size(64, 20);
            this.btnStartCall.TabIndex = 7;
            this.btnStartCall.Text = "Atender";
            this.btnStartCall.UseVisualStyleBackColor = true;
            this.btnStartCall.Click += new System.EventHandler(this.btnStartCall_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(250, 206);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(181, 13);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Ocurrió un error. Intente nuevamente";
            this.lblError.Visible = false;
            // 
            // EnteringCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnStartCall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOperatorName);
            this.Name = "EnteringCall";
            this.Text = "EnteringCalll";
            this.Load += new System.EventHandler(this.EnteringCalll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperatorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartCall;
        private System.Windows.Forms.Label lblError;
    }
}