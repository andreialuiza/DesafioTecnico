using Dominio.Elevador;
using System.Drawing;

    public class Program
    {

    private const string _sair = "s";

    public static void Main(string[] args)
    {        
                                
        var elevador = new Elevador();

        string entrada = string.Empty;

        
        while (entrada != _sair)
        {

            Console.WriteLine("Selecione o andar para chamar o elevador (1-4) ou pressione 's' para sair");
            entrada = Console.ReadLine();

            if (entrada.ToLower() == "s")
            {
                break;
            }

            if (Int32.TryParse(entrada, out int andar))
            {
                if (andar >= 1 && andar <= 4)
                {
                    elevador.AndarSelecionado(andar);
                    Console.WriteLine($"Elevador chamado para o andar {andar}");

                    Console.WriteLine("Por favor, selecione o andar para chamar o elevador (1-4) ou pressione 's' para sair");
                    string entradaDestino = Console.ReadLine();

                    if (entradaDestino.ToLower() == "s")
                    {
                        break;
                    }
                    if (int.TryParse(entradaDestino, out int andarDestino))
                    {
                        if (andarDestino >= 1 && andarDestino <= 4 && andarDestino != andar)
                        {
                            elevador.AndarSelecionado(andarDestino);
                            Console.WriteLine($"Piso de destino no andar {andarDestino}");
                        }
                        else
                        {
                            Console.WriteLine("Andar de destino inválido. Selecione um andar diferente entre 1 e 4.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Insira um número de andar válido.");
                    }
                }
                else
                {
                    Console.WriteLine("Piso de chamada inválido. Selecione um andar entre 1 e 4.");
                }
            }

            else if (entrada == _sair)
                Console.WriteLine("Até Logo!");
            
        }
    }
}
