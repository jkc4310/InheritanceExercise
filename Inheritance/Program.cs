﻿using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // DONE - Create a class Animal
            // DONE - give this class 4 members that all Animals have in common


            // DONE - Create a class Bird
            // DONE - give this class 4 members that are specific to Bird
            // DONE - Set this class to inherit from your Animal Class

            // DONE - Create a class Reptile
            // DONE - give this class 4 members that are specific to Reptile
            // DONE - Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *
             * Creatively display the class member values 
             */


            var myBird = new Bird();
            myBird.Extinct = false;
            myBird.CanFly = true;
            myBird.Migrate = true;
            myBird.WingColor = "Blue";


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var myReptile = new Reptile()
            {
               Nocturnal = true,
               HasATail = true,
               IsColdBlooded = true,
               Habitat = "Amphibious"
            };

            var myAnimals = new Animal[] { myBird, myReptile };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Extinct: {animal.Extinct}");
                Console.WriteLine($"Legs: {animal.Legs}");
                Console.WriteLine($"Tail: {animal.Tail}");
                Console.WriteLine($"Habitat: {animal.LandSeaAir}");
                Console.WriteLine($"");

            }
            
        }
    }
}
