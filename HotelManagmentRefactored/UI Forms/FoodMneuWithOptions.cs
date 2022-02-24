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
    public partial class FoodMneuWithOptions : Form
    {
        public reservation reservationObj { get; set; }

        public FoodMneuWithOptions(reservation _reservationObj)
        {
            InitializeComponent();
            reservationObj = _reservationObj;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkIfNoEmptyTextBox())
            {
                reservationObj.break_fast = int.Parse(tbBreakfast.Text);
                reservationObj.dinner = int.Parse(tbDinner.Text);
                reservationObj.lunch = int.Parse(tbLunch.Text);

                reservationObj.cleaning = cbCleaning.Checked;
                reservationObj.towel = cbTowels.Checked;
                reservationObj.supply_status = cbSweSurp.Checked;

                reservationObj.food_bill =
                    reservationObj.break_fast * 7
                    + reservationObj.dinner * 15
                    + reservationObj.lunch * 15;

                reservationObj.total_bill = reservationObj.food_bill * 1.35;
            }
            else
            {
                MessageBox.Show("Please Fill All Data Required!");
                DialogResult = DialogResult.None;
            }
        }

        private void FoodMneuWithOptions_Load(object sender, EventArgs e) { }

        private bool checkIfNoEmptyTextBox()
        {
            return (
                !string.IsNullOrEmpty(tbLunch.Text)
                && !string.IsNullOrEmpty(tbDinner.Text)
                && !string.IsNullOrEmpty(tbBreakfast.Text)
            );
        }
    }
}
