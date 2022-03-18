using System;
using System.Windows.Forms;
/**************************************************************
 * File: RoomCharge.cs                                        *
 * Author: Yosef D. Figueroa Sánchez 841-17-9954              *
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas             *
 * Date: 02/27/2022                                           *
 * Purpose: This aplication calculates the room charge of the *
 * night. The total of the room and divides the fees between  *
 * room charge, service, telephone and miscellaneous.         *
 **************************************************************/
namespace Exercise3Exam1
{
    public partial class RoomChargeCalculatorForm : Form
    {
        public RoomChargeCalculatorForm()
        {
            InitializeComponent();
        }
        //Method that sets the date and time
        private void RoomChargeCalculatorForm_Load(object sender, EventArgs e)
        {
            lblCurrentDate.Text = DateTime.Now.ToLongDateString();
            lblCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }
        //Method that gets and calculates various prices and variables
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                int nights = Convert.ToInt16(txtNights.Text);
                decimal nightCharge = Convert.ToDecimal(txtNightCharge.Text);

                decimal service = Convert.ToDecimal(txtRoomService.Text);
                decimal phone = Convert.ToDecimal(txtTelephone.Text);
                decimal miscellaneous = Convert.ToDecimal(txtMiscellaneous.Text);

                decimal roomCharge = roomCharges(nights, nightCharge);
                decimal additionalCharge = additionalCharges(service, phone, miscellaneous);
                decimal subTotal = subtotal(roomCharge, additionalCharge);
                decimal tax = taxCharge(subTotal);
                decimal total = totalCharge(subTotal, tax);

                txtRoomCharges.Text = roomCharge.ToString("c");
                txtAdditionalCharges.Text = additionalCharge.ToString("c");
                txtSubtotal.Text = subTotal.ToString("c");
                txtTax.Text = tax.ToString("c");
                txtTotal.Text = total.ToString("c");

            }
        }
        //Exits the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region
        //Calculates the price per night for the stay
        private decimal roomCharges(int nights, decimal nightCharge)
        { decimal chargeTotal; return chargeTotal = nights * nightCharge; }
        //Calculates the additional charges like service, telephone and miscellaneous
        private decimal additionalCharges(decimal service, decimal phone, decimal miscellaneous)
        { decimal additionalCharge; return additionalCharge = service + phone + miscellaneous; }
        //Calculates the subtotal that is a sum of the charge of the room and the additional charge
        private decimal subtotal(decimal roomCharge, decimal additionalCharge)
        { decimal subTotal; return subTotal = roomCharge + additionalCharge; }
        //Calculates the tax that is 8% of the subtotal
        private decimal taxCharge(decimal subTotal)
        { decimal tax; return tax = subTotal * 0.08M; }
        //Calculate the total of the stay that is the subtotal with the tax
        private decimal totalCharge(decimal subtotal, decimal tax)
        { decimal total; return total = subtotal + tax; }

        #endregion
        private bool isValid()
        {
            return
                //Validates the number of days the guests will be staying
                IsPresent(txtNights, "How many night will they be staying?") &&
                IsInt32(txtNights, "You must enter a number of days:") &&
                IsWithinRange(txtNights, "Days you not be under 1 or above 30", 1, 30) &&
                //Validates the price per night for the stay
                IsPresent(txtNightCharge, "How much per night?") &&
                IsDecimal(txtNightCharge, "Number must be a decimal") &&
                IsWithinRange(txtNightCharge, "Number must be between $50 and $100", 50.0M, 100.0M) &&
                //Validates the service fee
                IsPresent(txtRoomService, "How much for room service?") &&
                IsDecimal(txtRoomService, "number must be a decimal") &&
                IsWithinRange(txtRoomService, "Price must be between $10 and $15", 10.0M, 15.0M) &&
                //Validates the telephone service fee
                IsPresent(txtTelephone, "How much for the telephone service?") &&
                IsDecimal(txtTelephone, "Number must be a decimal") &&
                IsWithinRange(txtTelephone, "Price must be between $5 and $7.50", 5.0M, 7.50M) &&
                //Validates the miscellaneous fee
                IsPresent(txtMiscellaneous, "How much for miscellaneous?") &&
                IsDecimal(txtMiscellaneous, "Number must be a decimal") &&
                IsWithinRange(txtMiscellaneous, "Price must be between $0 and $10", 0.0M, 10.0M);
        }
        #region
        /******************************
         * All the validation methods *
         ******************************/
        private bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == string.Empty)
            {
                MessageBox.Show(name + " is required.", "Entry Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }
        private bool IsInt32(TextBox textBox, string name)
        {
            if (!int.TryParse(textBox.Text, out _))
            {
                MessageBox.Show(name + " should be an integer.", "Entry Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
            return true;
        }
        private bool IsDecimal(TextBox textBox, string name)
        {
            if (!decimal.TryParse(textBox.Text, out _))
            {
                MessageBox.Show(name + " should be a decimal.", "Entry Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
            return true;
        }
        private bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal value = decimal.Parse(textBox.Text);
            if (value < min || value > max)
            {
                MessageBox.Show(name + " should be between " +
                    min + " and " + max + ".", "Entry Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
            return true;
        }
        #endregion
    }
}
