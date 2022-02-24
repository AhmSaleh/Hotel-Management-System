using HotelManagmentRefactored.Context;
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
    public partial class Frontend : Form
    {
        FrontendReservationRef context;
        BindingSource bSource;
        reservation reservationObj;

        public Frontend()
        {
            InitializeComponent();

            context = new();
            bSource = new();
            reservationObj = new();

            loadGridview();
            loadListboxes();
            loadReservations();
        }

        void loadGridview()
        {
            gridViewResTotal.DataSource = (from i in context?.reservations select i).ToList();
        }

        private void loadListboxes()
        {
            roomOccupiedListBox.DataSource = (
                from i in context?.reservations
                where i.check_in == true
                select new
                {
                    Display = $"[{i.room_number.ToString().Trim()}]    {i.room_type}     {i.ID}       [{i.first_name} {i.last_name}]      {i.phone_number}"
                }
            ).ToList();
            roomOccupiedListBox.DisplayMember = "Display";

            roomReservedListBox.DataSource = (
                from i in context?.reservations
                where i.check_in == false
                select new
                {
                    Display = $"[{i.room_number.ToString().Trim()}]    {i.room_type}     {i.ID}       [{i.last_name} {i.last_name}]      {i.phone_number}   {i.arrival_time.ToString("MM-dd-yyy")}   {i.leaving_time.ToString("MM-dd-yyy")}"
                }
            ).ToList();
            roomReservedListBox.DisplayMember = "Display";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id;
            dataGridViewSearchResults.DataSource = (
                from i in context?.reservations
                where
                    i.ID == (int.TryParse(tbSearch.Text, out id) ? id : 0)
                    || i.first_name.Contains(tbSearch.Text)
                    || i.last_name.Contains(tbSearch.Text)
                    || i.gender.Contains(tbSearch.Text)
                    || i.state.Contains(tbSearch.Text)
                    || i.city.Contains(tbSearch.Text)
                    || i.room_number.Contains(tbSearch.Text)
                    || i.room_type.Contains(tbSearch.Text)
                    || i.email_address.Contains(tbSearch.Text)
                    || i.phone_number.Contains(tbSearch.Text)
                select i
            ).ToList();
        }

        private void Frontend_Load(object sender, EventArgs e) { }

        private void loadReservations()
        {
            bSource.DataSource = (
                from i in context?.reservations
                select new
                {
                    i.ID,
                    i.first_name,
                    i.last_name,
                    i.phone_number,
                    i.room_type,
                    i.room_floor,
                    i.room_number,
                    i.break_fast,
                    i.lunch,
                    i.dinner,
                    i.food_bill,
                    i.cleaning,
                    i.towel,
                    i.supply_status,
                    i.s_surprise,
                    i.gender,
                    i.email_address,
                    i.apt_suite,
                    i.city,
                    i.state,
                    i.street_address,
                    i.birth_day,
                    i.arrival_time,
                    i.leaving_time,
                    i.zip_code,
                    i.check_in,
                    i.number_guest,
                    Display = $"{i.ID} | {i.first_name} | {i.last_name} | {i.phone_number}"
                }
            ).ToList();

            ClearBinding();

            cbReservations.DataSource = bSource;
            cbReservations.DisplayMember = "Display";
            cbReservations.ValueMember = "ID";

            tbFirstName.DataBindings.Add("Text", bSource, "first_name");
            tbLastName.DataBindings.Add("Text", bSource, "last_name");
            tbPhone.DataBindings.Add("Text", bSource, "phone_number");
            cbRoomType.DataBindings.Add("Text", bSource, "room_type");
            cbRoomNumber.DataBindings.Add("Text", bSource, "room_number");
            cbGender.DataBindings.Add("Text", bSource, "gender");
            tbEmail.DataBindings.Add("Text", bSource, "email_address");
            tbApt.DataBindings.Add("Text", bSource, "apt_suite");
            tbCity.DataBindings.Add("Text", bSource, "city");
            cbState.DataBindings.Add("Text", bSource, "state");
            cbRoomFloor.DataBindings.Add("Text", bSource, "room_floor");
            cbNofGuests.DataBindings.Add("Text", bSource, "number_guest");
            rbStreet.DataBindings.Add("Text", bSource, "street_address");
            daTimePickerEntryDate.DataBindings.Add("Text", bSource, "arrival_time");
            daTimePickerDepertureDate.DataBindings.Add("Text", bSource, "leaving_time");
            tbBirthday.DataBindings.Add("Text", bSource, "birth_day");
            tbZipCode.DataBindings.Add("text", bSource, "zip_code");
            cbSupplyStatus.DataBindings.Add("checked", bSource, "supply_status");
            cbCheckIn.DataBindings.Add("checked", bSource, "check_in");
        }

        private void btnFoodAndMenu_Click(object sender, EventArgs e)
        {
            if (new FoodMneuWithOptions(reservationObj).ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("You Choosed Food Successfully");
            }
        }

        private void btnFinalizeBtn_Click(object sender, EventArgs e)
        {
            if (new FinalizePayment(reservationObj).ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("You Finalized Your Payment Successfully");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = 0;

                reservationObj.first_name = tbFirstName.Text;
                reservationObj.last_name = tbLastName.Text;
                reservationObj.birth_day = tbBirthday.Text;
                reservationObj.gender = cbGender.Text;
                reservationObj.phone_number = tbPhone.Text;
                reservationObj.email_address = tbEmail.Text;
                reservationObj.street_address = rbStreet.Text;
                reservationObj.apt_suite = tbApt.Text;
                reservationObj.city = tbCity.Text;
                reservationObj.state = cbState.Text;
                reservationObj.zip_code = tbZipCode.Text;
                reservationObj.number_guest = int.TryParse(cbNofGuests.Text, out temp) ? temp : 0;
                reservationObj.room_type = cbRoomType.Text;
                reservationObj.room_floor = cbRoomFloor.Text;
                reservationObj.room_number = cbRoomNumber.Text;

                reservationObj.arrival_time = daTimePickerEntryDate.Value;
                reservationObj.leaving_time = daTimePickerDepertureDate.Value;

                reservationObj.check_in = cbCheckIn.Checked;
                reservationObj.supply_status = cbSupplyStatus.Checked;

                context?.reservations.Add(reservationObj);
                context?.SaveChanges();

                MessageBox.Show("Reservation Added Successfully");

                loadListboxes();
                ClearAllControls();
                reservationObj = new();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Coudn't add this reservation, you should finalize the payment first."
                );
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                context?.reservations.Remove(
                    context
                        ?.reservations.Where(
                            r => r.ID == int.Parse(cbReservations.SelectedValue.ToString())
                        )
                        .FirstOrDefault()
                );

                context?.SaveChanges();
                ClearAllControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Coudn't remove this reservation!");
            }

            MessageBox.Show("Deleted Successfully");
        }

        private void ClearAllControls()
        {
            Action<Control.ControlCollection> func = null;
            tbApt.Clear();

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is ComboBox)
                        (control as ComboBox).Text = "";
                    else
                        func(control.Controls);
            };

            func(Controls);

            cbCheckIn.Checked = false;
            cbSnedSms.Checked = false;
            cbSupplyStatus.Checked = false;
        }

        private void ClearBinding()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    control.DataBindings.Clear();
                }
            };

            func(Controls);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = 0;

                reservationObj = context
                    ?.reservations.Where(
                        r => r.ID == int.Parse(cbReservations.SelectedValue.ToString())
                    )
                    .FirstOrDefault();

                reservationObj.first_name = tbFirstName.Text;
                reservationObj.last_name = tbLastName.Text;
                reservationObj.birth_day = tbBirthday.Text;
                reservationObj.gender = cbGender.Text;
                reservationObj.phone_number = tbPhone.Text;
                reservationObj.email_address = tbEmail.Text;
                reservationObj.street_address = rbStreet.Text;
                reservationObj.apt_suite = tbApt.Text;
                reservationObj.city = tbCity.Text;
                reservationObj.state = cbState.Text;
                reservationObj.zip_code = tbZipCode.Text;
                reservationObj.number_guest = int.TryParse(cbNofGuests.Text, out temp) ? temp : 0;
                reservationObj.room_type = cbRoomType.Text;
                reservationObj.room_floor = cbRoomFloor.Text;
                reservationObj.room_number = cbRoomNumber.Text;

                reservationObj.arrival_time = daTimePickerEntryDate.Value;
                reservationObj.leaving_time = daTimePickerDepertureDate.Value;

                reservationObj.check_in = cbCheckIn.Checked;
                reservationObj.supply_status = cbSupplyStatus.Checked;

                context?.SaveChanges();

                MessageBox.Show("Reservation Updated Successfully");

                loadListboxes();
                ClearAllControls();
                reservationObj = new();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Coudn't update this reservation");
            }
        }
    }
}
