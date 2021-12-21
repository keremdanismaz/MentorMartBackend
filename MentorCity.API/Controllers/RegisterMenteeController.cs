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
    public class RegisterMenteeController : ControllerBase
    {
        private readonly PostgreSqlDbContext _postgreSqlDbContext;

        public RegisterMenteeController(PostgreSqlDbContext postgreSqlDbContext)
        {
            _postgreSqlDbContext = postgreSqlDbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _postgreSqlDbContext.Users.ToListAsync();
        }

        [HttpPost]
        public async Task<IEnumerable<User>> UserPost(User user)
        {
            user.RoleId = 2;
            user.MentorId = user.CoprorationId;
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            _postgreSqlDbContext.Users.Add(user);
            await _postgreSqlDbContext.SaveChangesAsync();
            return (IEnumerable<User>)CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }
    }
}