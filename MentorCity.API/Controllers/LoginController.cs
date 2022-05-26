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

            [HttpPost]
            public IActionResult UserLogin(LoginDto dto)
            {
                User user = _postgreSqlDbContext.Users.FirstOrDefault(x => x.Mail == dto.Mail && x.IsActive == true);
                if (user == null) return Ok(new { error = "Bu maile ait kayıtlı kullanıcı bulunamadı." });
                if (!BCrypt.Net.BCrypt.Verify(dto.Password, user.Password)) return Ok(new { error = "Girmiş olduğunuz şifre hatalı. Lütfen tekrar deneyin." });

                var jwt = _jwtService.Generate(user.Id);

                Response.Cookies.Append("jwt", jwt, new Microsoft.AspNetCore.Http.CookieOptions
                {
                    Path = "http://localhost:3000",
                });

                return Ok(new
                {
                    message = jwt
                });
            }

        [HttpGet("user")]
        public IActionResult ReturnUser()
        {
            try
            {
                HttpContext.Request.Headers.TryGetValue("Authorization", out var tokenHeaders);
                var token = _jwtService.Verify(tokenHeaders);
                int userId = int.Parse(token.Issuer);
                var user = _postgreSqlDbContext.Users.FirstOrDefault(x => x.Id == userId && x.IsActive == true);
                return Ok(user);
            }
            catch (Exception)
            {
                return Unauthorized();
            }
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("jwt");
            return Ok(new
            {
                message = "Tekrar Görüşmek Üzere MentorMart Kullanıcısı :)"
            });
        }
    }
}