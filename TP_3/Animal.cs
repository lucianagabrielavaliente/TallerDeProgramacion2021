using System;

namespace Ejercicio_1
{
    public abstract class Animal
    {
        public abstract void HacerRuido();
        
        public void Saltar()
        {
            Console.WriteLine("Saltando");
        }
        public void Correr()
        {
            Console.WriteLine("Corriendo");
        }
    }
}
