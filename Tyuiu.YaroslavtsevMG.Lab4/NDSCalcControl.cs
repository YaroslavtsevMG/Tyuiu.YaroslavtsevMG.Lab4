using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.YaroslavtsevMG.Lab4
{
    public partial class NDSCalcControl : UserControl
    {
        public NDSCalcControl()
        {
            InitializeComponent();
        }

        private void FirstFormulaButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(FirstFormulaFirstTextBoxYMG.Text) || string.IsNullOrEmpty(FirstFormulaSecondTextBoxYMG.Text))
            {
                return;
            }
            double x;
            double y;
            if(double.TryParse(FirstFormulaFirstTextBoxYMG.Text,out x) && double.TryParse(FirstFormulaSecondTextBoxYMG.Text, out y))
            {
                var res=NDSCalc.Lib.NDSCalc.CalcFirstFormula(x, y);
                ResultNDSLabel.Text = "Размер НДС: "+ Math.Round(res[0], 2).ToString();
                SummaWithoutNDSLabel.Text= "Сумма без НДС: " + Math.Round(res[1], 2).ToString();
            }
        }

        private void SecondFormulaButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SecondFormulaFirstTextBox.Text) || string.IsNullOrEmpty(SecondFormulaSecondTextBoxYMG.Text))
            {
                return;
            }
            double x;
            double y;
            if (double.TryParse(SecondFormulaFirstTextBox.Text, out x) && double.TryParse(SecondFormulaSecondTextBoxYMG.Text, out y))
            {
                var res = NDSCalc.Lib.NDSCalc.CalcSecondFormula(x, y);
                ResultSummaNDSLabel.Text = "Размер НДС: "+Math.Round(res[0],2).ToString();
                SummaWithNDSLabel.Text = "Сумма с начисленным НДС: "+ Math.Round(res[1], 2).ToString();
            }
        }
    }
}
