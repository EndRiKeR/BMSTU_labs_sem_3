using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrafsForIris.GrafsBuilder;

namespace GrafsForIris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SL_chart.Titles.Add("Sepal Length");
            SW_chart.Titles.Add("Sepal Width");
            PL_chart.Titles.Add("Petal Length");
            PW_chart.Titles.Add("Petal Width");
            Pie_chart.Titles.Add("Distances");

        }

        private void LoadButtonClick(object sender, EventArgs e)

        {
            FileReader fr = new FileReader();
            VectorWorker vw = new VectorWorker();

            fr.ChooseFilePath();

            try
            {
                var irises = fr.ReadReformAndResortIrisPoints();

                Console.WriteLine(irises.ToString());

                var sortedVectots = vw.FromIrisesToVectors(irises);

                var middleVectors = vw.CountMiddleForVectors(sortedVectots);

                var distances = vw.CountDistanceBetweenVectors(middleVectors);

                Console.WriteLine(middleVectors.ToString());

                UpdateUI(middleVectors, distances);
            }
            catch (RikerBaseFileExceptions ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateUI(MiddleVectors vectors, DistanceValues value)
        {

            //В теории... это можно оптимизировать, но это архитектуру менять

            SL_chart.Series.Clear();
            SW_chart.Series.Clear();
            PL_chart.Series.Clear();
            PW_chart.Series.Clear();
            Pie_chart.Series.Clear();

            SL_chart.Series.Add("Setosa");
            SL_chart.Series.Add("Versicolor");
            SL_chart.Series.Add("Virginica");

            SW_chart.Series.Add("Setosa");
            SW_chart.Series.Add("Versicolor");
            SW_chart.Series.Add("Virginica");

            PL_chart.Series.Add("Setosa");
            PL_chart.Series.Add("Versicolor");
            PL_chart.Series.Add("Virginica");

            PW_chart.Series.Add("Setosa");
            PW_chart.Series.Add("Versicolor");
            PW_chart.Series.Add("Virginica");

            Pie_chart.Series.Add("Iris");
            Pie_chart.Series["Iris"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            SL_chart.Series["Setosa"].IsValueShownAsLabel = true;
            SL_chart.Series["Versicolor"].IsValueShownAsLabel = true;
            SL_chart.Series["Virginica"].IsValueShownAsLabel = true;
            SL_chart.Series["Setosa"].Points.AddXY("Setosa", vectors.Setosa[0]);
            SL_chart.Series["Versicolor"].Points.AddXY("Versicolor", vectors.Versicolor[0]);
            SL_chart.Series["Virginica"].Points.AddXY("Virginica", vectors.Virginica[0]);

            SW_chart.Series["Setosa"].IsValueShownAsLabel = true;
            SW_chart.Series["Versicolor"].IsValueShownAsLabel = true;
            SW_chart.Series["Virginica"].IsValueShownAsLabel = true;
            SW_chart.Series["Setosa"].Points.AddXY("Setosa", vectors.Setosa[1]);
            SW_chart.Series["Versicolor"].Points.AddXY("Versicolor", vectors.Versicolor[1]);
            SW_chart.Series["Virginica"].Points.AddXY("Virginica", vectors.Virginica[1]);

            PL_chart.Series["Setosa"].IsValueShownAsLabel = true;
            PL_chart.Series["Versicolor"].IsValueShownAsLabel = true;
            PL_chart.Series["Virginica"].IsValueShownAsLabel = true;
            PL_chart.Series["Setosa"].Points.AddXY("Setosa", vectors.Setosa[2]);
            PL_chart.Series["Versicolor"].Points.AddXY("Versicolor", vectors.Versicolor[2]);
            PL_chart.Series["Virginica"].Points.AddXY("Virginica", vectors.Virginica[2]);

            PW_chart.Series["Setosa"].IsValueShownAsLabel = true;
            PW_chart.Series["Versicolor"].IsValueShownAsLabel = true;
            PW_chart.Series["Virginica"].IsValueShownAsLabel = true;
            PW_chart.Series["Setosa"].Points.AddXY("Setosa", vectors.Setosa[3]);
            PW_chart.Series["Versicolor"].Points.AddXY("Versicolor", vectors.Versicolor[3]);
            PW_chart.Series["Virginica"].Points.AddXY("Virginica", vectors.Virginica[3]);
 
            Pie_chart.Series["Iris"].IsValueShownAsLabel = true;
            Pie_chart.Series["Iris"].Points.AddXY("Setosa - Versicolor", value.Setosa);
            Pie_chart.Series["Iris"].Points.AddXY("Versicolor - Verginica", value.Versicolor);
            Pie_chart.Series["Iris"].Points.AddXY("Virginica - Setosa", value.Virginica);

        }
    }
}
