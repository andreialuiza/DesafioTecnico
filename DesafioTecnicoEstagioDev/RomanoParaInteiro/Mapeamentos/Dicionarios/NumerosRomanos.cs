﻿namespace RomanoParaInteiro.Mapeamentos.Dicionarios
{
    public class NumerosRomanos
    {
        public readonly Dictionary<char, int> RomanMap = new Dictionary<char, int>
        {
            {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
        };
    }
}