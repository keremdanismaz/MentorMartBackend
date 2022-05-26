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
                CorporationType=Core.Enums.CorporationTypeEnum.Vispeahen,
                Name="Vispeahen",
                IsActive=true,
                CreatedDate= new DateTime(2022, 03, 19),
                UpdatedTime=new DateTime(2022, 03, 19)
           }, new Corporation{
                Id=2,
                CorporationType=Core.Enums.CorporationTypeEnum.Vodofone,
                Name="Vodofone Genç Gurup",
                IsActive=true,
                CreatedDate= new DateTime(2022, 03, 19),
                UpdatedTime=new DateTime(2022, 03, 19)
           }, new Corporation{
                Id=3,
                CorporationType=Core.Enums.CorporationTypeEnum.SMSElotherm,
                Name="SMS Elotherm Mekanik",
                IsActive=true,
                CreatedDate= new DateTime(2022, 03, 19),
                UpdatedTime=new DateTime(2022, 03, 19)
           },new Corporation{
                Id=4,
                CorporationType=Core.Enums.CorporationTypeEnum.KTUN,
                Name="Konya Teknik Üniversitesi Genç Girişimci",
                IsActive=true,
                CreatedDate= new DateTime(2022, 03, 19),
                UpdatedTime=new DateTime(2022, 03, 19)
           },new Corporation{
                Id=5,
                CorporationType=Core.Enums.CorporationTypeEnum.EnglishTime,
                Name="English Time Dil Okulları",
                IsActive=true,
                CreatedDate= new DateTime(2022, 03, 19),
                UpdatedTime=new DateTime(2022, 03, 19)
           }
        };
    }
}