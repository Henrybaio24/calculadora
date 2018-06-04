using System;
 
namespace Calculadora
{
class Program
{
static void Main(string[] args)
{
    Console.WriteLine("Operaciones:\n1) Sumar\n2) Restar\n3) Multiplicar\n5) Raiz Cuadrada");
 
    String opcion = Console.ReadLine();
 
    if (opcion.Equals("1") || opcion.Equals("2") || opcion.Equals("3")  || opcion.Equals("4") || opcion.Equals("5"))
    {
        Calculadora Numeros = new Calculadora();
 
        Console.Write("Ingrese un número : ");
        Numeros.Numero1 = double.Parse(Console.ReadLine());
 
        Console.Write("Ingrese otro número : ");
        Numeros.Numero2 = int.Parse(Console.ReadLine());
 
        if (opcion.Equals("1"))
        {
            Console.WriteLine(Numeros.Sumar());
        }
        if (opcion.Equals("2"))
        {
            Console.WriteLine(Numeros.Restar());
        }
        if (opcion.Equals("3"))
        {       
            Console.WriteLine(Numeros.Multiplicar());
        }
        if (opcion.Equals("4"))
        {
            Console.WriteLine(Numeros.Dividir());
        }
        if (opcion.Equals("5"))
        {
            Console.WriteLine(Numeros.Raiz());
        }
    }
        else
        {
            Console.WriteLine("Opción no válida");
        }
            Console.ReadKey();
}
}
}
