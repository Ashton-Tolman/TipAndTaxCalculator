namespace Tip_TaxCalculator
{
    public partial class TipAndTaxCalculatorForm : Form
    {
        public TipAndTaxCalculatorForm()
        {
            InitializeComponent();
            SetDefaults();
        }


        //Custom Methods-------------------------------------------------------

        void SetDefaults()
        {
            DollarAmountTextBox.Text = "";
            Tip15RadioButton.Checked = true;
            TipCustomTextBox.Text = "0";
            TipCustomTextBox.Enabled = false;
            TipCustomRadioButton.Checked = false;
            DiscountAAACheckBox.Checked = false;
            DiscountDCCheckBox.Checked = false;
            DisplayLabel.Text = "";
            AllFieldsValid();
            DollarAmountTextBox.Select();
        }

        bool AllFieldsValid()
        {
            bool _valid = true;
            
            //Validate dollar amount 
            try
            {
                decimal.Parse(DollarAmountTextBox.Text);
                DollarAmountTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                DollarAmountTextBox.BackColor = Color.LightYellow;
                _valid = false;
            }

            //Validate custom tip amount 
            try
            {
                decimal.Parse(TipCustomTextBox.Text);
                TipCustomTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                TipCustomTextBox.BackColor = Color.LightYellow;
                _valid = false;
            }
            return _valid;
        }

        /// <summary>
        /// Calculates discounts
        /// </summary>
        /// <param name="thisAmount">Discount calculated with this param</param>
        /// <returns></returns>
        decimal CalculateAAADiscountOn(decimal thisAmount)
        {
            return thisAmount * 0.03m;
        }

        decimal CalculateDinersCardDiscountOn(decimal thisAmount)
        {
            return thisAmount * 0.05m;
        }

        /// <summary>
        /// Does tax stuff
        /// </summary>
        /// <param name="thisAmount">pass in a number you want idaho tax on</param>
        /// <returns></returns>
        decimal CalculateTaxOn(decimal thisAmount)
        {

            return thisAmount * 0.06m;
        }
        /// <summary>
        /// Calculate tip amount based on specified subtotal and selected tip percent 
        /// </summary>
        /// <param name="thisAmount">The subtotal amount that is used to calculated percent</param>
        /// <returns>only the tip percent not including the passed in amount</returns>
        decimal CalculateTipOn(decimal thisAmount , decimal customTip = 0)
        {
            decimal subTotal = 0.00m;

            switch (true)
            {
                case bool when Tip15RadioButton.Checked:
                    subTotal = thisAmount * 0.15m;
                    break;
                case bool when Tip18RadioButton.Checked:
                    subTotal = thisAmount * 0.18m;
                    break;
                case bool when Tip20RadioButton.Checked:
                    subTotal = thisAmount * 0.20m;
                    break;
                case bool when TipCustomRadioButton.Checked:
                    subTotal = customTip;
                    break;
                default:
                    MessageBox.Show("YOU FOOL. WHAT HAVE YOU DONE?! YOU'VE DESTROYED US ALL!!!");
                    break;
            }

            return subTotal;
        }

        void DisplayTransaction()
        {
            decimal originalAmount = 0;
            decimal totalDiscount = 0;
            decimal tax = 0;
            decimal tip = 0;
            decimal amountDue = 0;
            if (AllFieldsValid())
            {
                originalAmount = decimal.Parse(DollarAmountTextBox.Text);
                totalDiscount += CalculateAAADiscountOn(originalAmount);
                totalDiscount = totalDiscount + CalculateDinersCardDiscountOn(originalAmount);
                tax = CalculateTaxOn(originalAmount - totalDiscount);
                tip = CalculateTipOn(originalAmount - totalDiscount + tax);
                amountDue = originalAmount - totalDiscount + tax + tip;
                DisplayLabel.Text = $"Amount Given:{originalAmount:C}\n" + //:C transfers format of strings to be displayed as your computers
                                    $"Discount:    {totalDiscount:C}\n" +      //default monetary system i.e. american dollars                                                                                        
                                    $"Sales Tax:   {tax:C}\n" +               //Could also be expressed as .ToString("C")
                                    $"Subtotal:   \n" +
                                    $"Total Tip:   {tip:C}\n" +
                                    $"Amount Due:  {amountDue:C}";
            }
        }

        //EventHandlers below--------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            DisplayTransaction();
        }
        

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void DollarAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            AllFieldsValid();
        }

        private void TipCustomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TipCustomRadioButton.Checked)
            {
                TipCustomTextBox.Enabled = true;
            }
            else
            {
                TipCustomTextBox.Enabled = false;
                TipCustomTextBox.Text = "";
            }
        }

        private void TipCustomTextBox_TextChanged(object sender, EventArgs e)
        {
            AllFieldsValid();
        }
    }
}
