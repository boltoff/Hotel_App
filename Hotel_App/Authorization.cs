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
    public partial class Authorization : Form
    {
        public bool logIn = false;

        public Authorization()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int? uID = null;
            int? errorID = null;
            string fName = "";
            string lName = "";
            int? userTypeID = null;
            string userTypeName = "";
            int? guestID = null;

            procedures.UserLogin(tbLogin.Text, tbPassword.Text, ref uID, ref errorID);
            if (errorID == 0)
            {
                logIn = true;
                procedures.UserGet(uID, ref fName, ref lName, ref userTypeID, ref userTypeName, ref guestID);
                User.userID = (uID != null) ? (int)uID : 0;
                User.fName = fName;
                User.lName = lName;
                User.userTypeID = (userTypeID != null) ? (int)userTypeID : 0;
                User.userTypeName = userTypeName;
                User.guestID = (guestID != null) ? (int)guestID : 0;

                this.permissionList.Fill(this.hotel_BaseDataSet.PermissionList, User.userTypeID);

                foreach (DataRow r in hotel_BaseDataSet.PermissionList.Rows)
                {
                    User.permissionServicesList.Add(r.Field<string>("Name"));
                }

                this.Close();
            }
            else
            {
                logIn = false;
                MessageBox.Show("Invalid login or password",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            logIn = false;
            this.Close();
        }
    }
}
