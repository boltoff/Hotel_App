using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AuthorizationForm auth = new AuthorizationForm();
            auth.ShowDialog();
            if (User.guestID == 0 && User.userTypeID == 1)
            {
                AddUpdateGuestForm addnewguest = new AddUpdateGuestForm();
                addnewguest.tbFName.Text = User.fName;
                addnewguest.tbLName.Text = User.lName;
                addnewguest.ShowDialog();

            }
            if (auth.logIn)
            {
                Application.Run(new MainForm());
            }
        }
    }
}
