using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStringFunctionality();
            Console.WriteLine();
        }

        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String Functionality:");
            string firstName = "Freddy";

            //Значение FirstName.
            Console.WriteLine("Value of firstName: {0}", firstName);

            //Длина firstName
            Console.WriteLine("firstName has {0} characters.", firstName.Length);

            // firstName в верхнем регистре.
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());

            //firstName в нижнем регистре.
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());

            //Содержит ли firstName букву у?
            Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));

            //firstName после замены.
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();
        }
    }
}
