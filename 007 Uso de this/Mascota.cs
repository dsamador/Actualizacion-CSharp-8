namespace _007_Uso_de_this
{
    public class Mascota
    {
        //Version de default
        //Si colocamos la invocacion al otro constructor
        //se invoca primero el de parametro y luego el de 
        //default. El de default pondra sus propios valores
        //sin importar los colocados por el de parametros.

        public string nombre = "Sin nombre";

        public Mascota():this("Manchas")
        {
            Console.WriteLine("Constructor de default");
            //Esta version puede sobreescribir un valor
            //que ya hayamos asignado a alguna de las variables
            nombre = "Roper";
        }

        public Mascota(string nombre)
        {
            Console.WriteLine("Constructor con parametro");
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return $"Tu mascota se llama {nombre}"; 
        }//10:06
    }
}
