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
        private bool _hasMinus = false;

        public Number(string strNum)
        {
            fromStringToNumber(strNum);
        }

        public Number(double doublNum)
        {
            fromStringToNumber(doublNum.ToString());
        }

        public string RealNum
        {
            get => _num.ToString();
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
            _hasMinus = strNum.Contains("-");
        }


    }
}
