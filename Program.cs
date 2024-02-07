using System;

namespace Exercici7OOP
{
    public class Program
    {
        public static void Main()
        {
            Turtle turtle = new Turtle(true, 20, 8, "Mortadelo");
            turtle.GetTurtleInfo();
            Console.WriteLine();
            Wolf wolf = new Wolf("Gris", 15, 80, "CarlesCapel AKA: el lobo");
            wolf.GetWolfInfo();
            Console.WriteLine();
            Iguana iguana = new Iguana(40, "Amblyrhynchus", 45, "Raquel AKA: la iguana");
            iguana.GetIguanaInfo();
            Console.WriteLine();


        }

    }
}