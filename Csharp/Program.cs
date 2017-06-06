//Dallas Carraher

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cheatsheet
{
    class Program
    {
        //static void Main(string[] args)
        //{

        /*  
        //Basic Write and Read commands

        Console.Write("What is your name?: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello " + name);
        */


        /* 
        //Basic data types

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


        /*
        //Conditionals (relationship operators, logical operators, etc)

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


        /* 
        //Looping

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


        /*

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

        */

        /*

        //Stringbuilder (are used to edit strings without creating new ones)

        StringBuilder sb = new StringBuilder();

        sb.Append("This is a string with stringbuilder ");

        sb.AppendFormat("My name is {0} and this is stringbuilder using an {1}", "Dallas", "Array");

        sb.Replace("a", "e");

        sb.Remove(0, 4); 

        Console.WriteLine(sb.ToString());

        */

        /*
        //Arrays

        int[] randnumArray;

        int[] randArray = new int[5];

        int[] randArray2 = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Array Length: " + randArray2.Length);

        Console.WriteLine("Item 0: " + randArray2[0]);

        for (int i = 0; i < randArray2.Length; i++){
            Console.WriteLine("{0} : {1}", i, randArray2[i]);
        }

        foreach(int num in randArray2){
            Console.WriteLine(num);
        }

        Console.WriteLine("Where is 1?: " + Array.IndexOf(randArray2, 1));

        string[] names = {"Dallas", "Sean", "Jackson"};

        string nameStr = string.Join(",", names);

        string[] nameArray = nameStr.Split(',');

        foreach(string name in nameArray){
            Console.WriteLine(name);
        }

        */

        /*

        //Multi-Arrays

        int[,] multArray = new int[3, 3];

        foreach(int num in multArray){
            Console.WriteLine(num);
        }

        for (int x = 0; x < multArray.GetLength(0); x++){
            for (int y = 0; y < multArray.GetLength(1); y++){
                Console.WriteLine("{0} | {1} : {2}", x, y, multArray[x,y]);
            }
        }

        */

        /*

        //Lists (similar to vectors in C++; array resizes FOR you

        List<int> numList = new List<int>(); //how to declare a list

        numList.Add(5);
        numList.Add(15);
        numList.Add(25);

        int[] randArray = { 1, 2, 3, 4, 5 };
        numList.AddRange(randArray);

        List<int> numList2 = new List<int>(randArray);

        List<int> numList3 = new List<int>(new int[] { 1, 2, 3 });

        numList.Insert(1, 10);

        numList.Remove(5);

        numList.RemoveAt(2);

        for (int i = 0; i < numList.Count; i++){
            Console.WriteLine(numList[i]);
            Console.WriteLine("-");
        }

        Console.WriteLine("4 is in index " + numList3.IndexOf(4));

        Console.WriteLine("5 in List " + numList.Contains(5));

        List<string> strList = new List<string>(new string[] { "Tom", "Paul" });

        Console.WriteLine("Tom in list" + strList.Contains("tom",
            StringComparer.OrdinalIgnoreCase));

        strList.Sort();

        */


        /*
        //Exception handling

        try{
            Console.WriteLine("Divide 10 by ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("10 / {0} = {1}", num, (10/num));
        }

        catch(DivideByZeroException ex){
            Console.WriteLine("Can't divide by zero!");
            Console.WriteLine(ex.GetType().Name);
            Console.WriteLine("Error! " + ex.Message);
        }

        catch(Exception ex){
            Console.WriteLine(ex.GetType().Name);
            Console.WriteLine("Error! " + ex.Message);
        } 

        */


        //Objects and their methods

        class Animal
        {
            public double height { get; set; }
            public double weight { get; set; }
            public string sound { get; set; }
            public string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public Animal()
            {
                this.height = 0;
                this.weight = 0;
                this.name = "No name";
                this.sound = "No sound";
                numOfAnimals++;
            }

            public Animal(double height, double weight, string name, string sound)
            {
                this.height = height;
                this.weight = weight;
                this.name = name;
                this.sound = sound;
                numOfAnimals++;
            }

            static int numOfAnimals = 0;

            public static int getNumOfAnimals()
            {
                return numOfAnimals;
            }

            public string toString()
            {
                return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3}", name, height, weight, sound);
            }

            //method overloading

            public int getSum (int num1 = 1, int num2 = 1)
            {
                return num1 + num2;
            }

			public double getSum(double num1 = 1, double num2 = 1)
			{
				return num1 + num2;
			}

            //

            static void Main(string[] args)
            {

                Animal spot = new Animal(15, 10, "Spot", "Woof");

                Animal rex = new Animal(24, 100, "Rex", "Bark!"); 

                Console.WriteLine("{0} is a tiny dog, he weighs {1} pounds and says {2}", spot.name, spot.weight, spot.sound);

                Console.WriteLine("{0} is a big dog, he weighs {1} pounds and says {2}", rex.name, rex.weight, rex.sound);

                Console.WriteLine("The number of Animal objects created = " + Animal.getNumOfAnimals());

                Console.WriteLine(spot.toString());

                Console.WriteLine(rex.toString());

                Console.WriteLine(spot.getSum(1.4, 2.7));

                Console.WriteLine(rex.getSum(1, 2));

                Console.WriteLine(spot.getSum(num2: 1.4, num1: 2.7)); //if inputs are in incorrect order you can assign them with name and colon

                Animal Grover = new Animal
                {
                    name = "Grover",
                    height = 16,
                    weight = 18,
                    sound = "Grrr"
                };

            }
        }

        class Dog : Animal 
        {
            public string favFood { get; set; }

            public Dog() : base()
            {
                this.favFood = "No Favorite food";
            }

            public Dog(double height, double weight, string name, string sound, string favFood) : base (height, weight, name, sound)
            {
                this.favFood = favFood;
            }

            new public string toString()
            {
                return string.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3} and eats {4}", name, height, weight, sound, favFood);
            }
        }
    }
}