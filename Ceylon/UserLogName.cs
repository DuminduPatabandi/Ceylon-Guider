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

        public static string UserName
        {
            get { return userName; }
            set { userName = value; }   

        }
    }
}
