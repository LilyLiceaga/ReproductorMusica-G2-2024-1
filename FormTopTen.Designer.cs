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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint21 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint22 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            this.chartTop = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.guardarGráficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop)).BeginInit();
            this.ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartTop
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTop.ChartAreas.Add(chartArea2);
            this.chartTop.ContextMenuStrip = this.ContextMenuStrip;
            legend2.Name = "Legend1";
            legend2.Title = "TOP TEN";
            this.chartTop.Legends.Add(legend2);
            this.chartTop.Location = new System.Drawing.Point(77, 41);
            this.chartTop.Name = "chartTop";
            this.chartTop.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Serie Top";
            dataPoint12.LegendText = "I Want to Break Free";
            dataPoint13.LegendText = "Lost Cause";
            dataPoint14.LegendText = "Cherry Wine";
            dataPoint15.LegendText = "Talk Too Much";
            dataPoint16.LegendText = "Northern Attitude";
            dataPoint17.LegendText = "Red Wine Supernova";
            dataPoint18.LegendText = "Life on Mars?";
            dataPoint19.LegendText = "Arabella";
            dataPoint20.LegendText = "Not Strong Enough";
            dataPoint21.LegendText = "The 1";
            dataPoint22.LegendText = "Moonage Daydream";
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series2.Points.Add(dataPoint15);
            series2.Points.Add(dataPoint16);
            series2.Points.Add(dataPoint17);
            series2.Points.Add(dataPoint18);
            series2.Points.Add(dataPoint19);
            series2.Points.Add(dataPoint20);
            series2.Points.Add(dataPoint21);
            series2.Points.Add(dataPoint22);
            this.chartTop.Series.Add(series2);
            this.chartTop.Size = new System.Drawing.Size(650, 363);
            this.chartTop.TabIndex = 0;
            this.chartTop.Text = "chart1";
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarGráficoToolStripMenuItem});
            this.ContextMenuStrip.Name = "topTenToolStripMenuItem";
            this.ContextMenuStrip.Size = new System.Drawing.Size(158, 26);
            // 
            // guardarGráficoToolStripMenuItem
            // 
            this.guardarGráficoToolStripMenuItem.Name = "guardarGráficoToolStripMenuItem";
            this.guardarGráficoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarGráficoToolStripMenuItem.Text = "Guardar Gráfico";
            this.guardarGráficoToolStripMenuItem.Click += new System.EventHandler(this.guardarGráficoToolStripMenuItem_Click);
            // 
            // FormTopTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.ContextMenuStrip;
            this.Controls.Add(this.chartTop);
            this.Name = "FormTopTen";
            this.Text = "TOP TEN CANCIONES";
            ((System.ComponentModel.ISupportInitialize)(this.chartTop)).EndInit();
            this.ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem guardarGráficoToolStripMenuItem;
    }
}