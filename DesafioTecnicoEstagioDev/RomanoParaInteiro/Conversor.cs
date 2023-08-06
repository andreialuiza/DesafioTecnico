using RomanoParaInteiro.Mapeamentos.Dicionarios;

namespace ConversorRomanoDecimal;

public class Conversor
{

    public int RomanoParaInteiro(string text)
    {
        var numerosRomanos = new NumerosRomanos().RomanMap;

        var valorToltal = 0;
        var valorAnterior = 0;
        
        foreach (var c in text)
        {
        
            if (!numerosRomanos.ContainsKey(c))
                return 0;
            
            var valorReal = numerosRomanos[c];

            valorToltal += valorReal;
            
            if (valorAnterior != 0 && valorAnterior < valorReal)
            {
                if (valorAnterior == 1 && (valorReal == 5 || valorReal == 10) 
                    || valorAnterior == 10 && (valorReal == 50 || valorReal == 100) 
                    || valorAnterior == 100 && (valorReal == 500 || valorReal == 1000))
                {
                    valorToltal -= 2 * valorAnterior;
                }

                else
                    return 0;
            }

            valorAnterior = valorReal;

        }
        return valorToltal;
    }
}



