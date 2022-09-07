using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_calculator
{
    enum Actions
    {
        None = 0,
        Plus,
        Minus,
        Mult,
        Divide
    }

    enum Moves
    {
        None = 0,
        Plus,
        Minus,
        Mult,
        Divide,
        Point,
        Clear,
        Add,
        Delete,
        Equale
    }

    internal struct CalculatorData
    {
        //тут лежит и сумма в виде числа, которую можно достать
        //и с помощью этого объекта можно действовать с числами
        public BLogic bLogic;

        //Хранит строку, которая сейчас на дисплее
        public string onDisplay;

        //Текущее суммарное значение
        public string inSum;

        //Енамы, которые запоминаю арифм действия и действия в целом
        public Actions nowAction;
        public Moves nowMove;


    }

}
