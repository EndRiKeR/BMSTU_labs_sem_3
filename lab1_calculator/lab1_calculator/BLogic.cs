using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_calculator
{
    //сюда докинуть static
    class BLogic
    {
        private Dictionary<Actions, MyAction> _fromActToFunc;
        private Dictionary<Moves, Action<double, double>> _fromMovesToFunc;

        delegate void MyAction(ref double sum, ref double num);

        public void SetupDict()
        {
            _fromActToFunc = new Dictionary<Actions, MyAction>()
            {
                { Actions.None, noneAct },
                { Actions.Plus, plusAct },
                { Actions.Minus, minusAct },
                { Actions.Mult, multAct },
                { Actions.Divide, divideAct },
                { Actions.Equale, equaleAct },
            };
        }

        public void DoAct(ref double sum, ref double num, Actions act)
        {

            _fromActToFunc[act].Invoke(ref sum, ref num);
            /*switch (act)
            {
                case Actions.Plus:
                    plusAct(ref sum, ref num);
                    break;
                case Actions.Minus:
                    minusAct(ref sum, ref num);
                    break;
                case Actions.Mult:
                    multAct(ref sum, ref num);
                    break;
                case Actions.Divide:
                    divideAct(ref sum, ref num);
                    break;
                case Actions.Equale:
                    equaleAct(ref sum, ref num);
                    break;
                case Actions.None:
                    noneAct(ref sum, ref num);
                    break;
                default:
                    //do nothing :)
                    break;
            }*/

        }

        public void DoMove(ref double sum, ref double num, ref double mem, Actions act, Moves mov)
        {

        }

        private void plusAct(ref double n1, ref double n2)
        {
            n1 += n2;
        }

        private void minusAct(ref double n1, ref double n2)
        {
            n1 -= n2;
        }

        private void multAct(ref double n1, ref double n2)
        {
            n1 *= n2;
        }

        private void divideAct(ref double n1, ref double n2)
        {
            if (n2 != 0)
            {
                n1 /= n2;
            }
        }

        private void noneAct(ref double n1, ref double n2)
        {
            if (n1 == 0.0)
                n1 = n2;
        }

        private void equaleAct(ref double sum, ref double num)
        {
            num = sum;
        }
    }
}
