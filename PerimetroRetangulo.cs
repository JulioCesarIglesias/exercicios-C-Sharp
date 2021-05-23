using System;

namespace exercicios_C_Sharp.exercicios
{
    public class PerimetroRetangulo
    {
        static void Main(string[] args)
        {   
            double Lado1,
                   Lado2,
                   Perimetro;             
            
            Console.Write("Digite o valor do primeiro lado! ");
            Lado1 = Math.Abs(double.Parse(Console.ReadLine()));

            Console.Write("Digite o valor do segundo lado! ");
            Lado2 = Math.Abs(double.Parse(Console.ReadLine()));

            Perimetro = 2 * Lado1 + 2 * Lado2;

            Console.WriteLine($"O Perimetro do  retângulo é: {Perimetro}");
        }
    }
}