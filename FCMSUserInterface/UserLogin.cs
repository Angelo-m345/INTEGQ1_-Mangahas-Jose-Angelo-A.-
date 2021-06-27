using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCMSUserInterface
{
    public class UserLogin
    {
        public  void Login ()
        {
            Console.WriteLine("==========User Login==========");

         

            string usernameC = ("PUPuser");
            string passwordC = ("P103003");

            string username, password;

            Console.Write("username: ");
            username = Console.ReadLine();
            Console.Write("password: ");
            password = Console.ReadLine();


            if (username == usernameC && password == passwordC)
            {
                Console.WriteLine("Successfully Logged In");
                Menu.menu();
            }


            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
