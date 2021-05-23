using System;

namespace exercicios_C_Sharp.exercicios
{
    public class AreaRetangulo
    {
        static void Main(string[] args)
        {   
            double Lado1,
                   Lado2,
                   Area;             
            
            Console.Write("Digite o valor do primeiro lado! ");
            Lado1 = Math.Abs(double.Parse(Console.ReadLine()));

            Console.Write("Digite o valor do segundo lado! ");
            Lado2 = Math.Abs(double.Parse(Console.ReadLine()));

            Area = Lado1 * Lado2;

            Console.WriteLine($"A area do  retângulo é: {Area}");
        }
    }
}