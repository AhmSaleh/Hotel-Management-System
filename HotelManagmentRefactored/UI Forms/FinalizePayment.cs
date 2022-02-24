using HotelManagmentRefactored.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagmentRefactored.UI_Forms
{
    public partial class FinalizePayment : Form
    {
        reservation reservationObj;

        public FinalizePayment(reservation _reservationObj)
        {
            InitializeComponent();
            reservationObj = _reservationObj;
            textTotal.Text = reservationObj.total_bill.ToString();
            txtFoodBill.Text = reservationObj.food_bill.ToString();
            textTax.Text = (reservationObj.total_bill / 1.35 * .35).ToString("#.##");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkIfNoEmptyTextBox())
            {
                reservationObj.payment_type = cbPaymentType.Text;
                reservationObj.card_type = tbCardType.Text;
                reservationObj.card_number = cbPaymentType.Text;
                reservationObj.card_exp = $"{cbMM.Text}/{cbMM.Text}";
                reservationObj.card_cvc = tbCVC.Text;
            }
            else
            {
                MessageBox.Show("Please Fill All Data Required!");
                DialogResult = DialogResult.None;
            }
        }

        private bool checkIfNoEmptyTextBox()
        {
            return (
                !string.IsNullOrEmpty(cbPaymentType.Text)
                && !string.IsNullOrEmpty(tbCardNumbeer.Text)
                && !string.IsNullOrEmpty(cbMM.Text)
                && !string.IsNullOrEmpty(cbYY.Text)
                && !string.IsNullOrEmpty(tbCVC.Text)
                && !string.IsNullOrEmpty(tbCardType.Text)
            );
        }

        private void cbPaymentType_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
