using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_App
{
    public static class User
    {
        public static int userID;
        public static string fName;
        public static string lName;
        public static int userTypeID;
        public static string userTypeName;
        public static int guestID;
        public static List<string> permissionServicesList;

        static User()
        {
            permissionServicesList = new List<string>();
        }

        public static string UserName()
        {
            return fName + " " + lName;
        }

        public static string UserDescription()
        {
            return fName + " " + lName + ", " + userTypeName;
        }
    }
}
