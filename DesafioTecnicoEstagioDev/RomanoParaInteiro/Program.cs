using System.Security.Cryptography;

namespace ConversorRomanoDecimal;

class Program
{
    static void Main(string[] args)
    {

        while (true)
        {

            Console.WriteLine("Conversor de números - Romanos para Decimal");
            Console.WriteLine("----------------------------------------");

            Console.Write("Digite um número romano (ou 'sair' para encerrar a aplicação): ");
            var entrada = Console.ReadLine().ToUpper();

            while (String.IsNullOrWhiteSpace(entrada))
            {
                Console.Write("Digite um número romano (ou 'sair' para encerrar a aplicação): ");

                entrada = Console.ReadLine().ToUpper();
            }

            if (entrada!.ToLower() == "sair")
            {
                Console.WriteLine("Programa fechado");
                Environment.Exit(0);
            }

                        
            try
            {
                var result = new Conversor().RomanoParaInteiro(entrada);

                Console.WriteLine($"Resultado: {result}");
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            Console.WriteLine();
        }
    }
}