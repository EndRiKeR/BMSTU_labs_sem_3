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
        private CalculatorData Data;

        public Калькулятор()
        {
            InitializeComponent();
        }

        private void updateActionsState(Moves move, Actions act = Actions.None)
        {
            Data.nowMove = move;
            if(act != Actions.None)
            {
                Data.nowAction = act;
            }
        }

        private void numericBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            updateActionsState(Moves.Add);
            if (txtbox_display.Text == "0") {
                txtbox_display.Text = "";
            }
            txtbox_display.Text = txtbox_display.Text + btn.Text;
        }

        private void pointBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtbox_display.Text = txtbox_display.Text + ",";
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
            txtbox_display.Text = "0";
        }

        private void backspaceBtn(object sender, EventArgs e)
        {
            //txtbox_display.Text = new String(txtbox_display.Text, txtbox_display.Text.Length - 1);
        }
    }
}
