namespace Tip_TaxCalculator
{
    partial class TipAndTaxCalculatorForm
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
            CalculateButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            DollarAmountTextBox = new TextBox();
            AmountLabel = new Label();
            label2 = new Label();
            Tip15RadioButton = new RadioButton();
            Tip18RadioButton = new RadioButton();
            Tip20RadioButton = new RadioButton();
            TipAmountLabel = new Label();
            TipCustomRadioButton = new RadioButton();
            DiscountAAACheckBox = new CheckBox();
            DiscountDCCheckBox = new CheckBox();
            DiscountLabel = new Label();
            toolStrip1 = new ToolStrip();
            TipCustomTextBox = new TextBox();
            SuspendLayout();
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(440, 366);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(112, 72);
            CalculateButton.TabIndex = 0;
            CalculateButton.Text = "&Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(558, 366);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 72);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "C&lear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(676, 366);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 72);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DollarAmountTextBox
            // 
            DollarAmountTextBox.Location = new Point(147, 30);
            DollarAmountTextBox.Name = "DollarAmountTextBox";
            DollarAmountTextBox.Size = new Size(142, 31);
            DollarAmountTextBox.TabIndex = 3;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(12, 33);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(129, 25);
            AmountLabel.TabIndex = 4;
            AmountLabel.Text = "Dollar Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 33);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // Tip15RadioButton
            // 
            Tip15RadioButton.AutoSize = true;
            Tip15RadioButton.Location = new Point(148, 67);
            Tip15RadioButton.Name = "Tip15RadioButton";
            Tip15RadioButton.Size = new Size(72, 29);
            Tip15RadioButton.TabIndex = 6;
            Tip15RadioButton.TabStop = true;
            Tip15RadioButton.Text = "15%";
            Tip15RadioButton.UseVisualStyleBackColor = true;
            // 
            // Tip18RadioButton
            // 
            Tip18RadioButton.AutoSize = true;
            Tip18RadioButton.Location = new Point(148, 102);
            Tip18RadioButton.Name = "Tip18RadioButton";
            Tip18RadioButton.Size = new Size(72, 29);
            Tip18RadioButton.TabIndex = 7;
            Tip18RadioButton.TabStop = true;
            Tip18RadioButton.Text = "18%";
            Tip18RadioButton.UseVisualStyleBackColor = true;
            // 
            // Tip20RadioButton
            // 
            Tip20RadioButton.AutoSize = true;
            Tip20RadioButton.Location = new Point(148, 137);
            Tip20RadioButton.Name = "Tip20RadioButton";
            Tip20RadioButton.Size = new Size(72, 29);
            Tip20RadioButton.TabIndex = 8;
            Tip20RadioButton.TabStop = true;
            Tip20RadioButton.Text = "20%";
            Tip20RadioButton.UseVisualStyleBackColor = true;
            // 
            // TipAmountLabel
            // 
            TipAmountLabel.AutoSize = true;
            TipAmountLabel.Location = new Point(13, 69);
            TipAmountLabel.Name = "TipAmountLabel";
            TipAmountLabel.Size = new Size(106, 25);
            TipAmountLabel.TabIndex = 9;
            TipAmountLabel.Text = "Tip Amount";
            // 
            // TipCustomRadioButton
            // 
            TipCustomRadioButton.AutoSize = true;
            TipCustomRadioButton.Location = new Point(148, 172);
            TipCustomRadioButton.Name = "TipCustomRadioButton";
            TipCustomRadioButton.Size = new Size(99, 29);
            TipCustomRadioButton.TabIndex = 10;
            TipCustomRadioButton.TabStop = true;
            TipCustomRadioButton.Text = "Custom";
            TipCustomRadioButton.UseVisualStyleBackColor = true;
            // 
            // DiscountAAACheckBox
            // 
            DiscountAAACheckBox.AutoSize = true;
            DiscountAAACheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiscountAAACheckBox.Location = new Point(148, 207);
            DiscountAAACheckBox.Name = "DiscountAAACheckBox";
            DiscountAAACheckBox.Size = new Size(74, 29);
            DiscountAAACheckBox.TabIndex = 11;
            DiscountAAACheckBox.Text = "AAA";
            DiscountAAACheckBox.UseVisualStyleBackColor = true;
            // 
            // DiscountDCCheckBox
            // 
            DiscountDCCheckBox.AutoSize = true;
            DiscountDCCheckBox.Location = new Point(148, 242);
            DiscountDCCheckBox.Name = "DiscountDCCheckBox";
            DiscountDCCheckBox.Size = new Size(134, 29);
            DiscountDCCheckBox.TabIndex = 12;
            DiscountDCCheckBox.Text = "Diner's Card";
            DiscountDCCheckBox.UseVisualStyleBackColor = true;
            // 
            // DiscountLabel
            // 
            DiscountLabel.AutoSize = true;
            DiscountLabel.Location = new Point(13, 211);
            DiscountLabel.Name = "DiscountLabel";
            DiscountLabel.Size = new Size(82, 25);
            DiscountLabel.TabIndex = 13;
            DiscountLabel.Text = "Discount";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 14;
            toolStrip1.Text = "toolStrip1";
            // 
            // TipCustomTextBox
            // 
            TipCustomTextBox.Location = new Point(253, 170);
            TipCustomTextBox.Name = "TipCustomTextBox";
            TipCustomTextBox.Size = new Size(74, 31);
            TipCustomTextBox.TabIndex = 15;
            TipCustomTextBox.TabStop = false;
            // 
            // TipAndTaxCalculatorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TipCustomTextBox);
            Controls.Add(toolStrip1);
            Controls.Add(DiscountLabel);
            Controls.Add(DiscountDCCheckBox);
            Controls.Add(DiscountAAACheckBox);
            Controls.Add(TipCustomRadioButton);
            Controls.Add(TipAmountLabel);
            Controls.Add(Tip20RadioButton);
            Controls.Add(Tip18RadioButton);
            Controls.Add(Tip15RadioButton);
            Controls.Add(label2);
            Controls.Add(AmountLabel);
            Controls.Add(DollarAmountTextBox);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(CalculateButton);
            MaximizeBox = false;
            Name = "TipAndTaxCalculatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalculateButton;
        private Button ClearButton;
        private Button ExitButton;
        private TextBox DollarAmountTextBox;
        private Label AmountLabel;
        private Label label2;
        private RadioButton Tip15RadioButton;
        private RadioButton Tip18RadioButton;
        private RadioButton Tip20RadioButton;
        private Label TipAmountLabel;
        private RadioButton TipCustomRadioButton;
        private CheckBox DiscountAAACheckBox;
        private CheckBox DiscountDCCheckBox;
        private Label DiscountLabel;
        private ToolStrip toolStrip1;
        private TextBox TipCustomTextBox;
    }
}
