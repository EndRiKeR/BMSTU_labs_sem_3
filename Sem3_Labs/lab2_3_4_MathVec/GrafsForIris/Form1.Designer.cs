
namespace GrafsForIris
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SL_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.load_btn = new System.Windows.Forms.Button();
            this.path_txt = new System.Windows.Forms.TextBox();
            this.SW_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PL_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PW_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Pie_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MedianChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.SL_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SW_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PL_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PW_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pie_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedianChart)).BeginInit();
            this.SuspendLayout();
            // 
            // SL_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.SL_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SL_chart.Legends.Add(legend1);
            this.SL_chart.Location = new System.Drawing.Point(12, 12);
            this.SL_chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SL_chart.Name = "SL_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Setosa";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Versicolor";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Virginica";
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.SL_chart.Series.Add(series1);
            this.SL_chart.Series.Add(series2);
            this.SL_chart.Series.Add(series3);
            this.SL_chart.Size = new System.Drawing.Size(300, 300);
            this.SL_chart.TabIndex = 0;
            this.SL_chart.Text = "chart1";
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(12, 366);
            this.load_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(605, 263);
            this.load_btn.TabIndex = 5;
            this.load_btn.Text = "LoadFile";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.LoadButtonClick);
            // 
            // path_txt
            // 
            this.path_txt.Location = new System.Drawing.Point(13, 327);
            this.path_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.path_txt.Name = "path_txt";
            this.path_txt.ReadOnly = true;
            this.path_txt.Size = new System.Drawing.Size(605, 22);
            this.path_txt.TabIndex = 6;
            // 
            // SW_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.SW_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.SW_chart.Legends.Add(legend2);
            this.SW_chart.Location = new System.Drawing.Point(317, 12);
            this.SW_chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SW_chart.Name = "SW_chart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Setosa";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Versicolor";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Virginica";
            this.SW_chart.Series.Add(series4);
            this.SW_chart.Series.Add(series5);
            this.SW_chart.Series.Add(series6);
            this.SW_chart.Size = new System.Drawing.Size(300, 300);
            this.SW_chart.TabIndex = 7;
            this.SW_chart.Text = "chart1";
            // 
            // PL_chart
            // 
            chartArea3.Name = "ChartArea1";
            this.PL_chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.PL_chart.Legends.Add(legend3);
            this.PL_chart.Location = new System.Drawing.Point(627, 12);
            this.PL_chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PL_chart.Name = "PL_chart";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Setosa";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Versicolor";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Virginica";
            this.PL_chart.Series.Add(series7);
            this.PL_chart.Series.Add(series8);
            this.PL_chart.Series.Add(series9);
            this.PL_chart.Size = new System.Drawing.Size(300, 300);
            this.PL_chart.TabIndex = 8;
            this.PL_chart.Text = "chart2";
            // 
            // PW_chart
            // 
            chartArea4.Name = "ChartArea1";
            this.PW_chart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.PW_chart.Legends.Add(legend4);
            this.PW_chart.Location = new System.Drawing.Point(933, 12);
            this.PW_chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PW_chart.Name = "PW_chart";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Setosa";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Versicolor";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Virginica";
            this.PW_chart.Series.Add(series10);
            this.PW_chart.Series.Add(series11);
            this.PW_chart.Series.Add(series12);
            this.PW_chart.Size = new System.Drawing.Size(300, 300);
            this.PW_chart.TabIndex = 9;
            this.PW_chart.Text = "chart3";
            // 
            // Pie_chart
            // 
            chartArea5.Name = "ChartArea1";
            this.Pie_chart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.Pie_chart.Legends.Add(legend5);
            this.Pie_chart.Location = new System.Drawing.Point(627, 327);
            this.Pie_chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pie_chart.Name = "Pie_chart";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series13.Legend = "Legend1";
            series13.Name = "Iris";
            this.Pie_chart.Series.Add(series13);
            this.Pie_chart.Size = new System.Drawing.Size(605, 300);
            this.Pie_chart.TabIndex = 10;
            this.Pie_chart.Text = "chart3";
            // 
            // MedianChart
            // 
            chartArea6.Name = "ChartArea1";
            this.MedianChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.MedianChart.Legends.Add(legend6);
            this.MedianChart.Location = new System.Drawing.Point(1239, 190);
            this.MedianChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MedianChart.Name = "MedianChart";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Setosa";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Versicolor";
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "Virginica";
            this.MedianChart.Series.Add(series14);
            this.MedianChart.Series.Add(series15);
            this.MedianChart.Series.Add(series16);
            this.MedianChart.Size = new System.Drawing.Size(300, 300);
            this.MedianChart.TabIndex = 11;
            this.MedianChart.Text = "chart3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 677);
            this.Controls.Add(this.MedianChart);
            this.Controls.Add(this.Pie_chart);
            this.Controls.Add(this.PW_chart);
            this.Controls.Add(this.PL_chart);
            this.Controls.Add(this.SW_chart);
            this.Controls.Add(this.path_txt);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.SL_chart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SL_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SW_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PL_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PW_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pie_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedianChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SL_chart;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.TextBox path_txt;
        private System.Windows.Forms.DataVisualization.Charting.Chart SW_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PL_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PW_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart Pie_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart MedianChart;
    }
}

