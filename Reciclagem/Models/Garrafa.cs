using System;
using Reciclagem;

namespace Reciclagem.Models
{
    class Garrafa
        {
            public string Nome {get; set;}
            public string CorDaLixeira {get; set;}
        public void lixo (string Nome,string CorDaLixeira)
        {
            this.Nome=Nome;
            this.CorDaLixeira=CorDaLixeira;
        }
        
        
        }
    }