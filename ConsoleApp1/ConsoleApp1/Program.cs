using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int birth, age;//give birth and age data type
            DateTime year;//code in  date data type

            year = DateTime.Now;//code to get date

            Console.WriteLine("Enter the birth year: ");// write the text that will appear on the screen.
            birth =Convert.ToInt32(Console.ReadLine());//read the text on the screen and convert it to an int value

            age = year.Date.Year - birth;//age equation code

            Console.WriteLine("Age:" + age);
            Console.ReadLine();




        }
    }
}
