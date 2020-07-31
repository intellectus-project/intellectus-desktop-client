namespace intellectus_desktop_client
{
    partial class OnCallWindow
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
            this.components = new System.ComponentModel.Container();
            this.lblConsultantName = new System.Windows.Forms.Label();
            this.lblVoiceOrigin = new System.Windows.Forms.Label();
            this.lblTranscurredTimeName = new System.Windows.Forms.Label();
            this.lblTranscurredTime = new System.Windows.Forms.Label();
            this.btnEndCall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOperatorName = new System.Windows.Forms.Label();
            this.suggestionActual = new System.Windows.Forms.TextBox();
            this.suggestionOld = new System.Windows.Forms.TextBox();
            this.suggestionLast = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblConsultantName
            // 
            this.lblConsultantName.AccessibleName = "lblConsultantName";
            this.lblConsultantName.AutoSize = true;
            this.lblConsultantName.Location = new System.Drawing.Point(82, 38);
            this.lblConsultantName.Name = "lblConsultantName";
            this.lblConsultantName.Size = new System.Drawing.Size(53, 15);
            this.lblConsultantName.TabIndex = 0;
            this.lblConsultantName.Text = "Pepa pig";
            // 
            // lblVoiceOrigin
            // 
            this.lblVoiceOrigin.AccessibleName = "lblVoiceOrigin";
            this.lblVoiceOrigin.AutoSize = true;
            this.lblVoiceOrigin.Location = new System.Drawing.Point(82, 85);
            this.lblVoiceOrigin.Name = "lblVoiceOrigin";
            this.lblVoiceOrigin.Size = new System.Drawing.Size(75, 15);
            this.lblVoiceOrigin.TabIndex = 1;
            this.lblVoiceOrigin.Text = "Google meet";
            // 
            // lblTranscurredTimeName
            // 
            this.lblTranscurredTimeName.AutoSize = true;
            this.lblTranscurredTimeName.Location = new System.Drawing.Point(50, 146);
            this.lblTranscurredTimeName.Name = "lblTranscurredTimeName";
            this.lblTranscurredTimeName.Size = new System.Drawing.Size(117, 15);
            this.lblTranscurredTimeName.TabIndex = 2;
            this.lblTranscurredTimeName.Text = "Tiempo transcurrido:";
            // 
            // lblTranscurredTime
            // 
            this.lblTranscurredTime.AccessibleName = "transcurredTime";
            this.lblTranscurredTime.AutoSize = true;
            this.lblTranscurredTime.Location = new System.Drawing.Point(168, 146);
            this.lblTranscurredTime.Name = "lblTranscurredTime";
            this.lblTranscurredTime.Size = new System.Drawing.Size(0, 15);
            this.lblTranscurredTime.TabIndex = 3;
            // 
            // btnEndCall
            // 
            this.btnEndCall.AccessibleName = "btnEndCall";
            this.btnEndCall.Location = new System.Drawing.Point(82, 199);
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Size = new System.Drawing.Size(75, 23);
            this.btnEndCall.TabIndex = 4;
            this.btnEndCall.Text = "Finalizar";
            this.btnEndCall.UseVisualStyleBackColor = true;
            this.btnEndCall.Click += new System.EventHandler(this.btnEndCall_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(229, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 305);
            this.label1.TabIndex = 5;
            // 
            // lblOperatorName
            // 
            this.lblOperatorName.AccessibleName = "lblOperatorName";
            this.lblOperatorName.AutoSize = true;
            this.lblOperatorName.Location = new System.Drawing.Point(484, 20);
            this.lblOperatorName.Name = "lblOperatorName";
            this.lblOperatorName.Size = new System.Drawing.Size(62, 15);
            this.lblOperatorName.TabIndex = 6;
            this.lblOperatorName.Text = "Juan Perez";
            // 
            // suggestionActual
            // 
            this.suggestionActual.AccessibleName = "currentSuggestion";
            this.suggestionActual.BackColor = System.Drawing.SystemColors.Menu;
            this.suggestionActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.suggestionActual.ForeColor = System.Drawing.SystemColors.WindowText;
            this.suggestionActual.Location = new System.Drawing.Point(327, 119);
            this.suggestionActual.Name = "suggestionActual";
            this.suggestionActual.Size = new System.Drawing.Size(100, 16);
            this.suggestionActual.TabIndex = 7;
            this.suggestionActual.Text = "Bla";
            this.suggestionActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // suggestionOld
            // 
            this.suggestionOld.BackColor = System.Drawing.SystemColors.Control;
            this.suggestionOld.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.suggestionOld.ForeColor = System.Drawing.Color.Gray;
            this.suggestionOld.Location = new System.Drawing.Point(327, 159);
            this.suggestionOld.Name = "suggestionOld";
            this.suggestionOld.Size = new System.Drawing.Size(100, 16);
            this.suggestionOld.TabIndex = 8;
            this.suggestionOld.Text = "blaViejo";
            this.suggestionOld.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // suggestionLast
            // 
            this.suggestionLast.BackColor = System.Drawing.SystemColors.Control;
            this.suggestionLast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.suggestionLast.ForeColor = System.Drawing.Color.Silver;
            this.suggestionLast.Location = new System.Drawing.Point(327, 199);
            this.suggestionLast.Name = "suggestionLast";
            this.suggestionLast.Size = new System.Drawing.Size(100, 16);
            this.suggestionLast.TabIndex = 8;
            this.suggestionLast.Text = "blaAnterior";
            this.suggestionLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OnCallWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.suggestionLast);
            this.Controls.Add(this.suggestionOld);
            this.Controls.Add(this.suggestionActual);
            this.Controls.Add(this.lblOperatorName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEndCall);
            this.Controls.Add(this.lblTranscurredTime);
            this.Controls.Add(this.lblTranscurredTimeName);
            this.Controls.Add(this.lblConsultantName);
            this.Controls.Add(this.lblVoiceOrigin);
            this.Name = "OnCallWindow";
            this.Text = "Suggestions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultantName;
        private System.Windows.Forms.Label lblVoiceOrigin;
        private System.Windows.Forms.Label lblTranscurredTimeName;
        private System.Windows.Forms.Label lblTranscurredTime;
        private System.Windows.Forms.Button btnEndCall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOperatorName;
        private System.Windows.Forms.TextBox suggestionActual;
        private System.Windows.Forms.TextBox suggestionOld;
        private System.Windows.Forms.TextBox suggestionLast;
        private System.Windows.Forms.Timer timer1;
    }
}