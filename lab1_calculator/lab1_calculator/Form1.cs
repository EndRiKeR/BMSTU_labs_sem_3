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
        private string _onDisplay = "0";
        private string _inSummary = "0";
        private string _inMemory = "0";

        //Енамы, которые запоминаю арифм действия и действия в целом
        Moves _action = Moves.None;
        Moves _move = Moves.None;

        //Словарь для Moves
        private Dictionary<string, Moves> _strToMove = new Dictionary<string, Moves>()
        {
            { "+", Moves.Plus },
            { "-", Moves.Minus },
            { "*", Moves.Mult },
            { "/", Moves.Divide },
            { "sqrt(x)", Moves.Sqrt2 },
            { "X^2", Moves.Pow2 },
            { "MC", Moves.MC },
            { "MR", Moves.MR },
            { "M+", Moves.MPlus },
            { "M-", Moves.MMinus }
        };

        public Calculator()
        {
            InitializeComponent();
        }

        //Функция-сборник из базисных действий большинства триггер-функций
        private void startMath(Moves move)
        {
            _move = move;
            setupData();
            bool error = _data.DoBLogic(_action, _move, out _inSummary, out _onDisplay, out _inMemory);
            if (error) {
                secureUp();
            }
        }

        //Реакция на ошибки
        private void secureUp()
        {
            resetStat();
            //Как заставить его появиться перед окном, а не просто по цетнру экрана?
            MessageBox.Show("You can't do this!", "Error", MessageBoxButtons.OK);
        }

        //Очистка всего
        private void resetStat()
        {
            _onDisplay = "0";
            _inSummary = "0";
            _move = Moves.None;
            _action = Moves.None;
            UpdateUI(_onDisplay);
        }

        //Обновление дисплея
        public void UpdateUI(string outStr)
        {
            if (outStr.Length >= 12)
            {
                outStr = String.Format("{0:#.###e+00}", Convert.ToDouble(outStr));
            }

            txtbox_display.Text = outStr;
            
         }

        //Перекидывание строк в CalculatorData
        private void setupData()
        {
            _data.DDisplay = Convert.ToDouble(_onDisplay);
            _data.DSummary = Convert.ToDouble(_inSummary);
            _data.DMemory = Convert.ToDouble(_inMemory);
        }


        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // 0 - 9
        private void numericBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if ((_onDisplay == "0") || (_move == Moves.Equale)) {
                _onDisplay = "";
            } else if (_onDisplay == "-0")
            {
                _onDisplay = "-";
            }
            _move = Moves.Add;
            _onDisplay += btn.Text;
            UpdateUI(_onDisplay);
        }

        // Точка .
        private void pointBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if ((!_onDisplay.Contains(",")) && (_move != Moves.Equale))
            {
                _onDisplay = _onDisplay + ",";
            }
            UpdateUI(_onDisplay);
        }

        // Равно =
        private void equalityBtnClick(object sender, EventArgs e)
        {
            if ((_move != Moves.None) || (_move != Moves.Equale))
            {
                startMath(Moves.Equale);
                _action = Moves.Equale;
                startMath(Moves.Equale);
                _action = Moves.None;
            }
            UpdateUI(_onDisplay);
        }

        // "+ - * /"
        private void actionsBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            startMath(_strToMove[btn.Text]);
            _action = _strToMove[btn.Text];
            UpdateUI(_onDisplay = "0");
        }

        // "sqrt(x), pow(x, 2)"
        private void additActionsBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            startMath(_strToMove[btn.Text]);
            UpdateUI(_onDisplay);
        }

        // "MR, MC, M+, M-"
        private void memoryActionsBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            startMath(_strToMove[btn.Text]);
            UpdateUI(_onDisplay);
        }

        // Clear
        private void clearBtnClick(object sender, EventArgs e)
        {
            resetStat();
        }

        // Delete
        private void backspaceBtn(object sender, EventArgs e)
        {
            if (_onDisplay.Length != 1 && _onDisplay != "-0")
            {
                _onDisplay = _onDisplay.Substring(0, _onDisplay.Length - 1);
            } else
            {
                _onDisplay = "0";
            }

            if (_onDisplay == "-")
            {
                _onDisplay = "0";
            }

            UpdateUI(_onDisplay);
        }

        // "+/-"
        private void revertBtn(object sender, EventArgs e)
        {
            if (_onDisplay.StartsWith("-")) {
                //_onDisplay.TrimStart(new char[] {'-'});
                _onDisplay = _onDisplay.Substring(1);
            } else {
                _onDisplay = $"-{_onDisplay}";
            }
            UpdateUI(_onDisplay);
        }
    }
}
