using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    class User
    {
        string username;
        string password;


        public string _username
        {
            get
            {
                return username;
            }
            set
            {
                while (checkUsername(value) != true)
                {
                    Console.Write("Username is wrong, Please enter again: ");
                    value = Console.ReadLine();
                }

                username = value;

            }
        }
        public string _password
        {
            get
            {
                return password;
            }
            set
            {
                while (checkPassword(value) != true)
                {
                    Console.Write($"Password is wrong, Please enter again: ");
                    value = Console.ReadLine();
                }
                password = value;
            }
        }

        bool checkPassword(string str)
        {
            bool checkDigit = false;
            bool checkToUpper = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    checkDigit = true;
                else if (char.IsUpper(str[i])==true & char.IsSymbol(str[i])==false) 
                {
                    checkToUpper = true;                   
                }
                   
            }
            if (checkToUpper == true & checkDigit == true)
                return true;

            return false;
        } 

        bool checkUsername(string str)
        {
            if (str.Length < 6)
                return false;
            return true;
        }

      //  public User() {}
        public User(string Username, string Password)
        {
            _username = Username;
            _password = Password;            
        }
    }
}
