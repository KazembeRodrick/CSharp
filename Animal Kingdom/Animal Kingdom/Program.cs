using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Kingdom
{
    class Program // canis familiaris
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            Console.Write("The " + animal.name + " belongs to the " + animal.family + " family. It eats " + animal.food);
            
            animal.name = "Dog";
            animal.family = "canis familiaris";
            animal.food = "Meat";

            Console.Write("\nThe " + animal.name + " belongs to the " + animal.family + " family. It eats " + animal.food);

            Console.ReadLine();
        }
    }
}
