using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Constructor_Estatico
{
    public class Mascota
    {
        protected string nombre;

        public Mascota()
        {

        }

        public Mascota(string nombre)        {
            this.nombre = nombre;
            Console.WriteLine("Desde el constructor de Mascota");
        }

        public override string ToString()
        {
            return $"Mi mascota es {nombre}";
        }

    }
}
