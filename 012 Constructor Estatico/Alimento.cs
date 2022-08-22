using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Constructor_Estatico
{
    public class Alimento
    {
        private int calorias;

        //El constructor estatico se ejecuta solo una vez para todas las
        //instancias
        static Alimento()
        {
            Console.WriteLine("Desde el constructor de Alimento");
        }

        public int Calorias
        {
            set { calorias = value; }
        }

        public override string ToString()
        {
            return $"Tienes {calorias}";
        }
    }
}
