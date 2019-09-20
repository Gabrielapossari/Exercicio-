using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1=0;
            int num2=0;
            string oper;

           Console.WriteLine("Digite o primeiro número");
           num1 = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite o segundo número");
           num2 = int.Parse(Console.ReadLine()); 
           Console.WriteLine("Qual o operador desejado?");
           oper = Console.ReadLine();

    switch(oper) {
        case "+":
           Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
           break;
        case "-":
           Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
           break;
        case "*": 
           Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
           break;
        case "/":
           Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
           break;
        case "%":
           Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
           break;
           default: 
           Console.WriteLine("Operação não reconhecida");
           break;

            }


        }
    }
}
