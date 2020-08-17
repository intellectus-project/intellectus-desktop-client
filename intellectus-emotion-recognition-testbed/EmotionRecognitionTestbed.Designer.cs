namespace intellectus_emotion_recognition_testbed
{
    partial class EmotionRecognitionTestbed
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
            this.lstFiles = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.lstEmotions = new System.Windows.Forms.ListView();
            this.lstEmotionsRealTime = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstFiles
            // 
            this.lstFiles.HideSelection = false;
            this.lstFiles.Location = new System.Drawing.Point(55, 41);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(295, 317);
            this.lstFiles.TabIndex = 0;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.List;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(386, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Procesar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstEmotions
            // 
            this.lstEmotions.Enabled = false;
            this.lstEmotions.HideSelection = false;
            this.lstEmotions.Location = new System.Drawing.Point(386, 157);
            this.lstEmotions.Name = "lstEmotions";
            this.lstEmotions.Size = new System.Drawing.Size(250, 201);
            this.lstEmotions.TabIndex = 2;
            this.lstEmotions.UseCompatibleStateImageBehavior = false;
            this.lstEmotions.View = System.Windows.Forms.View.List;
            // 
            // lstEmotionsRealTime
            // 
            this.lstEmotionsRealTime.Enabled = false;
            this.lstEmotionsRealTime.HideSelection = false;
            this.lstEmotionsRealTime.Location = new System.Drawing.Point(669, 157);
            this.lstEmotionsRealTime.Name = "lstEmotionsRealTime";
            this.lstEmotionsRealTime.Size = new System.Drawing.Size(277, 201);
            this.lstEmotionsRealTime.TabIndex = 3;
            this.lstEmotionsRealTime.UseCompatibleStateImageBehavior = false;
            this.lstEmotionsRealTime.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(382, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Full File Analysis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(665, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Real-Time Analysis, each 5 seconds";
            // 
            // EmotionRecognitionTestbed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEmotionsRealTime);
            this.Controls.Add(this.lstEmotions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstFiles);
            this.Name = "EmotionRecognitionTestbed";
            this.Text = "EmotionRecognitionTestbed";
            this.Load += new System.EventHandler(this.EmotionRecognitionTestbed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstFiles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lstEmotions;
        private System.Windows.Forms.ListView lstEmotionsRealTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}