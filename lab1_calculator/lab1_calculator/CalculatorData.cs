using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_calculator
{
    internal class CalculatorData
    {
        private BLogic _bLogic = new BLogic();

        //Все самое нужное, но уже в double
        private double _dDisplay;
        private double _dSummary;
        private double _dMemory;

        public double DDisplay
        {
            get { return _dDisplay; }
            set { _dDisplay = value; }
        }

        public double DSummary
        {
            get { return _dSummary; }  
            set { _dSummary = value; }
        }

        public double DMemory
        {
            get { return _dMemory; }
            set { _dMemory = value; }
        }

        public void DoBLogic(Actions act, Moves mov, out string _summaryText, out string _displayText, out string _memoryText)
        {
            _bLogic.DoMove(ref _dSummary, ref _dDisplay, ref _dMemory, act, mov);
            _summaryText = _dSummary.ToString();
            _displayText = _dDisplay.ToString();
            _memoryText = _dMemory.ToString();
        }

    }
}
