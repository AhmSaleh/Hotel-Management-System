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
    public partial class FoodMenu : Form
    {
        public int breakfast { get; set; }
        public int lunch { get; set; }
        public int dinner { get; set; }
        public int selecteIndexID { get; set; }

        public FoodMenu(int _selecteIndexID)
        {
            InitializeComponent();
            this.selecteIndexID = _selecteIndexID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            breakfast = Convert.ToInt32(
                string.IsNullOrEmpty(tbBreakfast.Text) ? 0 : tbBreakfast.Text.ToString()
            );
            dinner = Convert.ToInt32(
                string.IsNullOrEmpty(tbDinner.Text) ? 0 : tbDinner.Text.ToString()
            );
            lunch = Convert.ToInt32(
                string.IsNullOrEmpty(tbLunch.Text) ? 0 : tbLunch.Text.ToString()
            );

            DialogResult = DialogResult.OK;
            Close();
        }

        private void FoodMenu_Load(object sender, EventArgs e) { }
    }
}
