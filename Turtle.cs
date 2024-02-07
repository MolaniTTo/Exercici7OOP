using System;

namespace Exercici7OOP
{
    public class Turtle : Animal
    {
        private bool tortugaNinja;
        private int velocity;

        public bool Tortuganinja { get { return tortugaNinja; } set {  tortugaNinja = value; } }
        public int Velocity { get {  return velocity; } set { velocity = value; } }

        public Turtle (bool tortugaNinja, int velocity, int peso, string name) : base (peso, name)
        {
            Tortuganinja = tortugaNinja;
            Velocity = velocity;
        }

        public void GetTurtleInfo()
        {
            Console.WriteLine($"TortugaNinja:{Tortuganinja}, Velocity:{Velocity}m/s, Peso:{Peso}kg, Nombre:{Name}");
        }



    }
}
