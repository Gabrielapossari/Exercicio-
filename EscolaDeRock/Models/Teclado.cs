using System;
using System.Collections.Generic;
using System.Text; 

namespace EscolaDeRock.Models 
{
    public class Teclado : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando os acordes do teclado");
            return true;
        }
        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando o solo do Teclado.");
            return true;
        }
    }
}