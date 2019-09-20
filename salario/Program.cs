using System;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario1; 
            double salario2;
         
        
            Console.Write("Qual é o seu salário ?");
            salario1 = double.Parse(Console.ReadLine());

            salario2=1.3*salario1;

            if ( salario1 < 500) {
            Console.WriteLine("Haverá um reajuste no seu salário de 30%");
            Console.WriteLine("Seu salario agora é " + salario2);
            } else { 
            Console.WriteLine("Não possui direito de reajuste ");
            }
       
        }
    }
}
