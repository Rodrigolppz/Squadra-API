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
        [HttpPost]

        public IActionResult Login([FromBody] UserLogin login)
        {
            if (login.UserName.Equals("Administrador") && login.Password.Equals("123456")) 
            {
                var token = GerarTokenJWT();

                return Ok(new {Token = token});
            }

            return Unauthorized(new {Mensagem = "Credenciais invalidas", Codigo = 001});

        }

        [HttpGet("RotaProtegida")]
        [Authorize]
        public IActionResult RotaProtegida()
        {
            return Ok("Acessando uma rota protegida");
        }


        private string GerarTokenJWT()
        {
            var claims = new[] 
            { 
                new Claim(ClaimTypes.Name,"Administrador"), //nomeusuario
                new Claim(ClaimTypes.Role,"Admin") //papelusuario
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
