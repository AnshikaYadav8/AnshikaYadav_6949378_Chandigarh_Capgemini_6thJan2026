using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApplicationProject
{
    abstract class User
    {
        public string UserName;
        public static int UserId = 300;
        public abstract void UserDetails();
    }

}
