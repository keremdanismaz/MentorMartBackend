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
    public class AccessDeniedController : ControllerBase
    {
        private readonly PostgreSqlDbContext _postgreSqlDbContext;

        public AccessDeniedController(PostgreSqlDbContext postgreSqlDbContext)
        {
            _postgreSqlDbContext = postgreSqlDbContext;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return StatusCode(403);
        }
    }
}