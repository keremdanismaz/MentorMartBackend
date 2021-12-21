using MentorCity.Core.Enums;

namespace MentorCity.Entities.Entities
{
    public class Corporation : BaseEntity
    {
        public CorporationTypeEnum CorporationType { get; set; }
        public string Name { get; set; }
    }
}