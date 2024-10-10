using JWT_Auth_Demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWT_Auth_Demo.Services
{
    public class AuthService// : IAuthService
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _config;
        public AuthService(ApplicationDbContext context,IConfiguration config)
        {
                _config = config;
                _context = context;
        }

        //public string Authenticate(string username, string password)
        //{
           
        //        var user = _context.Users.Include(u => u.Role).FirstOrDefault(u => u.Username == username && u.PasswordHash == password);
        //        if (user == null) return null;

        //        var tokenHandler = new JwtSecurityTokenHandler();
        //        var key = Encoding.ASCII.GetBytes(_config["Jwt:Key"]);
        //        var tokenDescriptor = new SecurityTokenDescriptor
        //        {
        //            Subject = new ClaimsIdentity(new[] {
        //            new Claim(ClaimTypes.Name, user.Username),
        //            new Claim(ClaimTypes.Role, user.Role.Name)
        //          }),
        //            Expires = DateTime.UtcNow.AddDays(7),
        //            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        //        };
        //        var token = tokenHandler.CreateToken(tokenDescriptor);
        //        return tokenHandler.WriteToken(token);

        //    }
        }
}
