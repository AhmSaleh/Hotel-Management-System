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

namespace HotelManagmentRefactored
{
    public partial class Login : Form
    {
        LoginManagerContext context = new();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmCredinFront = context
                    ?.frontend.Where(
                        u =>
                            u.user_name == tbUsername.Text.Trim()
                            && u.pass_word == tbPassword.Text.Trim()
                    )
                    .ToList();
                if (confirmCredinFront?.Count > 0)
                {
                    MessageBox.Show("Frontend");
                    return;
                }
            }
            catch (Exception E) { }

            try
            {
                var confirmCredinKitch = context
                    ?.kitchen.Where(
                        u =>
                            u.user_name == tbUsername.Text.Trim()
                            && u.pass_word == tbPassword.Text.Trim()
                    )
                    .ToList();

                if (confirmCredinKitch?.Count > 0)
                {
                    MessageBox.Show("Kitchen");
                    return;
                }
                else
                {
                    MessageBox.Show("UnAuthorized!");
                }
            }
            catch (Exception E) { }
        }

        private void Login_Load(object sender, EventArgs e) { }
    }
}
