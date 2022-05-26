using MentorCity.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace MentorCity.Entities.Seeder
{
    public class UserDataSeeder
    {

        internal static void Run(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(Users);
        }

        private static List<User> Users = new List<User>()
        {
           new User{
                Id=1,
                CoprorationId=1,
                RoleId=1,
                FirstName="Ahmet",
                LastName="Candemir",
                Mail="ahmetCandemir@gmail.com",
                Password=BCrypt.Net.BCrypt.HashPassword("AhmetCan123"),
                About="Merhaba. 2008'den beri grafik tasarım, illüstrasyon ve plastik sanatlar alanlarında, üretmekteyim. Son 4 yıldır yurtiçi-yurtdışı çeşitli markalar için serbest çalışıyorum.2020, Eylül'de Web Tasarım ve Kodlama bölümüne kayıt oldum. Kendime yeni bir artı daha eklemek heyecan verici. Bu yeni alanda üretmek için sabırsızlanıyorum.",
                Address="Eskişehir, Türkiye",
                IsActive=true,
                CreatedDate= new DateTime(2020, 11, 01),
                UpdatedTime=new DateTime(2020, 11, 01)
           },  new User{
                Id=2,
                CoprorationId=2,
                RoleId=1,
                FirstName="Muhsin",
                LastName="Dertlitek",
                Mail="muhsinDertli@gmail.com",
                Password=BCrypt.Net.BCrypt.HashPassword("MuhsinDertli123"),
                About="Teknik liseden mezun olduktan sonra Sütçü İmam Üni. 'nde Bilgisayar Müh. okumaktayım. Çeşitli firmalarda Frontend Developer olarak görev aldım. Arneca Technology de stajımı yaptıktan sonra aynı firmada aktif olarak Frontned Developer olarak çalışmaktayım. Üzerinde çalıştığım teknolojiler, HTML5, CSS3, SCSS, Bootstrap, JQuery, JSON, AJAX, React.js, PHP, MySQL",
                Address="KahramanMaraş, Türkiye",
                IsActive=true,
                CreatedDate= new DateTime(2020, 11, 01),
                UpdatedTime=new DateTime(2020, 11, 01)
           },  new User{
                Id=3,
                CoprorationId=3,
                RoleId=1,
                FirstName="Koray",
                LastName="Güler",
                Mail="korayGüler@gmail.com",
                Password= BCrypt.Net.BCrypt.HashPassword("KorayGüler123"),
                About="Merhaba ben Koray arayüz geliştiricisiyim. Yeni teknoloji, trendleri yakından takip eden ve sürekli öğrenen biriyim, yazılım geliştirmeyi ve içerik üretmeyi seviyorum. Genel olarak javascript ve web teknolojileri ile ilgileniyorum. Artan zamanımda iste kahve hazırlamaktan ve müzik dinlemekten hoşlanırım.",
                Address="İstanbul, Türkiye",
                IsActive=true,
                CreatedDate= new DateTime(2020, 11, 01),
                UpdatedTime=new DateTime(2020, 11, 01)
           },  new User{
                Id=4,
                CoprorationId=4,
                RoleId=1,
                FirstName="Mert",
                LastName="Doydu",
                Mail="mertDoydu@gmail.com",
                Password= BCrypt.Net.BCrypt.HashPassword("MertDoydu123"),
                About="Bilgisayar Mühendisi (Android Geliştirici) Android uygulama geliştirmede Kotlin ve Java dillerine hakimim. Üçüncü parti kütüphane kullanabilen, Web Services, SOAP, REST API, JSON, XML konularında bilgi ve tecrübe sahibiyim. Arayüz komponentleri geliştirme ve verilen görsel tasarımları, uygulamalara giydirme konusunda deneyim sahibiyim. GIT, SVN, TFS gibi versiyonlama sistemleri hakkında bilgi sahibiyim. Ekip çalışmasına uyumlu, yeni teknolojileri öğrenmeye meraklı ve araştırmacıyım.",
                Address="İzmir, Türkiye",
                IsActive=true,
                CreatedDate= new DateTime(2020, 11, 01),
                UpdatedTime=new DateTime(2020, 11, 01)
           }, new User{
                Id=5,
                CoprorationId=5,
                RoleId=1,
                FirstName="Kerem",
                LastName="Danışmaz",
                Mail="danismaz2000@gmail.com",
                Password= BCrypt.Net.BCrypt.HashPassword("KeremDan123"),
                About="MentorCity tüm kurum ve organizasyonlarda hemen devreye alınabilir. MentorCity bir danışmanlık şirketi değildir. Mentorluk, koçluk veya eğitim hizmeti sunmaz. Kurum olarak eğitim ve gelişim programlarınız için danışmanlık hizmeti alıyorsanız MentorCity platformunuzu kendi danışmanlarınız ile birlikte yönetebilirsiniz.",
                Address="Ankara, Türkiye",
                IsActive=true,
                CreatedDate= new DateTime(2020, 11, 01),
                UpdatedTime=new DateTime(2020, 11, 01)
           },
        };
    }
}