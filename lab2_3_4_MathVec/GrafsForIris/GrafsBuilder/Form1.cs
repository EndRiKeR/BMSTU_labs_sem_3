using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            

            var irises = fr.ReadReformAndResortIrisPoints();

            Console.WriteLine(irises.ToString());

            var sortedVectots = vw.FromIrisesToVectors(irises);

            var middleVectors = vw.CountMiddleForVectors(sortedVectots);

            var distances = vw.CountDistanceBetweenVectors(middleVectors);

            Console.WriteLine(middleVectors.ToString());

            UpdateUI(middleVectors, distances);
        }

        private void UpdateUI(MiddleVectors vectors, DistanceValues value)
        {
            SL_chart.Series["Setosa"].Points.AddXY("Setosa", vectors.Setosa[0].ToString());
            SL_chart.Series["Versicolor"].Points.AddXY("Versicolor", vectors.Versicolor[0].ToString());
            SL_chart.Series["Virginica"].Points.AddXY("Virginica", vectors.Virginica[0].ToString());

            SL_chart.Titles.Add("Sepal Length");

            SW_chart.Series["Setosa"].Points.AddXY("Setosa", vectors.Setosa[1].ToString());
            SW_chart.Series["Versicolor"].Points.AddXY("Versicolor", vectors.Versicolor[1].ToString());
            SW_chart.Series["Virginica"].Points.AddXY("Virginica", vectors.Virginica[1].ToString());

            SW_chart.Titles.Add("Sepal Width");

            PL_chart.Series["Setosa"].Points.AddXY("Setosa", vectors.Setosa[2].ToString());
            PL_chart.Series["Versicolor"].Points.AddXY("Versicolor", vectors.Versicolor[2].ToString());
            PL_chart.Series["Virginica"].Points.AddXY("Virginica", vectors.Virginica[2].ToString());

            PL_chart.Titles.Add("Petal Length");

            PW_chart.Series["Setosa"].Points.AddXY("Setosa", vectors.Setosa[3].ToString());
            PW_chart.Series["Versicolor"].Points.AddXY("Versicolor", vectors.Versicolor[3].ToString());
            PW_chart.Series["Virginica"].Points.AddXY("Virginica", vectors.Virginica[3].ToString());

            PW_chart.Titles.Add("Petal Width");

            Pie_chart.Titles.Add("Distances");

            Pie_chart.Series["Setosa"].Points.DataBindXY("Setosa", value.Setosa);
            Pie_chart.Series["Versicolor"].Points.DataBindXY("Versicolor", value.Versicolor);
            Pie_chart.Series["Virginica"].Points.AddXY("Virginica", value.Virginica);

        }

        private void Pie_chart_Click(object sender, EventArgs e)
        {

        }
    }
}
