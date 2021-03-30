using System;

namespace validarNotasDion
{
    class Program
    {
        static void Main()
        {

            float nota_1;
            float nota_2;

            float mediaSem;

        inicio: //rótulo

            Console.Write("Digite a primeira nota: ");

            nota_1 = float.Parse(Console.ReadLine());

            while (nota_1 < 0 || nota_1 > 10)

            {
                Console.WriteLine("nota invalida");
                Console.Write("Digite a primeira nota: ");
                nota_1 = float.Parse(Console.ReadLine());
            }

            Console.Write("Digite a segunda nota: ");

            nota_2 = float.Parse(Console.ReadLine());

            while (nota_2 < 0 || nota_2 > 10)

            {
                Console.WriteLine("nota invalida");
                Console.Write("Digite a segunda nota: ");
                nota_2 = float.Parse(Console.ReadLine());

            }

            mediaSem = (nota_1 + nota_2) / 2;
            Console.WriteLine("media = {0}", mediaSem);

            Console.WriteLine();

        final: // rotulo defaul

            Console.WriteLine("novo calculo (1-sim 2-nao)");


            int x = int.Parse(Console.ReadLine());


            switch (x)
            {
                case 1:
                    goto inicio;


                case 2:
                    Console.Clear();
                    Console.WriteLine("----------------");
                    Console.WriteLine("Fim de programa!");
                    Console.WriteLine("----------------");
                    Console.ReadKey();
                    break;

                default:
                    goto final;

            }


        }

     }
    
 }

