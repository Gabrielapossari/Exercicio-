using System;

namespace aula
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int [] vetor = new int[] { 1, 2, 3, 4, 5 ,6 };

            for (int i=0;i<6;i++){
             if  (vetor[i] % 2 == 0)  {
                 Console.WriteLine("Seu número é par");
           
            } else { 
                 Console.WriteLine("Seu número é impar");
            }

            }

        }
    }
}
