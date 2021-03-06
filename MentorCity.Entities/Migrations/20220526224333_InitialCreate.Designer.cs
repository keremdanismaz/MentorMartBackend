// <auto-generated />
using System;
using MentorCity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MentorCity.Entities.Migrations
{
    [DbContext(typeof(PostgreSqlDbContext))]
    [Migration("20220526224333_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MentorCity.Entities.CorporationInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CorporationInfoText")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("CorporationServiceFive")
                        .HasColumnType("text");

                    b.Property<string>("CorporationServiceFour")
                        .HasColumnType("text");

                    b.Property<string>("CorporationServiceOne")
                        .HasColumnType("text");

                    b.Property<string>("CorporationServiceSix")
                        .HasColumnType("text");

                    b.Property<string>("CorporationServiceThree")
                        .HasColumnType("text");

                    b.Property<string>("CorporationServiceTwo")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("CorporationInfos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CorporationInfoText = "Vispeahen, 15 yılı aşkın veri ambarı, iş zekası, yazılım deneyimi bilgi birikiminin sonucu olarak ortaya çıkmış bir veri analiz platformudur. Vispeahen, sürekli artan ve büyüyen verileri stratejik kararlarda kullanılabilecek anlamlı bilgilere dönüştürür ve görselleştirir. Vispeahen, yeni grafikleri eklenti olarak eklemesi, farklı veri kaynaklarını aynı modelde görselleştirmesi, dağıtık mimaride çalışması, yüksek yük altında çalışması, görüntü dosyalarının metadatasını sorgulaması ve raporlaması ile diğer tüm görselleştirme ürünlerinden ayrılmaktadır. Vispeahen ile veriler kolay, hızlı ve estetik olarak görselleştirilebilir, dünyanın herhangi bir yerindeki herhangi bir masaüstü veya mobil cihazda, herhangi bir internet tarayıcısı ile kurulum gerektirmeden görüntülenebilir.",
                            CorporationServiceFive = "Toplantılarının zamanını takip et. Asla kaçırma senin için seferber olacağız.",
                            CorporationServiceFour = "Mentor bilgilerinden mentoruna bak ve mentorunu tanı.",
                            CorporationServiceOne = "Senin için özenle hazırlanmış notları incele.",
                            CorporationServiceSix = "Vispeahen ekibi elinden geleni yapacaktır.",
                            CorporationServiceThree = "Sorular kısmındaki sorulara cevap ver seni tanımama yardımcı ol.",
                            CorporationServiceTwo = "Toplantıları takip et ve toplantımızı kaçırma!",
                            CreatedDate = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            UpdatedTime = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CorporationInfoText = "Dünyanın en büyük teknoloji iletişimi şirketlerinden biri olan Vodafone Grubu’nun bünyesinde yer alan Vodafone Türkiye, “herkes için dijital bir gelecek inşa etme” vizyonu doğrultusunda, birey ve kurumlara sabit, mobil ve içerik hizmetleri dahil tüm telekomünikasyon teknolojilerini tek çatıda sunmaktadır. Türkiye’nin en büyük uluslararası doğrudan yatırımcılarından olan Vodafone Türkiye’nin bugüne kadar toplam yatırımları 24 milyar TL’ye ulaşmıştır. Vodafone Türkiye, 30 Haziran 2020 itibarıyla 23,6 milyon mobil müşteriye ve 1,1 milyon sabit genişbant müşterisine hizmet vermektedir. Ayrıntılı bilgi için www.vodafone.com.tr adresi ziyaret edilebilir.",
                            CorporationServiceFive = "Toplantılarının zamanını takip et. Asla kaçırma senin için seferber olacağız.",
                            CorporationServiceFour = "Mentor bilgilerinden mentoruna bak ve mentorunu tanı.",
                            CorporationServiceOne = "Senin için özenle hazırlanmış notları incele.",
                            CorporationServiceSix = "Vodofone ekibi elinden geleni yapacaktır.",
                            CorporationServiceThree = "Sorular kısmındaki sorulara cevap ver seni tanımama yardımcı ol.",
                            CorporationServiceTwo = "Toplantıları takip et ve toplantımızı kaçırma!",
                            CreatedDate = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            UpdatedTime = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            CorporationInfoText = "Metallerin endüktif ısıtma ve ısıl işlemlerinde uzun yıllara dayanan bilgi birikimi, SMS Elotherm'i güvenilir ortağınız yapar! Uzun ürünlerin ve yassı ürünlerin haddelenmesi, şerit ısıtma, dövme ısıtma, krank mili ve eksantrik mili sertleştirme, yüzey katmanı sertleştirme, halka sertleştirme, mil sertleştirme ve çok daha fazlası için metal ısıtma sistemleri sunuyoruz! Bu yolda eğitebileceğimiz adaylar sizlersiniz.",
                            CorporationServiceFive = "Toplantılarının zamanını takip et. Asla kaçırma senin için seferber olacağız.",
                            CorporationServiceFour = "Mentor bilgilerinden mentoruna bak ve mentorunu tanı.",
                            CorporationServiceOne = "Senin için özenle hazırlanmış notları incele.",
                            CorporationServiceSix = "SMS Elotherm ekibi elinden geleni yapacaktır.",
                            CorporationServiceThree = "Sorular kısmındaki sorulara cevap ver seni tanımama yardımcı ol.",
                            CorporationServiceTwo = "Toplantıları takip et ve toplantımızı kaçırma!",
                            CreatedDate = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            UpdatedTime = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            CorporationInfoText = "Mezunları evrensel değerlere bağlı, araştırmacı, üretken, paylaşımcı, özgüvenli ve yetkin olan; sürdürülebilir ve yenilikçi araştırmalarla bilim ve teknolojiyi üreten; toplumun kalkınması ve refahı için insan ve çevre odaklı çözümler sunan; alanlarında öncü araştırma faaliyetlerini tasarlayan ve gerçekleştiren bir araştırma üniversitesi olmak. KTUN sizleri eğitmek için sabırsılıkla bekliyor.",
                            CorporationServiceFive = "Toplantılarının zamanını takip et. Asla kaçırma senin için seferber olacağız.",
                            CorporationServiceFour = "Mentor bilgilerinden mentoruna bak ve mentorunu tanı.",
                            CorporationServiceOne = "Senin için özenle hazırlanmış notları incele.",
                            CorporationServiceSix = "KTUN ekibi elinden geleni yapacaktır.",
                            CorporationServiceThree = "Sorular kısmındaki sorulara cevap ver seni tanımama yardımcı ol.",
                            CorporationServiceTwo = "Toplantıları takip et ve toplantımızı kaçırma!",
                            CreatedDate = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            UpdatedTime = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            CorporationInfoText = "Bazı insanlar dil öğrenmek için doğal bir yeteneğe sahiptir, ancak diğerleri için yeni bir dil öğrenmek zor bir görev olabilir. Yeni bir dil öğrenmenin en iyi yolu, kendi öğrenme stilinize bağlı olarak değişir. İngilizce eğitimi günümüzde tüm dünyada olmazsa olmaz etkinliklerin arasına girmiş durumda. İngilizce eğitiminin önemi gün geçtikçe daha çok insan tarafından kavranıyor. İster okulda ister iş hayatında olun, başarıya ulaşmak için İngilizce bilmek, daha da önemlisi İngilizce konuşabilmek gerekiyor. Bu alanda başarılı olmanız için elimizden geleni yapacağız.",
                            CorporationServiceFive = "Toplantılarının zamanını takip et. Asla kaçırma senin için seferber olacağız.",
                            CorporationServiceFour = "Mentor bilgilerinden mentoruna bak ve mentorunu tanı.",
                            CorporationServiceOne = "Senin için özenle hazırlanmış notları incele.",
                            CorporationServiceSix = "English Time ekibi elinden geleni yapacaktır.",
                            CorporationServiceThree = "Sorular kısmındaki sorulara cevap ver seni tanımama yardımcı ol.",
                            CorporationServiceTwo = "Toplantıları takip et ve toplantımızı kaçırma!",
                            CreatedDate = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            UpdatedTime = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 5
                        });
                });

            modelBuilder.Entity("MentorCity.Entities.Entities.Corporation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CorporationType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Corporations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CorporationType = 1,
                            CreatedDate = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "Vispeahen",
                            UpdatedTime = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CorporationType = 2,
                            CreatedDate = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "Vodofone Genç Gurup",
                            UpdatedTime = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CorporationType = 3,
                            CreatedDate = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "SMS Elotherm Mekanik",
                            UpdatedTime = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CorporationType = 4,
                            CreatedDate = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "Konya Teknik Üniversitesi Genç Girişimci",
                            UpdatedTime = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CorporationType = 5,
                            CreatedDate = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "English Time Dil Okulları",
                            UpdatedTime = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MentorCity.Entities.Entities.MeetingLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<int>("MeetingLocationType")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("MeetingLocations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            MeetingLocationType = 1,
                            Name = "@Google Meet",
                            UpdatedTime = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            MeetingLocationType = 2,
                            Name = "@Zoom",
                            UpdatedTime = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            MeetingLocationType = 3,
                            Name = "@Jitsu Meet",
                            UpdatedTime = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MentorCity.Entities.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("RoleType")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "Mentor",
                            RoleType = 1,
                            UpdatedTime = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "Mentee",
                            RoleType = 2,
                            UpdatedTime = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MentorCity.Entities.Meeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("MeetingDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("MeetingEndingTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("MeetingLink")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("MeetingLocationId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("MeetingStartingTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("MeetingTopic")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<int>("MenteeId")
                        .HasColumnType("integer");

                    b.Property<int>("MentorId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MeetingLocationId");

                    b.HasIndex("MenteeId");

                    b.HasIndex("MentorId");

                    b.HasIndex("UserId");

                    b.ToTable("Meetings");
                });

            modelBuilder.Entity("MentorCity.Entities.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<int>("MenteeId")
                        .HasColumnType("integer");

                    b.Property<int>("MentorId")
                        .HasColumnType("integer");

                    b.Property<string>("NoteDescription")
                        .HasColumnType("text");

                    b.Property<DateTime>("NoteEndingTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("NoteLink")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("NoteLinkName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("NoteTitle")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MenteeId");

                    b.HasIndex("MentorId");

                    b.HasIndex("UserId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("MentorCity.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("text");

                    b.Property<string>("AskQuestion")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<int>("MenteeId")
                        .HasColumnType("integer");

                    b.Property<int>("MentorId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MenteeId");

                    b.HasIndex("MentorId");

                    b.HasIndex("UserId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("MentorCity.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("About")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Address")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<int>("CoprorationId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<int?>("MentorId")
                        .HasColumnType("integer");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CoprorationId");

                    b.HasIndex("MentorId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "Merhaba. 2008'den beri grafik tasarım, illüstrasyon ve plastik sanatlar alanlarında, üretmekteyim. Son 4 yıldır yurtiçi-yurtdışı çeşitli markalar için serbest çalışıyorum.2020, Eylül'de Web Tasarım ve Kodlama bölümüne kayıt oldum. Kendime yeni bir artı daha eklemek heyecan verici. Bu yeni alanda üretmek için sabırsızlanıyorum.",
                            Address = "Eskişehir, Türkiye",
                            CoprorationId = 1,
                            CreatedDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ahmet",
                            IsActive = true,
                            LastName = "Candemir",
                            Mail = "ahmetCandemir@gmail.com",
                            Password = "$2a$11$9I/cq9tUgEzPGSjdkUWj/ebv1gWt3zPUa4S9saAS0qVCoZ14BSvQa",
                            RoleId = 1,
                            UpdatedTime = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            About = "Teknik liseden mezun olduktan sonra Sütçü İmam Üni. 'nde Bilgisayar Müh. okumaktayım. Çeşitli firmalarda Frontend Developer olarak görev aldım. Arneca Technology de stajımı yaptıktan sonra aynı firmada aktif olarak Frontned Developer olarak çalışmaktayım. Üzerinde çalıştığım teknolojiler, HTML5, CSS3, SCSS, Bootstrap, JQuery, JSON, AJAX, React.js, PHP, MySQL",
                            Address = "KahramanMaraş, Türkiye",
                            CoprorationId = 2,
                            CreatedDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Muhsin",
                            IsActive = true,
                            LastName = "Dertlitek",
                            Mail = "muhsinDertli@gmail.com",
                            Password = "$2a$11$0B7ZKbVOl7T77T996zTrPuKR6L99vsrUAydhQyqmhAdNi17XlqeTm",
                            RoleId = 1,
                            UpdatedTime = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            About = "Merhaba ben Koray arayüz geliştiricisiyim. Yeni teknoloji, trendleri yakından takip eden ve sürekli öğrenen biriyim, yazılım geliştirmeyi ve içerik üretmeyi seviyorum. Genel olarak javascript ve web teknolojileri ile ilgileniyorum. Artan zamanımda iste kahve hazırlamaktan ve müzik dinlemekten hoşlanırım.",
                            Address = "İstanbul, Türkiye",
                            CoprorationId = 3,
                            CreatedDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Koray",
                            IsActive = true,
                            LastName = "Güler",
                            Mail = "korayGüler@gmail.com",
                            Password = "$2a$11$182tonlckpGDHEC7FLT.d.q6iq52Bx6BFpmfK5.ZlY4LNurR0jyKO",
                            RoleId = 1,
                            UpdatedTime = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            About = "Bilgisayar Mühendisi (Android Geliştirici) Android uygulama geliştirmede Kotlin ve Java dillerine hakimim. Üçüncü parti kütüphane kullanabilen, Web Services, SOAP, REST API, JSON, XML konularında bilgi ve tecrübe sahibiyim. Arayüz komponentleri geliştirme ve verilen görsel tasarımları, uygulamalara giydirme konusunda deneyim sahibiyim. GIT, SVN, TFS gibi versiyonlama sistemleri hakkında bilgi sahibiyim. Ekip çalışmasına uyumlu, yeni teknolojileri öğrenmeye meraklı ve araştırmacıyım.",
                            Address = "İzmir, Türkiye",
                            CoprorationId = 4,
                            CreatedDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Mert",
                            IsActive = true,
                            LastName = "Doydu",
                            Mail = "mertDoydu@gmail.com",
                            Password = "$2a$11$jRNonQGz2sHz.OdLxzvsGOtjrEpigSl1C.TroLoFE2TTcwPGT3eey",
                            RoleId = 1,
                            UpdatedTime = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            About = "MentorCity tüm kurum ve organizasyonlarda hemen devreye alınabilir. MentorCity bir danışmanlık şirketi değildir. Mentorluk, koçluk veya eğitim hizmeti sunmaz. Kurum olarak eğitim ve gelişim programlarınız için danışmanlık hizmeti alıyorsanız MentorCity platformunuzu kendi danışmanlarınız ile birlikte yönetebilirsiniz.",
                            Address = "Ankara, Türkiye",
                            CoprorationId = 5,
                            CreatedDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Kerem",
                            IsActive = true,
                            LastName = "Danışmaz",
                            Mail = "danismaz2000@gmail.com",
                            Password = "$2a$11$ViRXs3JbGGBLA4r3EtXPLej3Lh.qEmI1TGDijZ43xEJre.HuE4R1y",
                            RoleId = 1,
                            UpdatedTime = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MentorCity.Entities.CorporationInfo", b =>
                {
                    b.HasOne("MentorCity.Entities.User", "User")
                        .WithOne("CorporationInfo")
                        .HasForeignKey("MentorCity.Entities.CorporationInfo", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MentorCity.Entities.Meeting", b =>
                {
                    b.HasOne("MentorCity.Entities.Entities.MeetingLocation", "MeetingLocation")
                        .WithMany()
                        .HasForeignKey("MeetingLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MentorCity.Entities.User", "Mentee")
                        .WithMany()
                        .HasForeignKey("MenteeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MentorCity.Entities.User", "Mentor")
                        .WithMany()
                        .HasForeignKey("MentorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MentorCity.Entities.User", null)
                        .WithMany("Meetings")
                        .HasForeignKey("UserId");

                    b.Navigation("MeetingLocation");

                    b.Navigation("Mentee");

                    b.Navigation("Mentor");
                });

            modelBuilder.Entity("MentorCity.Entities.Note", b =>
                {
                    b.HasOne("MentorCity.Entities.User", "Mentee")
                        .WithMany()
                        .HasForeignKey("MenteeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MentorCity.Entities.User", "Mentor")
                        .WithMany()
                        .HasForeignKey("MentorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MentorCity.Entities.User", null)
                        .WithMany("Notes")
                        .HasForeignKey("UserId");

                    b.Navigation("Mentee");

                    b.Navigation("Mentor");
                });

            modelBuilder.Entity("MentorCity.Entities.Question", b =>
                {
                    b.HasOne("MentorCity.Entities.User", "Mentee")
                        .WithMany()
                        .HasForeignKey("MenteeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MentorCity.Entities.User", "Mentor")
                        .WithMany()
                        .HasForeignKey("MentorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MentorCity.Entities.User", null)
                        .WithMany("Questions")
                        .HasForeignKey("UserId");

                    b.Navigation("Mentee");

                    b.Navigation("Mentor");
                });

            modelBuilder.Entity("MentorCity.Entities.User", b =>
                {
                    b.HasOne("MentorCity.Entities.Entities.Corporation", "Coproration")
                        .WithMany()
                        .HasForeignKey("CoprorationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MentorCity.Entities.User", "Mentor")
                        .WithMany()
                        .HasForeignKey("MentorId");

                    b.HasOne("MentorCity.Entities.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coproration");

                    b.Navigation("Mentor");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("MentorCity.Entities.User", b =>
                {
                    b.Navigation("CorporationInfo");

                    b.Navigation("Meetings");

                    b.Navigation("Notes");

                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
