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
        public Калькулятор()
        {
            InitializeComponent();
        }

        private void numericBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
        }

        private void pointBtnClick(object sender, EventArgs e)
        {

        }

        private void equalityBtnClick(object sender, EventArgs e)
        {

        }

        private void actionsBtnClick(object sender, EventArgs e)
        {

        }

        private void additActionsBtnClick(object sender, EventArgs e)
        {

        }

        private void memoryActionsBtnClick(object sender, EventArgs e)
        {

        }

        private void clearBtnClick(object sender, EventArgs e)
        {

        }

        private void backspaceBtn(object sender, EventArgs e)
        {

        }
    }
}
