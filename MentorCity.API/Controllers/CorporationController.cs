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
    public class CorporationController : ControllerBase
    {
        private readonly PostgreSqlDbContext _postgreSqlDbContext;

        public CorporationController(PostgreSqlDbContext postgreSqlDbContext)
        {
            _postgreSqlDbContext = postgreSqlDbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Corporation>> GetCorporationName()
        {
            return await _postgreSqlDbContext.Corporations.Where(x => x.IsActive == true).ToListAsync();
        }

        [HttpGet("/corporationInfo/{id:int}")]
        public async Task<IEnumerable<CorporationInfo>> GetCorporationInfo(int id)
        {
            var roleId = _postgreSqlDbContext.Users.Where(x => x.Id == id && x.IsActive == true).Select(x => x.RoleId);
            int userId = 0;

            if (roleId == null) return null;

            if (roleId.First() == 1) userId = id;
            if (roleId.First() == 2)
            {
                var mentorId = _postgreSqlDbContext.Users.Where(x => x.Id == id && x.IsActive == true).Select(x => x.MentorId).FirstOrDefault();
                userId = (int)mentorId;
            }

            return _postgreSqlDbContext.CorporationInfos.Where(x => x.UserId == userId && x.IsActive == true);

        }

        [HttpPut("{mentorId}")]
        public async Task<IActionResult> UpdateCorporationInfo(int mentorId, CorporationInfo corInfo)
        {

            var item = await _postgreSqlDbContext.CorporationInfos.FindAsync(mentorId);
            if (item == null)
            {
                return NotFound();
            }

            item.CorporationInfoText = corInfo.CorporationInfoText;
            item.CorporationServiceOne = corInfo.CorporationServiceOne;
            item.CorporationServiceTwo = corInfo.CorporationServiceTwo;
            item.CorporationServiceThree = corInfo.CorporationServiceThree;
            if(corInfo.CorporationServiceFour != null) item.CorporationServiceFour = corInfo.CorporationServiceFour;
            if(corInfo.CorporationServiceFive != null) item.CorporationServiceFive = corInfo.CorporationServiceFive;
            if(corInfo.CorporationServiceSix != null) item.CorporationServiceSix = corInfo.CorporationServiceSix;
            item.UpdatedTime = DateTime.Now;

            try
            {
                await _postgreSqlDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!CorporationInfoItemExists(mentorId))
            {
                return NotFound();
            }

            return NoContent();
        }

        private bool CorporationInfoItemExists(int id)
        {
            throw new NotImplementedException();
        }

    }
}