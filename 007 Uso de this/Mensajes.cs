using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Uso_de_this
{
    public class Mensajes
    {
        //Tercer caso
        //Para invocar un metodo de la clase actual
        //Esto se puede simplificar, no es muy util

        public void Saluda()
        {
            Console.WriteLine("Hola a todos");
            this.Despide();
        }

        private void Despide()
        {
            Console.WriteLine("Adios a todos");
        }
    }
}
