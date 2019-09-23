using System;

namespace ususario
{
    class Program
    {
        static void Main(string[] args)
        {
            string login,senha;
            string admin = "admin";
        
            Console.Write("Qual é o seu Login? ");
            login = Console.ReadLine();

            
            Console.Write("Qual é a sua senha?");
            senha = Console.ReadLine();


            if (  login==admin && senha==admin  ) {
            Console.WriteLine("Você é o admin");

            } 

            else  {

            Console.WriteLine("Voce é um usuario ");
            
            }


        }
    }
}
