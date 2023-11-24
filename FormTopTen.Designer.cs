namespace ReproductorMusica_G2_2024_1
{
    partial class FormTopTen
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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(50D, 50D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(50D, 50D);
            this.chartTop = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTop
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTop.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "TOP TEN";
            this.chartTop.Legends.Add(legend1);
            this.chartTop.Location = new System.Drawing.Point(77, 41);
            this.chartTop.Name = "chartTop";
            this.chartTop.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Serie Top";
            dataPoint1.LegendText = "Lost Cause";
            dataPoint2.LegendText = "I Want to Break Free";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.chartTop.Series.Add(series1);
            this.chartTop.Size = new System.Drawing.Size(650, 363);
            this.chartTop.TabIndex = 0;
            this.chartTop.Text = "chart1";
            // 
            // FormTopTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartTop);
            this.Name = "FormTopTen";
            this.Text = "FormTopTen";
            ((System.ComponentModel.ISupportInitialize)(this.chartTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop;
    }
}