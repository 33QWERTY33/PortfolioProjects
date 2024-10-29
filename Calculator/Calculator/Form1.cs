using System;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        bool repeatPreviousCalc = false;
        int operatorCount = 0;

        string operation;
        string total;
        int operandOne;
        int operandTwo;
        public Form1()
        {
            InitializeComponent();
        }

        private void handleOperation(string op)
        {
            if (operatorCount != 1)
            {
                lblDisplay.Text += op;
                operation = op;
                operatorCount++;
                repeatPreviousCalc = false;
            }
        }

        private int performCalculation(int arg1, int arg2)
        {
            if (operation == "+")
            {
                return arg1 + arg2;
            }
            else if (operation == "-")
            {
                return arg1 - arg2;
            }
            else if (operation == "*")
            {
                return arg1 * arg2;
            }
            else if (operation == "/")
            {
                if (arg2 == 0)
                {
                    MessageBox.Show("You cannot divide by zero");
                    operation = "";
                    return arg1;
                }
                return arg1 / arg2;
            }
            return 0; // visual studio was complaining about all execution paths not returning an int
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            handleOperation("+");
        }
        private void cmdSub_Click(object sender, EventArgs e)
        {
            handleOperation("-");
        }

        private void cmdMul_Click(object sender, EventArgs e)
        {
            handleOperation("*");
        }

        private void cmdDiv_Click(object sender, EventArgs e)
        {
            handleOperation("/");
        }

        private void cmdClr_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            operation = "";
            total = "";
            operatorCount = 0;
        }

        private void cmdEqual_Click(object sender, EventArgs e)
        {
            if (operation != null)
            {
                if (repeatPreviousCalc)
                {
                    total = performCalculation(int.Parse(total), operandTwo).ToString();
                    lblDisplay.Text = total;
                }

                int operatorIndex = lblDisplay.Text.IndexOf(operation);

                if (operatorIndex + 1 != lblDisplay.Text.Length && operatorCount != 0)
                {
                    if (lblDisplay.Text.IndexOf("+") == 0 || lblDisplay.Text.IndexOf("-") == 0 || lblDisplay.Text.IndexOf("/") == 0 || lblDisplay.Text.IndexOf("*") == 0)
                    {
                        MessageBox.Show("You need to place an operand first instead of an operator.");
                        operation = "";
                        operatorCount = 0;
                        lblDisplay.Text = "";
                        return;
                    }
                    operandOne = int.Parse(lblDisplay.Text.Substring(0, operatorIndex));
                    operandTwo = int.Parse(lblDisplay.Text.Substring(operatorIndex + 1));

                    total = performCalculation(operandOne, operandTwo).ToString();

                    lblDisplay.Text = total;
                    operatorCount = 0;
                    repeatPreviousCalc = true;
                }
            }
        }

        private void cmdOne_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "1";
        }

        private void cmdTwo_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "2";
        }

        private void cmdThree_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "3";
        }

        private void cmdFour_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "4";
        }

        private void cmdFive_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "5";
        }

        private void cmdSix_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "6";
        }

        private void cmdSeven_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "7";
        }

        private void cmdEight_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "8";
        }

        private void cmdNine_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "9";
        }

        private void cmdZero_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "0";
        }

    }
}
