using MentorCity.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace MentorCity.Entities.Seeder
{
    public class CorporationDataSeeder
    {
        internal static void Run(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Corporation>().HasData(Corporations);
        }

        private static List<Corporation> Corporations = new List<Corporation>()
        {
           new Corporation{
                Id=1,
                CorporationType=Core.Enums.CorporationTypeEnum.Microsoft,
                Name="Microsoft",
                IsActive=true,
                CreatedDate= new DateTime(2020, 11, 01),
                UpdatedTime=new DateTime(2020, 11, 01)
           }, new Corporation{
                Id=2,
                CorporationType=Core.Enums.CorporationTypeEnum.Google,
                Name="Google",
                IsActive=true,
                CreatedDate= new DateTime(2020, 11, 01),
                UpdatedTime=new DateTime(2020, 11, 01)
           }, new Corporation{
                Id=3,
                CorporationType=Core.Enums.CorporationTypeEnum.Tesla,
                Name="Tesla",
                IsActive=true,
                CreatedDate= new DateTime(2020, 11, 01),
                UpdatedTime=new DateTime(2020, 11, 01)
           },new Corporation{
                Id=4,
                CorporationType=Core.Enums.CorporationTypeEnum.Lenovo,
                Name="Lenovo",
                IsActive=true,
                CreatedDate= new DateTime(2020, 11, 01),
                UpdatedTime=new DateTime(2020, 11, 01)
           },new Corporation{
                Id=5,
                CorporationType=Core.Enums.CorporationTypeEnum.Toyota,
                Name="Toyota",
                IsActive=true,
                CreatedDate= new DateTime(2020, 11, 01),
                UpdatedTime=new DateTime(2020, 11, 01)
           }
        };
    }
}