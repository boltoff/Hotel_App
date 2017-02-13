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
                cmbRoomType.Items.Add(r.Field<string>("RoomType"));
            }

            cmbRoomType.SelectedItem = cmbRoomType.Items[0];

            //if login as Admin
            if (User.userTypeID == 2)
            {
                this.guestSelect.Fill(this.hotel_BaseDataSet.GuestSelect);

                foreach (DataRow r in hotel_BaseDataSet.GuestSelect.Rows)
                {
                    string fName = r.Field<string>("FName");
                    string lName = r.Field<string>("LName");
                    string fullName = fName + " " + lName;
                    cmbGuest.Items.Add(fullName);
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
    }
}
