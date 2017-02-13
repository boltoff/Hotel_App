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
    public partial class ReservationsForm : Form
    {
        public ReservationsForm()
        {
            InitializeComponent();
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReservationsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_BaseDataSet.ReservationSelect' table. You can move, or remove it, as needed.
            this.reservationSelectTableAdapter.Fill(this.hotel_BaseDataSet.ReservationSelect);

        }

        private void tsbtnUpdateReservation_Click(object sender, EventArgs e)
        {
            int rowindex = dgvReservations.CurrentCell.RowIndex;
            List<string> cellsvalues = new List<string>();
            for (int i = 0; i < 6; i++)
            {
                cellsvalues.Add(dgvReservations.Rows[rowindex].Cells[i].Value.ToString());
            }

            AddUpdateReservationForm updateReservationForm = new AddUpdateReservationForm();
            updateReservationForm.Text = "Update Guest";
            updateReservationForm.btnOK.Text = "Update";
            //updateReservationForm.updateid = int.Parse(cellsvalues[0]);
            //updateReservationForm.tbFName.Text = cellsvalues[1];
            //updateReservationForm.tbLName.Text = cellsvalues[2];
            //updateReservationForm.tbAddress.Text = cellsvalues[3];
            //updateReservationForm.tbCity.Text = cellsvalues[4];
            //updateReservationForm.tbState.Text = cellsvalues[5];
            //updateReservationForm.tbCountry.Text = cellsvalues[6];
            //updateReservationForm.tbPhone.Text = cellsvalues[7];
            //updateReservationForm.tbEmail.Text = cellsvalues[8];
            //updateReservationForm.changetype = true;
            updateReservationForm.ShowDialog();
            this.reservationSelectTableAdapter.Fill(this.hotel_BaseDataSet.ReservationSelect);
        }
    }
}
