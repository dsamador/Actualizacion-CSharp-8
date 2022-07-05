
string dia = "";
int numero = 3;
string horario = "diurno";

dia = numero switch
{
    1 => "Domingo",
    2 => "Lunes",
    3 => "Martes",
    4 => "Miercoles",
    5 => "Jueves",
    6 => "Viernes",
    7 => "Sabado",
    _ => "Numero invalido",
};

Console.WriteLine(dia);//Martes

dia = (numero, horario) switch
{
    (2, "diurno") => "Laboral",
    (3, "diurno") => "Laboral",
    (3, "nocturno") => "Laboral",
    _ => "Datos invalidos"
};

Console.WriteLine(dia);//Laboral

