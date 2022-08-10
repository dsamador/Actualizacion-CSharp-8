
//Las funciones locales permiten declarar una funcion adentro de otra
// (metodo adentro de otro metodo)
//La funcion local tiene como ambito unicamente a la funcion donde
// fue creada
//Se pueden colocar en: metodos, constructores, propiedades, etc.

string nombre = "Ada";
string puesto = "Programadora senior";

//definimos el metodo local
int ejemplo(int a, int b)
{
    int r = a + b;

    //puede acceder a las variables locales a su clase contenedora
    Console.WriteLine($"Saludos a {nombre}, {puesto}");
    return r;
}

//Uso de la funcion local
Console.WriteLine("Usamos la funcion");
int x = ejemplo(3, 5);
Console.WriteLine($"La funcion regreso {x}");

static int ejemploStatic(int a, int b)
{
    int r = a + b;

    //NO puede acceder a las variables locales a su clase contenedora
    //Console.WriteLine($"Saludos a {nombre}, {puesto}");
    return r;
}