using MentorCity.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorCity.Entities.Seeder
{
    public class MeetingLocationDataSeeder
    {
        internal static void Run(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MeetingLocation>().HasData(MeetingLocations);
        }

        private static List<MeetingLocation> MeetingLocations = new List<MeetingLocation>()
        {
           new MeetingLocation{
                Id=1,
                MeetingLocationType=Core.Enums.MeetingLocationTypeEnum.GoogleMeet,
                Name="@Google Meet",
                IsActive=true,
                CreatedDate= new DateTime(2020, 11, 01),
                UpdatedTime=new DateTime(2020, 11, 01)
           }, new MeetingLocation{
                Id=2,
                MeetingLocationType=Core.Enums.MeetingLocationTypeEnum.Zoom,
                Name="@Zoom",
                IsActive=true,
                CreatedDate= new DateTime(2020, 11, 01),
                UpdatedTime=new DateTime(2020, 11, 01)
           }, new MeetingLocation{
                Id=3,
                MeetingLocationType=Core.Enums.MeetingLocationTypeEnum.JitsuMeet,
                Name="@Jitsu Meet",
                IsActive=true,
                CreatedDate= new DateTime(2020, 11, 01),
                UpdatedTime=new DateTime(2020, 11, 01)
           }
        };
    }
}