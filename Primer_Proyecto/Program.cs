int Edad, EdadMeses;
﻿String Nombre;
Console.WriteLine("Bienvenidos a nuestro sistema");
Console.WriteLine("Ingrese su nombre para continuar");
Nombre = Console.WriteLine();
Console.WriteLine("Ingrese su Edad");
Edad = Convert.ToInt32(Console.ReadLine);
EdadMeses = Edad * 12;
Console.WriteLine("La edad de meses es: ", EdadMeses);
