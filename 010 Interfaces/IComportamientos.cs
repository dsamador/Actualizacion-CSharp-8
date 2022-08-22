using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Interfaces
{
    //Ya puede existir una implementacion de default
    //Es util si deseamos adicionar un miembro a una interfaz
    //sin mal afectar a las implementaciones ya realizadas
    //Las implementaciones de default son siempre explicitas.
    interface IComportamientos
    {
        void Mostrar()
        {
            Console.WriteLine("Implementacion de default");
        }

        //Ahora tambien podemos definir campos estaticos
        //Pertenece a la interfaz, no a las clases

        static int valor = 5;

    }
}
