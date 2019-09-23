using System;

namespace nascimento
{
    class Program
    {
        static void Main(string[] args)
        {
           
           double  ano;
           double idade;

             
            Console.Write("Que ano voce nasceu?");
            ano = double.Parse(Console.ReadLine());

            idade = 2019 - ano;

        
            if ( 0 >= idade && idade <= 2 ) {
                Console.WriteLine("Récem-Nascido");
            } 
            else if ( 0 <= idade && idade <= 2 ) { 
            Console.WriteLine("Récem Nascido");
            }
            else if (3 <= idade && idade <=11 ) {
                Console.WriteLine("Criança");
            }
            else if ( 12 <= idade && idade <=19 ) {
                Console.WriteLine("Adolecente");
            }
            else if (20 <= idade && idade <=65 ) {
                Console.WriteLine("Adulto");
            }
            else if ( idade>=60  ) {
                Console.WriteLine("Idoso");
            }
           


            }
        }
    }

