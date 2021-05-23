using System;

namespace exercicios_C_Sharp.exercicios
{
    public class Produto
    {
        static void Main(string[] args)
        {   
            double Num1,
                   Num2,
                   Mult; 
            
            Console.Write("Digite o primeiro número! ");
            Num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número! ");
            Num2 = double.Parse(Console.ReadLine());

            Mult = Num1 * Num2;

            Console.WriteLine($"A multiplicação de {Num1} por {Num2} é {Mult}");
        }
    }
}