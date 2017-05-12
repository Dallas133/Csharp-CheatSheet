using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            
            bool canVote;

            for (int i = 0; i < args.Length; i++){
                Console.WriteLine(args[i]);  
                }
        }
    }

}