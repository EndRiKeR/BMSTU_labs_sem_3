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

        private Moves _move;
        private Moves _action;

        private double _dDisplay;
        private double _dSummary;
        private double _dMemory;

        public Moves Move
        {
            get => _move;
            set => _move = value;
        }

        public Moves Action
        {
            get => _action;
            set => _action = value;
        }

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
            dataTransport dt = new dataTransport(_move,
                                                    _action,
                                                    _dDisplay.ToString(),
                                                    _dSummary.ToString(),
                                                    _dMemory.ToString());

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
                switch (_move)
                {
                    case Moves.Plus:
                    case Moves.Minus:
                    case Moves.Mult:
                    case Moves.Divide:
                    case Moves.Equale:
                        _fromActToFunc[_action].Invoke();
                        break;
                    default:
                        _fromActToFunc[_move].Invoke();
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
            _dSummary += _dDisplay;
        }

        private void minusAct()
        {
            _dSummary -= _dDisplay;
        }

        private void multAct()
        {
            _dSummary *= _dDisplay;
        }

        private void divideAct()
        {
            if (_dDisplay == 0)
                throw new DivideByZeroException();

            _dSummary /= _dDisplay;
        }

        private void noneAct()
        {
            if (_dSummary == 0.0)
                _dSummary = _dDisplay;
        }

        private void equaleAct()
        {
            _dDisplay = _dSummary;
            _dSummary = 0;
        }

        private void sqrt2Move()
        {
            if (_dDisplay < 0)
                throw new InvalidOperationException();

            _dDisplay = Math.Sqrt(_dDisplay);   
        }

        private void pow2Move()
        {
            _dDisplay = Math.Pow(_dDisplay, 2);
        }

        private void clearMove()
        {
            _dDisplay = 0;
            _dSummary = 0;
            _dMemory = 0;
        }

        private void memPlus()
        {
            _dMemory += _dDisplay;
        }

        private void memMinus()
        {
            _dMemory -= _dDisplay;
        }

        private void memClearMove()
        {
            _dMemory = 0;
        }

        private void memResultMove()
        {
            _dDisplay = _dMemory;
        }
    }
}
