using HotelManagmentRefactored.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagmentRefactored.UI_Forms
{
    public partial class ManageKitchenForm : Form
    {
        FrontendReservationRef context;
        BindingSource bSource;

        public int breakfast { get; set; } = 0;
        public int lunch { get; set; } = 0;
        public int dinner { get; set; } = 0;

        public ManageKitchenForm()
        {
            InitializeComponent();

            context = new();
            bSource = new();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void ManageKitchenForm_Load(object sender, EventArgs e)
        {
            LoadForDataGridView();
            listBoxFromDataBase();
        }

        private void LoadForDataGridView()
        {
            try
            {
                var source = (
                    from i in context?.reservations
                    where (i.check_in == true && i.supply_status == false)
                    select new
                    {
                        i.ID,
                        i.first_name,
                        i.last_name,
                        i.phone_number,
                        i.room_type,
                        i.room_floor,
                        i.break_fast,
                        i.lunch,
                        i.dinner,
                        i.cleaning,
                        i.towel,
                        i.s_surprise,
                        i.supply_status,
                        i.food_bill
                    }
                ).ToList();

                overviewDataGridView.DataSource = source;
            }
            catch (Exception E)
            {
                MessageBox.Show("Couldn't Connect to DB!");
                overviewDataGridView.DataSource = null;
            }
        }

        private void listBoxFromDataBase()
        {
            bSource.DataSource = (
                from i in context?.reservations
                where i.supply_status == false && i.check_in == true
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
                    Display = $"{i.ID} | {i.first_name} | {i.last_name} | {i.phone_number}"
                }
            ).ToList();

            queueListBox.DataSource = bSource;
            queueListBox.DisplayMember = "Display";
            queueListBox.ValueMember = "ID";

            cbSweSurp.DataBindings.Clear();
            cbFoSupStatus.DataBindings.Clear();
            cbTowels.DataBindings.Clear();
            cbCleaning.DataBindings.Clear();
            tbDinner.DataBindings.Clear();
            tbLunch.DataBindings.Clear();
            tbBreakfast.DataBindings.Clear();
            tbFloor.DataBindings.Clear();
            tbRoom.DataBindings.Clear();
            tbRoomType.DataBindings.Clear();
            tbFirstName.DataBindings.Clear();
            tbLastName.DataBindings.Clear();
            tbPhone.DataBindings.Clear();

            cbSweSurp.DataBindings.Add("checked", bSource, "s_surprise");
            cbFoSupStatus.DataBindings.Add("checked", bSource, "supply_status");
            cbTowels.DataBindings.Add("checked", bSource, "towel");
            cbCleaning.DataBindings.Add("checked", bSource, "cleaning");
            tbDinner.DataBindings.Add("Text", bSource, "dinner");
            tbLunch.DataBindings.Add("Text", bSource, "lunch");
            tbBreakfast.DataBindings.Add("Text", bSource, "break_fast");
            tbFloor.DataBindings.Add("Text", bSource, "room_floor");
            tbRoom.DataBindings.Add("Text", bSource, "room_number");
            tbRoomType.DataBindings.Add("Text", bSource, "room_type");
            tbFirstName.DataBindings.Add("Text", bSource, "first_name");
            tbLastName.DataBindings.Add("Text", bSource, "last_name");
            tbPhone.DataBindings.Add("Text", bSource, "phone_number");
        }

        private void cbFoSupStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFoSupStatus.Checked)
            {
                cbTowels.Checked = false;
                cbCleaning.Checked = false;
                cbSweSurp.Checked = false;

                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var entity = (
                    from i in context?.reservations
                    where i.ID == int.Parse(queueListBox.SelectedValue.ToString())
                    select i
                ).FirstOrDefault();

                entity.supply_status = cbFoSupStatus.Checked;
                entity.towel = cbTowels.Checked;
                entity.cleaning = cbCleaning.Checked;
                entity.s_surprise = cbSweSurp.Checked;

                entity.break_fast = breakfast;
                entity.lunch = lunch;
                entity.dinner = dinner;

                entity.food_bill = (breakfast * 7 + lunch * 15 + dinner * 15);
                context.SaveChanges();

                listBoxFromDataBase();
                MessageBox.Show("Updated Successfully");
            }
            catch (Exception E)
            {
                MessageBox.Show("Coudln't update!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FoodMenu menuForm = new FoodMenu(int.Parse(queueListBox.SelectedValue.ToString()));
            menuForm.ShowDialog();

            if (menuForm.DialogResult == DialogResult.OK)
            {
                breakfast = menuForm.breakfast;
                lunch = menuForm.lunch;
                dinner = menuForm.dinner;

                tbBreakfast.Text = breakfast.ToString();
                tbLunch.Text = lunch.ToString();
                tbDinner.Text = dinner.ToString();
            }
        }
    }
}
