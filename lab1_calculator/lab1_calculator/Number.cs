using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_calculator
{
    internal class Number
    {
        private double _beforeP = 0.0;
        private double _afterP = 0.0;
        private bool _hasPoint;

        public double RealNum
        {
            get
            {
                return createNumber();
            }
            set
            {
                string str = value.ToString();
                fromStringToNumber(str);
            }
        }

        private double createNumber()
        {
            return _beforeP + (1 / _afterP);
        }

        private void fromStringToNumber(string strNum)
        {
            _beforeP = double.Parse(strNum);
        }


    }
}
