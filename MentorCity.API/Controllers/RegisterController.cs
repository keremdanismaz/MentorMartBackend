using MentorCity.Entities;
using MentorCity.Entities.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorCity.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterController : ControllerBase
    {
        private readonly PostgreSqlDbContext _postgreSqlDbContext;

        public RegisterController(PostgreSqlDbContext postgreSqlDbContext)
        {
            _postgreSqlDbContext = postgreSqlDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> UserPost(User user)
        {
            User isValid = _postgreSqlDbContext.Users.FirstOrDefault(x => x.Mail == user.Mail && x.IsActive == true);
            if (isValid != null)
            {
                return BadRequest(new { error = "Bu maile ait kayıtlı kullanıcı bulunmaktadır." });
            }
            else
            {
                user.RoleId = 2;
                user.MentorId = user.CoprorationId;
                user.UpdatedTime = DateTime.Now;
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
                user.About = "This is a mentee";
                user.Address = "Kargin,8, 7800, Korkuteli/ Antalya, Turkey";
                _postgreSqlDbContext.Users.Add(user);
                await _postgreSqlDbContext.SaveChangesAsync();
                return NoContent();
            }

        }
    }
}