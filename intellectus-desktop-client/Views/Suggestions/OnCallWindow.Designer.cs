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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Bla");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Bla");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("bla");
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.suggestionsList = new System.Windows.Forms.ListView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTranscurredTime = new MaterialSkin.Controls.MaterialLabel();
            this.btnEndCall = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWeather = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblOpName = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.suggestionsList.Location = new System.Drawing.Point(308, 115);
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
            this.materialLabel1.Location = new System.Drawing.Point(12, 115);
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
            this.lblTranscurredTime.Location = new System.Drawing.Point(167, 115);
            this.lblTranscurredTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTranscurredTime.Name = "lblTranscurredTime";
            this.lblTranscurredTime.Size = new System.Drawing.Size(0, 19);
            this.lblTranscurredTime.TabIndex = 11;
            // 
            // btnEndCall
            // 
            this.btnEndCall.Depth = 0;
            this.btnEndCall.Location = new System.Drawing.Point(86, 224);
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
            this.materialDivider1.Location = new System.Drawing.Point(259, 64);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(5, 500);
            this.materialDivider1.TabIndex = 13;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblWeather);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 31);
            this.panel1.TabIndex = 14;
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Depth = 0;
            this.lblWeather.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblWeather.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWeather.Location = new System.Drawing.Point(487, 5);
            this.lblWeather.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(0, 19);
            this.lblWeather.TabIndex = 3;
            this.lblWeather.Text = Domain.CurrentWeather.Descrption;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(13, 5);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(79, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Intellectus";
            // 
            // lblOpName
            // 
            this.lblOpName.AutoSize = true;
            this.lblOpName.Depth = 0;
            this.lblOpName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOpName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOpName.Location = new System.Drawing.Point(529, 71);
            this.lblOpName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOpName.Name = "lblOpName";
            this.lblOpName.Size = new System.Drawing.Size(0, 19);
            this.lblOpName.TabIndex = 15;
            this.lblOpName.Text = string.Concat(Domain.CurrentUser.Name, " ", Domain.CurrentUser.LastName);
            // 
            // OnCallWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.lblOpName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnEndCall);
            this.Controls.Add(this.lblTranscurredTime);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.suggestionsList);
            this.Name = "OnCallWindow";
            this.Text = "Suggestions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView suggestionsList;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblTranscurredTime;
        private MaterialSkin.Controls.MaterialRaisedButton btnEndCall;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel lblWeather;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblOpName;
    }
}