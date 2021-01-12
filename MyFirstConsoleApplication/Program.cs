using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Sam";
            char firstLetter = 'S';

           //Number types
            int number = Int32.MaxValue;

            long bigNumber = Int64.MaxValue;

            short littleNumber = Int16.MaxValue;

            Console.WriteLine(number);
            Console.WriteLine(bigNumber);
            Console.WriteLine(littleNumber);

            var implicitStringThing = "this is an implicitly typed variable";
            var implicitNumber = 42;

            var today = DateTime.Today;

            //instantiation
            var worstYear = new DateTime(2020, 1, 1);

            //anonymous type, new object
            var person = new { Name = "Sam" };

            //everything either is or can be an object
            object weirdStuff = 1234;
            weirdStuff = "More craziness";

            Console.WriteLine(weirdStuff);
        }
    }
}
