using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.FullName = "Sukran Sirinov";
            user.Email = "sukransirinov0@gmail.com";
            user.Passsword = "Sukran758";
            user.ShowInfo();
            Console.WriteLine(user.PasswordChecker("sukran758")); 
        }
    }
}
