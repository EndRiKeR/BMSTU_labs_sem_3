using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_calculator
{
    internal class CalculatorData
    {
        //Все самое нужное, но уже в double
        private double _dDisplay;
        private double _dSummary;
        private double _dMemory;

        public double DisplayText
        {
            get { return _dDisplay; }
            set { _dDisplay = value; }
        }

        public double SumText
        {
            get { return _dSummary; }  
            set { _dSummary = value; }
        }

        public double Memory
        {
            get { return _dMemory; }
            set { _dMemory = value; }
        }

        public void DoBLogic()
        {
            BLogic.Do(ref _inSum, ref _onDisplay, Action, Move);
        }

    }
}
