using System;
using Reciclagem.Models;

namespace Reciclagem.Models
{
    public class Papelao
    {
        public string Nome;
        public string CorDaLixeira;

        public Papelao (string Nome,string CorDaLixeira)
        {
            this.Nome=Nome;
            this.CorDaLixeira=CorDaLixeira;
        }
    }
} 
        