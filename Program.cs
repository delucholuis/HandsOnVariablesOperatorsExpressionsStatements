/*Main method demonstrates the use of variables, operators, expressions, and statements */ 
using System;

namespace HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
           int x = 3;
           int y = 4;
           int sum = x + y;
            Console.WriteLine($"The Sum {x} and {y} is: {sum}");
            Console.WriteLine($"Are the values of sum and 7 equal?" + " " + (sum == 7));

            string text1 = "Hello";
            string text2 = "World";
            string message = "Message: ";
            Console.WriteLine(message + text1 + " " + text2 + "!");

        }
    }
}
