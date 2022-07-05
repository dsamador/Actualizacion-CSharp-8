
int[] arreglo = new int[] { 1, 2, 3, 4, 5 };

int ultimo = arreglo[^1];
int penultimo = arreglo[^2];
Console.WriteLine($"Ultimo: {ultimo} y penultimo: {penultimo}");

int[] primeros = arreglo[..2];// Sin tomar el índice 2
int[] ultimos = arreglo[3..];//Del inice 3 en adelante
int[] intermedios = arreglo[2..4];//No toma el indice 4


Console.WriteLine($"Primeros" );//1,2
foreach (int i in primeros) Console.WriteLine($"{i}");

Console.WriteLine($"Ultimos" );//4,5
foreach (int i in ultimos) Console.WriteLine($"{i}");

Console.WriteLine($"Intermedios" );//3,4
foreach (int i in intermedios) Console.WriteLine($"{i}");

