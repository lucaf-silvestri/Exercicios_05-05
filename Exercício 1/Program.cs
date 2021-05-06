using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resposta = false;
            do{
                Console.WriteLine ("\n"+"Digite um número entre 0 e 10: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > 10){
                    Console.WriteLine ("\n"+"Esse não é um número entre 0 e 10!");
                }

                else if (numero < 0){
                    Console.WriteLine ("\n"+"Esse não é um número entre 0 e 10!");
                }

                else{
                    Console.WriteLine ("\n"+"Número válido");
                    Console.WriteLine ("Fim da Execução \n");
                    resposta = true;
                }
                
            } while (resposta == false);
        }
    }
}
