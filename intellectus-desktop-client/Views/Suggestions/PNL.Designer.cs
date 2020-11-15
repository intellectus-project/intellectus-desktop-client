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
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(190, 133);
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
            this.returnEC.Location = new System.Drawing.Point(322, 220);
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
            // PNL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnEC);
            this.Controls.Add(this.materialLabel1);
            this.Name = "PNL";
            this.Text = "PNL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton returnEC;
    }
}