using System;

namespace Exercici7OOP
{
    public class Wolf : Animal
    {
        private string color;
        private int age;

        public string Color { get { return color; } set {  color = value; } }
        public int Age { get { return age; } set { age = value; } }

        public Wolf(string color, int age, int peso, string name) : base(peso, name)
        {
            Color=color;
            Age = age;
        }

        public void GetWolfInfo()
        {
            Console.WriteLine($"Edad:{Age}, Color:{Color}, Peso:{Peso}kg, Nombre:{Name}");
        }





    }
}
