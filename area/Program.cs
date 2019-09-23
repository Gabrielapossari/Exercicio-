using System;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            string  numero;
            double lado;
            double altura;
            
            double raio;
            double grande;
            double pequeno;
            double altur; 
            double diagnalg;
            double diagonalp;
            double ladod;
            double ladob;
            double Base;


            
            do {

            Console.Write("Qual é a figura desejada? ");

            numero = Console.ReadLine();




            switch(numero) {
                    case "Quadrado":
                         Console.WriteLine("Qual o lado do quadrado?");
                         lado = double.Parse(Console.ReadLine());
                         Console.WriteLine(lado*lado);
                         break;
                    case "Triângulo":
                         Console.WriteLine("Qual é a altura do triangulo?");
                         altura = double.Parse(Console.ReadLine());
                          Console.WriteLine("Qual é a base do triangulo?");
                          Base  =  double.Parse(Console.ReadLine());
                          Console.WriteLine((altura*Base) / 2 );
                          break;
                    case "Círculo": 
                        Console.WriteLine("Qual é o raio do circulo?");
                        raio = double.Parse(Console.ReadLine());
                        Console.WriteLine(raio * raio * 3.14);
                        break;
                    case "Trapézio":
                         Console.WriteLine("Qual é a base maior?");
                         grande = double.Parse(Console.ReadLine());
                         Console.WriteLine("Qual é a base menor?");
                         pequeno = double.Parse(Console.ReadLine());
                         Console.WriteLine("Qual é a altura ?");
                         altur = double.Parse(Console.ReadLine());

                        Console.WriteLine((grande + pequeno) * altur / 2 );
                        break;
                    case "Losango":
                         Console.WriteLine("Qual é a  diagonal maior?");
                         diagnalg = double.Parse(Console.ReadLine());
                         Console.WriteLine("Qual é a diagonal menor?");
                         diagonalp = double.Parse(Console.ReadLine());
                        

                        Console.WriteLine((diagnalg + diagonalp) / 2 );
                        break;
                     case "Retangulo":
                         Console.WriteLine("Qual é o lado maior?");
                         ladob = double.Parse(Console.ReadLine());
                         Console.WriteLine("Qual é o lado menor?");
                         ladod = double.Parse(Console.ReadLine());
                      

                        Console.WriteLine((ladob * ladod) / 2 );
                        break;
         
                     default: 
                     Console.WriteLine("Operação não reconhecida");
                     break;
            }
        
            }while ( numero != "f");
        }
    }
}
