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

            #region
            //Console.WriteLine("Area of Rectangle : {0}",
            //    ShapeMath.GetArea("rectangle",5,6));

            //int? randNum = null;

            //if(randNum == null)
            //{
            //    Console.WriteLine("randNum is null");
            //}

            //if (!randNum.HasValue)
            //{
            //    Console.WriteLine("randNum is null");
            //}
            #endregion

            #region
            //Animal cat = new Animal();

            //cat.SetName("Whiskers");
            //cat.Sound = "Meow";

            //Console.WriteLine("The cat is named {0} and says {1}",
            //    cat.GetName(),cat.Sound);

            //cat.Owner = "Derek";

            //Console.WriteLine("{0} owner is {1}",
            //    cat.GetName(), cat.Owner);

            //Console.WriteLine("{0} shelter id is {1}",
            //    cat.GetName(),cat.idNum);

            //Animal fox = new Animal("Oscar","Rawrrr");

            //Console.WriteLine("# of Animals : {0}",
            //    Animal.NumOfAnimals);
            #endregion

            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Animal grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrr"
            };
            grover.Sound = "Woooof";

            whiskers.MakeSound();
            grover.MakeSound();

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
