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
    }
}
