using System;
using System.Collections.Generic;
using System.Text; 

namespace EscolaDeRock.Models 
{
    class Baixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        

        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo do Baixo.");
            return true;
        }
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Mantendo o ritmo dos acordes.");
            return true;
        }
    }
}