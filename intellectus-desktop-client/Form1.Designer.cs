namespace intellectus_desktop_client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cmbRecorder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lstEmotions = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(55, 178);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Grabar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbRecorder
            // 
            this.cmbRecorder.FormattingEnabled = true;
            this.cmbRecorder.Items.AddRange(new object[] {
            "Sonido entrante",
            "Sonido saliente"});
            this.cmbRecorder.Location = new System.Drawing.Point(55, 76);
            this.cmbRecorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRecorder.Name = "cmbRecorder";
            this.cmbRecorder.Size = new System.Drawing.Size(259, 24);
            this.cmbRecorder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona la opcion";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(220, 178);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(94, 23);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Detener";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // folderDialog
            // 
            this.folderDialog.HelpRequest += new System.EventHandler(this.folderDialog_HelpRequest);
            // 
            // lstEmotions
            // 
            this.lstEmotions.HideSelection = false;
            this.lstEmotions.Location = new System.Drawing.Point(464, 45);
            this.lstEmotions.Name = "lstEmotions";
            this.lstEmotions.Size = new System.Drawing.Size(635, 254);
            this.lstEmotions.TabIndex = 3;
            this.lstEmotions.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 311);
            this.Controls.Add(this.lstEmotions);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRecorder);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Grabado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbRecorder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.ListView lstEmotions;
    }
}

