using System;
using System.Collections.Generic;
using System.Text; 

namespace EscolaDeRock.Models 
{
    class ContraBaixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        

        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo do ContraBaixo");
            return true;
        }

        public bool TocarAcordes()
        {
            
            Console.WriteLine("Tocando os acordos do ContraBaixo");
            return true;

        }
    }
}
