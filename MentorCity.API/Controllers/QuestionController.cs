using MentorCity.Entities;
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
    public class QuestionController : Controller
    {
        private readonly PostgreSqlDbContext _postgreSqlDbContext;

        public QuestionController(PostgreSqlDbContext postgreSqlDbContext)
        {
            _postgreSqlDbContext = postgreSqlDbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Question>> GetAllQuestions()
        {
            return await _postgreSqlDbContext.Questions.Where(x => x.IsActive == true).ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<IEnumerable<Question>> GetQuestionById(int id)
        {
            var result = _postgreSqlDbContext.Questions.Where(x => x.Id == id && x.IsActive == true);
            return result;
        }

        [HttpGet("/Question/mentorId/{mentorId:int}")]
        public async Task<IEnumerable<Question>> GetQuestionByMentorId(int mentorId)
        {
            var questionList = _postgreSqlDbContext.Questions.Where(u => u.MentorId == mentorId && u.IsActive == true);
            return questionList;
        }

        [HttpGet("/Question/menteeId/{menteeId:int}")]
        public async Task<IEnumerable<Question>> GetQuestionByMenteeId(int menteeId)
        {
            var questionList = _postgreSqlDbContext.Questions.Where(u => u.MenteeId == menteeId && u.IsActive == true);
            return questionList;
        }

        [HttpPost]
        public async Task<IActionResult> QuestionPost(Question question)
        {
            _postgreSqlDbContext.Questions.Add(question);
            await _postgreSqlDbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMeeting(int id, Question question)
        {

            var item = await _postgreSqlDbContext.Questions.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            if (question.AskQuestion != null) item.AskQuestion = question.AskQuestion;
            if (question.Answer != null) item.Answer = question.Answer;
            if (question.MenteeId != null && question.MenteeId != 0) item.MenteeId = question.MenteeId;

            item.UpdatedTime = DateTime.Now;

            try
            {
                await _postgreSqlDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!QuestionItemExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        private bool QuestionItemExists(int id)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> QuestionMeeting(int id)
        {
            var questionItem = await _postgreSqlDbContext.Questions.FindAsync(id);

            if (questionItem == null)
            {
                return NotFound();
            }

            questionItem.IsActive = false;
            await _postgreSqlDbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
