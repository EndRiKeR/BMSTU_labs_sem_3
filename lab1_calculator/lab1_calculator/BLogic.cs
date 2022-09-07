using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_calculator
{
    internal class BLogic
    {
        private double _sum;
        private double _num;
        private double _total;
        private Actions _act;

        //тут должна быть библиотека <Actions, Action>

        public string SetupAndActivateBLogic(string sum, string num, Actions act)
        {
            //Что лучше: Parse or ToDouble?
            //_sum = Convert.ToDouble(sum);
            _sum = double.Parse(sum);
            _num = double.Parse(num);
            _act = act;
            Do();
            return _total.ToString();
        }

        private void Do()
        {
            switch (_act)
            {
                case Actions.Plus:
                    AddToSum();
                    break;
                case Actions.Minus:
                    MinusToSum();
                    break;
                case Actions.Mult:
                    MultSum();
                    break;
                case Actions.Divide:
                    DivideSum();
                    break;
                default:
                    _total = _num;
                    break;

            }
        }

        private void AddToSum()
        {
            _total = _sum + _num;
        }

        private void MinusToSum()
        {
            _total = _sum - _num;
        }

        private void MultSum()
        {
            _total = _sum * _num;
        }

        private void DivideSum()
        {
            if (_num != 0)
            {
                _total = _sum / _num;
            }
            
        }


    }
}
