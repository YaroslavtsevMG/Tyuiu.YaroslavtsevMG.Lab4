using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrdinaryCalc.Lib;
namespace Tyuiu.YaroslavtsevMG.Lab4
{
    public partial class OrdinaryCalcControl : UserControl
    {
        private delegate double currentOperation(double a, double b);
        private double firstOperand;
        private double secondOperand;
        private bool resultTyped = true;
        private enum operations
        {
            plus = '+',
            minus = '-',
            multiplication = '*',
            power = '^',
            root = '√',
            quotient = '/'
        }
        private operations operation;
        public OrdinaryCalcControl()
        {
            InitializeComponent();

            FirstPartLabel.Text = "";
            SecondPartLabel.Text = "0";
            operation = operations.power;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (!resultTyped) secondOperand = Convert.ToDouble(SecondPartLabel.Text);
            FirstPartLabel.Text = firstOperand.ToString()+(char)operation + secondOperand;
            switch (operation)
            {
                case (operations.plus):
                    
                    firstOperand = OrdinaryCalc.Lib.OrdinaryCalc.CalcSumma(firstOperand, secondOperand);
                    SecondPartLabel.Text = Convert.ToString(firstOperand);
                    resultTyped = true;
                    break;
                case (operations.minus):
                    {
                        
                        firstOperand = OrdinaryCalc.Lib.OrdinaryCalc.CalcDifference(firstOperand, secondOperand);
                        SecondPartLabel.Text = Convert.ToString(firstOperand);
                        resultTyped = true;
                        break;
                    }
                case(operations.multiplication):
                    firstOperand = OrdinaryCalc.Lib.OrdinaryCalc.CalcMultiplication(firstOperand, secondOperand);
                    SecondPartLabel.Text = Convert.ToString(firstOperand);
                    resultTyped = true;
                    break;
                case (operations.quotient):
                    firstOperand = OrdinaryCalc.Lib.OrdinaryCalc.CalcQuotient(firstOperand, secondOperand);
                    SecondPartLabel.Text = Convert.ToString(firstOperand);
                    resultTyped = true;
                    break;
                case (operations.power):
                    firstOperand = OrdinaryCalc.Lib.OrdinaryCalc.CalcPower(firstOperand, secondOperand);
                    SecondPartLabel.Text = Convert.ToString(firstOperand);
                    resultTyped = true;
                    break;
                case (operations.root):
                    firstOperand = OrdinaryCalc.Lib.OrdinaryCalc.CalcRoot(secondOperand,firstOperand);
                    SecondPartLabel.Text = Convert.ToString(firstOperand);
                    resultTyped = true;
                    break;
            }
            
        }
        private void TypeNumber(int number)
        {
            if (resultTyped)
            {
                SecondPartLabel.Text = Convert.ToString(number);
                resultTyped = false;
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

        private void InversButton_Click(object sender, EventArgs e)
        {
            if (SecondPartLabel.Text.Length == 1 && SecondPartLabel.Text[0] == '0')
            {
                return;
            }
            if (SecondPartLabel.Text.Contains('-'))
            {
                SecondPartLabel.Text=SecondPartLabel.Text.Remove(0, 1);
                return;
            }
            SecondPartLabel.Text = "-" + SecondPartLabel.Text;
        }

        private void OperatorPeakUp(operations peakedOperation)
        {
            if (SecondPartLabel.Text.Length == 0) return;
            operation = peakedOperation;
            foreach (operations op in Enum.GetValues(typeof(operations)))
            {
                if(resultTyped && FirstPartLabel.Text.Contains((char)op))
                {
                    FirstPartLabel.Text = FirstPartLabel.Text.Remove(FirstPartLabel.Text.Length-1, 1)+(char)operation;
                    return;
                }
            }
            firstOperand = Convert.ToDouble(SecondPartLabel.Text);
            FirstPartLabel.Text= SecondPartLabel.Text+ (char)operation;
            resultTyped = true;
            
        }
        private void PlusButton_Click(object sender, EventArgs e)
        {
            OperatorPeakUp(operations.plus);

        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            OperatorPeakUp(operations.minus);
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            OperatorPeakUp(operations.multiplication);
        }

        private void QuotientButton_Click(object sender, EventArgs e)
        {
            OperatorPeakUp(operations.quotient);
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            OperatorPeakUp(operations.power);
        }

        private void RootButton_Click(object sender, EventArgs e)
        {
            OperatorPeakUp(operations.root);
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (SecondPartLabel.Text.Length <= 1)
            {
                SecondPartLabel.Text = "0";
                return;
            }
            SecondPartLabel.Text = SecondPartLabel.Text.Remove(SecondPartLabel.Text.Length - 1, 1);
        }

        private void CommaButton_Click(object sender, EventArgs e)
        {
            if (resultTyped)
            {
                FirstPartLabel.Text = "";
                SecondPartLabel.Text = "0,";
                resultTyped = false;
                return;
            }
            if(SecondPartLabel.Text.Contains(','))
            {
                return;
            }
            SecondPartLabel.Text = SecondPartLabel.Text + ",";
        }
    }
}
