using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_calculator
{
    public partial class Calculator : Form
    {
        private CalculatorData _data = new CalculatorData();

        //Данные с формы в строках
        private string _onDisplay;
        private string _inSummary;
        private string _inMemory;

        //Енамы, которые запоминаю арифм действия и действия в целом
        Actions _action = Actions.None;
        Moves _move = Moves.None;

        //Словари для Actions и Moves
        private Dictionary<string, Actions> _strToAct = new Dictionary<string, Actions>()
        {
            { "+", Actions.Plus },
            { "-", Actions.Minus },
            { "*", Actions.Mult },
            { "/", Actions.Divide },
        };

        private Dictionary<string, Moves> _strToMove = new Dictionary<string, Moves>()
        {
            { "+", Moves.Plus },
            { "-", Moves.Minus },
            { "*", Moves.Mult },
            { "/", Moves.Divide },
            { "sqrt(x)", Moves.Sqrt2},
            { "X^2", Moves.Pow2}
        };

        Action<string> act;

        Dictionary<Actions, Action<string>> a;

        public Calculator()
        {
            InitializeComponent();
        }

        public void UpdateUI(string outputStr)
        {
            txtbox_display.Text = outputStr;
        }

        private void setupData()
        {
            _data.DDisplay = Convert.ToDouble(_onDisplay);
            _data.DSummary = Convert.ToDouble(_inSummary);
            _data.DMemory = Convert.ToDouble(_inMemory);
        }

        private void numericBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (_onDisplay == "0") {
                _onDisplay = "";
            }
            _onDisplay += btn.Text;
            UpdateUI(_onDisplay);
        }

        private void pointBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!_onDisplay.Contains(","))
            {
                _onDisplay = _onDisplay + ",";
            }
            UpdateUI(_onDisplay);
        }

        private void equalityBtnClick(object sender, EventArgs e)
        {
            _move = Moves.Equale;
            setupData();
            _data.DoBLogic(_action, _move, out _inSummary, out _onDisplay, out _inMemory);
            _action = Actions.Equale;
            _onDisplay = "0";
            UpdateUI(_inSummary);
        }

        private void actionsBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _move = _strToMove[btn.Text];
            setupData();
            _data.DoBLogic(_action, _move, out _inSummary, out _onDisplay, out _inMemory);
            _action = _strToAct[btn.Text];
            UpdateUI(_onDisplay = "0");
        }

        private void additActionsBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _move = _strToMove[btn.Text];
            setupData();
            _data.DoBLogic(_action, _move, out _inSummary, out _onDisplay, out _inMemory);
            UpdateUI(_onDisplay);
        }

        private void memoryActionsBtnClick(object sender, EventArgs e)
        {
            //work in progress
        }

        private void clearBtnClick(object sender, EventArgs e)
        {
            _onDisplay = "0";
            _inSummary = "0";
            _move = Moves.None;
            _action = Actions.None;
            UpdateUI(_onDisplay);
        }

        private void backspaceBtn(object sender, EventArgs e)
        {
            if (_onDisplay.Length != 1)
                _onDisplay = _onDisplay.Substring(0, _onDisplay.Length - 1);
            else
                _onDisplay = "0";
            UpdateUI(_onDisplay);
        }
    }
}
