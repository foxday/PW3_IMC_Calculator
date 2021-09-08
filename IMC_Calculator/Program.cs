//using IMC_CalculatorLogic;
using LogicClass;
using System;

namespace IMC_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su estatura en cm: ");
            int height = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese su peso en kg: ");
            int weight = Int32.Parse(Console.ReadLine());

            double imc = Logica.CalculateIMC(weight, height);
            Console.WriteLine("\nSu IMC es: " + imc);
            Console.WriteLine("\nDetalle: \n" + Logica.ShowIMCDetails(imc));
        }
    }
}
