using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_calculator
{
    class BLogic
    {
        private Dictionary<Moves, Action> _fromActToFunc;

        /*private Moves _move;
        private Moves _action;

        private double _dDisplay;
        private double _dSummary;
        private double _dMemory; */

        public Moves Move { get; set; }

        public Moves Action { get; set; }

        public double DDisplay { get; set; }

        public double DSummary { get; set; }

        public double DMemory { get; set; }

        public BLogic()
        {
            SetupDict();
        }

        public void SetupDict()
        {
            _fromActToFunc = new Dictionary<Moves, Action>()
            {
                { Moves.None, noneAct },
                { Moves.Plus, plusAct },
                { Moves.Minus, minusAct },
                { Moves.Mult, multAct },
                { Moves.Divide, divideAct },
                { Moves.Equale, equaleAct },
                { Moves.MPlus, memPlus },
                { Moves.MMinus, memMinus },
                { Moves.Clear, clearMove},
                { Moves.Pow2, pow2Move},
                { Moves.Sqrt2, sqrt2Move},
                { Moves.MR, memResultMove},
                { Moves.MC, memClearMove}
            };
        }

        private dataTransport setupDataTransport()
        {
            dataTransport dt = new dataTransport(Move,
                                                    Action,
                                                    DDisplay.ToString(),
                                                    DSummary.ToString(),
                                                    DMemory.ToString());

            /*dt.Number = _dDisplay.ToString();
            dt.Summary = _dSummary.ToString();
            dt.Memory = _dMemory.ToString();
            dt.Move = _move;
            dt.Action = _action;

            */
            return dt;
        }

        public dataTransport DoMove()
        {
            try
            {
                switch (Move)
                {
                    case Moves.Plus:
                    case Moves.Minus:
                    case Moves.Mult:
                    case Moves.Divide:
                    case Moves.Equale:
                        _fromActToFunc[Action].Invoke();
                        break;
                    default:
                        _fromActToFunc[Move].Invoke();
                        break;
                }

                return setupDataTransport();

            } catch (Exception ex)
            {
                throw ex;
            }
        }

        private void plusAct()
        {
            DSummary += DDisplay;
        }

        private void minusAct()
        {
            DSummary -= DDisplay;
        }

        private void multAct()
        {
            DSummary *= DDisplay;
        }

        private void divideAct()
        {
            if (DDisplay == 0)
                throw new DivideByZeroException();

            DSummary /= DDisplay;
        }

        private void noneAct()
        {
            if (DSummary == 0.0)
                DSummary = DDisplay;
        }

        private void equaleAct()
        {
            DDisplay = DSummary;
            DSummary = 0;
        }

        private void sqrt2Move()
        {
            if (DDisplay < 0)
                throw new InvalidOperationException();

            DDisplay = Math.Sqrt(DDisplay);   
        }

        private void pow2Move()
        {
            DDisplay = Math.Pow(DDisplay, 2);
        }

        private void clearMove()
        {
            DDisplay = 0;
            DSummary = 0;
            DMemory = 0;
        }

        private void memPlus()
        {
            DMemory += DDisplay;
        }

        private void memMinus()
        {
            DMemory -= DDisplay;
        }

        private void memClearMove()
        {
            DMemory = 0;
        }

        private void memResultMove()
        {
            DDisplay = DMemory;
        }
    }
}
