using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorCity.API.DataTranferObject
{
    public class ChangePasswordDto
    {
        public string previousPassword { get; set; }
        public string newPassword { get; set; }
        public string verifyPassword { get; set; }
    }
}
