namespace Tyuiu.YaroslavtsevMG.Lab4
{
    partial class ConversionCalcControl
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
            BackGroundPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            FromTable = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            FromComboBox = new ComboBox();
            FromLabel = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            FromTextBox = new TextBox();
            nameLabel = new Label();
            ToTable = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ToComboBox = new ComboBox();
            ToLabel = new Label();
            ResultLabel = new Label();
            ResultTable = new TableLayoutPanel();
            ConversionButton = new Button();
            BackGroundPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            FromTable.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ToTable.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ResultTable.SuspendLayout();
            SuspendLayout();
            // 
            // BackGroundPanel
            // 
            BackGroundPanel.BackColor = SystemColors.ControlDarkDark;
            BackGroundPanel.Controls.Add(tableLayoutPanel1);
            BackGroundPanel.Dock = DockStyle.Fill;
            BackGroundPanel.Location = new Point(0, 0);
            BackGroundPanel.Name = "BackGroundPanel";
            BackGroundPanel.Size = new Size(1258, 683);
            BackGroundPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(FromTable, 0, 0);
            tableLayoutPanel1.Controls.Add(ToTable, 0, 1);
            tableLayoutPanel1.Controls.Add(ResultTable, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1258, 683);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // FromTable
            // 
            FromTable.ColumnCount = 2;
            FromTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            FromTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            FromTable.Controls.Add(tableLayoutPanel2, 1, 0);
            FromTable.Controls.Add(tableLayoutPanel4, 0, 0);
            FromTable.Dock = DockStyle.Fill;
            FromTable.Location = new Point(3, 3);
            FromTable.Name = "FromTable";
            FromTable.RowCount = 1;
            FromTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            FromTable.Size = new Size(1252, 221);
            FromTable.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(FromComboBox, 0, 1);
            tableLayoutPanel2.Controls.Add(FromLabel, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(629, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(620, 215);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // FromComboBox
            // 
            FromComboBox.Dock = DockStyle.Left;
            FromComboBox.Font = new Font("Segoe UI", 26.25F);
            FromComboBox.FormattingEnabled = true;
            FromComboBox.Location = new Point(3, 110);
            FromComboBox.Name = "FromComboBox";
            FromComboBox.Size = new Size(121, 55);
            FromComboBox.TabIndex = 0;
            // 
            // FromLabel
            // 
            FromLabel.AutoSize = true;
            FromLabel.Dock = DockStyle.Fill;
            FromLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FromLabel.ForeColor = SystemColors.ControlLightLight;
            FromLabel.Location = new Point(3, 0);
            FromLabel.Name = "FromLabel";
            FromLabel.Size = new Size(614, 107);
            FromLabel.TabIndex = 2;
            FromLabel.Text = "Изначальная единица измерения";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(FromTextBox, 0, 1);
            tableLayoutPanel4.Controls.Add(nameLabel, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(620, 215);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // FromTextBox
            // 
            FromTextBox.Dock = DockStyle.Fill;
            FromTextBox.Font = new Font("Segoe UI", 26.25F);
            FromTextBox.Location = new Point(3, 110);
            FromTextBox.Name = "FromTextBox";
            FromTextBox.Size = new Size(614, 54);
            FromTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Dock = DockStyle.Fill;
            nameLabel.Font = new Font("Segoe UI", 15.75F);
            nameLabel.ForeColor = SystemColors.ControlLightLight;
            nameLabel.Location = new Point(3, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(614, 107);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Величина";
            // 
            // ToTable
            // 
            ToTable.ColumnCount = 2;
            ToTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ToTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ToTable.Controls.Add(tableLayoutPanel3, 1, 0);
            ToTable.Controls.Add(ResultLabel, 0, 0);
            ToTable.Dock = DockStyle.Fill;
            ToTable.Location = new Point(3, 230);
            ToTable.Name = "ToTable";
            ToTable.RowCount = 1;
            ToTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ToTable.Size = new Size(1252, 221);
            ToTable.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(ToComboBox, 0, 1);
            tableLayoutPanel3.Controls.Add(ToLabel, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(629, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(620, 215);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // ToComboBox
            // 
            ToComboBox.Dock = DockStyle.Left;
            ToComboBox.Font = new Font("Segoe UI", 26.25F);
            ToComboBox.FormattingEnabled = true;
            ToComboBox.Location = new Point(3, 110);
            ToComboBox.Name = "ToComboBox";
            ToComboBox.Size = new Size(121, 55);
            ToComboBox.TabIndex = 0;
            // 
            // ToLabel
            // 
            ToLabel.AutoSize = true;
            ToLabel.Dock = DockStyle.Fill;
            ToLabel.Font = new Font("Segoe UI", 15.75F);
            ToLabel.ForeColor = SystemColors.ControlLightLight;
            ToLabel.Location = new Point(3, 0);
            ToLabel.Name = "ToLabel";
            ToLabel.Size = new Size(614, 107);
            ToLabel.TabIndex = 1;
            ToLabel.Text = "Новая единица измерения";
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Dock = DockStyle.Fill;
            ResultLabel.Font = new Font("Segoe UI", 15.75F);
            ResultLabel.ForeColor = SystemColors.ControlLightLight;
            ResultLabel.Location = new Point(3, 0);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(620, 221);
            ResultLabel.TabIndex = 2;
            ResultLabel.Text = "Значение в другой единице измерения";
            // 
            // ResultTable
            // 
            ResultTable.ColumnCount = 2;
            ResultTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ResultTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ResultTable.Controls.Add(ConversionButton, 1, 0);
            ResultTable.Dock = DockStyle.Fill;
            ResultTable.Location = new Point(3, 457);
            ResultTable.Name = "ResultTable";
            ResultTable.RowCount = 1;
            ResultTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ResultTable.Size = new Size(1252, 223);
            ResultTable.TabIndex = 2;
            // 
            // ConversionButton
            // 
            ConversionButton.Dock = DockStyle.Fill;
            ConversionButton.Font = new Font("Segoe UI", 26.25F);
            ConversionButton.Location = new Point(629, 3);
            ConversionButton.Name = "ConversionButton";
            ConversionButton.Size = new Size(620, 217);
            ConversionButton.TabIndex = 0;
            ConversionButton.Text = "Конвертировать";
            ConversionButton.UseVisualStyleBackColor = true;
            ConversionButton.Click += ConversionButton_Click;
            // 
            // ConversionCalcControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BackGroundPanel);
            Name = "ConversionCalcControl";
            Size = new Size(1258, 683);
            BackGroundPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            FromTable.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ToTable.ResumeLayout(false);
            ToTable.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResultTable.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel BackGroundPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel FromTable;
        private TableLayoutPanel ToTable;
        private TableLayoutPanel ResultTable;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox FromComboBox;
        private Label FromLabel;
        private TextBox FromTextBox;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox ToComboBox;
        private Label ToLabel;
        private Label ResultLabel;
        private Button ConversionButton;
        private TableLayoutPanel tableLayoutPanel4;
        private Label nameLabel;
    }
}
