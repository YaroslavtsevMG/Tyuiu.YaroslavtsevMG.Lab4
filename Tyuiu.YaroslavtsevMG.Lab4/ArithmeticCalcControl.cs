using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.YaroslavtsevMG.Lab4
{
    public partial class ArithmeticCalcControl : UserControl
    {
        private int countOpenBracket = 0;
        private int countCloseBracket = 0;
        private bool resultTyped = true;
        private bool constantTyped = true;
        private bool equalTyped = true;
        public ArithmeticCalcControl()
        {
            InitializeComponent();
            FirstPartLabel.Text = "";
            SecondPartLabel.Text = "";
        }

        private void TypeNumber(int number)
        {
            if (resultTyped || constantTyped)
            {
                SecondPartLabel.Text = Convert.ToString(number);
                resultTyped = false;
                constantTyped = false;
                return;
            }
            if (SecondPartLabel.Text.Length == 1 && SecondPartLabel.Text[0] == '0' && number == 0)
            {
                return;
            }
            if (SecondPartLabel.Text.Length == 1 && SecondPartLabel.Text[0] == '0')
            {
                SecondPartLabel.Text = Convert.ToString(number);
                return;
            }
            SecondPartLabel.Text = SecondPartLabel.Text + Convert.ToString(number);
        }
        private void button0_Click(object sender, EventArgs e)
        {
            TypeNumber(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TypeNumber(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TypeNumber(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TypeNumber(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TypeNumber(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TypeNumber(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TypeNumber(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TypeNumber(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TypeNumber(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TypeNumber(9);
        }

        private void CommaButton_Click(object sender, EventArgs e)
        {
            if (resultTyped)
            {
                SecondPartLabel.Text = "0,";
                resultTyped = false;
                return;
            }
            if (SecondPartLabel.Text.Contains(','))
            {
                return;
            }
            SecondPartLabel.Text = SecondPartLabel.Text + ",";
        }

        private void InversButton_Click(object sender, EventArgs e)
        {
            if (SecondPartLabel.Text.Length == 1 && SecondPartLabel.Text[0] == '0')
            {
                return;
            }
            if (equalTyped)
            {
                SecondPartLabel.Text = "";
                equalTyped = false;
            }
            if (SecondPartLabel.Text.Contains("negative"))
            {
                SecondPartLabel.Text = SecondPartLabel.Text.Remove(0, 9);
                return;
            }
            
            SecondPartLabel.Text = "negative " + SecondPartLabel.Text;
            resultTyped = false;
            constantTyped = false;
        }

        private void OperatorPeakUp(string operatoration)
        {
            if(resultTyped)
            {
                var arr = FirstPartLabel.Text.Split(" ");
                FirstPartLabel.Text = "";
                for (int i=0;i<arr.Length-1;i++)
                {
                    FirstPartLabel.Text = FirstPartLabel.Text + arr[i]+" ";
                }
                FirstPartLabel.Text = FirstPartLabel.Text + operatoration;
                return;
            }
            FirstPartLabel.Text = FirstPartLabel.Text + " " +SecondPartLabel.Text+ " " + operatoration;
            resultTyped = true;
        }
        private void PlusButton_Click(object sender, EventArgs e)
        {
            OperatorPeakUp("+");
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            OperatorPeakUp("*");
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            OperatorPeakUp("^");
        }

        private void RootButton_Click(object sender, EventArgs e)
        {
            OperatorPeakUp("√");
        }

        private void CosButton_Click(object sender, EventArgs e)
        {
            OperatorPeakUp("cos");
        }

        private void SinButton_Click(object sender, EventArgs e)
        {
            OperatorPeakUp("sin");
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            OperatorPeakUp("log");
        }

        private void ModButton_Click(object sender, EventArgs e)
        {
            OperatorPeakUp("mod");
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            OperatorPeakUp("-");
        }

        private void QuotientButton_Click(object sender, EventArgs e)
        {
            OperatorPeakUp("/");
        }

        private void PiButton_Click(object sender, EventArgs e)
        {
            SecondPartLabel.Text = "pi";
            constantTyped = true;
            resultTyped = false;
        }

        private void ExpButton_Click(object sender, EventArgs e)
        {
            SecondPartLabel.Text = "exp";
            constantTyped = true;
            resultTyped = false;
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if(constantTyped)
            {
                SecondPartLabel.Text = "0";
                constantTyped = false;
                return;
            }
            if (SecondPartLabel.Text.Length <= 1)
            {
                SecondPartLabel.Text = "0";
                if(FirstPartLabel.Text.Length==0)
                {
                    return;
                }
                if (FirstPartLabel.Text[FirstPartLabel.Text.Length-1]=='(')
                {
                    FirstPartLabel.Text = FirstPartLabel.Text.Remove(FirstPartLabel.Text.Length - 1, 1);
                    countOpenBracket = countOpenBracket - 1;
                }
                else if (FirstPartLabel.Text[FirstPartLabel.Text.Length - 1] == ')')
                {
                    FirstPartLabel.Text = FirstPartLabel.Text.Remove(FirstPartLabel.Text.Length - 1, 1);
                    countCloseBracket = countCloseBracket - 1;
                }
                
                return;
            }
            SecondPartLabel.Text = SecondPartLabel.Text.Remove(SecondPartLabel.Text.Length - 1, 1);
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if(resultTyped)
            {
                return;
            }
            FirstPartLabel.Text = FirstPartLabel.Text + " " + SecondPartLabel.Text;
            while(countOpenBracket>countCloseBracket)
            {
                FirstPartLabel.Text = FirstPartLabel.Text + " )";
                countCloseBracket = countCloseBracket + 1;
            }
            resultTyped = true;
            equalTyped = true;
            SecondPartLabel.Text = FirstPartLabel.Text + " = " + ArithmeticCalc.Lib.ArithmeticCalc.CalcExpression(FirstPartLabel.Text);
            FirstPartLabel.Text = "";
        }

        private void OpenBracketButton_Click(object sender, EventArgs e)
        {
            FirstPartLabel.Text = FirstPartLabel.Text + " (";
            countOpenBracket = countOpenBracket + 1;
        }

        private void CloseBracketButton_Click(object sender, EventArgs e)
        {
            if(countOpenBracket>countCloseBracket)
            {
                FirstPartLabel.Text = FirstPartLabel.Text +" "+ SecondPartLabel.Text + " )";
                countCloseBracket = countCloseBracket + 1;
                SecondPartLabel.Text = "";
            }
        }
    }
}
