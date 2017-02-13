using System;
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
    public partial class AddUpdateReservationForm : Form
    {
        public bool changetype = false;
        public int updateid;

        public AddUpdateReservationForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUpdateReservationForm_Load(object sender, EventArgs e)
        {
            this.roomSelect.Fill(this.hotel_BaseDataSet.RoomSelect);

            foreach (DataRow r in hotel_BaseDataSet.RoomSelect.Rows)
            {
                if (changetype || User.userTypeID == 1)
                {
                    if (r.Field<string>("RoomType") != cmbRoomType.Items[0].ToString())
                    {
                        cmbRoomType.Items.Add(r.Field<string>("RoomType"));
                    }
                }
                else cmbRoomType.Items.Add(r.Field<string>("RoomType"));
            }

            cmbRoomType.SelectedItem = cmbRoomType.Items[0];

            dtpCheckIn.MinDate = DateTime.Today;
            dtpCheckOut.MinDate = DateTime.Today.AddDays(1);

            //if login as Admin
            if (User.userTypeID == 2)
            {
                this.guestSelect.Fill(this.hotel_BaseDataSet.GuestSelect);

                foreach (DataRow r in hotel_BaseDataSet.GuestSelect.Rows)
                {
                    string fName = r.Field<string>("FName");
                    string lName = r.Field<string>("LName");
                    string fullName = fName + " " + lName;
                    if (changetype)
                    {
                        if (fullName != cmbGuest.Items[0].ToString())
                        {
                            cmbGuest.Items.Add(fullName);
                        }
                    }
                    else cmbGuest.Items.Add(fullName);
                }

                cmbGuest.SelectedItem = cmbGuest.Items[0];
                lbGuest.Visible = true;
                cmbGuest.Visible = true;
            }
            //if login as Guest
            else
            {

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int? roomId = null;
            int? guestId = null;
            // if its update form
            if (changetype)
            {
                //if its Admin
                if (User.userTypeID == 2)
                {
                    RoomId_GuestId(out roomId, out guestId);

                    procedures.ReservationUpdate(updateid,
                        dtpCheckIn.Value,
                        dtpCheckOut.Value,
                        (int)nudGuestCount.Value,
                        roomId,
                        guestId);

                    this.Close();
                }
                // if its Guest
                else
                {

                }
            }
            // if its add form
            else
            {
                //if its Admin
                if (User.userTypeID == 2)
                {
                    int? id = null;
                    RoomId_GuestId(out roomId, out guestId);

                    procedures.ReservationInsert(dtpCheckIn.Value,
                        dtpCheckOut.Value,
                        (int)nudGuestCount.Value,
                        roomId, 
                        guestId, 
                        ref id);

                    this.Close();
                }
                // if its Guest
                else
                {
                    int? id = null;
                    RoomId_GuestId(out roomId, out guestId);
                    procedures.ReservationInsert(
                        dtpCheckIn.Value,
                        dtpCheckOut.Value,
                        (int)nudGuestCount.Value,
                        roomId,
                        User.guestID,
                        ref id);
                    this.Close();
                }
            }
        }

        private void RoomId_GuestId(out int? roomId, out int? guestId)
        {
            roomId = null;
            guestId = null;
            foreach (DataRow r in hotel_BaseDataSet.RoomSelect.Rows)
            {

                if (r.Field<string>("RoomType") == cmbRoomType.SelectedItem.ToString())
                {
                    roomId = r.Field<int>("ID");
                    break;
                }
            }

            foreach (DataRow r in hotel_BaseDataSet.GuestSelect.Rows)
            {
                string fName = r.Field<string>("FName");
                string lName = r.Field<string>("LName");
                string fullName = fName + " " + lName;

                if (fullName == cmbGuest.SelectedItem.ToString())
                {
                    guestId = r.Field<int>("ID");
                    break;
                }
            }
        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            dtpCheckOut.MinDate = dtpCheckIn.Value.AddDays(1);
        }
    }
}
