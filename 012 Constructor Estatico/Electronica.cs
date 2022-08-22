using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Constructor_Estatico
{
    public class Electronica : Mascota
    {
        //Usamos new para indicarle al compilador que
        //el ocultamiento no es accidental
        private new string nombre;

        public string Nombre
        {
            set { nombre = value; }
        }
    }
}
