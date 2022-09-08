using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_calculator
{
    //сюда докинуть static
    static class BLogic
    {
        //тут должна быть библиотека <Actions, Action>
        static public void Do(ref string sumStr, ref string numStr, Actions act, Moves move)
        {
            double sum = double.Parse(sumStr);
            double num = double.Parse(numStr);

            switch (act)
            {
                case Actions.Plus:
                    AddToSum(ref sum, ref num);
                    break;
                case Actions.Minus:
                    MinusToSum(ref sum, ref num);
                    break;
                case Actions.Mult:
                    MultSum(ref sum, ref num);
                    break;
                case Actions.Divide:
                    DivideSum(ref sum, ref num);
                    break;
                case Actions.Equale:
                    EqualeMove(ref sum, ref num);
                    break;
                case Actions.None:
                    NoneMove(ref sum, ref num);
                    break;
                default:
                    DoMove(ref sumStr, ref numStr, move);
                    break;

            }

            sumStr = sum.ToString();
            numStr = num.ToString();
        }

        static public void DoMove(ref string sumStr, ref string numStr, Moves move)
        {
        }

        static private void AddToSum(ref double n1, ref double n2)
        {
            n1 += n2;
        }

        static private void MinusToSum(ref double n1, ref double n2)
        {
            n1 -= n2;
        }

        static private void MultSum(ref double n1, ref double n2)
        {
            n1 *= n2;
        }

        static private void DivideSum(ref double n1, ref double n2)
        {
            if (n2 != 0)
            {
                n1 /= n2;
            }
        }

        static private void NoneMove(ref double n1, ref double n2)
        {
            if (n1 == 0.0)
                n1 = n2;
        }

        static private void Pow2Move(ref double num)
        {
            num = Math.Pow(num, 2);
        }

        static private void Sqrt2Move(ref double num)
        {
            if (num >= 0)
            {
                num = Math.Sqrt(num);
            }
        }

        static private void EqualeMove(ref double sum, ref double num)
        {
            num = sum;
        }
    }
}
