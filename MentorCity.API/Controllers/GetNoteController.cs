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
    public class GetNoteController : Controller
    {
        private readonly PostgreSqlDbContext _postgreSqlDbContext;

        public GetNoteController(PostgreSqlDbContext postgreSqlDbContext)
        {
            _postgreSqlDbContext = postgreSqlDbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Note>> Get()
        {
            return await _postgreSqlDbContext.Notes.ToListAsync();
        }
    }
}