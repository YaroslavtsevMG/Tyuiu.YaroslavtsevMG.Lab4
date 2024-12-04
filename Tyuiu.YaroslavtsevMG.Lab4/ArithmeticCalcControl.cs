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
            FirstPartLabelYMG.Text = "";
            SecondPartLabelYMG.Text = "";
        }

        private void TypeNumber(int number)
        {
            if (resultTyped || constantTyped)
            {
                SecondPartLabelYMG.Text = Convert.ToString(number);
                resultTyped = false;
                constantTyped = false;
                return;
            }
            if (SecondPartLabelYMG.Text.Length == 1 && SecondPartLabelYMG.Text[0] == '0' && number == 0)
            {
                return;
            }
            if (SecondPartLabelYMG.Text.Length == 1 && SecondPartLabelYMG.Text[0] == '0')
            {
                SecondPartLabelYMG.Text = Convert.ToString(number);
                return;
            }
            SecondPartLabelYMG.Text = SecondPartLabelYMG.Text + Convert.ToString(number);
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
                SecondPartLabelYMG.Text = "0,";
                resultTyped = false;
                return;
            }
            if (SecondPartLabelYMG.Text.Contains(','))
            {
                return;
            }
            SecondPartLabelYMG.Text = SecondPartLabelYMG.Text + ",";
        }

        private void InversButton_Click(object sender, EventArgs e)
        {
            if (SecondPartLabelYMG.Text.Length == 1 && SecondPartLabelYMG.Text[0] == '0')
            {
                return;
            }
            if (equalTyped)
            {
                SecondPartLabelYMG.Text = "";
                equalTyped = false;
            }
            if (SecondPartLabelYMG.Text.Contains("negative"))
            {
                SecondPartLabelYMG.Text = SecondPartLabelYMG.Text.Remove(0, 9);
                return;
            }
            
            SecondPartLabelYMG.Text = "negative " + SecondPartLabelYMG.Text;
            resultTyped = false;
            constantTyped = false;
        }

        private void OperatorPeakUp(string operatoration)
        {
            if(resultTyped)
            {
                var arr = FirstPartLabelYMG.Text.Split(" ");
                FirstPartLabelYMG.Text = "";
                for (int i=0;i<arr.Length-1;i++)
                {
                    FirstPartLabelYMG.Text = FirstPartLabelYMG.Text + arr[i]+" ";
                }
                FirstPartLabelYMG.Text = FirstPartLabelYMG.Text + operatoration;
                return;
            }
            if(operatoration=="cos" ||operatoration=="sin")
            {
                FirstPartLabelYMG.Text = FirstPartLabelYMG.Text + " " + operatoration;
                resultTyped = true;
                return;
            }
            FirstPartLabelYMG.Text = FirstPartLabelYMG.Text + " " +SecondPartLabelYMG.Text+ " " + operatoration;
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
            SecondPartLabelYMG.Text = "pi";
            constantTyped = true;
            resultTyped = false;
        }

        private void ExpButton_Click(object sender, EventArgs e)
        {
            SecondPartLabelYMG.Text = "exp";
            constantTyped = true;
            resultTyped = false;
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if(constantTyped)
            {
                SecondPartLabelYMG.Text = "0";
                constantTyped = false;
                return;
            }
            if (SecondPartLabelYMG.Text.Length <= 1)
            {
                SecondPartLabelYMG.Text = "0";
                if(FirstPartLabelYMG.Text.Length==0)
                {
                    return;
                }
                if (FirstPartLabelYMG.Text[FirstPartLabelYMG.Text.Length-1]=='(')
                {
                    FirstPartLabelYMG.Text = FirstPartLabelYMG.Text.Remove(FirstPartLabelYMG.Text.Length - 1, 1);
                    countOpenBracket = countOpenBracket - 1;
                }
                else if (FirstPartLabelYMG.Text[FirstPartLabelYMG.Text.Length - 1] == ')')
                {
                    FirstPartLabelYMG.Text = FirstPartLabelYMG.Text.Remove(FirstPartLabelYMG.Text.Length - 1, 1);
                    countCloseBracket = countCloseBracket - 1;
                }
                
                return;
            }
            SecondPartLabelYMG.Text = SecondPartLabelYMG.Text.Remove(SecondPartLabelYMG.Text.Length - 1, 1);
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if(resultTyped)
            {
                return;
            }
            FirstPartLabelYMG.Text = FirstPartLabelYMG.Text + " " + SecondPartLabelYMG.Text;
            while(countOpenBracket>countCloseBracket)
            {
                FirstPartLabelYMG.Text = FirstPartLabelYMG.Text + " )";
                countCloseBracket = countCloseBracket + 1;
            }
            resultTyped = true;
            equalTyped = true;
            SecondPartLabelYMG.Text = FirstPartLabelYMG.Text + " = " + ArithmeticCalc.Lib.ArithmeticCalc.CalcExpression(FirstPartLabelYMG.Text);
            FirstPartLabelYMG.Text = "";
        }

        private void OpenBracketButton_Click(object sender, EventArgs e)
        {
            FirstPartLabelYMG.Text = FirstPartLabelYMG.Text + " (";
            countOpenBracket = countOpenBracket + 1;
            resultTyped = false;
        }

        private void CloseBracketButton_Click(object sender, EventArgs e)
        {
            if(countOpenBracket>countCloseBracket)
            {
                FirstPartLabelYMG.Text = FirstPartLabelYMG.Text +" "+ SecondPartLabelYMG.Text + " )";
                countCloseBracket = countCloseBracket + 1;
                SecondPartLabelYMG.Text = "";
            }
        }
    }
}
