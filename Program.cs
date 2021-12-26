using System;

namespace template_csharp_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            // Standard code with a new console application
            Console.WriteLine("Hello World!");

            // Step 1: Enter your name in between the quotation marks
            string name = "YOUR NAME HERE";

            Console.WriteLine("Welcome to the Hello World application, " + name);

            // Step 2: Research Console.WriteLine
            // https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=net-6.0
            // Step 3: Use 3 variations of Console.WriteLine

            // --- START CODE HERE ---


            // --- END CODE HERE ---

            // This line is to pause the application without storing input
            Console.Read();

            // This line clears the console screen
            Console.Clear();

            // Step 4: Research Console.Read, Console.ReadLine
            // https://docs.microsoft.com/en-us/dotnet/api/system.console.read?view=net-6.0
            // https://docs.microsoft.com/en-us/dotnet/api/system.console.readline?view=net-6.0
            // Step 5: Use Console.ReadLine to get user input, store it as a string

            // --- START CODE HERE ---


            // --- END CODE HERE ---

            // Step 3: Set each data type to an appropriate non-zero number
            int a = 0;
            double b = 0;
            float c = 0;
            long d = 0;

            Console.WriteLine("The value of the integer is now {0}, the double is now {1}, the float is now {2}, the long is now {3}", a, b, c, d);


        }
    }
}
