using System;

namespace MentorCity.Entities
{
    public class Note : BaseEntity
    {
        public int MentorId { get; set; }
        public User Mentor { get; set; }
        public int MenteeId { get; set; }
        public User Mentee { get; set; }
        public string NoteTitle { get; set; }
        public string NoteDescription { get; set; }
        public string NoteLinkName { get; set; }
        public string NoteLink { get; set; }
        public DateTime NoteEndingTime { get; set; }
    }
}