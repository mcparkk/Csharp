namespace Chinook.Forms
{
    partial class AlbumChartForm
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
            this.chtChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bdsAlbumModel = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chtChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAlbumModel)).BeginInit();
            this.SuspendLayout();
            // 
            // chtChart
            // 
            chartArea1.Name = "ChartArea1";
            this.chtChart.ChartAreas.Add(chartArea1);
            this.chtChart.DataSource = this.bdsAlbumModel;
            this.chtChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chtChart.Legends.Add(legend1);
            this.chtChart.Location = new System.Drawing.Point(0, 0);
            this.chtChart.Name = "chtChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "Letter";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueMembers = "Count";
            this.chtChart.Series.Add(series1);
            this.chtChart.Size = new System.Drawing.Size(566, 434);
            this.chtChart.TabIndex = 0;
            this.chtChart.Text = "chart1";
            // 
            // bdsAlbumModel
            // 
            this.bdsAlbumModel.DataSource = typeof(Chinook.Data.Models.AlbumModel);
            // 
            // AlbumChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 434);
            this.Controls.Add(this.chtChart);
            this.Name = "AlbumChartForm";
            this.Text = "AlbumChartForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chtChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAlbumModel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtChart;
        private System.Windows.Forms.BindingSource bdsAlbumModel;
    }
}