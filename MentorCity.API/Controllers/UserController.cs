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
    public class UserController : Controller
    {
        private readonly PostgreSqlDbContext _postgreSqlDbContext;

        public UserController(PostgreSqlDbContext postgreSqlDbContext)
        {
            _postgreSqlDbContext = postgreSqlDbContext;
        }

        [HttpGet]
        public IEnumerable<User> GetUserByMentorId(int mentorId)
        {
            var user = _postgreSqlDbContext.Users.Where(p => p.MentorId == mentorId).ToList();
            return user;
        }
    }
}