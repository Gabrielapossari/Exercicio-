using System;
namespace Mcbonalds
{
    public class Cliente{

        //Atributos
        public string Nome  {get;set;}  
        public string Endereço {get;set;}
        public string Telefone {get;set;}
        public string Senha {get;set;}
        public string Email {get;set;}
        public DateTime DataNascimento {get;set;}

        //Construtor=Instânciar a classe (sempre o mesmo nome da classe)

        public Cliente (string nome, string telefone, string email){  //metódo conjunto de parametros para gerar informaçoes 
            this.Nome= nome;   //THIS = mostrar onde está definida a variável 
            this.Telefone= telefone;
            this.Email= email;

        }



    }
}