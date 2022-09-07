using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_calculator
{
    internal class Number
    {
        private double _num = 0.0;
        private bool _hasPoint = false;

        public Number(string strNum)
        {
            fromStringToNumber(strNum);
        }

        public Number(double doublNum)
        {
            fromStringToNumber(doublNum.ToString());
        }

        public double RealNum
        {
            get => _num;
            set
            {
                string str = value.ToString();
                fromStringToNumber(str);
            }
        }

        private void fromStringToNumber(string strNum)
        {
            _num = double.Parse(strNum);
            _hasPoint = strNum.Contains(".");
        }


    }
}
