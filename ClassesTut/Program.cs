using System;

namespace ClassesTut
{
    class Program
    {
        static void Main(string[] args)
        {
            #region           
            //Animal fox = new Animal()
            //{
            //    name = "Red",
            //    sound = "Raaww"
            //};

            //fox.MakeSound();

            //Console.WriteLine("# of animals : {0}",
            //    Animal.GetNumAnimals());
            #endregion

            //Console.WriteLine("Area of Rectangle : {0}",
            //    ShapeMath.GetArea("rectangle",5,6));

            int? randNum = null;

            if(randNum == null)
            {
                Console.WriteLine("randNum is null");
            }

            if (!randNum.HasValue)
            {
                Console.WriteLine("randNum is null");
            }

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
