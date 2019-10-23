using System;
using Reciclagem.Models;

namespace Reciclagem.Models
{
    public class PoteManteiga
    {
        public string Nome;
        public string CorDaLixeira;

        public PoteManteiga (string Nome,string CorDaLixeira)
        {
            this.Nome=Nome;
            this.CorDaLixeira=CorDaLixeira;
        }
    }
}