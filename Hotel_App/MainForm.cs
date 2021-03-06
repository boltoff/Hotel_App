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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_BaseDataSet.RoomSelect' table. You can move, or remove it, as needed.
            this.roomSelectTableAdapter.Fill(this.hotel_BaseDataSet.RoomSelect);
            tslbUserDesc.Text = User.UserDescription();

            foreach (var item in tsMainMenu.Items)
            {
                if (item.GetType() == typeof(ToolStripButton))
                {
                    ToolStripButton btn = (ToolStripButton)item;
                    if (User.permissionServicesList.Contains(btn.AccessibleName))
                    {
                        btn.Visible = true;
                    }
                }
            }

            if (User.permissionServicesList.Contains(btnAddRoom.AccessibleName) || User.permissionServicesList.Contains(btnUpdateRoom.AccessibleName))
            {
                lbDeleteDesc.Visible = true;
                btnAddRoom.Visible = true;
                btnUpdateRoom.Visible = true;
            }
            else
            {
                lbDeleteDesc.Visible = true;
                lbDeleteDesc.Text = "*Double click on row to make reservation";
            }
        }

        private void dgvRooms_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (User.userTypeID == 2)
            {
                try
                {
                    int rowindex = dgvRooms.CurrentCell.RowIndex;
                    procedures.RoomDelete(int.Parse(dgvRooms.Rows[rowindex].Cells[0].Value.ToString()));
                }
                catch
                {
                    MessageBox.Show("Please, delete reservation with this room before deleting room.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("You haven't permissions for this.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void dgvRooms_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.roomSelectTableAdapter.Fill(this.hotel_BaseDataSet.RoomSelect);
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddUpdateRoomForm addroomform = new AddUpdateRoomForm();
            addroomform.ShowDialog();
            this.roomSelectTableAdapter.Fill(this.hotel_BaseDataSet.RoomSelect);
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            int rowindex = dgvRooms.CurrentCell.RowIndex;
            List<string> cellsvalues = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                cellsvalues.Add(dgvRooms.Rows[rowindex].Cells[i].Value.ToString());
            }

            AddUpdateRoomForm updateRoomForm = new AddUpdateRoomForm();
            updateRoomForm.Text = "Update Room";
            updateRoomForm.btnOK.Text = "Update";
            updateRoomForm.updateid = int.Parse(cellsvalues[0]);
            updateRoomForm.tbRoomType.Text = cellsvalues[1];
            updateRoomForm.tbMaxPeople.Text = cellsvalues[2];
            updateRoomForm.rtbOptions.Text = cellsvalues[3];
            updateRoomForm.tbPrice.Text = cellsvalues[4];
            updateRoomForm.changetype = true;
            updateRoomForm.ShowDialog();
            this.roomSelectTableAdapter.Fill(this.hotel_BaseDataSet.RoomSelect);

        }

        private void tsbtnGuests_Click(object sender, EventArgs e)
        {
            GuestsForm gform = new GuestsForm();
            gform.ShowDialog();
        }

        private void tsbtnReservations_Click(object sender, EventArgs e)
        {
            ReservationsForm resForm = new ReservationsForm();
            resForm.ShowDialog();
        }

        private void tsbtnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm hisform = new HistoryForm();
            hisform.ShowDialog();
        }

        private void tsbtnEditProfile_Click(object sender, EventArgs e)
        {
            AddUpdateGuestForm updateprofileform = new AddUpdateGuestForm();
            this.guestSelectTableAdapter.Fill(this.hotel_BaseDataSet.GuestSelect);
            foreach (DataRow r in hotel_BaseDataSet.GuestSelect.Rows)
            {
                if (r.Field<int>("ID") == User.guestID)
                {
                    updateprofileform.tbFName.Text = r.Field<string>("FName");
                    updateprofileform.tbLName.Text = r.Field<string>("LName");
                    updateprofileform.tbAddress.Text = r.Field<string>("Address");
                    updateprofileform.tbCity.Text = r.Field<string>("City");
                    updateprofileform.tbState.Text = r.Field<string>("State");
                    updateprofileform.tbCountry.Text = r.Field<string>("Country");
                    updateprofileform.tbPhone.Text = r.Field<string>("Phone");
                    updateprofileform.tbEmail.Text = r.Field<string>("Email");
                    break;
                }
            }
            updateprofileform.updateid = User.guestID;
            updateprofileform.changetype = true;
            updateprofileform.tbFName.Text = User.fName;
            updateprofileform.tbLName.Text = User.lName;
            updateprofileform.Text = "Update Profile";
            updateprofileform.btnOK.Text = "Update";
            updateprofileform.ShowDialog();
        }
        private void dgvRooms_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = dgvRooms.CurrentCell.RowIndex;
            AddUpdateReservationForm addMyReservationForm = new AddUpdateReservationForm();
            addMyReservationForm.cmbRoomType.Items.Add(dgvRooms.Rows[rowindex].Cells[1].Value.ToString());
            addMyReservationForm.ShowDialog();
        }

        private void tsbtnMyReservations_Click(object sender, EventArgs e)
        {
            GuestReservationForm gureform = new GuestReservationForm();
            gureform.ShowDialog();
        }
    }
}
