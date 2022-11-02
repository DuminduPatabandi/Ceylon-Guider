using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceylon
{
    internal class UserLogName
    {
        static string userName;
        static string email;

        public static string UserName
        {
            get { return userName; }
            set { userName = value; } 

        }
        public static string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
