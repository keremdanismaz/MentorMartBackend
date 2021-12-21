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
    public class AddNoteController : Controller
    {
        private readonly PostgreSqlDbContext _postgreSqlDbContext;

        public AddNoteController(PostgreSqlDbContext postgreSqlDbContext)
        {
            _postgreSqlDbContext = postgreSqlDbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Note>> Get()
        {
            return await _postgreSqlDbContext.Notes.ToListAsync();
        }

        [HttpPost]
        public async Task<IEnumerable<Note>> NotePost(Note note)
        {
            note.MentorId = 2;
            _postgreSqlDbContext.Notes.Add(note);
            await _postgreSqlDbContext.SaveChangesAsync();
            return (IEnumerable<Note>)CreatedAtAction(nameof(Get), new { id = note.Id }, note);
        }
    }
}