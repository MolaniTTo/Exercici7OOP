using System;


namespace Exercici7OOP
{
    public abstract class Animal
    {
        private int peso;
        private string name;

        public int Peso { get { return peso; } set {  peso = value; } }
        public string Name { get { return name; } set { name = value; } }

        public Animal(int peso, string name)
        {
            Peso = peso;
            Name = name;
        }
    }
}
