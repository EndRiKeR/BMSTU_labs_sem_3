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
        }

        private void LoadButtonClick(object sender, EventArgs e)
        {
            FileReader fr = new FileReader();
            VectorWorker vw = new VectorWorker();

            fr.ChooseFilePath();

            try
            {
                var irises = fr.ReadReformAndResortIrisPoints();

                //Console.WriteLine(irises.ToString());

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

            SL_chart.Titles.Add("Sepal Length");
            SL_chart.Series["Setosa"].IsValueShownAsLabel = true;
            SL_chart.Series["Versicolor"].IsValueShownAsLabel = true;
            SL_chart.Series["Virginica"].IsValueShownAsLabel = true;
            SL_chart.Series["Setosa"].Points.AddXY("Setosa", vectors.Setosa[0].ToString());
            SL_chart.Series["Versicolor"].Points.AddXY("Versicolor", vectors.Versicolor[0].ToString());
            SL_chart.Series["Virginica"].Points.AddXY("Virginica", vectors.Virginica[0].ToString());

            SW_chart.Titles.Add("Sepal Width");
            SW_chart.Series["Setosa"].IsValueShownAsLabel = true;
            SW_chart.Series["Versicolor"].IsValueShownAsLabel = true;
            SW_chart.Series["Virginica"].IsValueShownAsLabel = true;
            SW_chart.Series["Setosa"].Points.AddXY("Setosa", vectors.Setosa[1].ToString());
            SW_chart.Series["Versicolor"].Points.AddXY("Versicolor", vectors.Versicolor[1].ToString());
            SW_chart.Series["Virginica"].Points.AddXY("Virginica", vectors.Virginica[1].ToString());

            PL_chart.Titles.Add("Petal Length");
            PL_chart.Series["Setosa"].IsValueShownAsLabel = true;
            PL_chart.Series["Versicolor"].IsValueShownAsLabel = true;
            PL_chart.Series["Virginica"].IsValueShownAsLabel = true;
            PL_chart.Series["Setosa"].Points.AddXY("Setosa", vectors.Setosa[2].ToString());
            PL_chart.Series["Versicolor"].Points.AddXY("Versicolor", vectors.Versicolor[2].ToString());
            PL_chart.Series["Virginica"].Points.AddXY("Virginica", vectors.Virginica[2].ToString());

            PW_chart.Titles.Add("Petal Width");
            PW_chart.Series["Setosa"].IsValueShownAsLabel = true;
            PW_chart.Series["Versicolor"].IsValueShownAsLabel = true;
            PW_chart.Series["Virginica"].IsValueShownAsLabel = true;
            PW_chart.Series["Setosa"].Points.AddXY("Setosa", vectors.Setosa[3].ToString());
            PW_chart.Series["Versicolor"].Points.AddXY("Versicolor", vectors.Versicolor[3].ToString());
            PW_chart.Series["Virginica"].Points.AddXY("Virginica", vectors.Virginica[3].ToString());

            Pie_chart.Titles.Add("Distances");
            Pie_chart.Series["Iris"].IsValueShownAsLabel = true;
            Pie_chart.Series["Iris"].Points.AddXY("Setosa - Versicolor", value.Setosa);
            Pie_chart.Series["Iris"].Points.AddXY("Versicolor - Verginica", value.Versicolor);
            Pie_chart.Series["Iris"].Points.AddXY("Virginica - Setosa", value.Virginica);

        }
    }
}
