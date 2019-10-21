using System;
using Reciclagem.Models;
namespace Reciclagem
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            
            System.Console.WriteLine("**************************");
            System.Console.WriteLine("    Reciclagem de Lixo    ");
            System.Console.WriteLine("**************************");
            System.Console.WriteLine("1 - Garrafa"); 
            System.Console.WriteLine("2 - GarrafaPET");
            System.Console.WriteLine("3 - GuardaChuva");
            System.Console.WriteLine("4 - Latinha");
            System.Console.WriteLine("5 - Papelão");
            System.Console.WriteLine("6 - Pote de Manteiga");
            System.Console.WriteLine("Digite um número:");
            opcao = int.Parse(Console.ReadLine());

            
            
            switch (opcao){
                    case 1:
                    
                        break;
                    case 2:
                    
                        break;
                    case 3:
                        
                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        Console.ReadLine();
                        break;
                }
            
            }
    }
    
}

