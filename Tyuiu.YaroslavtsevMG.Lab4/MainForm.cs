﻿namespace Tyuiu.YaroslavtsevMG.Lab4
{
    public partial class MainForm : Form
    {
        private enum State
        {
            ordinary,
            arithmetic,
            conversion,
            NDS
        }
        private State state;
        private bool firstRun = true;
        private UserControl currentUserControl;
        public MainForm()
        {
            InitializeComponent();
            state = State.ordinary;
            SideBarPanel.Location = new Point(-200, 0);
            NameCalcLabelYMG.Text = "Обычный";
            currentUserControl = new OrdinaryCalcControl { Dock = DockStyle.Fill };
            ControlPanel.Controls.Add(currentUserControl);
        }

        private void SideBarButton_Click(object sender, EventArgs e)
        {
            OpenTimer.Enabled = true;
            CloseTimer.Enabled = false;
        }

        private void OpenTimer_Tick(object sender, EventArgs e)
        {
            if (SideBarPanel.Location.X < 0)
            {
                SideBarPanel.Location = new Point(SideBarPanel.Location.X + 10, SideBarPanel.Location.Y);
                return;
            }
            OpenTimer.Enabled = false;
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            if (SideBarPanel.Location.X > -200)
            {
                SideBarPanel.Location = new Point(SideBarPanel.Location.X - 10, SideBarPanel.Location.Y);
                return;
            }
            CloseTimer.Enabled = false;
        }

        private void CloseSideBarButton_Click(object sender, EventArgs e)
        {
            CloseTimer.Enabled = true;
            OpenTimer.Enabled = false;
        }

        private void ToOrdinaryCalcButton_Click(object sender, EventArgs e)
        {
            if (currentUserControl.GetType() == typeof(OrdinaryCalcControl))
            {
                return;
            }
            ControlPanel.Controls.Remove(currentUserControl);
            currentUserControl = new OrdinaryCalcControl { Dock = DockStyle.Fill };
            ControlPanel.Controls.Add(currentUserControl);
            CloseTimer.Enabled = true;
            OpenTimer.Enabled = false;
            NameCalcLabelYMG.Text = "Обычный";

        }

        private void ToArithmeticCalcButton_Click(object sender, EventArgs e)
        {
            if (currentUserControl.GetType() == typeof(ArithmeticCalcControl))
            {
                return;
            }
            ControlPanel.Controls.Remove(currentUserControl);
            currentUserControl = new ArithmeticCalcControl { Dock = DockStyle.Fill };
            ControlPanel.Controls.Add(currentUserControl);
            CloseTimer.Enabled = true;
            OpenTimer.Enabled = false;
            NameCalcLabelYMG.Text = "Расширенный";
        }

        private void ToConversionCalcButton_Click(object sender, EventArgs e)
        {
            if (currentUserControl.GetType() == typeof(ConversionCalcControl))
            {
                return;
            }
            ControlPanel.Controls.Remove(currentUserControl);
            currentUserControl = new ConversionCalcControl { Dock = DockStyle.Fill };
            ControlPanel.Controls.Add(currentUserControl);
            CloseTimer.Enabled = true;
            OpenTimer.Enabled = false;
            NameCalcLabelYMG.Text = "Конвертация";
        }

        private void ToNDSCalcButton_Click(object sender, EventArgs e)
        {
            if (currentUserControl.GetType() == typeof(NDSCalcControl))
            {
                return;
            }
            ControlPanel.Controls.Remove(currentUserControl);
            currentUserControl = new NDSCalcControl { Dock = DockStyle.Fill };
            ControlPanel.Controls.Add(currentUserControl);
            CloseTimer.Enabled = true;
            OpenTimer.Enabled = false;
            NameCalcLabelYMG.Text = "Рассчет НДС";
        }

        private void AboutButtonYMG_Click(object sender, EventArgs e)
        {

            MessageBox.Show(
        "Разработал: Ярославцев М.Г. МКМб-22-1\n" +
        "Функционал:\n" +
        "Обычный калькулятор\n" +
        "Расширенный калькулятор\n" +
        "Калькулятор перевода систем счисления для размера информации\n" +
        "Калькулятор НДС\n",
        "О программе",
        MessageBoxButtons.OK);
        }
    }
}
