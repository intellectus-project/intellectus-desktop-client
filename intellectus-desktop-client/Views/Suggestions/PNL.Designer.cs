namespace intellectus_desktop_client.Views.Suggestions
{
    partial class PNL
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
            this.returnEC = new MaterialSkin.Controls.MaterialFlatButton();
            this.transcurredTime = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(190, 230);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(347, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Esperamos que el siguiente video te sea de ayuda.";
            // 
            // returnEC
            // 
            this.returnEC.AutoSize = true;
            this.returnEC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.returnEC.Depth = 0;
            this.returnEC.Location = new System.Drawing.Point(322, 317);
            this.returnEC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.returnEC.MouseState = MaterialSkin.MouseState.HOVER;
            this.returnEC.Name = "returnEC";
            this.returnEC.Primary = false;
            this.returnEC.Size = new System.Drawing.Size(63, 36);
            this.returnEC.TabIndex = 2;
            this.returnEC.Text = "volver";
            this.returnEC.UseVisualStyleBackColor = true;
            this.returnEC.Click += new System.EventHandler(this.returnEC_Click);
            // 
            // transcurredTime
            // 
            this.transcurredTime.AutoSize = true;
            this.transcurredTime.Depth = 0;
            this.transcurredTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.transcurredTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.transcurredTime.Location = new System.Drawing.Point(417, 132);
            this.transcurredTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.transcurredTime.Name = "transcurredTime";
            this.transcurredTime.Size = new System.Drawing.Size(65, 19);
            this.transcurredTime.TabIndex = 6;
            this.transcurredTime.Text = OnCallWindow.TranscurredTime.Elapsed.ToString("hh':'mm':'ss");
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(190, 132);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(153, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Tiempo transcurrido: ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(283, 82);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(134, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Llamada finalizada";
            // 
            // PNL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transcurredTime);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.returnEC);
            this.Controls.Add(this.materialLabel1);
            this.Name = "PNL";
            this.Text = "INTELLECTUS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton returnEC;
        private MaterialSkin.Controls.MaterialLabel transcurredTime;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}