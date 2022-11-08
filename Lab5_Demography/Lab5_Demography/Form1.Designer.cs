namespace Lab5_Demography
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LoadAges_btn = new System.Windows.Forms.Button();
            this.LoadDeath_btn = new System.Windows.Forms.Button();
            this.start_age_lbl = new System.Windows.Forms.Label();
            this.end_age_lbl = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.population_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.population_lbl = new System.Windows.Forms.Label();
            this.start_age_nud = new System.Windows.Forms.NumericUpDown();
            this.end_age_nud = new System.Windows.Forms.NumericUpDown();
            this.population_nud = new System.Windows.Forms.NumericUpDown();
            this.demography_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.population_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_age_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.end_age_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.population_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demography_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadAges_btn
            // 
            this.LoadAges_btn.Location = new System.Drawing.Point(56, 202);
            this.LoadAges_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadAges_btn.Name = "LoadAges_btn";
            this.LoadAges_btn.Size = new System.Drawing.Size(163, 118);
            this.LoadAges_btn.TabIndex = 0;
            this.LoadAges_btn.Text = "LoadInitialAges";
            this.LoadAges_btn.UseVisualStyleBackColor = true;
            this.LoadAges_btn.Click += new System.EventHandler(this.LoadAges_btn_Click);
            // 
            // LoadDeath_btn
            // 
            this.LoadDeath_btn.Location = new System.Drawing.Point(56, 335);
            this.LoadDeath_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadDeath_btn.Name = "LoadDeath_btn";
            this.LoadDeath_btn.Size = new System.Drawing.Size(163, 118);
            this.LoadDeath_btn.TabIndex = 1;
            this.LoadDeath_btn.Text = "LoadDeathRule";
            this.LoadDeath_btn.UseVisualStyleBackColor = true;
            this.LoadDeath_btn.Click += new System.EventHandler(this.LoadDeath_btn_Click);
            // 
            // start_age_lbl
            // 
            this.start_age_lbl.AutoSize = true;
            this.start_age_lbl.Location = new System.Drawing.Point(52, 46);
            this.start_age_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.start_age_lbl.Name = "start_age_lbl";
            this.start_age_lbl.Size = new System.Drawing.Size(63, 17);
            this.start_age_lbl.TabIndex = 4;
            this.start_age_lbl.Text = "StartAge";
            // 
            // end_age_lbl
            // 
            this.end_age_lbl.AutoSize = true;
            this.end_age_lbl.Location = new System.Drawing.Point(52, 101);
            this.end_age_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.end_age_lbl.Name = "end_age_lbl";
            this.end_age_lbl.Size = new System.Drawing.Size(58, 17);
            this.end_age_lbl.TabIndex = 5;
            this.end_age_lbl.Text = "EndAge";
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(56, 469);
            this.start_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(163, 48);
            this.start_btn.TabIndex = 6;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // population_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.population_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.population_chart.Legends.Add(legend1);
            this.population_chart.Location = new System.Drawing.Point(319, 26);
            this.population_chart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.population_chart.Name = "population_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.population_chart.Series.Add(series1);
            this.population_chart.Size = new System.Drawing.Size(692, 491);
            this.population_chart.TabIndex = 7;
            this.population_chart.Text = "Population";
            // 
            // population_lbl
            // 
            this.population_lbl.AutoSize = true;
            this.population_lbl.Location = new System.Drawing.Point(52, 149);
            this.population_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.population_lbl.Name = "population_lbl";
            this.population_lbl.Size = new System.Drawing.Size(75, 34);
            this.population_lbl.TabIndex = 9;
            this.population_lbl.Text = "Population\r\n  (в млн)";
            // 
            // start_age_nud
            // 
            this.start_age_nud.Location = new System.Drawing.Point(144, 41);
            this.start_age_nud.Maximum = new decimal(new int[] {
            2199,
            0,
            0,
            0});
            this.start_age_nud.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.start_age_nud.Name = "start_age_nud";
            this.start_age_nud.Size = new System.Drawing.Size(120, 22);
            this.start_age_nud.TabIndex = 10;
            this.start_age_nud.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.start_age_nud.ValueChanged += new System.EventHandler(this.start_age_nud_ValueChanged);
            // 
            // end_age_nud
            // 
            this.end_age_nud.Location = new System.Drawing.Point(144, 96);
            this.end_age_nud.Maximum = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            this.end_age_nud.Minimum = new decimal(new int[] {
            1951,
            0,
            0,
            0});
            this.end_age_nud.Name = "end_age_nud";
            this.end_age_nud.Size = new System.Drawing.Size(120, 22);
            this.end_age_nud.TabIndex = 11;
            this.end_age_nud.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.end_age_nud.ValueChanged += new System.EventHandler(this.end_age_nud_ValueChanged);
            // 
            // population_nud
            // 
            this.population_nud.Location = new System.Drawing.Point(144, 155);
            this.population_nud.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.population_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.population_nud.Name = "population_nud";
            this.population_nud.Size = new System.Drawing.Size(120, 22);
            this.population_nud.TabIndex = 12;
            this.population_nud.Value = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.population_nud.ValueChanged += new System.EventHandler(this.population_nud_ValueChanged);
            // 
            // demography_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.demography_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.demography_chart.Legends.Add(legend2);
            this.demography_chart.Location = new System.Drawing.Point(1018, 26);
            this.demography_chart.Name = "demography_chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.demography_chart.Series.Add(series2);
            this.demography_chart.Size = new System.Drawing.Size(271, 491);
            this.demography_chart.TabIndex = 13;
            this.demography_chart.Text = "man/woman demo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 554);
            this.Controls.Add(this.demography_chart);
            this.Controls.Add(this.population_nud);
            this.Controls.Add(this.end_age_nud);
            this.Controls.Add(this.start_age_nud);
            this.Controls.Add(this.population_lbl);
            this.Controls.Add(this.population_chart);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.end_age_lbl);
            this.Controls.Add(this.start_age_lbl);
            this.Controls.Add(this.LoadDeath_btn);
            this.Controls.Add(this.LoadAges_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.population_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_age_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.end_age_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.population_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demography_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadAges_btn;
        private System.Windows.Forms.Button LoadDeath_btn;
        private System.Windows.Forms.Label start_age_lbl;
        private System.Windows.Forms.Label end_age_lbl;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart population_chart;
        private System.Windows.Forms.Label population_lbl;
        private System.Windows.Forms.NumericUpDown start_age_nud;
        private System.Windows.Forms.NumericUpDown end_age_nud;
        private System.Windows.Forms.NumericUpDown population_nud;
        private System.Windows.Forms.DataVisualization.Charting.Chart demography_chart;
    }
}

