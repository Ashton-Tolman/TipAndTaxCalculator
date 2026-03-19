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
            TipCustomTextBox.Text = "";
            TipCustomRadioButton.Checked = false;
            DiscountAAACheckBox.Checked = false;
            DiscountDCCheckBox.Checked = false;
            DisplayLabel.Text = "";
            DollarAmountTextBox.Select();
        }

        bool AllValidateFields()
        {
            bool _valid = true;
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
            try
            {
                decimal.Parse(TipCustomTextBox.Text);
                TipCustomTextBox.BackColor = Color.White;
            }
            catch
            {
                TipCustomTextBox.BackColor= Color.LightYellow;
                _valid= false;
            }
            return _valid;
        }
        /// <summary>
        /// Calculate tip amount based on specified subtotal and selected tip percent 
        /// </summary>
        /// <param name="thisAmount">The subtotal amount that is used to calculated percent</param>
        /// <returns>only the tip percent not including the passed in amount</returns>
        decimal CalculateTipOn(decimal thisAmount)
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
                    subTotal = thisAmount * 0.15m;
                    break;
                default:
                    MessageBox.Show("YOU FOOL. WHAT HAVE YOU DONE?! YOU'VE DESTROYED US ALL!!!");
                    break;
            }

            return subTotal;
        }

        //EventHandlers below--------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }
    }
}
