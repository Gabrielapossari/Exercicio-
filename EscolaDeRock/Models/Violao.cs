using System;
using System.Collections.Generic;
using System.Text; 


namespace EscolaDeRock.Models 
{
    public class Violao : InstrumentoMusical, IHarmonia, IMelodia, IPercussao  /*Violão paga as informaçoes da classe InstrumentoMusical */
    {
        
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Manter o ritmo do violão.");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do Violão.");
            return true;
        }
        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo do Violão.");
            return true;
        }
    }

}
