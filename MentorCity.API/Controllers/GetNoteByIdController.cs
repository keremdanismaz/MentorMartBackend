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
    public class GetNoteById : Controller
    {
        private readonly PostgreSqlDbContext _postgreSqlDbContext;

        public GetNoteById(PostgreSqlDbContext postgreSqlDbContext)
        {
            _postgreSqlDbContext = postgreSqlDbContext;
        }

        [HttpGet]
        // Belli bir idli notu bana döndür.
        public IEnumerable<Note> NoteBuId(int noteId)
        {
            var notes = _postgreSqlDbContext.Notes.Where(p => p.Id == noteId).ToList();
            return notes;
        }
    }
}