using HotelManagmentRefactored.Context;
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

        public Frontend()
        {
            InitializeComponent();

            context = new();

            loadGridview();
            loadListboxes();
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
    }
}
