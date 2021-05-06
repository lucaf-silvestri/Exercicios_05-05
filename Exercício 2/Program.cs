using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool senhaCerta = false;

            do
            {
                Console.WriteLine("\n" + "Digite seu nome.");
                string nome = Console.ReadLine();
                Console.WriteLine("\n" + "Digite sua senha.");
                string senha = Console.ReadLine();

                if (senha == nome)
                {
                    Console.WriteLine("\n" + "Sua senha deve ser diferente do seu nome.");
                }

                else
                {
                    Console.WriteLine("\n" + "Seu nome e senha são válidos.");
                    Console.WriteLine("\n" + "Fim da Execução.");
                    senhaCerta = true;
                }
            } while (senhaCerta == false);
        }
    }
}
