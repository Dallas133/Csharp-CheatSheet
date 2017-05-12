using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
			/*  Basic Write and Read commands
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            */

			// Basic data types
            bool canVote = true; //boolean type t/f

            char grade = 'A'; //character type

            int maxInt = int.MaxValue; //integer with a max value of 2.1 billion

            long maxLong = long.MaxValue; //long with a max value of 9.2 quintilion

            decimal maxDec = decimal.MaxValue; //decimal with a max value of 79.2 octilion

            float maxFloat = float.MaxValue; //float is a 32bit number with max value 3.4x10^38 with 7 decimal precision
            
            double maxDouble = double.MaxValue; //double is a 32bit number with a max value of 1.79x10^308 with 15 decimals of precision.

            Console.WriteLine("Maximum integer: " + maxInt);
            Console.WriteLine("Maximum long: " + maxLong);
            Console.WriteLine("Maximum decimal: " + maxDec);
            Console.WriteLine("Maximum float: " + maxFloat);
            Console.WriteLine("Maximum double: " + maxDouble);
            
            /* Looping
			for (int i = 0; i < args.Length; i++){
                Console.WriteLine(args[i]);  
            }
            */
        }
    }

}