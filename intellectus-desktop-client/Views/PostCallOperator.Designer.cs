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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Llamada finalizada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "¿Cómo te sentis?";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(320, 209);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // emotion
            // 
            this.emotion.FormattingEnabled = true;
            this.emotion.HorizontalScrollbar = true;
            this.emotion.Items.AddRange(new object[] {
            "Feliz",
            "Enojado",
            "Triste",
            "Con miedo",
            "Neutral"});
            this.emotion.Location = new System.Drawing.Point(77, 143);
            this.emotion.MultiColumn = true;
            this.emotion.Name = "emotion";
            this.emotion.Size = new System.Drawing.Size(604, 22);
            this.emotion.TabIndex = 3;
            // 
            // requiredText
            // 
            this.requiredText.AutoSize = true;
            this.requiredText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.requiredText.Location = new System.Drawing.Point(211, 168);
            this.requiredText.Name = "requiredText";
            this.requiredText.Size = new System.Drawing.Size(266, 15);
            this.requiredText.TabIndex = 4;
            this.requiredText.Text = "*Debe seleccionar al menos un estado emocional";
            this.requiredText.Visible = false;
            // 
            // PostCallOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.CheckedListBox emotion;
        private System.Windows.Forms.Label requiredText;
    }
}