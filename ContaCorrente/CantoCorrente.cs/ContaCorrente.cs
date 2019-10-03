using System;

namespace ContaCorrente
{
    public class ContaCorrente
    {
        public string Titular {get; set;}
        public int Agencia {get; set;}
        public int Numero {get; set;}
        public double Saldo {get; set;}

        public ContaCorrente  (string titular,int agencia ,int numero) {         /* CONSTRUTOR */
            this.Titular=titular;
            this.Agencia=agencia;
            this.Numero=numero;
            this.Saldo= 0.0; 

        }
    }
}
