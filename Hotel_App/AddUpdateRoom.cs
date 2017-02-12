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
    public partial class AddUpdateRoom : Form
    {
        public bool changetype = false;
        public int updateid;
        public AddUpdateRoom()
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
                procedures.RoomUpdate(updateid, tbRoomType.Text,
                    int.Parse(tbMaxPeople.Text),
                    rtbOptions.Text,
                    decimal.Parse(tbPrice.Text));
                this.Close();
            }
            else
            {
                int? id = null;
                procedures.RoomInsert(tbRoomType.Text, 
                    int.Parse(tbMaxPeople.Text), 
                    rtbOptions.Text, 
                    decimal.Parse(tbPrice.Text), ref id);
                this.Close();
            }
        }
    }
}
