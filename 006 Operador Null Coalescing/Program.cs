
string a = "Hola";
string b = null;
string r = "";

//Si la variable no es null conserva su valor
r = a ?? "Adios";
Console.WriteLine(r);//Hola

//Si la variable es null recibe el valor dado
r = b ?? "Adios";
Console.WriteLine(r);//Adios


//Nuevo de C#8 
//Asignacion Null-Coalescing

//Asinga a la variable solo si es null
b = null;

a ??= "No tenia null";
b ??= "Tenia null";

Console.WriteLine(a);//No tenia null
Console.WriteLine(b);//Tenia null
