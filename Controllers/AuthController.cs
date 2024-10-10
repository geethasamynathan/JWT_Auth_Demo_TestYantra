using JWT_Auth_Demo.Models;
using JWT_Auth_Demo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Auth_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        //[HttpPost("login")]
        //public IActionResult Login([FromBody] LoginModel model)
        //{
        //    var token = _authService.Authenticate(model.Username, model.Password);
        //    if (token == null) return Unauthorized();
        //    return Ok(new { Token = token });
        //}
    }

    
}
