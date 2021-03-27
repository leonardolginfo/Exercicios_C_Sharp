using System;

namespace GotoCidade
{
    class Program
    {

       
        static void Main(string[] args)
        {

            string nome;
            char escolha;

            Console.Write("Olá! Qual é seu nome? ");
            Console.WriteLine();
            nome = Console.ReadLine();
            Console.WriteLine();

            inicio: //Rótulo para o GoTo

            Console.Clear();

            Console.Write("Olá {0}! Estou a disposição para ajudar na esolha da capital, vamos lá ?", nome);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Você gostaria de qual é a capital de qual estado:");
            Console.WriteLine();
            Console.WriteLine("[P]- Piauí  | [M]- Maranhão  |  [C] - Ceará ");

            escolha = char.Parse(Console.ReadLine().ToUpper());
             
            switch (escolha)
                {
                case 'P':
                    Console.WriteLine("A capital do Piauí é Teresina.");
                    break;
                case 'M':
                    Console.WriteLine("A capital do Maranhão é São Luiz.");
                    break;
                case 'C':
                    Console.WriteLine("A capital do Ceará é Fortaleza.");
                    break;
                default:
                    Console.WriteLine("Você não digitou uma opção válida!");
                    break;
                }
            Console.WriteLine("Você deseja conhecer outra capital? [S/N] ");
            escolha = char.Parse(Console.ReadLine().ToUpper());

            if (escolha == 'S')
            {
                goto inicio;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("----------------");
                Console.WriteLine("Fim de programa!");
                Console.WriteLine("----------------");
                Console.ReadKey();

            }
        }
    }
}
