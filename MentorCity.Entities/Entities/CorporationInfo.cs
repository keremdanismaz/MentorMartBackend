using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorCity.Entities
{
    public class CorporationInfo : BaseEntity
    {
        public int UserId { get; set; }
        public string CorporationInfoText { get; set; }
        public string CorporationServiceOne { get; set; }
        public string CorporationServiceTwo { get; set; }
        public string CorporationServiceThree { get; set; }
        public string CorporationServiceFour { get; set; }
        public string CorporationServiceFive { get; set; }
        public string CorporationServiceSix { get; set; }
        public User User { get; set; }
    }
}
