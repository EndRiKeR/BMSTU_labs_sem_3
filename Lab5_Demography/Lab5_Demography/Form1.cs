﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileReader;

namespace Lab5_Demography
{
    public partial class Form1 : Form
    {
        private Dictionary<int, double> _initialAges;
        private Dictionary<int[], double[]> _deathRules;

        public Form1()
        {
            InitializeComponent();
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

                Reader reader = new Reader();
                _deathRules = reader.ParceDeathRulesData(reader.ReadFromFile(filePath));

                Console.WriteLine($"{_deathRules}");

            }
            catch (RikerBaseFileException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
