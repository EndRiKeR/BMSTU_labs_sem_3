using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileReader;
using DemographicEngine.StructsAndEnums;
using DemographicEngine;

namespace Lab5_Demography
{
    public partial class Form1 : Form
    {
        private Dictionary<int, double> _initialAges;
        private List<AgesDeathPeriod> _deathRules;

        private Reader _reader = new Reader();

        private int _startAge = 1970;
        private int _endAge = 2022;
        private int _population = 130;

        private const int _inMillions = 1000000;


        public Form1()
        {
            InitializeComponent();

            SetupNewCharts();
        }

        private string TryLoadFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Распределение возрастов | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                return openFileDialog.FileName;
            else
                throw new RikerFileNotExistsException();

        }

        private void LoadAges_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = TryLoadFile();

                Reader reader = new Reader();
                _initialAges = reader.ParceInitialAgeData(reader.ReadFromFile(filePath));

                Console.WriteLine($"{_initialAges}");

            }
            catch(RikerBaseFileException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void LoadDeath_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = TryLoadFile();

                
                _deathRules = _reader.ParceDeathRulesData(_reader.ReadFromFile(filePath));

                Console.WriteLine($"{_deathRules}");

            }
            catch (RikerBaseFileException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            SetupNewCharts();

            if (_endAge - _startAge <= 300)
            {
                Engine engine = new Engine(_initialAges, _deathRules, _startAge, _endAge, _population * _inMillions);

                engine.StatisticSend += UpdateSplineCharts;

                engine.DemographyStatisticSend += UpdateChartsCharts;

                engine.StartEngine();

                Console.WriteLine("END!");
            }
            else
            {
                MessageBox.Show("Слишком большой период моделирования!\nПериод моделирования не может быть более 300 лет\nПожалейте оперативу разраба(");
            }
        }

        private void SetupNewCharts()
        {
            //populationChart
            population_chart.Series.Clear();
            population_chart.Series.Add("PopTotal").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            population_chart.Series.Add("PopMan").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            population_chart.Series.Add("PopWoman").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            //population_chart.Series["PopTotal"].IsValueShownAsLabel = true;
            //population_chart.Series["PopMan"].IsValueShownAsLabel = true;
            //population_chart.Series["PopWoman"].IsValueShownAsLabel = true;

            //demography chart
            demography_chart.Series.Clear();
            demography_chart.Series.Add("Man").IsValueShownAsLabel = true;
            demography_chart.Series.Add("Woman").IsValueShownAsLabel = true;
        }

        private void UpdateSplineCharts(StatisticData data)
        {
            population_chart.Series["PopTotal"].Points.AddXY(data.Age, data.PopTotal);
            population_chart.Series["PopMan"].Points.AddXY(data.Age, data.PopMan);
            population_chart.Series["PopWoman"].Points.AddXY(data.Age, data.PopWoman);
        }

        private void UpdateChartsCharts(List<AgedStatistic> data)
        {
            foreach(var stat in data)
            {
                demography_chart.Series["Man"].Points.AddXY(stat.GetPeriod(), stat.ManCounter);
                demography_chart.Series["Woman"].Points.AddXY(stat.GetPeriod(), stat.WomanCounter);
            }
            
        }

        private void start_age_nud_ValueChanged(object sender, EventArgs e)
        {
            _startAge = Convert.ToInt32(start_age_nud.Value);
        }

        private void end_age_nud_ValueChanged(object sender, EventArgs e)
        {
            _endAge = Convert.ToInt32(end_age_nud.Value);
        }

        private void population_nud_ValueChanged(object sender, EventArgs e)
        {
            _population = Convert.ToInt32(population_nud.Value);
        }
    }
}
