using Microsoft.AspNetCore.Identity;

namespace GeradorDeSenha.Configuracao
{
    public class ControladorDeSenha
    {

        public string GerarSenhaAleatoria(PasswordOptions parametrosDeSenha = null)
        {
            if (parametrosDeSenha == null) parametrosDeSenha = new PasswordOptions()
            {
                RequireUppercase = true,
                RequireLowercase = true,
                RequireDigit = true,
                RequireNonAlphanumeric = true,
                RequiredLength = 8,
            };

            string[] charAleatorio = new[] {
                "ABCDEFGHJKLMNOPQRSTUVWXYZ",    
                "abcdefghijkmnopqrstuvwxyz",    
                "0123456789",                   
                "!@$?_-"                        
            };

            Random rand = new Random();
            List<char> chars = new List<char>();

            for (int i = 0; i < parametrosDeSenha.RequiredLength; i++)
            {
                if (parametrosDeSenha.RequireUppercase)
                    chars.Insert(rand.Next(0, chars.Count),
                        charAleatorio[0][rand.Next(0, charAleatorio[0].Length)]);

                if (parametrosDeSenha.RequireLowercase)
                    chars.Insert(rand.Next(0, chars.Count),
                        charAleatorio[1][rand.Next(0, charAleatorio[1].Length)]);

                if (parametrosDeSenha.RequireDigit)
                    chars.Insert(rand.Next(0, chars.Count),
                        charAleatorio[2][rand.Next(0, charAleatorio[2].Length)]);

                if (parametrosDeSenha.RequireNonAlphanumeric)
                    chars.Insert(rand.Next(0, chars.Count),
                        charAleatorio[3][rand.Next(0, charAleatorio[3].Length)]);
            }
            
            return new string(chars.ToArray());
        }
    }
}
