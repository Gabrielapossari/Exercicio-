using System;
using System.Collections.Generic;
using System.Text; 

namespace EscolaDeRock.Models 
{
    class Tambores: InstrumentoMusical, IPercussao
    {
        

        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo dos tambores.");
            return true;
        }

    

    }
}