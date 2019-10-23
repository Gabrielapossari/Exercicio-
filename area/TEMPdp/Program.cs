using System;

namespace TEMPdp
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp;
            Console.WriteLine("Digite a temperatura:");
            temp = double.Parse(Console.ReadLine());
            System.Console.WriteLine(((temp*9) + 32) /5);
            Console.ReadLine();
            

        }
    }
}
