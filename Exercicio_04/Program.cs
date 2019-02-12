using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desenvolva um algoritmo que solicite a entrada da idade de um determinado usuário, se for menor que 18 anos exiba na cor vermelha “Sem permissão”, caso seja maior ou igual a 18 anos exiba na cor verde “Permissão concedida”.

            processar();
            Console.ReadKey();
        }

        private static void processar()
        {
            int idade;
            Console.Write("Digite sua idade ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem permissão");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Permissão concedida");
            }
        }
    }
}
