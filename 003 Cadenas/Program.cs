
//Como usar caracteres unicode codificados como 4
//digitos hexadecimales
char c = '\u00A9';
Console.WriteLine($"{c}");

//Concatenacion con valores numericos
//ToString se invoca automaticamente

Console.WriteLine("El cinco es " + 5);

float a = 3.567891f;

Console.WriteLine("El valor de a " + a);

//Interpolacion de cadena
Console.WriteLine($"El {c} valor de {a} es importante");
