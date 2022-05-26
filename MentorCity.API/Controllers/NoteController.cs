using MentorCity.API.DataTranferObject;
using MentorCity.Entities;
using MentorCity.Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorCity.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : Controller
    {
        private readonly PostgreSqlDbContext _postgreSqlDbContext;

        public NoteController(PostgreSqlDbContext postgreSqlDbContext)
        {
            _postgreSqlDbContext = postgreSqlDbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Note>> GetAllNotes()
        {
            return await _postgreSqlDbContext.Notes.Where(x => x.IsActive == true).ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<IEnumerable<Note>> GetNoteById(int id)
        {
            var result = _postgreSqlDbContext.Notes.Where(x => x.Id == id && x.IsActive == true);
            return result;
        }

        [HttpGet("/Note/mentorId/{mentorId:int}")]
        public async Task<IEnumerable<Note>> GetNoteByMentorId(int mentorId)
        {
            var noteList = _postgreSqlDbContext.Notes.Where(u => u.MentorId == mentorId && u.IsActive == true);
            return noteList;
        }

        [HttpGet("/Note/menteeId/{menteeId:int}")]
        public async Task<IEnumerable<Note>> GetNoteByMenteeId(int menteeId)
        {
            var noteList = _postgreSqlDbContext.Notes.Where(u => u.MenteeId == menteeId && u.IsActive == true);
            return noteList;
        }

        [HttpPost]
        public async Task<IActionResult> NotePost(Note note)
        {
            note.NoteEndingTime = Convert.ToDateTime(note.NoteEndingTime);
            _postgreSqlDbContext.Notes.Add(note);
            await _postgreSqlDbContext.SaveChangesAsync();
            return NoContent();

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNote(int id, Note note)
        {

            var item = await _postgreSqlDbContext.Notes.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            item.NoteTitle = note.NoteTitle;
            item.NoteDescription = note.NoteDescription;
            item.MenteeId = note.MenteeId;
            item.NoteLink = note.NoteLink;
            item.NoteLinkName = note.NoteLinkName;
            item.NoteEndingTime = note.NoteEndingTime;
            item.UpdatedTime = DateTime.Now;

            try
            {
                await _postgreSqlDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!NoteItemExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        private bool NoteItemExists(int id)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNote(int id)
        {
            var noteItem = await _postgreSqlDbContext.Notes.FindAsync(id);

            if (noteItem == null)
            {
                return NotFound();
            }

            noteItem.IsActive = false;
            await _postgreSqlDbContext.SaveChangesAsync();

            return NoContent();
        }

    }
}