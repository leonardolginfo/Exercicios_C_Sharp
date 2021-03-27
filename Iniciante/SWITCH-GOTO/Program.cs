using System;

namespace cursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3, nota4, res;
            
                    
                      
            Console.Write("Digite a nota do aluno...: ");

            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nota 1 :" + nota1);

            Console.Write("Digite a nota do aluno...: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nota 2 :" + nota2);

            Console.Write("Digite a nota do aluno...: ");
            nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nota 3 :" + nota3);

            Console.Write("Digite a nota do aluno...: ");
            nota4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nota 4 :" + nota4);

            res = nota1 + nota2 + nota3 + nota4;
            float media = res / 4;

          
            
            if (media >=70)
                {
                    Console.WriteLine("O aluno está com média {0} e seu status é de APROVADO", media);
                }else if(media >= 5)
                {
                Console.WriteLine("O aluno está com média {0} e seu status é de recuperação", media);
            }
            else
            {
                Console.WriteLine ("O aluno está com média {0} e seu status é de reprovado", media);
            }

                    }
    }
}
