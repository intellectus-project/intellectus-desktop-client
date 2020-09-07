namespace intellectus_emotion_recognition_testbed
{
    partial class EmotionRecognitionTestbed
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lstFiles = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.lstEmotions = new System.Windows.Forms.ListView();
            this.lstEmotionsRealTime = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emotionalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.emotionalChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lstFiles
            // 
            this.lstFiles.HideSelection = false;
            this.lstFiles.Location = new System.Drawing.Point(55, 41);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(295, 317);
            this.lstFiles.TabIndex = 0;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.List;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(386, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Procesar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstEmotions
            // 
            this.lstEmotions.Enabled = false;
            this.lstEmotions.HideSelection = false;
            this.lstEmotions.Location = new System.Drawing.Point(386, 157);
            this.lstEmotions.Name = "lstEmotions";
            this.lstEmotions.Size = new System.Drawing.Size(250, 201);
            this.lstEmotions.TabIndex = 2;
            this.lstEmotions.UseCompatibleStateImageBehavior = false;
            this.lstEmotions.View = System.Windows.Forms.View.List;
            // 
            // lstEmotionsRealTime
            // 
            this.lstEmotionsRealTime.Enabled = false;
            this.lstEmotionsRealTime.HideSelection = false;
            this.lstEmotionsRealTime.Location = new System.Drawing.Point(669, 157);
            this.lstEmotionsRealTime.Name = "lstEmotionsRealTime";
            this.lstEmotionsRealTime.Size = new System.Drawing.Size(277, 201);
            this.lstEmotionsRealTime.TabIndex = 3;
            this.lstEmotionsRealTime.UseCompatibleStateImageBehavior = false;
            this.lstEmotionsRealTime.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(382, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Full File Analysis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(665, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Real-Time Analysis, each 5 seconds";
            // 
            // emotionalChart
            // 
            chartArea1.Name = "ChartArea1";
            this.emotionalChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.emotionalChart.Legends.Add(legend1);
            this.emotionalChart.Location = new System.Drawing.Point(55, 400);
            this.emotionalChart.Name = "emotionalChart";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.Name = "Happiness";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Fuchsia;
            series2.Legend = "Legend1";
            series2.Name = "Sadness";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Neutrality";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Fear";
            series5.BorderWidth = 5;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.Name = "Anger";
            this.emotionalChart.Series.Add(series1);
            this.emotionalChart.Series.Add(series2);
            this.emotionalChart.Series.Add(series3);
            this.emotionalChart.Series.Add(series4);
            this.emotionalChart.Series.Add(series5);
            this.emotionalChart.Size = new System.Drawing.Size(914, 300);
            this.emotionalChart.TabIndex = 6;
            this.emotionalChart.Text = "emotionalChart";
            // 
            // EmotionRecognitionTestbed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 712);
            this.Controls.Add(this.emotionalChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEmotionsRealTime);
            this.Controls.Add(this.lstEmotions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstFiles);
            this.Name = "EmotionRecognitionTestbed";
            this.Text = "EmotionRecognitionTestbed";
            this.Load += new System.EventHandler(this.EmotionRecognitionTestbed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emotionalChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstFiles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lstEmotions;
        private System.Windows.Forms.ListView lstEmotionsRealTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart emotionalChart;
    }
}