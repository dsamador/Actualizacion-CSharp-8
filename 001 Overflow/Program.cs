
int n = 1000000;
int m = 1000000;

//Genera overflow, pero no nos enteramos
int r = n  * m;
Console.WriteLine(r);
Console.WriteLine("-------");

//Recibimos notificacion del overflow
//int r2 = checked(n * m);
//Console.WriteLine(r2);
//Console.WriteLine("-------");

//Ahora capturamos la excepcion
int r3 = 0;
int r4 = 0;

try
{
    //podemos tener un bloque donde se
    //verifican todas la operaciones que
    //causan overflow
    checked
    {
        r3 = n * m;
        r4 = n + m;
    }
}
catch 
{

    Console.WriteLine("Problema de overflow");
}