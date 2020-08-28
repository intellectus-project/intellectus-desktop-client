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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("bla");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Bla");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Bla");
            this.lblTranscurredTimeName = new System.Windows.Forms.Label();
            this.lblTranscurredTime = new System.Windows.Forms.Label();
            this.btnEndCall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOperatorName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.suggestionsList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblTranscurredTimeName
            // 
            this.lblTranscurredTimeName.AutoSize = true;
            this.lblTranscurredTimeName.Location = new System.Drawing.Point(31, 71);
            this.lblTranscurredTimeName.Name = "lblTranscurredTimeName";
            this.lblTranscurredTimeName.Size = new System.Drawing.Size(103, 13);
            this.lblTranscurredTimeName.TabIndex = 2;
            this.lblTranscurredTimeName.Text = "Tiempo transcurrido:";
            // 
            // lblTranscurredTime
            // 
            this.lblTranscurredTime.AccessibleName = "transcurredTime";
            this.lblTranscurredTime.AutoSize = true;
            this.lblTranscurredTime.Location = new System.Drawing.Point(140, 74);
            this.lblTranscurredTime.Name = "lblTranscurredTime";
            this.lblTranscurredTime.Size = new System.Drawing.Size(0, 13);
            this.lblTranscurredTime.TabIndex = 3;
            // 
            // btnEndCall
            // 
            this.btnEndCall.AccessibleName = "btnEndCall";
            this.btnEndCall.Location = new System.Drawing.Point(57, 148);
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Size = new System.Drawing.Size(64, 20);
            this.btnEndCall.TabIndex = 4;
            this.btnEndCall.Text = "Finalizar";
            this.btnEndCall.UseVisualStyleBackColor = true;
            this.btnEndCall.Click += new System.EventHandler(this.btnEndCall_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(196, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 265);
            this.label1.TabIndex = 5;
            // 
            // lblOperatorName
            // 
            this.lblOperatorName.AccessibleName = "lblOperatorName";
            this.lblOperatorName.AutoSize = true;
            this.lblOperatorName.Location = new System.Drawing.Point(415, 17);
            this.lblOperatorName.Name = "lblOperatorName";
            this.lblOperatorName.Size = new System.Drawing.Size(60, 13);
            this.lblOperatorName.TabIndex = 6;
            this.lblOperatorName.Text = string.Concat(Domain.CurrentUser.Name, " ",Domain.CurrentUser.LastName);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // suggestionsList
            // 
            this.suggestionsList.HideSelection = false;
            this.suggestionsList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.suggestionsList.Location = new System.Drawing.Point(283, 60);
            this.suggestionsList.Name = "suggestionsList";
            this.suggestionsList.Size = new System.Drawing.Size(330, 132);
            this.suggestionsList.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.suggestionsList.TabIndex = 9;
            this.suggestionsList.UseCompatibleStateImageBehavior = false;
            this.suggestionsList.View = System.Windows.Forms.View.Tile;
            // 
            // OnCallWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.suggestionsList);
            this.Controls.Add(this.lblOperatorName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEndCall);
            this.Controls.Add(this.lblTranscurredTime);
            this.Controls.Add(this.lblTranscurredTimeName);
            this.Name = "OnCallWindow";
            this.Text = "Suggestions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTranscurredTimeName;
        private System.Windows.Forms.Label lblTranscurredTime;
        private System.Windows.Forms.Button btnEndCall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOperatorName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView suggestionsList;
    }
}