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
        }

        static void Main(string[] args)
        {
            
        }
    }
}
