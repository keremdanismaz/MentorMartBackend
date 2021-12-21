using MentorCity.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorCity.Entities
{
    public class Meeting : BaseEntity
    {
        public int MentorId { get; set; }
        public User Mentor { get; set; }
        public int MenteeId { get; set; }
        public User Mentee { get; set; }
        public string MeetingTopic { get; set; }
        public DateTime MeetingDate { get; set; }
        public DateTime MeetingStartingTime { get; set; }
        public DateTime MeetingEndingTime { get; set; }
        public MeetingLocation MeetingLocation { get; set; }
        public int MeetingLocationId { get; set; }
        public string MeetingLink { get; set; }
    }
}