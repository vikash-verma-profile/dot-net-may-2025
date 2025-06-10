using EShoppingAPI.Models;
using EShoppingAPI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EShoppingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly EshoppingDbContext _db;
        private readonly JWTSettings _jwtSettings;
        public LoginController(EshoppingDbContext db, IOptions<JWTSettings> jwtSettings)
        {
            _db = db;
            _jwtSettings=
            _jwtSettings = jwtSettings.Value;
        }

        [HttpPost]
        [Route("/login")]
        public IActionResult Login(Login login)
        {
            if (!(_db.TblLogins.Any(x=>x.UserName==login.UserName && x.Password==login.Password)))
            {
                return Ok(new { Message = "Either email or password is incorrect" });
            }

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,login.UserName),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var creds = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwtSettings.ExpiresInMinutes),
                signingCredentials:creds
                );
            
            return Ok(new {token=new JwtSecurityTokenHandler().WriteToken(token), Message = "success" });
        }
        [HttpPost]
        [Route("/register")]
        public string Register(Register register)
        {
            if(!(string.IsNullOrEmpty(register.UserName) && string.IsNullOrEmpty(register.Password)))
            {
                TblLogin tblLogin = new TblLogin();
                tblLogin.UserName = register.UserName; 
                tblLogin.Password = register.Password;
                tblLogin.IsActive = 1;
                tblLogin.RoleId = 1;
                _db.TblLogins.Add(tblLogin);
                _db.SaveChanges();
                TblUserDetail tblUserDetail = new TblUserDetail();
                tblUserDetail.UserId = tblLogin.Id;
                tblUserDetail.Gender = register.Gender;
                tblUserDetail.FirstName = register.FirstName;
                tblUserDetail.LastName = register.LastName;
                _db.TblUserDetails.Add(tblUserDetail);
                _db.SaveChanges();
            }
            else
            {
                return "please provide details";
            }
            return "success";
        }
    }
}
