using intellectus_desktop_client.Models;

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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.lblOperatorName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.suggestionsList = new System.Windows.Forms.ListView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTranscurredTime = new MaterialSkin.Controls.MaterialLabel();
            this.btnEndCall = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // lblOperatorName
            // 
            this.lblOperatorName.AccessibleName = "lblOperatorName";
            this.lblOperatorName.AutoSize = true;
            this.lblOperatorName.Location = new System.Drawing.Point(415, 17);
            this.lblOperatorName.Name = "lblOperatorName";
            this.lblOperatorName.Size = new System.Drawing.Size(0, 13);
            this.lblOperatorName.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // suggestionsList
            // 
            this.suggestionsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.suggestionsList.HideSelection = false;
            this.suggestionsList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.suggestionsList.Location = new System.Drawing.Point(308, 92);
            this.suggestionsList.Name = "suggestionsList";
            this.suggestionsList.Size = new System.Drawing.Size(330, 132);
            this.suggestionsList.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.suggestionsList.TabIndex = 9;
            this.suggestionsList.UseCompatibleStateImageBehavior = false;
            this.suggestionsList.View = System.Windows.Forms.View.Tile;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 92);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(149, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Tiempo transcurrido:";
            // 
            // lblTranscurredTime
            // 
            this.lblTranscurredTime.AutoSize = true;
            this.lblTranscurredTime.Depth = 0;
            this.lblTranscurredTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTranscurredTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTranscurredTime.Location = new System.Drawing.Point(167, 92);
            this.lblTranscurredTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTranscurredTime.Name = "lblTranscurredTime";
            this.lblTranscurredTime.Size = new System.Drawing.Size(0, 19);
            this.lblTranscurredTime.TabIndex = 11;
            // 
            // btnEndCall
            // 
            this.btnEndCall.Depth = 0;
            this.btnEndCall.Location = new System.Drawing.Point(86, 201);
            this.btnEndCall.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Primary = true;
            this.btnEndCall.Size = new System.Drawing.Size(75, 23);
            this.btnEndCall.TabIndex = 12;
            this.btnEndCall.Text = "Finalizar";
            this.btnEndCall.UseVisualStyleBackColor = true;
            this.btnEndCall.Click += new System.EventHandler(this.btnEndCall_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(259, 61);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(5, 500);
            this.materialDivider1.TabIndex = 13;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // OnCallWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnEndCall);
            this.Controls.Add(this.lblTranscurredTime);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.suggestionsList);
            this.Controls.Add(this.lblOperatorName);
            this.Name = "OnCallWindow";
            this.Text = "INTELLECTUS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOperatorName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView suggestionsList;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblTranscurredTime;
        private MaterialSkin.Controls.MaterialRaisedButton btnEndCall;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}