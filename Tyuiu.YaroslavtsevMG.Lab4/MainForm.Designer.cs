namespace Tyuiu.YaroslavtsevMG.Lab4
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TopPanel = new Panel();
            SideBarButtonYMG = new Button();
            NameCalcLabelYMG = new Label();
            SideBarPanel = new Panel();
            BotButtonsPanel = new TableLayoutPanel();
            AboutButtonYMG = new Button();
            TopBottonPanel = new TableLayoutPanel();
            ToNDSCalcButtonYMG = new Button();
            ToConversionCalcButtonYMG = new Button();
            ToArithmeticCalcButtonYMG = new Button();
            ToOrdinaryCalcButtonYMG = new Button();
            CloseSideBarButtonYMG = new Button();
            OpenTimer = new System.Windows.Forms.Timer(components);
            CloseTimer = new System.Windows.Forms.Timer(components);
            ControlPanel = new Panel();
            TopPanel.SuspendLayout();
            SideBarPanel.SuspendLayout();
            BotButtonsPanel.SuspendLayout();
            TopBottonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = SystemColors.ControlDarkDark;
            TopPanel.Controls.Add(SideBarButtonYMG);
            TopPanel.Controls.Add(NameCalcLabelYMG);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(800, 40);
            TopPanel.TabIndex = 0;
            // 
            // SideBarButtonYMG
            // 
            SideBarButtonYMG.BackColor = SystemColors.ControlDarkDark;
            SideBarButtonYMG.BackgroundImageLayout = ImageLayout.Center;
            SideBarButtonYMG.Dock = DockStyle.Left;
            SideBarButtonYMG.ForeColor = SystemColors.ControlLightLight;
            SideBarButtonYMG.Location = new Point(0, 0);
            SideBarButtonYMG.Name = "SideBarButtonYMG";
            SideBarButtonYMG.Size = new Size(75, 40);
            SideBarButtonYMG.TabIndex = 1;
            SideBarButtonYMG.Text = "меню";
            SideBarButtonYMG.UseVisualStyleBackColor = false;
            SideBarButtonYMG.Click += SideBarButton_Click;
            // 
            // NameCalcLabelYMG
            // 
            NameCalcLabelYMG.AutoSize = true;
            NameCalcLabelYMG.Dock = DockStyle.Right;
            NameCalcLabelYMG.Font = new Font("Segoe UI", 15.75F);
            NameCalcLabelYMG.ForeColor = SystemColors.ControlLightLight;
            NameCalcLabelYMG.Location = new Point(528, 0);
            NameCalcLabelYMG.Name = "NameCalcLabelYMG";
            NameCalcLabelYMG.Size = new Size(272, 30);
            NameCalcLabelYMG.TabIndex = 0;
            NameCalcLabelYMG.Text = "какой именно калькулятор";
            NameCalcLabelYMG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SideBarPanel
            // 
            SideBarPanel.BackColor = SystemColors.ControlDarkDark;
            SideBarPanel.Controls.Add(BotButtonsPanel);
            SideBarPanel.Controls.Add(TopBottonPanel);
            SideBarPanel.Location = new Point(200, 0);
            SideBarPanel.Name = "SideBarPanel";
            SideBarPanel.Size = new Size(200, 451);
            SideBarPanel.TabIndex = 4;
            // 
            // BotButtonsPanel
            // 
            BotButtonsPanel.ColumnCount = 1;
            BotButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            BotButtonsPanel.Controls.Add(AboutButtonYMG, 0, 0);
            BotButtonsPanel.Dock = DockStyle.Bottom;
            BotButtonsPanel.Location = new Point(0, 393);
            BotButtonsPanel.Name = "BotButtonsPanel";
            BotButtonsPanel.RowCount = 1;
            BotButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BotButtonsPanel.Size = new Size(200, 58);
            BotButtonsPanel.TabIndex = 1;
            // 
            // AboutButtonYMG
            // 
            AboutButtonYMG.Dock = DockStyle.Fill;
            AboutButtonYMG.Location = new Point(3, 3);
            AboutButtonYMG.Name = "AboutButtonYMG";
            AboutButtonYMG.Size = new Size(194, 52);
            AboutButtonYMG.TabIndex = 0;
            AboutButtonYMG.Text = "О программе";
            AboutButtonYMG.UseVisualStyleBackColor = true;
            AboutButtonYMG.Click += AboutButtonYMG_Click;
            // 
            // TopBottonPanel
            // 
            TopBottonPanel.ColumnCount = 1;
            TopBottonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TopBottonPanel.Controls.Add(ToNDSCalcButtonYMG, 0, 4);
            TopBottonPanel.Controls.Add(ToConversionCalcButtonYMG, 0, 3);
            TopBottonPanel.Controls.Add(ToArithmeticCalcButtonYMG, 0, 2);
            TopBottonPanel.Controls.Add(ToOrdinaryCalcButtonYMG, 0, 1);
            TopBottonPanel.Controls.Add(CloseSideBarButtonYMG, 0, 0);
            TopBottonPanel.Dock = DockStyle.Top;
            TopBottonPanel.Location = new Point(0, 0);
            TopBottonPanel.Name = "TopBottonPanel";
            TopBottonPanel.RowCount = 5;
            TopBottonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9992046F));
            TopBottonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9992F));
            TopBottonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9992F));
            TopBottonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9992F));
            TopBottonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0032F));
            TopBottonPanel.Size = new Size(200, 174);
            TopBottonPanel.TabIndex = 0;
            // 
            // ToNDSCalcButtonYMG
            // 
            ToNDSCalcButtonYMG.Dock = DockStyle.Fill;
            ToNDSCalcButtonYMG.Location = new Point(3, 139);
            ToNDSCalcButtonYMG.Name = "ToNDSCalcButtonYMG";
            ToNDSCalcButtonYMG.Size = new Size(194, 32);
            ToNDSCalcButtonYMG.TabIndex = 3;
            ToNDSCalcButtonYMG.Text = "Рассчет НДС";
            ToNDSCalcButtonYMG.UseVisualStyleBackColor = true;
            ToNDSCalcButtonYMG.Click += ToNDSCalcButton_Click;
            // 
            // ToConversionCalcButtonYMG
            // 
            ToConversionCalcButtonYMG.Dock = DockStyle.Fill;
            ToConversionCalcButtonYMG.Location = new Point(3, 105);
            ToConversionCalcButtonYMG.Name = "ToConversionCalcButtonYMG";
            ToConversionCalcButtonYMG.Size = new Size(194, 28);
            ToConversionCalcButtonYMG.TabIndex = 2;
            ToConversionCalcButtonYMG.Text = "Конвертация";
            ToConversionCalcButtonYMG.UseVisualStyleBackColor = true;
            ToConversionCalcButtonYMG.Click += ToConversionCalcButton_Click;
            // 
            // ToArithmeticCalcButtonYMG
            // 
            ToArithmeticCalcButtonYMG.Dock = DockStyle.Fill;
            ToArithmeticCalcButtonYMG.FlatStyle = FlatStyle.System;
            ToArithmeticCalcButtonYMG.Location = new Point(3, 71);
            ToArithmeticCalcButtonYMG.Name = "ToArithmeticCalcButtonYMG";
            ToArithmeticCalcButtonYMG.Size = new Size(194, 28);
            ToArithmeticCalcButtonYMG.TabIndex = 1;
            ToArithmeticCalcButtonYMG.Text = "Расширенный";
            ToArithmeticCalcButtonYMG.UseVisualStyleBackColor = true;
            ToArithmeticCalcButtonYMG.Click += ToArithmeticCalcButton_Click;
            // 
            // ToOrdinaryCalcButtonYMG
            // 
            ToOrdinaryCalcButtonYMG.Dock = DockStyle.Fill;
            ToOrdinaryCalcButtonYMG.FlatStyle = FlatStyle.System;
            ToOrdinaryCalcButtonYMG.Location = new Point(3, 37);
            ToOrdinaryCalcButtonYMG.Name = "ToOrdinaryCalcButtonYMG";
            ToOrdinaryCalcButtonYMG.Size = new Size(194, 28);
            ToOrdinaryCalcButtonYMG.TabIndex = 0;
            ToOrdinaryCalcButtonYMG.Text = "Обычный";
            ToOrdinaryCalcButtonYMG.UseVisualStyleBackColor = true;
            ToOrdinaryCalcButtonYMG.Click += ToOrdinaryCalcButton_Click;
            // 
            // CloseSideBarButtonYMG
            // 
            CloseSideBarButtonYMG.Dock = DockStyle.Fill;
            CloseSideBarButtonYMG.Location = new Point(3, 3);
            CloseSideBarButtonYMG.Name = "CloseSideBarButtonYMG";
            CloseSideBarButtonYMG.Size = new Size(194, 28);
            CloseSideBarButtonYMG.TabIndex = 4;
            CloseSideBarButtonYMG.Text = "Закрыть боковое меню";
            CloseSideBarButtonYMG.UseVisualStyleBackColor = true;
            CloseSideBarButtonYMG.Click += CloseSideBarButton_Click;
            // 
            // OpenTimer
            // 
            OpenTimer.Interval = 1;
            OpenTimer.Tick += OpenTimer_Tick;
            // 
            // CloseTimer
            // 
            CloseTimer.Enabled = true;
            CloseTimer.Interval = 1;
            CloseTimer.Tick += CloseTimer_Tick;
            // 
            // ControlPanel
            // 
            ControlPanel.Dock = DockStyle.Fill;
            ControlPanel.Location = new Point(0, 40);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(800, 410);
            ControlPanel.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SideBarPanel);
            Controls.Add(ControlPanel);
            Controls.Add(TopPanel);
            Name = "MainForm";
            Text = "Calculator";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            SideBarPanel.ResumeLayout(false);
            BotButtonsPanel.ResumeLayout(false);
            TopBottonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Label NameCalcLabelYMG;
        private Panel SideBarPanel;
        private System.Windows.Forms.Timer OpenTimer;
        private System.Windows.Forms.Timer CloseTimer;
        private TableLayoutPanel TopBottonPanel;
        private TableLayoutPanel BotButtonsPanel;
        private Button ToOrdinaryCalcButtonYMG;
        private Button ToArithmeticCalcButtonYMG;
        private Button ToConversionCalcButtonYMG;
        private Button ToNDSCalcButtonYMG;
        private Button SideBarButtonYMG;
        private Button CloseSideBarButtonYMG;
        private Panel ControlPanel;
        private Button AboutButtonYMG;
    }
}
