using System;
using Reciclagem.Models;

namespace Reciclagem.Models
{
    public class GarrafaPET 
    {
        public string Nome;
        public string CorDaLixeira;

        public GarrafaPET (string Nome,string CorDaLixeira)
        {
            this.Nome=Nome;
            this.CorDaLixeira=CorDaLixeira;
        }

    }

}