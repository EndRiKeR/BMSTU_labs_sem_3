using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_calculator
{
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
        Equale,
        Sqrt2,
        Pow2,
        MC,
        MR,
        MPlus,
        MMinus
    }

    struct dataTransport
    {
        //Moves _move;
        //Moves _action;
        //string _num;
        //string _sum;
        //string _mem;

        public Moves Move { get; set; }
        public Moves Action { get; set; }
        public string Number { get; set; }
        public string Summary { get; set; }
        public string Memory { get; }

        public dataTransport(Moves move, Moves act, string num, string sum, string mem)
        {
            Move = move;
            Action = act;
            Number = num;
            Summary = sum;
            Memory = mem;
        }


        /*public Moves Action
        {
            get => _action;
            set => _action = value;
        }

        public string Number
        {
            get { return _num; }
            set { _num = value; }
        }

        public string Summary
        {
            get { return _sum; }
            set { _sum = value; }
        }

        public string Memory
        {
            get { return _mem; }
            set { _mem = value; }
        }*/
    }
}
