using System;
using System.Collections.Generic;
using System.Text; 

namespace EscolaDeRock.Models 
{
    public class Guitarra : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes de Guitarra.");
            return true;
            throw new NotImplementedException();

        }
        public bool TrocarSolo()
        {
            System.Console.WriteLine("Tocando solo da Guitarra.");
            return true;
        }
    }
}