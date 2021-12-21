namespace MentorCity.Entities
{
    public class Question : BaseEntity
    {
        public int MentorId { get; set; }
        public User Mentor { get; set; }
        public int MenteeId { get; set; }
        public User Mentee { get; set; }
        public string AskQuestion { get; set; }
        public string Answer { get; set; }
    }
}