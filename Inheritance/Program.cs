using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {




            var myBird = new Bird();
            myBird.WingColor = "blue";
            myBird.CanFly = true;
            myBird.WillMigrate = true;
            myBird.BeakLength = 3.5;



            Reptile Lizard = new Reptile()
            {

                    IsColdBlooded = true,
                    IsScaly = true,
                    Habitat = "swamp",
                    CanGrowTail = true

            };


            var myAnimals = new Animal[] { myBird, Lizard };

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"ALive: {animal.IsAlive}");
                Console.WriteLine($"Age: {animal.Age} years old");
                Console.WriteLine($"it has {animal.LegCount}legs");
                Console.WriteLine($"It lives by {animal.LandSeaAir}");
                Console.WriteLine($"");


            }


           
        }
    }
}
