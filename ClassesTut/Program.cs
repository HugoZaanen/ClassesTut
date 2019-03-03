using System;

namespace ClassesTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaww"
            };

            fox.MakeSound();

            Console.WriteLine("# of animals : {0}",
                Animal.GetNumAnimals());

            Console.ReadLine();
        }

        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l = 1,
                double w = 1)
            {
                length = l;
                width = w;
            }

            public double Area()
            {
                return length * width;
            }
        }
    }
}
