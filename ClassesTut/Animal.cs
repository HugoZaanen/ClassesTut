using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesTut
{
    class Animal
    {
        public string name;
        public string sound;

        public Animal()
        {
            name = "No Name";
            sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No name")
        {
            this.name = name;
            this.sound = "no Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No name",
            string sound = "No sound")
        {
            this.name = name;
            this.sound = sound;
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}",
                name,sound);
        }

        static int numOfAnimals = 0;

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }
    }
}
