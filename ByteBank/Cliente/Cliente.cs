using System;

namespace ByteBank
{
    public class Cliente
    {
        public string CPF {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Senha {get; set;}

        public Cliente (string nome,string cpf ,string email) {   /*     CONSTRUTOR     */
            this.Nome=nome;
            this.CPF=cpf;
            this.Email= email;
        }
        public bool TrocaSenha ( string senha){           /*  Metodo TrocaSenha */
            if ((senha.Length > 6 ) && (senha.Length < 16)){
                this.Senha = senha;
                return true;
            }else {
                return false;
            }



        }
    }
}