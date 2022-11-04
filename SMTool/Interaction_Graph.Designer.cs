namespace SMTool
{
    partial class Interaction_Graph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Interaction_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_pie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Interaction_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_pie)).BeginInit();
            this.SuspendLayout();
            // 
            // Interaction_Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Interaction_Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Interaction_Chart.Legends.Add(legend1);
            this.Interaction_Chart.Location = new System.Drawing.Point(34, 34);
            this.Interaction_Chart.Name = "Interaction_Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Interaction_Chart.Series.Add(series1);
            this.Interaction_Chart.Size = new System.Drawing.Size(509, 439);
            this.Interaction_Chart.TabIndex = 1;
            this.Interaction_Chart.Text = "chart1";
            this.Interaction_Chart.Customize += new System.EventHandler(this.Interaction_Chart_Customize);
            // 
            // chart_pie
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_pie.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_pie.Legends.Add(legend2);
            this.chart_pie.Location = new System.Drawing.Point(576, 34);
            this.chart_pie.Name = "chart_pie";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_pie.Series.Add(series2);
            this.chart_pie.Size = new System.Drawing.Size(509, 439);
            this.chart_pie.TabIndex = 2;
            this.chart_pie.Text = "chart1";
            // 
            // Interaction_Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 500);
            this.Controls.Add(this.chart_pie);
            this.Controls.Add(this.Interaction_Chart);
            this.Name = "Interaction_Graph";
            this.Text = "Etkileşim Grafiği";
            this.Load += new System.EventHandler(this.Interaction_Graph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Interaction_Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_pie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataVisualization.Charting.Chart Interaction_Chart;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart_pie;
    }
}