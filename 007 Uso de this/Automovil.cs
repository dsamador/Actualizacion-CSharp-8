using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Uso_de_this
{
    internal class Automovil
    {
        private string modelo = "Ninguno asignado";

        //Primer uso
        //Usamos this para quitar la ambiguedad entre el nombre del 
        //parametro y el atributo
        public Automovil(string modelo)
        {
            //Aqui aparece una ambiguedad para quien lea el codigo
            //la computadora hace referencia al parametro del constructor
            //modelo = "4";

            //Ahora indicamos que usamos el atributo
            //this es una autorreferencia al objeto que esta ejecutando el codigo
            //this.modelo = "Corsa";
            this.modelo = modelo;

        }
        public override string ToString()        
            => string.Format($"Tu auto es {modelo}");//4:12
        
    }
}
