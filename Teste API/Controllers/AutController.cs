using Microsoft.AspNetCore.Mvc;
using Teste_API.Models;
using Teste_API.Services;

namespace Teste_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutController : ControllerBase
    {
        private readonly AuthService _authService;

        // Injetando o AuthService através do construtor
        public AutController(AuthService authService)
        {
            _authService = authService;
        }

        // Endpoint para login e geração do token
        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLogin login)
        {
            // Simulando uma verificação de usuário e senha
            if (login.UserName == "admin" && login.Password == "123456")
            {
                var token = _authService.GerarTokenJWT("Gerente");  // Chamando o método no AuthService
                return Ok(new { Token = token });
            }
            else if (login.UserName == "funcionario" && login.Password == "123456")
            {
                var token = _authService.GerarTokenJWT("Funcionario");  // Chamando o método no AuthService
                return Ok(new { Token = token });
            }
            else
            {
                return Unauthorized("Credenciais inválidas");
            }
        }
    }
}
