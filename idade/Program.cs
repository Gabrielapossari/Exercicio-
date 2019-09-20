using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, soma;


            Console.Write("Entre na primeira nota:");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Entre na segunda nota:");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Entre na terceira nota:");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("Entre na quarta nota:");
            nota4 = double.Parse(Console.ReadLine());

            soma = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.Write("A media é:" + soma);

            if ( soma >= 7) {
                Console.WriteLine("Parabéns!Aprovado");
            } else { 
            Console.WriteLine("Reprovado");
            }

            
        }
    }
}
