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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transcurredTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Llamada finalizada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tiempo transcurrido:";
            // 
            // transcurredTime
            // 
            this.transcurredTime.AutoSize = true;
            this.transcurredTime.Location = new System.Drawing.Point(361, 58);
            this.transcurredTime.Name = "transcurredTime";
            this.transcurredTime.Size = new System.Drawing.Size(0, 15);
            this.transcurredTime.Text = Domain.CurrentUser.Call.EndTime.Subtract(Domain.CurrentUser.Call.StartTime).ToString("hh':'mm':'ss");
            this.transcurredTime.TabIndex = 0;
            // 
            // PostCallWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transcurredTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PostCallWindow";
            this.Text = "PostCallWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label transcurredTime;
    }
}