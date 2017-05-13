//Dallas Carraher


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


            /* Basic data types
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
            Console.WriteLine("Grade equals: " + grade);
            Console.WriteLine("Can you Vote?: " + !canVote);
            */


            /*Conditionals (relationship operators, logical operators, etc)

            int Age = 20;

            if (Age >= 5 && Age <= 7){
                Console.WriteLine("Ready for Kindergarten. ");
            }
            else if ((Age > 7) || (Age < 22)){
                Console.WriteLine("You are in school. ");
            }
            else {
                Console.WriteLine("You are ready for work. "); 
            }
            
            bool canDrive = Age >= 16 ? true : false;
            Console.WriteLine(canDrive);
            
            switch(Age){
            
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Young Adult");
                    break;
                default:
                    Console.WriteLine("Human");
                    break;
            }
            */


            /* Looping
            int i = 0;
            
			while(i < 10){
                if (i == 7){
                    Console.WriteLine("7");
                    i++;
                    continue;
                }

                if (i == 9){
                    Console.WriteLine("9");
                    break;
                }

                if ((i % 2) > 0){
                    Console.WriteLine(i);
                }
                i++;
                
            }


            string guess;
            
            do
            {
                Console.WriteLine("Guess a Number ");
                guess = Console.ReadLine();


            } while (!guess.Equals("15"));


            for (int j = 0; j < 10; j++){
                if ((j%2) > 0){
                    Console.WriteLine(j);
                }
            }

            string randStr = "Here are some random character";

            foreach (char c in randStr){
                Console.WriteLine(c);
            }
            */


            //Escape sequences (\' \" \\ \b \n \t) & string manipulation

            string sampleString = "A bunch of random words";

            string sampleString2 = "more random words";
            
            Console.WriteLine("is empty " + string.IsNullOrEmpty(sampleString));
            
            Console.WriteLine("is empty " + string.IsNullOrWhiteSpace(sampleString));
            
            Console.WriteLine("string length " + sampleString.Length);
            
            Console.WriteLine("Index of bunch " + sampleString.IndexOf("bunch"));
            
            Console.WriteLine("2nd Word " + sampleString.Substring(2, 6));
            
            Console.WriteLine("Strings equal " + sampleString.Equals(sampleString2));
            
            Console.WriteLine("Starts with a \"A bunch\" " + sampleString.StartsWith("A bunch"));
            
            Console.WriteLine("Ends with words " + sampleString.EndsWith("words"));

            sampleString = sampleString.Trim();

            sampleString = sampleString.Replace("words", "characters");
            
            Console.WriteLine(sampleString);

            sampleString = sampleString.Remove(0, 2);
            
            Console.WriteLine(sampleString);

            string[] names = new string[3] { "Matt", "Joe", "Paul" };
            
            Console.WriteLine("Name list: " + string.Join(", ", names));

            string formatStr = string.Format("{0:c}", 1.56);
            
            Console.WriteLine(formatStr);
        }
    }

}