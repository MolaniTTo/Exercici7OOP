using System;


namespace Exercici7OOP
{
    public class Iguana : Animal
    {
        private int age;
        private string type;

        public int Age { get { return age; } set { age = value; } }
        public string Type { get { return type; } set { type = value; } }

        public Iguana(int age, string type, int peso, string name) : base (peso, name)  
        {
            Age= age;
            Type = type;
        }

        public void GetIguanaInfo()
        {
            Console.WriteLine($"Edad:{Age}, Tipo:{Type}, Peso:{Peso}kg, Nombre:{Name}");
        }





    }
}
