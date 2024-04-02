using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // DONE Create a class Animal
            // give this class 4 members that all Animals have in common


            // DONE Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // DONE Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /* DONE Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var myBird = new Bird();
            myBird.Flightless = true;
            myBird.BeakLength = 3.14;
            myBird.Migratory = true;
            myBird.Coloration = "Blue";

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var myReptile = new Reptile()
            {
                Venomous = true,
                TailLength = 2.72,
                AliveMYA = 1,
                CanSwim = true,
            };

            var Zoo = new Animal[] {myBird , myReptile};
            foreach (var z in Zoo)
            {
                Console.WriteLine($"Is exstinct: {z.Extinct}");
                Console.WriteLine($"has {z.LegCount} legs" );
                Console.WriteLine($"Lives in {z.Habbitat}");
                Console.WriteLine($"Eats {z.Diet}");
                Console.WriteLine(" ");
            }
        }
    }
}
