using Tarea_3.Entidades;
using Tarea_3.Negocio;

Numero Numero = new Numero();
ClsNumero clsnumero = new ClsNumero();

Console.WriteLine("Ingrese el numero menor");
Numero.NumeroMinimo = int.Parse(Console.ReadLine());


Console.WriteLine("Ingrese el numero mayor");
Numero.NumeroMaximo = int.Parse(Console.ReadLine());
clsnumero.ImprimirPares(Numero);