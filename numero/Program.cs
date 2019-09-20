using System;

namespace numero
{
    class Program
    {
        static void Main(string[] args)
        {   
            double numero; 
        
             do {
            Console.Write("Escreva um número!");
            numero = double.Parse(Console.ReadLine());

            if (numero !=0) {
            if  (numero % 2 == 0)  {
            Console.WriteLine("Seu número é par");
           
            } else { 
            Console.WriteLine("Seu número é impar");
            }
            
            }
            
            } while (numero !=0);

        }
    }
}
