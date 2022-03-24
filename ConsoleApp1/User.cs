using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class User:IAccount
    {
        public string FullName;
        public string Email;
        private string _passsword;
        public string Passsword
        {
            get
            {
                return _passsword;  
            }
            set
            {
                if(value.Length>=8)
                    _passsword = value;
            }
        }

        public bool PasswordChecker (string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;
            for (int i = 0; i < password.Length; i++)
            {
                if(char.IsLower(password[i]))
                    hasLower=true;

                else if(char.IsDigit(password[i]))
                    hasDigit=true;  
                else if(char.IsUpper(password[i]))
                    hasUpper = true;

                if(hasUpper && hasDigit && hasLower)
                    return true;
            }
            return false;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"FullName: {this.FullName} - Email: {this.Email}"); 
        }
    }
}
