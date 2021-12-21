using MentorCity.Entities.Entities;
using System.Collections.Generic;

namespace MentorCity.Entities
{
    public class User : BaseEntity
    {
        public Corporation Coproration { get; set; }
        public int CoprorationId { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
        public int? MentorId { get; set; }
        public User Mentor { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string About { get; set; }
        public string Address { get; set; }
        public ICollection<Note> Notes { get; set; }
        public ICollection<Meeting> Meetings { get; set; }
        public ICollection<Question> Questions { get; set; }
        public CorporationInfo CorporationInfo { get; set; }
    }
}