using MentorCity.API.DataTranferObject;
using MentorCity.API.Helpers;
using MentorCity.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorCity.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly PostgreSqlDbContext _postgreSqlDbContext;
        private readonly JwtService _jwtService;

        public LoginController(PostgreSqlDbContext postgreSqlDbContext, JwtService jwtService)
        {
            _postgreSqlDbContext = postgreSqlDbContext;
            _jwtService = jwtService;
        }

        //[HttpPost]
        //public IActionResult UserLogin(LoginDto dto)
        //{
        //    User user = _postgreSqlDbContext.Users.FirstOrDefault(x => x.Mail == dto.Mail);
        //    if (user == null) return BadRequest(new { message = "Bu maile ait kayıtlı kullanıcı bulunamadı." });
        //    if (!BCrypt.Net.BCrypt.Verify(dto.Password, user.Password)) return BadRequest(new { message = "Girmiş olduğunuz şifre hatalı. Lütfen tekrar deneyin." });

        //    var jwt = _jwtService.Generate(user.Id);

        //    Response.Cookies.Append("jwt", jwt, new Microsoft.AspNetCore.Http.CookieOptions
        //    {
        //        HttpOnly = true
        //    });

        //    return Ok(new
        //    {
        //        message = "Hoşgeldiniz Sayın MentorCity Kullanıcısı."
        //    });
        //}

        [HttpGet("user")]
        public IActionResult ReturnUser()
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtService.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                var user = _postgreSqlDbContext.Users.FirstOrDefault(x => x.Id == userId);
                return Ok(user);
            }
            catch (Exception)
            {
                return Unauthorized();
            }
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("jwt");
            return Ok(new
            {
                message = "Tekrar Görüşmek Üzere MentorCity Kullanıcısı :)"
            });
        }
    }
}