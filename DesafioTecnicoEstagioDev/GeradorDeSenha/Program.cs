using GeradorDeSenha.Configuracao;
using Microsoft.AspNetCore.Identity;
using System;


class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Bem vindo ao gerador de senhas poderosas da Andreia Luiza");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Qual o tamanho da senha que deseja criar?");
            var tamanhoSenha = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Você quer que sua senha tenha letras maiúsculas? \nDigite 0 para Não e 1 para Sim");
            var letraMaiuscula = Convert.ToBoolean(Convert.ToInt16((Console.ReadLine())));

            Console.WriteLine("Você quer que sua senha tenha letras minúscula? \nDigite 0 para Não e 1 para Sim");
            var letraMinuscula = Convert.ToBoolean(Convert.ToInt16((Console.ReadLine())));

            Console.WriteLine("Você quer que sua senha tenha números? \nDigite 0 para Não e 1 para Sim");
            var numeros = Convert.ToBoolean(Convert.ToInt16((Console.ReadLine())));

            Console.WriteLine("Você quer que sua senha tenha caracteres especiais? \nDigite 0 para Não e 1 para Sim");
            var caracteresEspeciais = Convert.ToBoolean(Convert.ToInt16((Console.ReadLine())));

            Console.WriteLine();

            var parametrosDaSenha = GeradorDeParametrosDaSenha(tamanhoSenha, letraMaiuscula, letraMinuscula, numeros, caracteresEspeciais);

            var senha = new ControladorDeSenha().GerarSenhaAleatoria(parametrosDaSenha);

            Console.WriteLine($"Sua senha é: {senha}");

        }
    }

    private static PasswordOptions GeradorDeParametrosDaSenha(int tamanhoSenha, bool letraMaiuscula, bool numeros, bool letraMinuscula, bool caracteresEspeciais)
    {
        return  new PasswordOptions()
        {
            RequireUppercase = letraMaiuscula,
            RequireLowercase = letraMinuscula,
            RequireDigit = numeros,
            RequireNonAlphanumeric = caracteresEspeciais,
            RequiredLength = tamanhoSenha,
        };
    }
}