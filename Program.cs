using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            string temperatura;
            double fahrenheit;
            double celsius;

            Console.WriteLine ("--- Conversor de Temperatura --- \n");
            Console.Write("Digite o valor em Fharenheit para conversão: ");
            temperatura = Console.ReadLine();
            Console.WriteLine();
            fahrenheit = Convert.ToDouble(temperatura);
            celsius = (fahrenheit-32 )  / 1.8;
            Console.WriteLine($"A temperatura convertida para Celsius é: {celsius:N1}");
            Console.WriteLine("Digite ENTER para encerrar... ");
            Console.ReadKey();
            

        }
    }
}
