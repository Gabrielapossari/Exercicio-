using System;
using Reciclagem.Models;
using Reciclagem.Interface.ILixo;
namespace Reciclagem.Models
{
    public class Garrafa
        {
            public string Nome;
            public string CorDaLixeira;
            public Garrafa (string Nome,string CorDaLixeira)
            {
                this.Nome=Nome;
                this.CorDaLixeira=CorDaLixeira;
            }
            public void  MostrarTexto (string Nome,string CorDaLixeira){
                System.Console.WriteLine($"O lixo de {Nome} é descartado na lixeira {CorDaLixeira}.");
            }
        }
    }