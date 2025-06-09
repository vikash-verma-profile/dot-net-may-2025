using EShoppingAPI.Models;
using EShoppingAPI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShoppingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly EshoppingDbContext _db;
        public LoginController(EshoppingDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        [Route("/login")]
        public IActionResult Login(Login login)
        {
            if (_db.TblLogins.Any(x=>x.UserName==login.UserName && x.Password==login.Password))
            {
                return Ok(new { Message="success" });
            }
            return Ok(new { Message = "Either email or password is incorrect" });

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
