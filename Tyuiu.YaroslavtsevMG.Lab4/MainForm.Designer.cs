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
            SideBarButton = new Button();
            NameCalcLabel = new Label();
            SideBarPanel = new Panel();
            BotButtonsPanel = new TableLayoutPanel();
            TopBottonPanel = new TableLayoutPanel();
            ToNDSCalcButton = new Button();
            ToConversionCalcButton = new Button();
            ToArithmeticCalcButton = new Button();
            ToOrdinaryCalcButton = new Button();
            CloseSideBarButton = new Button();
            OpenTimer = new System.Windows.Forms.Timer(components);
            CloseTimer = new System.Windows.Forms.Timer(components);
            ControlPanel = new Panel();
            TopPanel.SuspendLayout();
            SideBarPanel.SuspendLayout();
            TopBottonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = SystemColors.ControlDarkDark;
            TopPanel.Controls.Add(SideBarButton);
            TopPanel.Controls.Add(NameCalcLabel);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(800, 40);
            TopPanel.TabIndex = 0;
            // 
            // SideBarButton
            // 
            SideBarButton.BackColor = SystemColors.ControlDarkDark;
            SideBarButton.BackgroundImageLayout = ImageLayout.Center;
            SideBarButton.Dock = DockStyle.Left;
            SideBarButton.ForeColor = SystemColors.ControlLightLight;
            SideBarButton.Location = new Point(0, 0);
            SideBarButton.Name = "SideBarButton";
            SideBarButton.Size = new Size(75, 40);
            SideBarButton.TabIndex = 1;
            SideBarButton.Text = "меню";
            SideBarButton.UseVisualStyleBackColor = false;
            SideBarButton.Click += SideBarButton_Click;
            // 
            // NameCalcLabel
            // 
            NameCalcLabel.Dock = DockStyle.Right;
            NameCalcLabel.ForeColor = SystemColors.ControlLightLight;
            NameCalcLabel.Location = new Point(688, 0);
            NameCalcLabel.Name = "NameCalcLabel";
            NameCalcLabel.Size = new Size(112, 40);
            NameCalcLabel.TabIndex = 0;
            NameCalcLabel.Text = "какой именно калькулятор";
            NameCalcLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            BotButtonsPanel.Dock = DockStyle.Bottom;
            BotButtonsPanel.Location = new Point(0, 393);
            BotButtonsPanel.Name = "BotButtonsPanel";
            BotButtonsPanel.RowCount = 1;
            BotButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BotButtonsPanel.Size = new Size(200, 58);
            BotButtonsPanel.TabIndex = 1;
            // 
            // TopBottonPanel
            // 
            TopBottonPanel.ColumnCount = 1;
            TopBottonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TopBottonPanel.Controls.Add(ToNDSCalcButton, 0, 4);
            TopBottonPanel.Controls.Add(ToConversionCalcButton, 0, 3);
            TopBottonPanel.Controls.Add(ToArithmeticCalcButton, 0, 2);
            TopBottonPanel.Controls.Add(ToOrdinaryCalcButton, 0, 1);
            TopBottonPanel.Controls.Add(CloseSideBarButton, 0, 0);
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
            // ToNDSCalcButton
            // 
            ToNDSCalcButton.Dock = DockStyle.Fill;
            ToNDSCalcButton.Location = new Point(3, 139);
            ToNDSCalcButton.Name = "ToNDSCalcButton";
            ToNDSCalcButton.Size = new Size(194, 32);
            ToNDSCalcButton.TabIndex = 3;
            ToNDSCalcButton.Text = "рассчет НДС";
            ToNDSCalcButton.UseVisualStyleBackColor = true;
            ToNDSCalcButton.Click += ToNDSCalcButton_Click;
            // 
            // ToConversionCalcButton
            // 
            ToConversionCalcButton.Dock = DockStyle.Fill;
            ToConversionCalcButton.Location = new Point(3, 105);
            ToConversionCalcButton.Name = "ToConversionCalcButton";
            ToConversionCalcButton.Size = new Size(194, 28);
            ToConversionCalcButton.TabIndex = 2;
            ToConversionCalcButton.Text = "конвертация";
            ToConversionCalcButton.UseVisualStyleBackColor = true;
            ToConversionCalcButton.Click += ToConversionCalcButton_Click;
            // 
            // ToArithmeticCalcButton
            // 
            ToArithmeticCalcButton.Dock = DockStyle.Fill;
            ToArithmeticCalcButton.FlatStyle = FlatStyle.System;
            ToArithmeticCalcButton.Location = new Point(3, 71);
            ToArithmeticCalcButton.Name = "ToArithmeticCalcButton";
            ToArithmeticCalcButton.Size = new Size(194, 28);
            ToArithmeticCalcButton.TabIndex = 1;
            ToArithmeticCalcButton.Text = "расширенный";
            ToArithmeticCalcButton.UseVisualStyleBackColor = true;
            ToArithmeticCalcButton.Click += ToArithmeticCalcButton_Click;
            // 
            // ToOrdinaryCalcButton
            // 
            ToOrdinaryCalcButton.Dock = DockStyle.Fill;
            ToOrdinaryCalcButton.FlatStyle = FlatStyle.System;
            ToOrdinaryCalcButton.Location = new Point(3, 37);
            ToOrdinaryCalcButton.Name = "ToOrdinaryCalcButton";
            ToOrdinaryCalcButton.Size = new Size(194, 28);
            ToOrdinaryCalcButton.TabIndex = 0;
            ToOrdinaryCalcButton.Text = "обыкновенный";
            ToOrdinaryCalcButton.UseVisualStyleBackColor = true;
            ToOrdinaryCalcButton.Click += ToOrdinaryCalcButton_Click;
            // 
            // CloseSideBarButton
            // 
            CloseSideBarButton.Dock = DockStyle.Fill;
            CloseSideBarButton.Location = new Point(3, 3);
            CloseSideBarButton.Name = "CloseSideBarButton";
            CloseSideBarButton.Size = new Size(194, 28);
            CloseSideBarButton.TabIndex = 4;
            CloseSideBarButton.Text = "меню";
            CloseSideBarButton.UseVisualStyleBackColor = true;
            CloseSideBarButton.Click += CloseSideBarButton_Click;
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
            Text = "Form1";
            TopPanel.ResumeLayout(false);
            SideBarPanel.ResumeLayout(false);
            TopBottonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Label NameCalcLabel;
        private Panel SideBarPanel;
        private System.Windows.Forms.Timer OpenTimer;
        private System.Windows.Forms.Timer CloseTimer;
        private TableLayoutPanel TopBottonPanel;
        private TableLayoutPanel BotButtonsPanel;
        private Button ToOrdinaryCalcButton;
        private Button ToArithmeticCalcButton;
        private Button ToConversionCalcButton;
        private Button ToNDSCalcButton;
        private Button SideBarButton;
        private Button CloseSideBarButton;
        private Panel ControlPanel;
    }
}
