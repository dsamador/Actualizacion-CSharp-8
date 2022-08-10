
//Podemos usar base para invocar la version (de la clase base)
// de un metodo que ha tenido override

using _009_Uso_de_base;

ClaseBase claseBase = new ClaseBase();

claseBase.Saludo();
Console.WriteLine("------");

ClaseHija claseHija = new ClaseHija();

claseHija.Saludo();
Console.WriteLine("------");

claseHija.Seleccion(1);
claseHija.Seleccion(2);