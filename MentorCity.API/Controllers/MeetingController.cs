using MentorCity.Entities;
using MentorCity.Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MentorCity.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Table("Meetings")]
    public class MeetingController : Controller
    {
        private readonly PostgreSqlDbContext _postgreSqlDbContext;

        public MeetingController(PostgreSqlDbContext postgreSqlDbContext)
        {
            _postgreSqlDbContext = postgreSqlDbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Meeting>> GetAllMeetings()
        {
            return await _postgreSqlDbContext.Meetings.Where(x => x.IsActive == true).ToListAsync();
        }

        [HttpGet("/MeetingLocations")]
        public async Task<IEnumerable<MeetingLocation>> GetAllMeetingLocations()
        {
            return await _postgreSqlDbContext.MeetingLocations.Where(x => x.IsActive == true).ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<IEnumerable<Meeting>> GetMeetingById(int id)
        {
            var result = _postgreSqlDbContext.Meetings.Where(x => x.Id == id && x.IsActive == true);
            return result;
        }

        [HttpGet("/meeting/mentorId/{mentorId:int}")]
        public async Task<IEnumerable<Meeting>> GetMeetingByMentorId(int mentorId)
        {
            var meetingList = _postgreSqlDbContext.Meetings.Where(u => u.MentorId == mentorId && u.IsActive == true);
            return meetingList;
        }

        [HttpGet("/Meeting/menteeId/{menteeId:int}")]
        public async Task<IEnumerable<Meeting>> GetMeetingByMenteeId(int menteeId)
        {
            var meetingList = _postgreSqlDbContext.Meetings.Where(u => u.MenteeId == menteeId && u.IsActive == true);
            return meetingList;
        }

        [HttpPost]
        public async Task<IActionResult> MeetingPost(Meeting meeting)
        {
            meeting.MeetingDate = Convert.ToDateTime(meeting.MeetingDate);
            meeting.MeetingStartingTime = Convert.ToDateTime(meeting.MeetingStartingTime);
            meeting.MeetingEndingTime = Convert.ToDateTime(meeting.MeetingEndingTime);
            _postgreSqlDbContext.Meetings.Add(meeting);
            await _postgreSqlDbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMeeting(int id, Meeting meeting)
        {

            var item = await _postgreSqlDbContext.Meetings.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            item.MeetingTopic = meeting.MeetingTopic;
            item.MeetingDate = meeting.MeetingDate;
            item.MeetingStartingTime = meeting.MeetingStartingTime;
            item.MeetingEndingTime = meeting.MeetingEndingTime;
            item.MenteeId = meeting.MenteeId;
            item.MeetingLocationId = meeting.MeetingLocationId;
            item.MeetingLink = meeting.MeetingLink;
            item.UpdatedTime = DateTime.Now;

            try
            {
                await _postgreSqlDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!MeetingItemExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        private bool MeetingItemExists(int id)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeeting(int id)
        {
            var meetingItem = await _postgreSqlDbContext.Meetings.FindAsync(id);

            if (meetingItem == null)
            {
                return NotFound();
            }

            meetingItem.IsActive = false;
            await _postgreSqlDbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
