﻿// <auto-generated />
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
    [Migration("20211026131653_InitialCreate")]
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
                            CreatedDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "Microsoft",
                            UpdatedTime = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CorporationType = 2,
                            CreatedDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "Google",
                            UpdatedTime = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CorporationType = 3,
                            CreatedDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "Tesla",
                            UpdatedTime = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CorporationType = 4,
                            CreatedDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "Lenovo",
                            UpdatedTime = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CorporationType = 5,
                            CreatedDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "Toyota",
                            UpdatedTime = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
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
                            CreatedDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            MeetingLocationType = 1,
                            Name = "@Google Meet",
                            UpdatedTime = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            MeetingLocationType = 2,
                            Name = "@Zoom",
                            UpdatedTime = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            MeetingLocationType = 3,
                            Name = "@Jitsu Meet",
                            UpdatedTime = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
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
                            CreatedDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "Mentor",
                            RoleType = 1,
                            UpdatedTime = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "Mentee",
                            RoleType = 2,
                            UpdatedTime = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
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
                            Password = "AhmetCan123",
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
                            Password = "MuhsinDertli123",
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
                            Password = "KorayGüler123",
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
                            Password = "MertDoydu123",
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
                            Password = "KeremDan123",
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
