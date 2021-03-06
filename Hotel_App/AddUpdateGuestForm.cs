﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_App
{
    public partial class AddUpdateGuestForm : Form
    {
        public bool changetype = false;
        public int updateid;
        public AddUpdateGuestForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (changetype)
            {
                try
                {
                    procedures.GuestUpdate(updateid, tbFName.Text,
                        tbLName.Text,
                        tbAddress.Text,
                        tbCity.Text,
                        tbState.Text,
                        tbCountry.Text,
                        tbPhone.Text,
                        tbEmail.Text);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Please, fill all Text Boxes.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                int? guestid = null;
                try
                {
                    procedures.GuestInsert(tbFName.Text,
                        tbLName.Text,
                        tbAddress.Text,
                        tbCity.Text,
                        tbState.Text,
                        tbCountry.Text,
                        tbPhone.Text,
                        tbEmail.Text,
                        ref guestid);
                }
                catch
                {
                    MessageBox.Show("Please, fill all Text Boxes.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                }
                if (User.userTypeID == 1)
                {
                    User.guestID = (int)guestid;
                    procedures.UserUpdateGuestID(guestid, User.userID);
                }

                this.Close();
            }
        }
    }
}
