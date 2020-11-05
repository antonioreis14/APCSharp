/*
 * Memorizar 6.6
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                Console.WriteLine("Insira um numero:");
                int numero = Convert.ToInt32(Console.ReadLine());
                int soma=0;
                if (numero != 0)
                    soma =soma + numero;
            } while (numero != 0);
            Console.WriteLine("A soma dos numeros e {0}.", soma);
        }
    }
}
