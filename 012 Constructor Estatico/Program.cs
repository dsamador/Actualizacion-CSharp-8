using _012_Constructor_Estatico;


Mascota perro = new Mascota("Manchas");
Mascota gato = new Mascota("Michi");
Mascota pez = new Mascota("Nemo");

Console.WriteLine(perro);
Console.WriteLine(gato);
Console.WriteLine(pez);

Console.WriteLine("----------");

//Constructor estatico
Alimento pan = new Alimento();
Alimento leche = new Alimento();

pan.Calorias = 50;
leche.Calorias = 75;

Console.WriteLine(pan);
Console.WriteLine(leche);