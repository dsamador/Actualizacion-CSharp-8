using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Uso_de_base
{
    public class ClaseHija : ClaseBase
    {
        public override void Saludo()
        {
            Console.WriteLine("Saludos desde clase hija");
        }

        public void Seleccion(int opcion)
        {
            //Invocamos nuestra version de la funcion
            if (opcion == 1)
                Saludo();

            //Version de la clase base
            if(opcion == 2)
                base.Saludo();
        }
    }
}
