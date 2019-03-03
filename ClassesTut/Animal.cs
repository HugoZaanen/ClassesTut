using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesTut
{
    class Animal
    {
        private string name;
        protected string sound;

        public void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public Animal()
            : this("No Name","No Sound") { }

        public Animal(string name)
            : this(name,"No Sound"){}

        public Animal(string name,string sound)
        {
            Name = name;
            Sound = sound;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if(!value.Any(char.IsDigit))
                {
                    name = "No name";
                }
                name = value;
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    name = "No sound";
                }
                sound = value;
            }
        }
    }
}
