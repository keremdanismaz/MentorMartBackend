using MentorCity.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace MentorCity.Entities.Seeder
{
    public class CorporationInfoDataSeeder
    {
        internal static void Run(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CorporationInfo>().HasData(CorporationInfos);
        }

        private static List<CorporationInfo> CorporationInfos = new List<CorporationInfo>()
        {
           new CorporationInfo{
                Id=1,
                UserId =1,
                CorporationInfoText = "Vispeahen, 15 yılı aşkın veri ambarı, iş zekası, yazılım deneyimi bilgi birikiminin sonucu olarak ortaya çıkmış bir veri analiz platformudur. Vispeahen, sürekli artan ve büyüyen verileri stratejik kararlarda kullanılabilecek anlamlı bilgilere dönüştürür ve görselleştirir. Vispeahen, yeni grafikleri eklenti olarak eklemesi, farklı veri kaynaklarını aynı modelde görselleştirmesi, dağıtık mimaride çalışması, yüksek yük altında çalışması, görüntü dosyalarının metadatasını sorgulaması ve raporlaması ile diğer tüm görselleştirme ürünlerinden ayrılmaktadır. Vispeahen ile veriler kolay, hızlı ve estetik olarak görselleştirilebilir, dünyanın herhangi bir yerindeki herhangi bir masaüstü veya mobil cihazda, herhangi bir internet tarayıcısı ile kurulum gerektirmeden görüntülenebilir.",
                CorporationServiceOne = "Senin için özenle hazırlanmış notları incele.",
                CorporationServiceTwo = "Toplantıları takip et ve toplantımızı kaçırma!",
                CorporationServiceThree = "Sorular kısmındaki sorulara cevap ver seni tanımama yardımcı ol.",
                CorporationServiceFour = "Mentor bilgilerinden mentoruna bak ve mentorunu tanı.",
                CorporationServiceFive = "Toplantılarının zamanını takip et. Asla kaçırma senin için seferber olacağız.",
                CorporationServiceSix = "Vispeahen ekibi elinden geleni yapacaktır.",
                IsActive=true,
                CreatedDate= new DateTime(2022, 03, 19),
                UpdatedTime=new DateTime(2022, 03, 19)
           },  new CorporationInfo{
                Id=2,
                UserId =2,
                CorporationInfoText = "Dünyanın en büyük teknoloji iletişimi şirketlerinden biri olan Vodafone Grubu’nun bünyesinde yer alan Vodafone Türkiye, “herkes için dijital bir gelecek inşa etme” vizyonu doğrultusunda, birey ve kurumlara sabit, mobil ve içerik hizmetleri dahil tüm telekomünikasyon teknolojilerini tek çatıda sunmaktadır. Türkiye’nin en büyük uluslararası doğrudan yatırımcılarından olan Vodafone Türkiye’nin bugüne kadar toplam yatırımları 24 milyar TL’ye ulaşmıştır. Vodafone Türkiye, 30 Haziran 2020 itibarıyla 23,6 milyon mobil müşteriye ve 1,1 milyon sabit genişbant müşterisine hizmet vermektedir. Ayrıntılı bilgi için www.vodafone.com.tr adresi ziyaret edilebilir.",
                CorporationServiceOne = "Senin için özenle hazırlanmış notları incele.",
                CorporationServiceTwo = "Toplantıları takip et ve toplantımızı kaçırma!",
                CorporationServiceThree = "Sorular kısmındaki sorulara cevap ver seni tanımama yardımcı ol.",
                CorporationServiceFour = "Mentor bilgilerinden mentoruna bak ve mentorunu tanı.",
                CorporationServiceFive = "Toplantılarının zamanını takip et. Asla kaçırma senin için seferber olacağız.",
                CorporationServiceSix = "Vodofone ekibi elinden geleni yapacaktır.",
                IsActive=true,
                CreatedDate= new DateTime(2022, 03, 19),
                UpdatedTime=new DateTime(2022, 03, 19)
           },  new CorporationInfo{
                Id=3,
                UserId =3,
                CorporationInfoText = "Metallerin endüktif ısıtma ve ısıl işlemlerinde uzun yıllara dayanan bilgi birikimi, SMS Elotherm'i güvenilir ortağınız yapar! Uzun ürünlerin ve yassı ürünlerin haddelenmesi, şerit ısıtma, dövme ısıtma, krank mili ve eksantrik mili sertleştirme, yüzey katmanı sertleştirme, halka sertleştirme, mil sertleştirme ve çok daha fazlası için metal ısıtma sistemleri sunuyoruz! Bu yolda eğitebileceğimiz adaylar sizlersiniz.",
                CorporationServiceOne = "Senin için özenle hazırlanmış notları incele.",
                CorporationServiceTwo = "Toplantıları takip et ve toplantımızı kaçırma!",
                CorporationServiceThree = "Sorular kısmındaki sorulara cevap ver seni tanımama yardımcı ol.",
                CorporationServiceFour = "Mentor bilgilerinden mentoruna bak ve mentorunu tanı.",
                CorporationServiceFive = "Toplantılarının zamanını takip et. Asla kaçırma senin için seferber olacağız.",
                CorporationServiceSix = "SMS Elotherm ekibi elinden geleni yapacaktır.",
                IsActive=true,
                CreatedDate= new DateTime(2022, 03, 19),
                UpdatedTime=new DateTime(2022, 03, 19)
           },  new CorporationInfo{
                Id=4,
                UserId =4,
                CorporationInfoText = "Mezunları evrensel değerlere bağlı, araştırmacı, üretken, paylaşımcı, özgüvenli ve yetkin olan; sürdürülebilir ve yenilikçi araştırmalarla bilim ve teknolojiyi üreten; toplumun kalkınması ve refahı için insan ve çevre odaklı çözümler sunan; alanlarında öncü araştırma faaliyetlerini tasarlayan ve gerçekleştiren bir araştırma üniversitesi olmak. KTUN sizleri eğitmek için sabırsılıkla bekliyor.",
                CorporationServiceOne = "Senin için özenle hazırlanmış notları incele.",
                CorporationServiceTwo = "Toplantıları takip et ve toplantımızı kaçırma!",
                CorporationServiceThree = "Sorular kısmındaki sorulara cevap ver seni tanımama yardımcı ol.",
                CorporationServiceFour = "Mentor bilgilerinden mentoruna bak ve mentorunu tanı.",
                CorporationServiceFive = "Toplantılarının zamanını takip et. Asla kaçırma senin için seferber olacağız.",
                CorporationServiceSix = "KTUN ekibi elinden geleni yapacaktır.",
                IsActive=true,
                CreatedDate= new DateTime(2022, 03, 19),
                UpdatedTime=new DateTime(2022, 03, 19)
           },  new CorporationInfo{
                Id=5,
                UserId =5,
                CorporationInfoText = "Bazı insanlar dil öğrenmek için doğal bir yeteneğe sahiptir, ancak diğerleri için yeni bir dil öğrenmek zor bir görev olabilir. Yeni bir dil öğrenmenin en iyi yolu, kendi öğrenme stilinize bağlı olarak değişir. İngilizce eğitimi günümüzde tüm dünyada olmazsa olmaz etkinliklerin arasına girmiş durumda. İngilizce eğitiminin önemi gün geçtikçe daha çok insan tarafından kavranıyor. İster okulda ister iş hayatında olun, başarıya ulaşmak için İngilizce bilmek, daha da önemlisi İngilizce konuşabilmek gerekiyor. Bu alanda başarılı olmanız için elimizden geleni yapacağız.",
                CorporationServiceOne = "Senin için özenle hazırlanmış notları incele.",
                CorporationServiceTwo = "Toplantıları takip et ve toplantımızı kaçırma!",
                CorporationServiceThree = "Sorular kısmındaki sorulara cevap ver seni tanımama yardımcı ol.",
                CorporationServiceFour = "Mentor bilgilerinden mentoruna bak ve mentorunu tanı.",
                CorporationServiceFive = "Toplantılarının zamanını takip et. Asla kaçırma senin için seferber olacağız.",
                CorporationServiceSix = "English Time ekibi elinden geleni yapacaktır.",
                IsActive=true,
                CreatedDate= new DateTime(2022, 03, 19),
                UpdatedTime=new DateTime(2022, 03, 19)
           },

        };
    }
}