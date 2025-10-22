using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the password checker");
            Console.WriteLine("the password has to be 13 characters long and has to contain '!' or '$' or '.'");
            Console.WriteLine("enter your password to check if it is vaild");

            string password = "";
            bool isvalid = false;
            while (!isvalid)
            {
                password = Console.ReadLine();

                bool hasSpecialChar = password.Contains(".") || password.Contains("!") || password.Contains("$");
                bool is13charlong = password.Length == 13;


                if (hasSpecialChar && is13charlong)
                {
                    Console.WriteLine("the password you have entered is vaild");
                }
                else
                {
                    Console.WriteLine(" the password you have entered is not valid so please try again");
                }
            }

            Console.ReadLine();


               


         }
    }
}
