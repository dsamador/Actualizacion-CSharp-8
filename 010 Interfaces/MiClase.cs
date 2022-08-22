using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Interfaces
{
    public class MiClase : IComportamientos
    {
        //Asi por defecto no hay error si no implementamos el codigo

        public void Calcula()
        {
            Console.WriteLine( $"5 + 5 es =  {5 + IComportamientos.valor}");
        }
    }
}
