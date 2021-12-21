using MentorCity.Entities;
using MentorCity.Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MentorCity.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoleController : ControllerBase
    {
        private readonly PostgreSqlDbContext _postgreSqlDbContext;

        public RoleController(PostgreSqlDbContext postgreSqlDbContext)
        {
            _postgreSqlDbContext = postgreSqlDbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Role>> Get()
        {
            return await _postgreSqlDbContext.Roles.ToListAsync();
        }
    }
}