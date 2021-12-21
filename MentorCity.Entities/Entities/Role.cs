using MentorCity.Core.Enums;

namespace MentorCity.Entities.Entities
{
    public class Role : BaseEntity
    {
        public RoleTypeEnum RoleType { get; set; }
        public string Name { get; set; }
    }
}