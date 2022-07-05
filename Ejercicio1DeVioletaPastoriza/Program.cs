using System;

namespace Ejercicio1DeVioletaPastoriza
{
    class Program
    {
        static void Main(string[] args)
        {
            double pesos;
            double dolares;
            double euros;
            Console.Title = "Convertir pesos a dólares y euros";
            Console.Write("Ingrese el monto en pesos:");
            pesos = double.Parse(Console.ReadLine());
            dolares = pesos/230;
            Console.Write($"Con ese monto se pueden comprar {dolares} dolares.");
            euros = (dolares/1.17);
            Console.Write($" Eso equivale a {euros} euros");
        }
    }
}
