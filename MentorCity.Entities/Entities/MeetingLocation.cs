using MentorCity.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorCity.Entities.Entities
{
    public class MeetingLocation : BaseEntity
    {
        public MeetingLocationTypeEnum MeetingLocationType { get; set; }
        public string Name { get; set; }
    }
}