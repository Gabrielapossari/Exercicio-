using System;
using System.Collections.Generic;
using ByteBank2.Models;

namespace ByteBank2

{
    class Program
    {
        static void Main(string[] args)
        {
            string Cliente1 = "Alexandre";
            string Cliente2 = "Cesar";
            
            ContaCorrente contaCorrente = new ContaCorrente(1,2, Cliente1);
            ContaEspecial contaEspecial = new ContaEspecial(1,2,Cliente2);
            contaCorrente.Deposito(10);
            DepositarConta(contaCorrente1);
            DepositarConta(contaCorrente2);
            SacarConta(contaCorrente1);
            SacarConta(contaCorrente);
            TransferirEntreContas(contaCorrente1,contaCorrente2);
        }
        public startic void  DepositarConta (ContaBancaria cotaBancaria)
        {
            Console.WriteLine("ByteBank - Deposito");
            Cliente usuario = contaCorrente.Titular;
            Console.WriteLine($"Bem vindo - {usuario.Nome}");
            Console.WriteLine($"Agencia: {contaCorrente.Agencia}   Conta: {contaCorrente.Numero}");
            Console.WriteLine($"Saldo: {contaCorrente.Saldo}");
            Console.Write("Digite o valor do Deposito: ");
            double valor = double.Parse(Console.ReadLine());
            if(contaCorrente.Deposito(valor)){
                    System.Console.WriteLine("Deposito realizado!");
            } else {
                Console.WriteLine("Deposito não realizado!");

            }
            saldo = contaCorrente.Deposito(valor);
            Console.WriteLine($"Saldo atual: {saldo}");
            Console.WriteLine();
        }
    }
} 