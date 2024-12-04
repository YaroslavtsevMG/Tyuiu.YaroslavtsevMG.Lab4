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
    public partial class ConversionCalcControl : UserControl
    {
        private string[] arrConversion;
        public ConversionCalcControl()
        {
            InitializeComponent();
            arrConversion = new string[] { "байт", "килобайт", "мегабайт", "гигабайт", "терабайт", "петабайт", "экзабайт", };
            FromComboBox.Items.AddRange(arrConversion);
            ToComboBox.Items.AddRange(arrConversion);
            FromComboBox.SelectedIndex = 0;
            ToComboBox.SelectedIndex = 0;
            FromTextBox.Text = "0";
        }

        private void ConversionButton_Click(object sender, EventArgs e)
        {
            if(ToComboBox.SelectedIndex == -1 || FromComboBox.SelectedIndex == -1)
            {
                return;
            }
            if(ToComboBox.SelectedIndex == FromComboBox.SelectedIndex)
            {
                ResultLabel.Text = "Значение в выбранной единице измерения: " + FromTextBox.Text;
            }
            double z;
            if(!double.TryParse(FromTextBox.Text,out z))
            {
                FromTextBox.Text = "0";
            }
            double bytes=0;
            switch(FromComboBox.SelectedIndex)
            {
                case (0):
                    bytes = Convert.ToDouble(FromTextBox.Text);
                    break;
                case (1):
                    bytes = ConversionCalc.Lib.ConversionCalc.FromKilobyteToByte(Convert.ToDouble(FromTextBox.Text));
                    break;
                case (2):
                    bytes = ConversionCalc.Lib.ConversionCalc.FromMegabyteToByte(Convert.ToDouble(FromTextBox.Text));
                    break;
                case (3):
                    bytes = ConversionCalc.Lib.ConversionCalc.FromGigabyteToByte(Convert.ToDouble(FromTextBox.Text));
                    break;
                case (4):
                    bytes = ConversionCalc.Lib.ConversionCalc.FromTerrabyteToByte(Convert.ToDouble(FromTextBox.Text));
                    break;
                case (5):
                    bytes = ConversionCalc.Lib.ConversionCalc.FromPetabyteToByte(Convert.ToDouble(FromTextBox.Text));
                    break;
                case (6):
                    bytes = ConversionCalc.Lib.ConversionCalc.FromEkzobyteToByte(Convert.ToDouble(FromTextBox.Text));
                    break;
            }
            switch(ToComboBox.SelectedIndex)
            {
                case (0):
                    ResultLabel.Text = "Значение в выбранной единице измерения: "+bytes.ToString();
                    break;
                case (1):
                    ResultLabel.Text = "Значение в выбранной единице измерения: " + ConversionCalc.Lib.ConversionCalc.FromByteToKilobyte(bytes).ToString();
                    break;
                case (2):
                    ResultLabel.Text = "Значение в выбранной единице измерения: " + ConversionCalc.Lib.ConversionCalc.FromByteToMegabyte(bytes).ToString();
                    break;
                case (3):
                    ResultLabel.Text = "Значение в выбранной единице измерения: " + ConversionCalc.Lib.ConversionCalc.FromByteToGigabyte(bytes).ToString();
                    break;
                case (4):
                    ResultLabel.Text = "Значение в выбранной единице измерения: " + ConversionCalc.Lib.ConversionCalc.FromByteToTerrabyte(bytes).ToString();
                    break;
                case (5):
                    ResultLabel.Text = "Значение в выбранной единице измерения: " + ConversionCalc.Lib.ConversionCalc.FromByteToPetabyte(bytes).ToString();
                    break;
                case (6):
                    ResultLabel.Text = "Значение в выбранной единице измерения: " + ConversionCalc.Lib.ConversionCalc.FromByteToEkzobyte(bytes).ToString();
                    break;
            }
        }
    }
}
