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
            this.lblOperatorName.Location = new System.Drawing.Point(553, 21);
            this.lblOperatorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperatorName.Name = "lblOperatorName";
            this.lblOperatorName.Size = new System.Drawing.Size(0, 17);
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
            this.suggestionsList.Location = new System.Drawing.Point(411, 113);
            this.suggestionsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.suggestionsList.Name = "suggestionsList";
            this.suggestionsList.Size = new System.Drawing.Size(440, 162);
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
            this.materialLabel1.Location = new System.Drawing.Point(16, 113);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(186, 24);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Tiempo transcurrido:";
            // 
            // lblTranscurredTime
            // 
            this.lblTranscurredTime.AutoSize = true;
            this.lblTranscurredTime.Depth = 0;
            this.lblTranscurredTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTranscurredTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTranscurredTime.Location = new System.Drawing.Point(223, 113);
            this.lblTranscurredTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTranscurredTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTranscurredTime.Name = "lblTranscurredTime";
            this.lblTranscurredTime.Size = new System.Drawing.Size(0, 24);
            this.lblTranscurredTime.TabIndex = 11;
            // 
            // btnEndCall
            // 
            this.btnEndCall.Depth = 0;
            this.btnEndCall.Location = new System.Drawing.Point(115, 247);
            this.btnEndCall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEndCall.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Primary = true;
            this.btnEndCall.Size = new System.Drawing.Size(100, 28);
            this.btnEndCall.TabIndex = 12;
            this.btnEndCall.Text = "Finalizar";
            this.btnEndCall.UseVisualStyleBackColor = true;
            this.btnEndCall.Click += new System.EventHandler(this.btnEndCall_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(345, 75);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(7, 615);
            this.materialDivider1.TabIndex = 13;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // OnCallWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 480);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnEndCall);
            this.Controls.Add(this.lblTranscurredTime);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.suggestionsList);
            this.Controls.Add(this.lblOperatorName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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