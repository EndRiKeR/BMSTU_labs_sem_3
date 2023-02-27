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
using DemographicEngine.StaticAndConstants;
using DemographicEngine.StructsAndEnums;
using DemographicEngine;
using System.Threading;

namespace Lab5_Demography
{
    //TODO: ПРогресс бар принял определенную религию
    //Либо переделывать все под Task, а это перелопачивать архитектуру
    //Либо что-то сделать с BackGroundWorker
    public partial class Form1 : Form
    {
        private Dictionary<int, double> _initialAges;
        private List<AgesDeathPeriod> _deathRules;

        private Reader _reader = new Reader();

        private int _startAge = 1970;
        private int _endAge = 2022;
        private int _population = 130;

        private const int _inMillions = 1000000;

        private Engine _engine;

        private BackgroundWorker _backWorker;
       
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

                
                _initialAges = _reader.ParceInitialAgeData(_reader.ReadFromFile(filePath));

                LoadDeath_btn.Enabled = true;

                Console.WriteLine($"{_initialAges}");

            }
            catch(RikerBaseFileException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadDeath_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = TryLoadFile();
                
                _deathRules = _reader.ParceDeathRulesData(_reader.ReadFromFile(filePath));

                start_btn.Enabled = true;

                Console.WriteLine($"{_deathRules}");

            }
            catch (RikerBaseFileException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            SetupNewCharts();

            if ((_endAge - _startAge <= 300) && (_endAge > _startAge))
            {
                _engine = new Engine(_initialAges, _deathRules, _startAge, _endAge, _population * _inMillions);

                LoadAges_btn.Enabled = false;
                LoadDeath_btn.Enabled = false;
                start_btn.Enabled = false;

                //_engine.StatisticSend += UpdateSplineCharts;
                //_engine.DemographyStatisticSend += UpdateChartsCharts;

                backgroundWorker.RunWorkerAsync();

                Console.WriteLine("END!");
            }
            else
            {
                if (_endAge <= _startAge)
                    MessageBox.Show("Период моделирвоания слишком мал!\nПрограмме нечего моделировать!");
                else
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

            demography_chart.Series.Clear();
            demography_chart.Series.Add("Man").IsValueShownAsLabel = true;
            demography_chart.Series.Add("Woman").IsValueShownAsLabel = true;

            progressBar.Value = 0;
        }

        private void UpdateCharts(StatisticData data)
        {
            UpdateSplineCharts(data.PopStat);
            UpdateChartsCharts(data.AgedStat);
        }

        private void UpdateSplineCharts(List<PopStatistic> data)
        {
            foreach(var year in data)
            {
                    population_chart.Series["PopTotal"].Points.AddXY(year.Age, year.PopTotal * StandartConstants.InOnePerson);
                    population_chart.Series["PopMan"].Points.AddXY(year.Age, year.PopMan * StandartConstants.InOnePerson);
                    population_chart.Series["PopWoman"].Points.AddXY(year.Age, year.PopWoman * StandartConstants.InOnePerson);

                
            }
            
        }

        private void UpdateChartsCharts(List<AgedStatistic> data)
        {
            foreach(var stat in data)
            {


                demography_chart.Series["Man"].Points.AddXY(stat.GetPeriod(), stat.ManCounter * StandartConstants.InOnePerson);
                demography_chart.Series["Woman"].Points.AddXY(stat.GetPeriod(), stat.WomanCounter * StandartConstants.InOnePerson);

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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            _backWorker = (BackgroundWorker)sender;
            _engine.Ping += backWorkerTakePing;
           
            var data = _engine.StartEngine();
            e.Result = data;
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UpdateCharts((StatisticData)e.Result);
            LoadAges_btn.Enabled = true;
            LoadDeath_btn.Enabled = true;
            start_btn.Enabled = true;
        }

        private void backWorkerTakePing(int age)
        {
            _backWorker.ReportProgress((age - _startAge)/(_endAge - _startAge) * 100);
        }
    }
}
