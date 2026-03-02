using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApplicationProject
{
        internal sealed class DisplayUser : User 
        {
            override public void UserDetails()
            {
                Console.WriteLine("Enter Name: ");
                this.UserName = Console.ReadLine();
                UserId++;
            }
            public void DisplayUserDetails()
            {
                Console.WriteLine("User Name: " + UserName);
                Console.WriteLine("User Id: " + UserId);
            }
    }
}
