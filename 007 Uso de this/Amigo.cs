
namespace _007_Uso_de_this
{
    public class Amigo
    {
        public string Nombre { get; set; }
        public string Whats { get; set; }

        public Amigo(string nombre, string whats)
        {
            Nombre = nombre;
            Whats = whats;
        }

        public override string ToString()
        {
            return $"Mi amigo {Nombre} tiene un tel: {Whats}";
        }

        //Cuarto caso
        //Nos mandamos a nosotros mismos como parametro
        //para que quien nos reciba trabaje con nosotros
        public void Mensajear()
        {
            Mensajes mensajes = new Mensajes();
            mensajes.Presentar(this);
        }
    }

}