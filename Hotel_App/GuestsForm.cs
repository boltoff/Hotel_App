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
    public partial class GuestsForm : Form
    {
        public GuestsForm()
        {
            InitializeComponent();
        }

        private void GuestsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_BaseDataSet.GuestSelect' table. You can move, or remove it, as needed.
            this.guestSelectTableAdapter.Fill(this.hotel_BaseDataSet.GuestSelect);
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvGuests_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                int rowindex = dgvGuests.CurrentCell.RowIndex;
                string rowguestid = dgvGuests.Rows[rowindex].Cells[0].Value.ToString();
                procedures.GuestDelete(int.Parse(rowguestid));

                this.userSelectGuestIDTableAdapter.Fill(this.hotel_BaseDataSet.UserSelectGuestID);
                foreach (DataRow r in hotel_BaseDataSet.UserSelectGuestID.Rows)
                {
                        if (r.Field<int?>("GuestID") == int.Parse(rowguestid))
                        {
                            procedures.UserUpdateGuestID(0, r.Field<int>("ID"));
                            break;
                        }
                }
            }
            catch
            {
                MessageBox.Show("Please, delete reservation with this guest before deleting guest.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        private void dgvGuests_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.guestSelectTableAdapter.Fill(this.hotel_BaseDataSet.GuestSelect);
        }

        private void tsbtnAddGuest_Click(object sender, EventArgs e)
        {
            AddUpdateGuestForm addguestform = new AddUpdateGuestForm();
            addguestform.ShowDialog();
            this.guestSelectTableAdapter.Fill(this.hotel_BaseDataSet.GuestSelect);
        }

        private void tsbtnUpdateGuest_Click(object sender, EventArgs e)
        {
            int rowindex = dgvGuests.CurrentCell.RowIndex;
            List<string> cellsvalues = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                cellsvalues.Add(dgvGuests.Rows[rowindex].Cells[i].Value.ToString());
            }

            AddUpdateGuestForm updateGuestForm = new AddUpdateGuestForm();
            updateGuestForm.Text = "Update Guest";
            updateGuestForm.btnOK.Text = "Update";
            updateGuestForm.updateid = int.Parse(cellsvalues[0]);
            updateGuestForm.tbFName.Text = cellsvalues[1];
            updateGuestForm.tbLName.Text = cellsvalues[2];
            updateGuestForm.tbAddress.Text = cellsvalues[3];
            updateGuestForm.tbCity.Text = cellsvalues[4];
            updateGuestForm.tbState.Text = cellsvalues[5];
            updateGuestForm.tbCountry.Text = cellsvalues[6];
            updateGuestForm.tbPhone.Text = cellsvalues[7];
            updateGuestForm.tbEmail.Text = cellsvalues[8];
            updateGuestForm.changetype = true;
            updateGuestForm.ShowDialog();
            this.guestSelectTableAdapter.Fill(this.hotel_BaseDataSet.GuestSelect);
        }
    }
}
