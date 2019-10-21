using System;

namespace Reciclagem.Models
{
    class Papelao
    {
        public string Nome;
        public string CorDaLixeira;

        public void lixo (string Nome,string CorDaLixeira)
        {
            this.Nome=Nome;
            this.CorDaLixeira=CorDaLixeira;
        }
    }
} 
        