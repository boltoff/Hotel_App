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
    public partial class AddUpdateRoomForm : Form
    {
        public bool changetype = false;
        public int updateid;
        public AddUpdateRoomForm()
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
                    procedures.RoomUpdate(updateid, tbRoomType.Text,
                        int.Parse(tbMaxPeople.Text),
                        rtbOptions.Text,
                        decimal.Parse(tbPrice.Text));
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
                try
                {
                    int? id = null;
                    procedures.RoomInsert(tbRoomType.Text,
                        int.Parse(tbMaxPeople.Text),
                        rtbOptions.Text,
                        decimal.Parse(tbPrice.Text), ref id);
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
        }
    }
}
