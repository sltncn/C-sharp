

// This code is written by Sultan Can in 27.03.22.
/* This program acts like a calculator as much as possible. It does basic four operation of 
 math.
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calculator : Form
    {

        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public calculator()
        {
            InitializeComponent();
            
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            this.txtInput.Text = "";
            input += "0";
            this.txtInput.Text += input;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            this.txtInput.Text = "";
            input += "1";
            this.txtInput.Text += input;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            this.txtInput.Text = "";
            input += "2";
            this.txtInput.Text += input;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            this.txtInput.Text = "";
            input += "3";
            this.txtInput.Text += input;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            this.txtInput.Text = "";
            input += "4";
            this.txtInput.Text += input;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            this.txtInput.Text = "";
            input += "5";
            this.txtInput.Text += input;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            this.txtInput.Text = "";
            input += "6";
            this.txtInput.Text += input;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            this.txtInput.Text = "";
            input += "7";
            this.txtInput.Text += input;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            this.txtInput.Text = "";
            input += "8";
            this.txtInput.Text += input;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            this.txtInput.Text = "";
            input += "9";
            this.txtInput.Text += input;
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            input += ".";

        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;

        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtInput.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;

        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            this.txtInput.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;


            if (operation == '+')
            {
                result = num1 + num2;
                txtInput.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                txtInput.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                txtInput.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    txtInput.Text = result.ToString();
                }
                else
                {
                    txtInput.Text = "ERROR!";
                }

            }

        }

       
    }
}
