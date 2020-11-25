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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostCallOperator));
            this.emotion = new System.Windows.Forms.CheckedListBox();
            this.lblErrorCreateCall = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.requiredText = new MaterialSkin.Controls.MaterialLabel();
            this.btnSend = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // emotion
            // 
            this.emotion.CheckOnClick = true;
            
            this.emotion.FormattingEnabled = true;
            this.emotion.HorizontalScrollbar = true;
            Dictionary<int, string> list = new Dictionary<int, string>();
            list.Add(0, "Triste");
            list.Add(1, "Feliz");
            list.Add(2, "Con miedo");
            list.Add(3, "Neutral");
            list.Add(4, "Enojado");
            this.emotion.DataSource = new BindingSource(list, null);
            this.emotion.ValueMember = "Key";
            this.emotion.DisplayMember = "Value";
            this.emotion.Location = new System.Drawing.Point(17, 177);
            this.emotion.MultiColumn = true;
            this.emotion.Name = "emotion";
            this.emotion.Size = new System.Drawing.Size(643, 19);
            this.emotion.TabIndex = 3;
            // 
            // lblErrorCreateCall
            // 
            this.lblErrorCreateCall.AutoSize = true;
            this.lblErrorCreateCall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorCreateCall.Location = new System.Drawing.Point(256, 305);
            this.lblErrorCreateCall.Name = "lblErrorCreateCall";
            this.lblErrorCreateCall.Size = new System.Drawing.Size(178, 13);
            this.lblErrorCreateCall.TabIndex = 5;
            this.lblErrorCreateCall.Text = "Ocurió un error. Intente nuevamente";
            this.lblErrorCreateCall.Visible = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(280, 97);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(134, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Llamada finalizada";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(284, 138);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(126, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "¿Cómo te sentís?";
            // 
            // requiredText
            // 
            this.requiredText.AutoSize = true;
            this.requiredText.Depth = 0;
            this.requiredText.Font = new System.Drawing.Font("Roboto", 11F);
            this.requiredText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.requiredText.Location = new System.Drawing.Point(241, 224);
            this.requiredText.MouseState = MaterialSkin.MouseState.HOVER;
            this.requiredText.Name = "requiredText";
            this.requiredText.Size = new System.Drawing.Size(276, 19);
            this.requiredText.TabIndex = 8;
            this.requiredText.Text = "*Debe seleccionar un estado emocional";
            this.requiredText.Visible = false;
            // 
            // btnSend
            // 
            this.btnSend.Depth = 0;
            this.btnSend.Location = new System.Drawing.Point(308, 258);
            this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.Primary = true;
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // PostCallOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.requiredText);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblErrorCreateCall);
            this.Controls.Add(this.emotion);
            this.Name = "PostCallOperator";
            this.Text = "INTELLECTUS";
            this.Load += new System.EventHandler(this.PostCall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox emotion;
        private Label lblErrorCreateCall;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel requiredText;
        private MaterialSkin.Controls.MaterialRaisedButton btnSend;
    }
}