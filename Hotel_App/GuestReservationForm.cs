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
    public partial class GuestReservationForm : Form
    {
        public GuestReservationForm()
        {
            InitializeComponent();
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuestReservationForm_Load(object sender, EventArgs e)
        {
            this.reservationSelectWhereIdTableAdapter.Fill(this.hotel_BaseDataSet.ReservationSelectWhereId, User.guestID);
        }
    }
}
