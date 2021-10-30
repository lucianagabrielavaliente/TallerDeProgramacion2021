using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    public class Veterinaria
    {
        public void AceptarAnimales(List<Animal>pAnimales)
        {
            foreach (var animal in pAnimales)
            {
                animal.Correr();
                animal.Saltar();
                animal.HacerRuido();
            }
        }
    }
}
