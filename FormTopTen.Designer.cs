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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTopTen));
            this.chartTop = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.guardarGráficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop)).BeginInit();
            this.ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartTop
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTop.ChartAreas.Add(chartArea1);
            this.chartTop.ContextMenuStrip = this.ContextMenuStrip;
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
            dataPoint1.LegendText = "I Want to Break Free";
            dataPoint2.LegendText = "Lost Cause";
            dataPoint3.LegendText = "Cherry Wine";
            dataPoint4.LegendText = "Talk Too Much";
            dataPoint5.LegendText = "Northern Attitude";
            dataPoint6.LegendText = "Red Wine Supernova";
            dataPoint7.LegendText = "Life on Mars?";
            dataPoint8.LegendText = "Arabella";
            dataPoint9.LegendText = "Not Strong Enough";
            dataPoint10.LegendText = "The 1";
            dataPoint11.LegendText = "Moonage Daydream";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.Points.Add(dataPoint10);
            series1.Points.Add(dataPoint11);
            this.chartTop.Series.Add(series1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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