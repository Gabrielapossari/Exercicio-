using System;

namespace ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Cadastro de clientes");
            System.Console.WriteLine("Aperte ENTER para prosseguir!");
            Console.ReadLine();

            
            System.Console.WriteLine("Titulo:");
            string titular = Console.ReadLine();
            
            System.Console.Write("Agencia:");
            int agencia = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Número: ");
            int numero = int.Parse(Console.ReadLine());



            bool saldoValido = false;
            
            do{
            System.Console.WriteLine("Saldo: ");
            double Saldo = double.Parse(Console.ReadLine());

            if (Saldo >= 0){
                ContaCorrente cliente01 = new ContaCorrente ( titular, agencia ,numero);
                saldoValido = true;
                System.Console.WriteLine("Cliente cadastrado!");
                
            }else {
            
                System.Console.WriteLine("Não é possivel realizar o cadastro!");
            }
            
            }while(!saldoValido);
            
        }
    }
}    
