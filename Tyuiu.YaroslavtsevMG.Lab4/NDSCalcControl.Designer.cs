namespace Tyuiu.YaroslavtsevMG.Lab4
{
    partial class NDSCalcControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            BackGrounPanel = new Panel();
            SeporatorPanel = new TableLayoutPanel();
            SecondFormulaPanel = new TableLayoutPanel();
            SecondFormulaSecondPanel = new TableLayoutPanel();
            NDSLabel2 = new Label();
            SecondFormulaSecondTextBox = new TextBox();
            SecondFormulaFirstPanel = new TableLayoutPanel();
            SummaNDSLabel = new Label();
            SecondFormulaFirstTextBox = new TextBox();
            SecondFormulaButton = new Button();
            ResultSummaNDSLabel = new Label();
            SummaWithNDSLabel = new Label();
            FirstFormulaPanel = new TableLayoutPanel();
            FirstFormulaButton = new Button();
            FirstFormulaFirstPanel = new TableLayoutPanel();
            SummaLabel = new Label();
            FirstFormulaFirstTextBox = new TextBox();
            FirstFormulaSecondPanel = new TableLayoutPanel();
            NDSLabel = new Label();
            FirstFormulaSecondTextBox = new TextBox();
            ResultNDSLabel = new Label();
            SummaWithoutNDSLabel = new Label();
            BackGrounPanel.SuspendLayout();
            SeporatorPanel.SuspendLayout();
            SecondFormulaPanel.SuspendLayout();
            SecondFormulaSecondPanel.SuspendLayout();
            SecondFormulaFirstPanel.SuspendLayout();
            FirstFormulaPanel.SuspendLayout();
            FirstFormulaFirstPanel.SuspendLayout();
            FirstFormulaSecondPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BackGrounPanel
            // 
            BackGrounPanel.BackColor = SystemColors.ControlDarkDark;
            BackGrounPanel.Controls.Add(SeporatorPanel);
            BackGrounPanel.Dock = DockStyle.Fill;
            BackGrounPanel.Location = new Point(0, 0);
            BackGrounPanel.Name = "BackGrounPanel";
            BackGrounPanel.Size = new Size(1226, 680);
            BackGrounPanel.TabIndex = 0;
            // 
            // SeporatorPanel
            // 
            SeporatorPanel.ColumnCount = 2;
            SeporatorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SeporatorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SeporatorPanel.Controls.Add(SecondFormulaPanel, 1, 0);
            SeporatorPanel.Controls.Add(FirstFormulaPanel, 0, 0);
            SeporatorPanel.Dock = DockStyle.Fill;
            SeporatorPanel.Location = new Point(0, 0);
            SeporatorPanel.Name = "SeporatorPanel";
            SeporatorPanel.RowCount = 1;
            SeporatorPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            SeporatorPanel.Size = new Size(1226, 680);
            SeporatorPanel.TabIndex = 0;
            // 
            // SecondFormulaPanel
            // 
            SecondFormulaPanel.ColumnCount = 1;
            SecondFormulaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            SecondFormulaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            SecondFormulaPanel.Controls.Add(SecondFormulaSecondPanel, 0, 1);
            SecondFormulaPanel.Controls.Add(SecondFormulaFirstPanel, 0, 0);
            SecondFormulaPanel.Controls.Add(SecondFormulaButton, 0, 2);
            SecondFormulaPanel.Controls.Add(ResultSummaNDSLabel, 0, 3);
            SecondFormulaPanel.Controls.Add(SummaWithNDSLabel, 0, 4);
            SecondFormulaPanel.Dock = DockStyle.Fill;
            SecondFormulaPanel.Location = new Point(616, 3);
            SecondFormulaPanel.Name = "SecondFormulaPanel";
            SecondFormulaPanel.RowCount = 5;
            SecondFormulaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            SecondFormulaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            SecondFormulaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            SecondFormulaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            SecondFormulaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            SecondFormulaPanel.Size = new Size(607, 674);
            SecondFormulaPanel.TabIndex = 1;
            // 
            // SecondFormulaSecondPanel
            // 
            SecondFormulaSecondPanel.ColumnCount = 2;
            SecondFormulaSecondPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SecondFormulaSecondPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SecondFormulaSecondPanel.Controls.Add(NDSLabel2, 0, 0);
            SecondFormulaSecondPanel.Controls.Add(SecondFormulaSecondTextBox, 1, 0);
            SecondFormulaSecondPanel.Dock = DockStyle.Fill;
            SecondFormulaSecondPanel.Location = new Point(3, 137);
            SecondFormulaSecondPanel.Name = "SecondFormulaSecondPanel";
            SecondFormulaSecondPanel.RowCount = 1;
            SecondFormulaSecondPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            SecondFormulaSecondPanel.Size = new Size(601, 128);
            SecondFormulaSecondPanel.TabIndex = 4;
            // 
            // NDSLabel2
            // 
            NDSLabel2.AutoSize = true;
            NDSLabel2.Dock = DockStyle.Fill;
            NDSLabel2.ForeColor = SystemColors.ControlLightLight;
            NDSLabel2.Location = new Point(3, 0);
            NDSLabel2.Name = "NDSLabel2";
            NDSLabel2.Size = new Size(294, 128);
            NDSLabel2.TabIndex = 0;
            NDSLabel2.Text = "Процентная ставка НДС";
            NDSLabel2.TextAlign = ContentAlignment.TopRight;
            // 
            // SecondFormulaSecondTextBox
            // 
            SecondFormulaSecondTextBox.Dock = DockStyle.Fill;
            SecondFormulaSecondTextBox.Location = new Point(303, 3);
            SecondFormulaSecondTextBox.Name = "SecondFormulaSecondTextBox";
            SecondFormulaSecondTextBox.Size = new Size(295, 23);
            SecondFormulaSecondTextBox.TabIndex = 1;
            // 
            // SecondFormulaFirstPanel
            // 
            SecondFormulaFirstPanel.ColumnCount = 2;
            SecondFormulaFirstPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SecondFormulaFirstPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SecondFormulaFirstPanel.Controls.Add(SummaNDSLabel, 0, 0);
            SecondFormulaFirstPanel.Controls.Add(SecondFormulaFirstTextBox, 1, 0);
            SecondFormulaFirstPanel.Dock = DockStyle.Fill;
            SecondFormulaFirstPanel.Location = new Point(3, 3);
            SecondFormulaFirstPanel.Name = "SecondFormulaFirstPanel";
            SecondFormulaFirstPanel.RowCount = 1;
            SecondFormulaFirstPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            SecondFormulaFirstPanel.Size = new Size(601, 128);
            SecondFormulaFirstPanel.TabIndex = 3;
            // 
            // SummaNDSLabel
            // 
            SummaNDSLabel.AutoSize = true;
            SummaNDSLabel.Dock = DockStyle.Fill;
            SummaNDSLabel.ForeColor = SystemColors.ControlLightLight;
            SummaNDSLabel.Location = new Point(3, 0);
            SummaNDSLabel.Name = "SummaNDSLabel";
            SummaNDSLabel.Size = new Size(294, 128);
            SummaNDSLabel.TabIndex = 0;
            SummaNDSLabel.Text = "Сумма продукта без НДС";
            SummaNDSLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // SecondFormulaFirstTextBox
            // 
            SecondFormulaFirstTextBox.Dock = DockStyle.Fill;
            SecondFormulaFirstTextBox.Location = new Point(303, 3);
            SecondFormulaFirstTextBox.Name = "SecondFormulaFirstTextBox";
            SecondFormulaFirstTextBox.Size = new Size(295, 23);
            SecondFormulaFirstTextBox.TabIndex = 1;
            // 
            // SecondFormulaButton
            // 
            SecondFormulaButton.Dock = DockStyle.Fill;
            SecondFormulaButton.Location = new Point(3, 271);
            SecondFormulaButton.Name = "SecondFormulaButton";
            SecondFormulaButton.Size = new Size(601, 128);
            SecondFormulaButton.TabIndex = 0;
            SecondFormulaButton.Text = "Рассчитать второй вариант\r\n";
            SecondFormulaButton.UseVisualStyleBackColor = true;
            SecondFormulaButton.Click += SecondFormulaButton_Click;
            // 
            // ResultSummaNDSLabel
            // 
            ResultSummaNDSLabel.AutoSize = true;
            ResultSummaNDSLabel.Dock = DockStyle.Fill;
            ResultSummaNDSLabel.Location = new Point(3, 402);
            ResultSummaNDSLabel.Name = "ResultSummaNDSLabel";
            ResultSummaNDSLabel.Size = new Size(601, 134);
            ResultSummaNDSLabel.TabIndex = 5;
            ResultSummaNDSLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SummaWithNDSLabel
            // 
            SummaWithNDSLabel.AutoSize = true;
            SummaWithNDSLabel.Dock = DockStyle.Fill;
            SummaWithNDSLabel.Location = new Point(3, 536);
            SummaWithNDSLabel.Name = "SummaWithNDSLabel";
            SummaWithNDSLabel.Size = new Size(601, 138);
            SummaWithNDSLabel.TabIndex = 6;
            SummaWithNDSLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FirstFormulaPanel
            // 
            FirstFormulaPanel.ColumnCount = 1;
            FirstFormulaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            FirstFormulaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            FirstFormulaPanel.Controls.Add(FirstFormulaButton, 0, 2);
            FirstFormulaPanel.Controls.Add(FirstFormulaFirstPanel, 0, 0);
            FirstFormulaPanel.Controls.Add(FirstFormulaSecondPanel, 0, 1);
            FirstFormulaPanel.Controls.Add(ResultNDSLabel, 0, 3);
            FirstFormulaPanel.Controls.Add(SummaWithoutNDSLabel, 0, 4);
            FirstFormulaPanel.Dock = DockStyle.Fill;
            FirstFormulaPanel.Location = new Point(3, 3);
            FirstFormulaPanel.Name = "FirstFormulaPanel";
            FirstFormulaPanel.RowCount = 5;
            FirstFormulaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            FirstFormulaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            FirstFormulaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            FirstFormulaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            FirstFormulaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            FirstFormulaPanel.Size = new Size(607, 674);
            FirstFormulaPanel.TabIndex = 0;
            // 
            // FirstFormulaButton
            // 
            FirstFormulaButton.Dock = DockStyle.Fill;
            FirstFormulaButton.Location = new Point(3, 271);
            FirstFormulaButton.Name = "FirstFormulaButton";
            FirstFormulaButton.Size = new Size(601, 128);
            FirstFormulaButton.TabIndex = 0;
            FirstFormulaButton.Text = "Рассчитать первый вариант";
            FirstFormulaButton.UseVisualStyleBackColor = true;
            FirstFormulaButton.Click += FirstFormulaButton_Click;
            // 
            // FirstFormulaFirstPanel
            // 
            FirstFormulaFirstPanel.ColumnCount = 2;
            FirstFormulaFirstPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            FirstFormulaFirstPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            FirstFormulaFirstPanel.Controls.Add(SummaLabel, 0, 0);
            FirstFormulaFirstPanel.Controls.Add(FirstFormulaFirstTextBox, 1, 0);
            FirstFormulaFirstPanel.Dock = DockStyle.Fill;
            FirstFormulaFirstPanel.Location = new Point(3, 3);
            FirstFormulaFirstPanel.Name = "FirstFormulaFirstPanel";
            FirstFormulaFirstPanel.RowCount = 1;
            FirstFormulaFirstPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            FirstFormulaFirstPanel.Size = new Size(601, 128);
            FirstFormulaFirstPanel.TabIndex = 1;
            // 
            // SummaLabel
            // 
            SummaLabel.AutoSize = true;
            SummaLabel.Dock = DockStyle.Fill;
            SummaLabel.ForeColor = SystemColors.ControlLightLight;
            SummaLabel.Location = new Point(3, 0);
            SummaLabel.Name = "SummaLabel";
            SummaLabel.Size = new Size(294, 128);
            SummaLabel.TabIndex = 0;
            SummaLabel.Text = "Сумма с НДС";
            SummaLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // FirstFormulaFirstTextBox
            // 
            FirstFormulaFirstTextBox.Dock = DockStyle.Fill;
            FirstFormulaFirstTextBox.Location = new Point(303, 3);
            FirstFormulaFirstTextBox.Name = "FirstFormulaFirstTextBox";
            FirstFormulaFirstTextBox.Size = new Size(295, 23);
            FirstFormulaFirstTextBox.TabIndex = 1;
            // 
            // FirstFormulaSecondPanel
            // 
            FirstFormulaSecondPanel.ColumnCount = 2;
            FirstFormulaSecondPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            FirstFormulaSecondPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            FirstFormulaSecondPanel.Controls.Add(NDSLabel, 0, 0);
            FirstFormulaSecondPanel.Controls.Add(FirstFormulaSecondTextBox, 1, 0);
            FirstFormulaSecondPanel.Dock = DockStyle.Fill;
            FirstFormulaSecondPanel.Location = new Point(3, 137);
            FirstFormulaSecondPanel.Name = "FirstFormulaSecondPanel";
            FirstFormulaSecondPanel.RowCount = 1;
            FirstFormulaSecondPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            FirstFormulaSecondPanel.Size = new Size(601, 128);
            FirstFormulaSecondPanel.TabIndex = 2;
            // 
            // NDSLabel
            // 
            NDSLabel.AutoSize = true;
            NDSLabel.Dock = DockStyle.Fill;
            NDSLabel.ForeColor = SystemColors.ControlLightLight;
            NDSLabel.Location = new Point(3, 0);
            NDSLabel.Name = "NDSLabel";
            NDSLabel.Size = new Size(294, 128);
            NDSLabel.TabIndex = 0;
            NDSLabel.Text = "Процентная ставка НДС";
            NDSLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // FirstFormulaSecondTextBox
            // 
            FirstFormulaSecondTextBox.Dock = DockStyle.Fill;
            FirstFormulaSecondTextBox.Location = new Point(303, 3);
            FirstFormulaSecondTextBox.Name = "FirstFormulaSecondTextBox";
            FirstFormulaSecondTextBox.Size = new Size(295, 23);
            FirstFormulaSecondTextBox.TabIndex = 1;
            // 
            // ResultNDSLabel
            // 
            ResultNDSLabel.AutoSize = true;
            ResultNDSLabel.Dock = DockStyle.Fill;
            ResultNDSLabel.Location = new Point(3, 402);
            ResultNDSLabel.Name = "ResultNDSLabel";
            ResultNDSLabel.Size = new Size(601, 134);
            ResultNDSLabel.TabIndex = 3;
            ResultNDSLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SummaWithoutNDSLabel
            // 
            SummaWithoutNDSLabel.AutoSize = true;
            SummaWithoutNDSLabel.Dock = DockStyle.Fill;
            SummaWithoutNDSLabel.Location = new Point(3, 536);
            SummaWithoutNDSLabel.Name = "SummaWithoutNDSLabel";
            SummaWithoutNDSLabel.Size = new Size(601, 138);
            SummaWithoutNDSLabel.TabIndex = 4;
            SummaWithoutNDSLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NDSCalcControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BackGrounPanel);
            Name = "NDSCalcControl";
            Size = new Size(1226, 680);
            BackGrounPanel.ResumeLayout(false);
            SeporatorPanel.ResumeLayout(false);
            SecondFormulaPanel.ResumeLayout(false);
            SecondFormulaPanel.PerformLayout();
            SecondFormulaSecondPanel.ResumeLayout(false);
            SecondFormulaSecondPanel.PerformLayout();
            SecondFormulaFirstPanel.ResumeLayout(false);
            SecondFormulaFirstPanel.PerformLayout();
            FirstFormulaPanel.ResumeLayout(false);
            FirstFormulaPanel.PerformLayout();
            FirstFormulaFirstPanel.ResumeLayout(false);
            FirstFormulaFirstPanel.PerformLayout();
            FirstFormulaSecondPanel.ResumeLayout(false);
            FirstFormulaSecondPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel BackGrounPanel;
        private TableLayoutPanel SeporatorPanel;
        private TableLayoutPanel SecondFormulaPanel;
        private TableLayoutPanel FirstFormulaPanel;
        private Button SecondFormulaButton;
        private Button FirstFormulaButton;
        private TableLayoutPanel SecondFormulaSecondPanel;
        private Label NDSLabel2;
        private TableLayoutPanel SecondFormulaFirstPanel;
        private Label SummaNDSLabel;
        private TableLayoutPanel FirstFormulaFirstPanel;
        private Label SummaLabel;
        private TableLayoutPanel FirstFormulaSecondPanel;
        private Label NDSLabel;
        private TextBox SecondFormulaSecondTextBox;
        private TextBox SecondFormulaFirstTextBox;
        private TextBox FirstFormulaFirstTextBox;
        private TextBox FirstFormulaSecondTextBox;
        private Label ResultSummaNDSLabel;
        private Label SummaWithNDSLabel;
        private Label ResultNDSLabel;
        private Label SummaWithoutNDSLabel;
    }
}
