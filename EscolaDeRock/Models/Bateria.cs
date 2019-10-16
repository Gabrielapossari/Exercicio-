using System;
using System.Collections.Generic;
using System.Text; 


namespace EscolaDeRock.Models 

{
    public class Bateria : InstrumentoMusical, IPercussao  /*Violão paga as informaçoes da classe InstrumentoMusical */
    {
        
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Manter o ritmo da bateria.");
            return true;
        }
    }

}
