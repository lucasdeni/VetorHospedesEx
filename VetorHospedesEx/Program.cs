using System;
using System.Globalization;

namespace VetorHospedesEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospedes[] vect = new Hospedes[10]; //Array com o número de hospedes
            Console.Write("Quantos quartos serão alugados? "); //Entrada do usuário da quantidade de hospedes
            int n = int.Parse(Console.ReadLine());
            while (n > 10) //Verificação do número dos quartos entre 1 a 10
            {
                Console.Write("Digite os números dos quartos serão alugados entre 1 a 10: ");
                n = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++) //For para entrar com o nome, email e quarto
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i+1}: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quartos: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Hospedes(nome, email);

            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: "); //Demonstração dos quartos ocupados
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
