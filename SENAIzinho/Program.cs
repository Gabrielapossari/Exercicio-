using System;
using System.Collections.Generic;
using System.Text;

namespace SENAIzinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int limiteAlunos;
            int limiteSalas;
            Aluno [] alunos = 100;
            Sala [] sala = 10;
            int alunosCadastrados;
            int salasCadastradas;
            bool querSair = false;


            int opcao = 0;
            System.Console.WriteLine("**************************************************");
            System.Console.WriteLine("************** CADASTRO DOS ALUNOS ***************");
            System.Console.WriteLine("**************************************************");
            System.Console.WriteLine("Digite uma opção");
            System.Console.WriteLine("1 - Cadastrar Aluno");
            System.Console.WriteLine("2 - Alocar Aluno");
            System.Console.WriteLine("3 - Remover o aluno");
            System.Console.WriteLine("4 - Verificar Salas ");
            System.Console.WriteLine("5 - Verificar os Alunos");
            System.Console.WriteLine("6 - Sair ");
            opcao = int.Parse(Console.ReadLine());
            
            switch (opcao){
                    case 1:
                    System.Console.WriteLine("Qual o seu nome?");
                    string Alunos = Console.ReadLine();
                    System.Console.WriteLine("Qual o sua Data de Nascimento?");
                    DateTime DataNasci = DateTime.Parse(Console.ReadLine());
                    System.Console.WriteLine("Qual o seu curso?");
                    string Curso = Console.ReadLine();
                    System.Console.WriteLine("Qual o número da sua sala?");
                    int NumeroSala = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Cadastro do aluno efetivado!");
                    

                        break;
                    case 2:

                        break;
                    case 3:
                        
                        break;
                    default:
                        
                        break;
                }
        }
    }
}
