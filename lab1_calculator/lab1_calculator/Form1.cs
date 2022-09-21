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
    /// <summary>
    /// Вопросы:
    /// 
    /// 1) Надо ли блокировать изменения значения после результата?
    /// 2) Как выводить MessageBox относительно приложения, а не экрана
    /// 
    /// 
    /// </summary>
    public partial class Calculator : Form
    {
        //private CalculatorData _data = new CalculatorData();
        private BLogic _bl = new BLogic();

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
            dataTransport dt;
            try
            {
                dt = _bl.DoMove();
                acceptDataTransfer(dt);
            }
            catch (DivideByZeroException er)
            {
                secureUp(er.Message);
            }
            catch (InvalidOperationException)
            {
                secureUp("Попытка взятия корня от отрицательного числа");
            }
            catch (Exception)
            {
                secureUp("OOOOPS! ER PROBLEM");
            }
        }

        //Реакция на ошибки
        private void secureUp(string erStr)
        {
            resetStat();
            MessageBox.Show(erStr, "ERROR!", MessageBoxButtons.OK);
        }

        //Очистка всего
        private void resetStat()
        {
            _onDisplay = "0";
            _inSummary = "0";
            _inMemory = "0";
            _move = Moves.None;
            _action = Moves.None;
            txtbox_display.Text = "0";
        }

        //Обновление дисплея
        public void UpdateUI(string outStr)
        {
            if (outStr.Length >= 12)
            {
                outStr = String.Format("{0:#.###e+00}", Convert.ToDouble(outStr));
            }

            if (outStr == "∞")
            {
                secureUp("U reach infinity! WoW. Stop, pls!");
                outStr = "0";
            }

            txtbox_display.Text = outStr;
            
         }

        private void setupData()
        {
            _bl.DDisplay = Convert.ToDouble(_onDisplay);
            _bl.DSummary = Convert.ToDouble(_inSummary);
            _bl.DMemory = Convert.ToDouble(_inMemory);

            _bl.Move = _move;
            _bl.Action = _action;
        }

        private void acceptDataTransfer(dataTransport dt)
        {
            _onDisplay = dt.Number;
            _inSummary = dt.Summary;
            _inMemory = dt.Memory;
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
            //if (_move != Moves.Equale)
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
