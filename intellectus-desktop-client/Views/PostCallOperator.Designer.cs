using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace intellectus_desktop_client.Views.Suggestions
{
    partial class PostCallOperator
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
            this.btnSend = new System.Windows.Forms.Button();
            this.emotion = new System.Windows.Forms.CheckedListBox();
            this.requiredText = new System.Windows.Forms.Label();
            this.lblErrorCreateCall = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Llamada finalizada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "¿Cómo te sentis?";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(311, 181);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(64, 20);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // emotion
            // 
            this.emotion.CheckOnClick = true;
            this.emotion.FormattingEnabled = true;
            this.emotion.HorizontalScrollbar = true;
            this.emotion.Items.AddRange(new object[] {
            "Feliz",
            "Enojado",
            "Triste",
            "Con miedo",
            "Neutral"});
            this.emotion.Location = new System.Drawing.Point(12, 109);
            this.emotion.MultiColumn = true;
            this.emotion.Name = "emotion";
            this.emotion.Size = new System.Drawing.Size(643, 19);
            this.emotion.TabIndex = 3;
            // 
            // requiredText
            // 
            this.requiredText.AutoSize = true;
            this.requiredText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.requiredText.Location = new System.Drawing.Point(237, 145);
            this.requiredText.Name = "requiredText";
            this.requiredText.Size = new System.Drawing.Size(195, 13);
            this.requiredText.TabIndex = 4;
            this.requiredText.Text = "*Debe seleccionar un estado emocional";
            this.requiredText.Visible = false;
            // 
            // lblErrorCreateCall
            // 
            this.lblErrorCreateCall.AutoSize = true;
            this.lblErrorCreateCall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorCreateCall.Location = new System.Drawing.Point(253, 219);
            this.lblErrorCreateCall.Name = "lblErrorCreateCall";
            this.lblErrorCreateCall.Size = new System.Drawing.Size(178, 13);
            this.lblErrorCreateCall.TabIndex = 5;
            this.lblErrorCreateCall.Text = "Ocurió un error. Intente nuevamente";
            this.lblErrorCreateCall.Visible = false;
            // 
            // PostCallOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.lblErrorCreateCall);
            this.Controls.Add(this.requiredText);
            this.Controls.Add(this.emotion);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PostCallOperator";
            this.Text = "PostCall";
            this.Load += new System.EventHandler(this.PostCall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label requiredText;
        private System.Windows.Forms.CheckedListBox emotion;
        private Label lblErrorCreateCall;
    }
}