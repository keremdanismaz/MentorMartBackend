using MentorCity.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace MentorCity.Entities.Seeder
{
    public class RoleDataSeeder
    {
        internal static void Run(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(Roles);
        }

        private static List<Role> Roles = new List<Role>()
        {
           new Role{
                Id=1,
                RoleType=Core.Enums.RoleTypeEnum.Mentor,
                Name="Mentor",
                IsActive=true,
                CreatedDate= new DateTime(2022, 03, 19),
                UpdatedTime=new DateTime(2022, 03, 19)
           }, new Role{
                Id=2,
                RoleType=Core.Enums.RoleTypeEnum.Mentee,
                Name="Mentee",
                IsActive=true,
                CreatedDate= new DateTime(2022, 03, 19),
                UpdatedTime=new DateTime(2022, 03, 19)
           }
        };
    }
}