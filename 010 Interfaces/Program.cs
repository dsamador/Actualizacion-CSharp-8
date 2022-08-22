

using _010_Interfaces;

MiClase miClase = new MiClase();

//Invocamos la implementacion de default

//miClase.Mostrar();// Da error, tiene que ser asi -> 

((IComportamientos)miClase).Mostrar();

miClase.Calcula();
