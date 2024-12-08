using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Teste_API.Models;

namespace Teste_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutController : ControllerBase
    {
        // Endpoint para login e geração do token
        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLogin login)
        {
            // Simulando uma verificação de usuário e senha
            if (login.UserName == "admin" && login.Password == "123456")
            {
                var token = GerarTokenJWT("Gerente");  // Passando a role de Gerente para o Admin
                return Ok(new { Token = token });
            }
            else if (login.UserName == "funcionario" && login.Password == "123456")
            {
                var token = GerarTokenJWT("Funcionario");  // Passando a role de Funcionario
                return Ok(new { Token = token });
            }
            else
            {
                return Unauthorized("Credenciais inválidas");
            }
        }

     
        // Método para gerar o token JWT
        private string GerarTokenJWT(string role)
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
