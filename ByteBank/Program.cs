using System;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Cadastro de clientes");
            Console.ReadLine();
            
            System.Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            
            System.Console.Write("CPF : ");
            string cpf = Console.ReadLine();
            
            System.Console.WriteLine("Email: ");
            string email = Console.ReadLine();

            Cliente cliente = new Cliente (nome,cpf,email);

            bool TrocouSenha = false; 

            do{
                    System.Console.Write("Digite a Senha : ");
                    string senha = Console.ReadLine();
                    bool  senhaOK = cliente1.TrocaSenha (senha);
                    
                    if (!senhaOK){
                        System.Console.WriteLine("Senha não atende aos requisitos");
                    } else {
                        System.Console.WriteLine("Senha Trocada com sucesso");
                    }
            }while(!senhaOK:);
        }
    
    }
}
