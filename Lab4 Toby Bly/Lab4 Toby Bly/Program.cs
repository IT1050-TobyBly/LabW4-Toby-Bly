using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Toby_Bly
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1; // declare first number to add 
            int number2; // declare second number to add
            int sum; // declare sum of number1 and number2
            Console.Write("Enter first integer:"); // prompt user
            // read first number from user
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer:"); // prompt user
            // read second number from user
            number2 = int.Parse(Console.ReadLine());
            sum = number1 + number2; // add numbers
            Console.WriteLine($"Sum is {sum}"); // display sum

            var x = 4;
            var y = 9;
            var z = 12;
            Console.WriteLine((x + y) * (z + 10));

            Console.WriteLine("\n Hello\tWorld!");
            Console.WriteLine("Hello\nWorld");
            Console.WriteLine("\"Hello World!\"");
            Console.WriteLine("Hello\\World");




            
            
            
            
            

            

        }
    }
}
