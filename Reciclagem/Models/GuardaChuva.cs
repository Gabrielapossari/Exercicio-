using System;
using Reciclagem.Models;

namespace Reciclagem.Models
{
    public class GuardaChuva
    {
        public string Nome;
        public string CorDaLixeira;

        public GuardaChuva (string Nome,string CorDaLixeira)
        {
            this.Nome=Nome;
            this.CorDaLixeira=CorDaLixeira;
        }
    }
}