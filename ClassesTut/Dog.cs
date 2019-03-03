using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesTut
{
    class Dog : Animal
    {
        public string Sound2 { get; set; } = "Grrrrr";

        public new void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }

        public Dog(string name = "No Name",
            string sound = "No Sound",
            string sound2 = "No sound 2")
            :base(name,sound)
        {
            Sound2 = sound2;
        }


    }
}
