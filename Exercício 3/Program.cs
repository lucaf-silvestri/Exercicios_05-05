using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool nomeCerto = false;

            do
            {
                Console.WriteLine("\n" + "Digite seu nome.");
                string nome = Console.ReadLine();

                if (nome == "")
                {
                    Console.WriteLine("Seu nome não foi digitado.");
                }

                else
                {
                    Console.WriteLine("\n" + "Seu nome é válido.");
                    nomeCerto = true;
                }
            } while (nomeCerto == false);

            bool idadeCerta = false;

            do
            {
                Console.WriteLine("\n" + "Digite sua idade.");
                int idade = int.Parse(Console.ReadLine());

                if (idade > 150)
                {
                    Console.WriteLine("\n" + "Sua idade não é válida.");
                }

                else if (idade < 0)
                {
                    Console.WriteLine("\n" + "Sua idade não é válida.");
                }

                else
                {
                    Console.WriteLine("\n" + "Sua idade é válida.");
                    idadeCerta = true;
                }

            } while (idadeCerta == false);

            bool salarioCerto = false;

            do
            {
                Console.WriteLine("\n" + "Digite seu salário.");
                int salario = int.Parse(Console.ReadLine());

                if (salario > 0)
                {
                    Console.WriteLine("\n" + "Seu salário é válido.");
                    salarioCerto = true;
                }

                else
                {
                    Console.WriteLine("\n" + "Seu salário não é válido.");
                }

            } while (salarioCerto == false);

            bool estadoCerto = false;

            do
            {
                Console.WriteLine("\n" + "Digite seu estado civil:" + "\n" + "Digite S se for solteiro(a), C se for casado(a), V se for viúvo(a) ou D se for divorciado(a).");
                string estadocivil = (Console.ReadLine());

                switch (estadocivil)
                {
                    case "S":
                        Console.WriteLine("\n" + "Seu estado civil é válido" + "\n");
                        estadoCerto = true;
                        break;

                    case "C":
                        Console.WriteLine("\n" + "Seu estado civil é válido" + "\n");
                        estadoCerto = true;
                        break;

                    case "V":
                        Console.WriteLine("\n" + "Seu estado civil é válido" + "\n");
                        estadoCerto = true;
                        break;

                    case "D":
                        Console.WriteLine("\n" + "Seu estado civil é válido" + "\n");
                        estadoCerto = true;
                        break;

                    case "s":
                        Console.WriteLine("\n" + "Seu estado civil é válido" + "\n");
                        estadoCerto = true;
                        break;

                    case "c":
                        Console.WriteLine("\n" + "Seu estado civil é válido" + "\n");
                        estadoCerto = true;
                        break;

                    case "v":
                        Console.WriteLine("\n" + "Seu estado civil é válido" + "\n");
                        estadoCerto = true;
                        break;

                    case "d":
                        Console.WriteLine("\n" + "Seu estado civil é válido" + "\n");
                        estadoCerto = true;
                        break;

                    default:
                        Console.WriteLine("\n" + "Seu estado civil não é válido");
                        break;
                }

            } while (estadoCerto == false);

            Console.WriteLine ("Fim da Execução\n");
        }
    }
}
