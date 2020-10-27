namespace intellectus_desktop_client.Views.Suggestions
{
    partial class TakeABreak
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
            this.msg = new MaterialSkin.Controls.MaterialLabel();
            this.returnEC = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnTakeABreak = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Depth = 0;
            this.msg.Font = new System.Drawing.Font("Roboto", 11F);
            this.msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.msg.Location = new System.Drawing.Point(84, 150);
            this.msg.MouseState = MaterialSkin.MouseState.HOVER;
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(17, 19);
            this.msg.TabIndex = 0;
            this.msg.Text = "=";
            // 
            // returnEC
            // 
            this.returnEC.AutoSize = true;
            this.returnEC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.returnEC.Depth = 0;
            this.returnEC.Location = new System.Drawing.Point(512, 258);
            this.returnEC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.returnEC.MouseState = MaterialSkin.MouseState.HOVER;
            this.returnEC.Name = "returnEC";
            this.returnEC.Primary = false;
            this.returnEC.Size = new System.Drawing.Size(63, 36);
            this.returnEC.TabIndex = 1;
            this.returnEC.Text = "volver";
            this.returnEC.UseVisualStyleBackColor = true;
            this.returnEC.Click += new System.EventHandler(this.returnEC_Click);
            // 
            // btnTakeABreak
            // 
            this.btnTakeABreak.Depth = 0;
            this.btnTakeABreak.Location = new System.Drawing.Point(274, 258);
            this.btnTakeABreak.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTakeABreak.Name = "btnTakeABreak";
            this.btnTakeABreak.Primary = true;
            this.btnTakeABreak.Size = new System.Drawing.Size(104, 36);
            this.btnTakeABreak.TabIndex = 2;
            this.btnTakeABreak.Text = "Tomar descanso";
            this.btnTakeABreak.UseVisualStyleBackColor = true;
            // 
            // TakeABreak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTakeABreak);
            this.Controls.Add(this.returnEC);
            this.Controls.Add(this.msg);
            this.Name = "TakeABreak";
            this.Text = "PostCallSuggestions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel msg;
        private MaterialSkin.Controls.MaterialFlatButton returnEC;
        private MaterialSkin.Controls.MaterialRaisedButton btnTakeABreak;
    }
}