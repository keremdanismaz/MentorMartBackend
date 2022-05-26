using MentorCity.API.DataTranferObject;
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

        [HttpGet("/filter/{mentorId:int}")]
        public async Task<IEnumerable<User>> GetUserByMentorId(int mentorId)
        {
            return await _postgreSqlDbContext.Users.Where(p => p.MentorId == mentorId && p.IsActive == true).ToListAsync();
        }

        [HttpGet("/userInfo/{mentorId:int}")]
        public async Task<IEnumerable<User>> GetUserInfo(int mentorId)
        {
            return await _postgreSqlDbContext.Users.Where(p => p.Id == mentorId && p.IsActive == true).ToListAsync();
        }

        [HttpPut("/UpdateMentorInfo/{mentorId}")]
        public async Task<IActionResult> UpdateMentorInfo(int mentorId, User user)
        {

            var item = await _postgreSqlDbContext.Users.FindAsync(mentorId);
            if (item == null)
            {
                return NotFound();
            }

            if(user.About != null) item.About = user.About;
            if(user.Address != null) item.Address = user.Address;
            
            item.UpdatedTime = DateTime.Now;

            try
            {
                await _postgreSqlDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!UserItemExists(mentorId))
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPut("/UpdateUserInfo/{userId}")]
        public async Task<IActionResult> UpdateUserInfo(int userId, User user)
        {

            var item = await _postgreSqlDbContext.Users.FindAsync(userId);
            if (item == null)
            {
                return NotFound();
            }

            if (user.FirstName != null) item.FirstName = user.FirstName;
            if (user.LastName != null) item.LastName = user.LastName;
            if (user.Mail != null) item.Mail = user.Mail;

            item.UpdatedTime = DateTime.Now;

            try
            {
                await _postgreSqlDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!UserItemExists(userId))
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPut("/UpdatePassword/{userId}")]
        public async Task<IActionResult> UpdatePassword(int userId, ChangePasswordDto user)
        {

            var item = await _postgreSqlDbContext.Users.FindAsync(userId);
            if (item == null)
            {
                return NotFound();
            }
            if (!BCrypt.Net.BCrypt.Verify(user.previousPassword, item.Password)) return Ok(new { message = "Önceki şifreniz doğru değil!" });
            else
            {
                if(user.newPassword != user.verifyPassword) return Ok(new { message = "Şifre tekrarı aynı olmalıdır!" });
                else
                {
                    item.Password = BCrypt.Net.BCrypt.HashPassword(user.newPassword);
                    item.UpdatedTime = DateTime.Now;
                }
            }

            try
            {
                await _postgreSqlDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!UserItemExists(userId))
            {
                return NotFound();
            }

            return NoContent();
        }
        private bool UserItemExists(int id)
        {
            throw new NotImplementedException();
        }
    }
}