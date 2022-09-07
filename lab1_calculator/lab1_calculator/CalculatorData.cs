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
        string onDisplay = "";

        //Текущее суммарное значение
        string inSum = "";

        //Енамы, которые запоминаю арифм действия и действия в целом
        Actions action = Actions.None;
        Moves move = Moves.None; 

        public string DisplayText
        {
            get { return onDisplay; }
            set { onDisplay = value; }
        }

        public string SumText
        {
            get { return inSum; }  
            set { inSum = value; }
        }

        public Actions Action
        {
            get { return action; }
            set { action = value; }
        }

        public Moves Move
        {
            get { return move; }
            set { move = value; }
        }

    }
}
