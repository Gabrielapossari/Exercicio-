using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank2.Models 
{
    public class ContaEspecial : ContaBancaria
    {
        public double limite;
        public ContaEspecial(int Agencia,int NumeroConta,string Titular):base(Agencia,NumeroConta,Titular)
        {
            limite = 0.0;
        }
        public override bool Saque(double valor) 
        {
            if (valor>=0)
            {
                if (valor <= base.Saldo + limite)
                {
                    Saldo-=valor;
                    return true;
                }else
                {
                    {
                        return false;
                    }
                }return false;
            }
        }
        public bool setLimite(double valor)
        {
            if (valor >= 0)
            {
                limite= valor;
                return true; 
            }
            return false;
        }
    }
}