using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Teste_API.Services
{
    public class AuthService
    {
        // Método para gerar o token JWT
        public string GerarTokenJWT(string role)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, "Usuário"),  // Pode ser alterado para o nome do usuário
                new Claim(ClaimTypes.Role, role)  // Usando o parâmetro role para definir o papel do usuário
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ChaveSecretaSegura1234567890AbCdEfGhIjKlMnOpQrSt"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken
            (
                issuer: "api-autentication",
                audience: "api-cadastro",
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
