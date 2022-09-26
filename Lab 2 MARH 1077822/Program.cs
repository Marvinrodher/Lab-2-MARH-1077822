// See https://aka.ms/new-console-template for more information
int dia = 0;

Console.WriteLine("EJERCICIO 2");
Console.WriteLine("Dia");
Console.WriteLine("Ingrese numero de dia");

dia = Convert.ToInt32(Console.ReadLine());
if (dia == 1)
{
    Console.WriteLine("Lunes");
}
else if (dia == 2)
{
    Console.WriteLine("Martes");
}
else if (dia == 3)
{
    Console.WriteLine("Miercoles");
}
else if (dia == 4)
{
    Console.WriteLine("Jueves");
}
else if (dia == 5)
{
    Console.WriteLine("Viernes");
}
else if (dia == 6)
{
    Console.WriteLine("Sabado");
}
else if (dia == 7)
{
    Console.WriteLine("Domingo");
}
else if (dia <= 0)
{
    Console.WriteLine("Error, El numero a ingresar debe estar contenido entre 1 y 7");
}
else if (dia > 7)
{
    Console.WriteLine("Error, El numero a ingresar debe estar contenido entre 1 y 7");
}


