//Dallas Carraher

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application
{
    class Animal
    {
        public double height { get; set; };
        public double weight { get; set; };
        public string sound { get; set; };

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

        public Animal(double height, double weight, string sound, string name)
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
            return String
        }

        public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3}", name, height, weight, sound);
        }

        static void Main(string[] args)
        {
            Animal spot = new Animal(15, 10, "Spot", "Woof");

            Console.WriteLine("{0} says {1}", spot.name, spot.sound);

            Console.WriteLine("Number of Animals" + Animal.getNumOfAnimals()());

            Console.WriteLine(spot.toString());
        }
    }
}
