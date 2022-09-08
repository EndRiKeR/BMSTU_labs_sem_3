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
    public partial class Калькулятор : Form
    {
        private CalculatorData _data = new CalculatorData();
        private Dictionary<string, Actions> _strToAct = new Dictionary<string, Actions>()
        {
            { "+", Actions.Plus },
            { "-", Actions.Minus },
            { "*", Actions.Mult },
            { "/", Actions.Divide },
        };

        Action<string> act;

        Dictionary<Actions, Action<string>> a;


        private Dictionary<string, Moves> _strToMove = new Dictionary<string, Moves>()
        {
            { "+", Moves.Plus },
            { "-", Moves.Minus },
            { "*", Moves.Mult },
            { "/", Moves.Divide },
            { "sqrt(x)", Moves.Sqrt2},
            { "X^2", Moves.Pow2}
        };

        public Калькулятор()
        {
            InitializeComponent();
            act += UpdateUI;

            a = new Dictionary<Actions, Action<string>>()
        {
            { Actions.Divide, UpdateUI }
        };
        }

        public void UpdateUI(string outputStr)
        {
            txtbox_display.Text = outputStr;
        }

        private void numericBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (_data.DisplayText == "0") {
                _data.DisplayText = "";
            }
            _data.DisplayText += btn.Text;
            UpdateUI(_data.DisplayText);
        }

        private void pointBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _data.DisplayText = _data.DisplayText + ",";
            UpdateUI(_data.DisplayText);
        }

        private void equalityBtnClick(object sender, EventArgs e)
        {
            _data.Move = Moves.Equale;
            _data.DoBLogic();
            _data.Action = Actions.Equale;
            UpdateUI(_data.SumText);
        }

        private void actionsBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _data.Move = _strToMove[btn.Text];
            _data.DoBLogic();
            _data.Action = _strToAct[btn.Text];
            UpdateUI(_data.DisplayText = "0");
        }

        private void additActionsBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _data.Move = _strToMove[btn.Text];
            _data.DoBLogic();
            UpdateUI(_data.DisplayText);
        }

        private void memoryActionsBtnClick(object sender, EventArgs e)
        {
            //work in progress
        }

        private void clearBtnClick(object sender, EventArgs e)
        {
            _data.DisplayText = "0";
            _data.SumText = "0";
            _data.Move = Moves.None;
            _data.Action = Actions.None;
            UpdateUI(_data.DisplayText);
        }

        private void backspaceBtn(object sender, EventArgs e)
        {
            if (_data.DisplayText.Length != 1)
                _data.DisplayText = _data.DisplayText.Substring(0, _data.DisplayText.Length - 1);
            else
                _data.DisplayText = "0";
            UpdateUI(_data.DisplayText);
        }
    }
}
