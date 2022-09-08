using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_calculator
{
    internal class CalculatorData
    {
        //Хранит строку, которая сейчас на дисплее
        string _onDisplay = "0";

        //Текущее суммарное значение
        string _inSum = "0,0";

        //Енамы, которые запоминаю арифм действия и действия в целом
        Actions _action = Actions.None;
        Moves _move = Moves.None; 

        public string DisplayText
        {
            get { return _onDisplay; }
            set { _onDisplay = value; }
        }

        public string SumText
        {
            get { return _inSum; }  
            set { _inSum = value; }
        }

        public Actions Action
        {
            get { return _action; }
            set { _action = value; }
        }

        public Moves Move
        {
            get { return _move; }
            set { _move = value; }
        }


        public void DoBLogic()
        {
            BLogic.Do(ref _inSum, ref _onDisplay, Action, Move);
        }

    }
}
