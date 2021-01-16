using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            int myNumber; //defualts to 0
            bool isMyNameTim; //defaults to false

            bool? graduatedCollege; // nullable boolean -- defaults to null

            // Nullable<bool> graduatedCollege; // also a nullable boolean but this is the .Net way to do it

            string name = null; // defaults to null, null is like undefined

            name.ToString(); //will throw an exception, in this case its a System.NullReferenceException

            name?.ToString(); // null conditional access operator -- do this thing if the thing to the left is not null, otherwise skip it -- conditional execution

            name = name ?? "nathan"; // null coalescing operator -- if the thing on the left is null, use the thing on the right



            //read input from a user
            Console.WriteLine("What is your first name?");
            var input = Console.ReadLine();
            
            // strings
            name = "Sam";
            char firstLetter = 'S';

            var myInterpolatedString = $"My name is {input} and that starts with the letter {firstLetter}";
            var stringLiteral = @"This is a paragraph.
                                  It is across multiple lines.
                                  Returns will be honored in the output.";

            Console.WriteLine(myInterpolatedString);
            Console.WriteLine(stringLiteral);

           //Number types
            int number = Int32.MaxValue;

            long bigNumber = Int64.MaxValue;

            short littleNumber = Int16.MaxValue;

            Console.WriteLine(number);
            Console.WriteLine(bigNumber);
            Console.WriteLine(littleNumber);

            //decimals can be represented by [f]loats(32bit), [d]oubles(64bit), and deci[m]als(128bit)
            var adding = 1 + 1.1d;
            var division = 3 / 2; //gives a whole number result because both numbers are ints
            var division2 = 3 / 2d; // resolves as 1.5 because 2 is specified as a double

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

            //Arrays
            var names = new string[5];

            var secondName = names[1];
            names[1] = "plob";

            var colors = new string[] { "red", "blue", "yellow", "orange", "purple" };

            //Control Flow

            if (input == "Sam")
            {
                Console.WriteLine("Pepper the puppy");
            }
            else if (input == "sam")
            {
                Console.WriteLine("PEPPER");
            }
            else
            {
                Console.WriteLine("Pepper the poppy");
            }

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine($"Currently for looping on color {colors[i]}");
            }

            var counter = 1;
            while (true)
            {
                Console.WriteLine($"While looping iteration {counter}");

                if (counter <= 5)
                {
                    counter++;
                    continue;
                }
      
                break;
            }

            foreach (var color in colors)
            {
                Console.WriteLine($"foreach looping on color {color}");
            }

        }
    }
}
