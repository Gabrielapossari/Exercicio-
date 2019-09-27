using System;

namespace Mcbonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Gabriela","55 11 3254 6576","Gabrielapossari@hotmail.com"); //Criando o objeto 
            Console.WriteLine("Nome : " + cliente1.Nome);
            Console.WriteLine("Telefone : "+ cliente1.Telefone);
            Console.WriteLine("Email : "+ cliente1.Email);
        }
    }
}
