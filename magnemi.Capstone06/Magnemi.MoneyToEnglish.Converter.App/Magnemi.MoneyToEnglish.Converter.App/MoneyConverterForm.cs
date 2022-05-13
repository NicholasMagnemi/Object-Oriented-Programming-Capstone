using System;
using System.Drawing;
using System.Windows.Forms;

namespace Magnemi.MoneyToEnglish.Converter.App
{
    public partial class frmMoneyConverterForm : Form
    {
        public frmMoneyConverterForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumberInput.Text = String.Empty;
            lbl_convertedNumberDisplay.Text = "Your number when converted will display here.";
        }

        public void createANewNumber(String theNumber, String currencyType)
        {
            MoneyToEnglish newNumber = new MoneyToEnglish(theNumber, currencyType);

            if (newNumber.get_convertedNumber().Length == 0 || newNumber.get_convertedNumber() == "dollars")
            {
                lbl_convertedNumberDisplay.Text = newNumber.invalidInputDisplay();
            }
            else
            {
                lbl_convertedNumberDisplay.Text = newNumber.get_convertedNumber();
            }
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnConvertNumber_MouseHover(object sender, EventArgs e)
        {
            btnConvertNumber.BackColor = Color.LightSlateGray;
        }

        private void btnConvertNumber_MouseLeave(object sender, EventArgs e)
        {
            btnConvertNumber.BackColor = Color.LightGray;
        }

        private void btnClearInput_MouseHover(object sender, EventArgs e)
        {
            btnClearInput.BackColor = Color.LightSlateGray;
        }

        private void btnClearInput_MouseLeave(object sender, EventArgs e)
        {
            btnClearInput.BackColor = Color.LightGray;
        }

        private void btnExitApplication_MouseHover(object sender, EventArgs e)
        {
            btnExitApplication.BackColor = Color.LightSlateGray;
        }

        private void btnExitApplication_MouseLeave(object sender, EventArgs e)
        {
            btnExitApplication.BackColor = Color.LightGray;
        }

        private void btnConvertNumber_Click(object sender, EventArgs e)
        {
            createANewNumber(txtNumberInput.Text, "dollars");
        }

        private void txtNumberInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '$' || e.KeyChar == '\b' || e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else if (restrictNumbersAfterDecimal())
            {
                e.Handled = true;
            }
            else if (e.KeyChar > '9' || e.KeyChar < '0')
            {
                e.Handled = true;
            }

            if (txtNumberInput.Text.Length > 16)
            {
                e.Handled = true;
            }
        }

        public bool restrictNumbersAfterDecimal()
        {
            if (txtNumberInput.Text.Contains('.'))
            {
                if ((txtNumberInput.Text.Substring(txtNumberInput.Text.LastIndexOf('.')).Length >= 3))
                    return true;
            }
            return false;
        }

        private void lbl_convertedNumberDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
