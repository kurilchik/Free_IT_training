using System;
using System.Collections.Generic;
using System.Text;

namespace week_6
{
    class User
    {
        public static string UserName;            
       
        public static void UserNameInput()
        {
            Console.WriteLine("Введите ваше имя:");
            User.UserName = Console.ReadLine();
        }

    }
    
}
