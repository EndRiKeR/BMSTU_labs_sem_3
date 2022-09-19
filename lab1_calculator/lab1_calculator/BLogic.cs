using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_calculator
{
    class BLogic
    {
        private Dictionary<Moves, MyAction> _fromActToFunc;

        delegate void MyAction(ref double sum, ref double num);

        private bool _error = false;

        public BLogic()
        {
            SetupDict();
        }

        public void SetupDict()
        {
            _fromActToFunc = new Dictionary<Moves, MyAction>()
            {
                { Moves.None, noneAct },
                { Moves.Plus, plusAct },
                { Moves.Minus, minusAct },
                { Moves.Mult, multAct },
                { Moves.Divide, divideAct },
                { Moves.Equale, equaleAct },
                { Moves.MPlus, plusAct },
                { Moves.MMinus, minusAct }
            };
        }

        public bool DoMove(ref double sum, ref double num, ref double mem, Moves act, Moves mov)
        {
            _error = false;

            switch (mov)
            {
                case Moves.Plus:
                case Moves.Minus:
                case Moves.Mult:
                case Moves.Divide:
                case Moves.Equale:
                    _fromActToFunc[act].Invoke(ref sum, ref num);
                    break;
                case Moves.MMinus:
                case Moves.MPlus:
                    _fromActToFunc[mov].Invoke(ref mem, ref num);
                    break;
                case Moves.Clear:
                    clearMove(ref sum, ref num, ref mem);
                    break;
                case Moves.Pow2:
                    pow2Move(ref num);
                    break;
                case Moves.Sqrt2:
                    sqrt2Move(ref num);
                    break;
                case Moves.MR:
                    memResultMove(ref mem, ref num);
                    break;
                case Moves.MC:
                    memClearMove(ref mem);
                    break;

                case Moves.None:
                default:
                    break;
            }

            return _error;
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
            } else
            {
                _error = true;
            }
        }

        private void noneAct(ref double sum, ref double num)
        {
            if (sum == 0.0)
                sum = num;
        }

        private void equaleAct(ref double sum, ref double num)
        {
            num = sum;
            sum = 0;
        }

        private void sqrt2Move(ref double num)
        {
            if (num >= 0) {
                num = Math.Sqrt(num);
            } else {
                _error = true;
            }
            
        }

        private void pow2Move(ref double num)
        {
            num = Math.Pow(num, 2);
        }

        private void clearMove(ref double sum, ref double num, ref double mem)
        {
            sum = 0.0;
            num = 0;
            mem = 0;
        }

        private void memClearMove(ref double mem)
        {
            mem = 0;
        }

        private void memResultMove(ref double mem, ref double num)
        {
            num = mem;
        }
    }
}
