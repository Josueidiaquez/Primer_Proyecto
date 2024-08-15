
int Edad, EdadMeses;
string ﻿Nombre;
Console.WriteLine("Bienvenidos a nuestro sistema");
Console.WriteLine("Ingrese su nombre para continuar");
Nombre = Console.ReadLine();
Console.WriteLine("Ingrese su Edad");
Edad = Convert.ToInt32(Console.ReadLine);
EdadMeses = Edad * 12;
Console.WriteLine(Nombre + "La edad de meses es: " + EdadMeses + "Meses");
if (EdadMeses > 0) ;
