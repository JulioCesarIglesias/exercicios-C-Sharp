using System;

namespace exercicios_C_Sharp.exercicios
{
    public class CalculoHipotenusa
    {
        static void Main(string[] args)
        {   
            int Cat1,
                Cat2,
                Hipo;             
            
            Console.Write("Digite o valor do primeiro Cateto! ");
            Cat1 = Math.Abs(int.Parse(Console.ReadLine()));

            Console.Write("Digite o valor do segundo Cateto! ");
            Cat2 = Math.Abs(int.Parse(Console.ReadLine()));

            Hipo = (int)Math.Sqrt(Math.Pow(Cat1, 2) + Math.Pow(Cat2, 2));

            Console.WriteLine($"Valor da hipotenusa: {Hipo}");
        }
    }
}