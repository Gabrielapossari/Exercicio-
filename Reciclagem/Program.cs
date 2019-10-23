using System;
using Reciclagem.Models;
using interface.ILixo;

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
                    Garrafa garrafa = new Garrafa ("Garrafa","Verde");
                        break;
                    case 2:
                    GarrafaPET garrafaPET = new GarrafaPET ("GarrafaPET","Vermelho");
                        break;
                    case 3:
                    GuardaChuva guardaChuva = new GuardaChuva ("Guarda Chuva","Amarelo");
                        break;
                    case 4:
                    Papelao papelao = new Papelao ("Papelao","Azul");
                        break;
                    case 5:
                    Latinha latinha = new Latinha ("Latinha","Amarelo");
                        break;
                    case 6:
                    PoteManteiga poteManteiga = new PoteManteiga ("Pote de manteiga","Vermelho");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        Console.ReadLine();
                        break;
                }
            
            }
    }
    
}

