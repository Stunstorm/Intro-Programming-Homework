using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday");
            DateTime Birthday = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;
            int age = today.Year - Birthday.Year;
            if ((Birthday.Month <= today.Month && Birthday.Day <= today.Day) ^ (Birthday.Month < today.Month && Birthday.Day > today.Day))
            {
                Console.WriteLine("You are {0} years old.", age);
                Console.WriteLine("After 10 years you will be {0} years old", age + 10);
            }
            else
            {
                Console.WriteLine("You are {0} years old.", age - 1);
                Console.WriteLine("After 10 years you will be {0} years old", age + 9);
            }
        }
    }
}
