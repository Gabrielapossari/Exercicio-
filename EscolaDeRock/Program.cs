using System;
using System.Collections.Generic;
using System.Text;
using EscolaDeRock.Models;


namespace EscolaDeRock
{
    enum FormaçaoEnum : int 
    {
        TRIO = 3,
        QUARTETO
    };
    enum InstrumentoMusical : int {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA
        ,TECLADO,
        TAMBORES,
        VIOLAO
    };
    enum CategoriaEnum : int {
        HARMONIA,
        PERCUSSAO,
        MELODIA
    };
    class Program
    {
        private static bool menubar;

        static void Main(string[] args)
        {
            bool querSair = false;
            string[] itensMenuPrincipal = Enum.GetNames(typeof(FormaçaoEnum));
            string[] itensManuCategoria = Enum.GetNames(typeof(CategoriaEnum));

            var opcoesFormacao = new List<string>()
            {
                "    -0       ",
            

                "    -1       "
            };
            int opcaoFormacao =0;
            do {
                do {
                    Console.Clear();
                    System.Console.WriteLine(menubar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.BackgroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("Seja bem- vindo");
                    System.Console.WriteLine("Escolha uma formação: ");
                    Console.ResetColor();
                    Console.WriteLine(menubar);
                }
                
            }

            InstrumentoMusical generico = new InstrumentoMusical();
            System.Console.WriteLine(generico.TocarMusica());

            Violao violao1 = new Violao();
            System.Console.WriteLine("Violão:"+ violao1.TocarMusica());
            violao1.TocarAcordes();

        }
    }
}
