using System;
using Reciclagem.Models;

namespace Reciclagem.Models
{
    public class Latinha
    {
        public string Nome;
        public string CorDaLixeira;

        public Latinha (string Nome,string CorDaLixeira)
        {
            this.Nome=Nome;
            this.CorDaLixeira=CorDaLixeira;
        }
    }
}