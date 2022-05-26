using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MentorCity.Entities.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Corporations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CorporationType = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corporations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeetingLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MeetingLocationType = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleType = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CoprorationId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    MentorId = table.Column<int>(type: "integer", nullable: true),
                    FirstName = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Mail = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Password = table.Column<string>(type: "character varying(400)", maxLength: 400, nullable: false),
                    About = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Address = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Corporations_CoprorationId",
                        column: x => x.CoprorationId,
                        principalTable: "Corporations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Users_MentorId",
                        column: x => x.MentorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CorporationInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CorporationInfoText = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    CorporationServiceOne = table.Column<string>(type: "text", nullable: true),
                    CorporationServiceTwo = table.Column<string>(type: "text", nullable: true),
                    CorporationServiceThree = table.Column<string>(type: "text", nullable: true),
                    CorporationServiceFour = table.Column<string>(type: "text", nullable: true),
                    CorporationServiceFive = table.Column<string>(type: "text", nullable: true),
                    CorporationServiceSix = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorporationInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CorporationInfos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meetings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MentorId = table.Column<int>(type: "integer", nullable: false),
                    MenteeId = table.Column<int>(type: "integer", nullable: false),
                    MeetingTopic = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    MeetingDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    MeetingStartingTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    MeetingEndingTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    MeetingLocationId = table.Column<int>(type: "integer", nullable: false),
                    MeetingLink = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meetings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meetings_MeetingLocations_MeetingLocationId",
                        column: x => x.MeetingLocationId,
                        principalTable: "MeetingLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meetings_Users_MenteeId",
                        column: x => x.MenteeId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meetings_Users_MentorId",
                        column: x => x.MentorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meetings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MentorId = table.Column<int>(type: "integer", nullable: false),
                    MenteeId = table.Column<int>(type: "integer", nullable: false),
                    NoteTitle = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    NoteDescription = table.Column<string>(type: "text", nullable: true),
                    NoteLinkName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    NoteLink = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    NoteEndingTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notes_Users_MenteeId",
                        column: x => x.MenteeId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notes_Users_MentorId",
                        column: x => x.MentorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MentorId = table.Column<int>(type: "integer", nullable: false),
                    MenteeId = table.Column<int>(type: "integer", nullable: false),
                    AskQuestion = table.Column<string>(type: "character varying(400)", maxLength: 400, nullable: false),
                    Answer = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Users_MenteeId",
                        column: x => x.MenteeId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questions_Users_MentorId",
                        column: x => x.MentorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Corporations",
                columns: new[] { "Id", "CorporationType", "CreatedDate", "IsActive", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Vispeahen", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Vodofone Genç Gurup", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "SMS Elotherm Mekanik", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Konya Teknik Üniversitesi Genç Girişimci", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "English Time Dil Okulları", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "MeetingLocations",
                columns: new[] { "Id", "CreatedDate", "IsActive", "MeetingLocationType", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, "@Google Meet", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, "@Zoom", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, "@Jitsu Meet", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedDate", "IsActive", "Name", "RoleType", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Mentor", 1, new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Mentee", 2, new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "Address", "CoprorationId", "CreatedDate", "FirstName", "IsActive", "LastName", "Mail", "MentorId", "Password", "RoleId", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, "Merhaba. 2008'den beri grafik tasarım, illüstrasyon ve plastik sanatlar alanlarında, üretmekteyim. Son 4 yıldır yurtiçi-yurtdışı çeşitli markalar için serbest çalışıyorum.2020, Eylül'de Web Tasarım ve Kodlama bölümüne kayıt oldum. Kendime yeni bir artı daha eklemek heyecan verici. Bu yeni alanda üretmek için sabırsızlanıyorum.", "Eskişehir, Türkiye", 1, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmet", true, "Candemir", "ahmetCandemir@gmail.com", null, "$2a$11$9I/cq9tUgEzPGSjdkUWj/ebv1gWt3zPUa4S9saAS0qVCoZ14BSvQa", 1, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Teknik liseden mezun olduktan sonra Sütçü İmam Üni. 'nde Bilgisayar Müh. okumaktayım. Çeşitli firmalarda Frontend Developer olarak görev aldım. Arneca Technology de stajımı yaptıktan sonra aynı firmada aktif olarak Frontned Developer olarak çalışmaktayım. Üzerinde çalıştığım teknolojiler, HTML5, CSS3, SCSS, Bootstrap, JQuery, JSON, AJAX, React.js, PHP, MySQL", "KahramanMaraş, Türkiye", 2, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Muhsin", true, "Dertlitek", "muhsinDertli@gmail.com", null, "$2a$11$0B7ZKbVOl7T77T996zTrPuKR6L99vsrUAydhQyqmhAdNi17XlqeTm", 1, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Merhaba ben Koray arayüz geliştiricisiyim. Yeni teknoloji, trendleri yakından takip eden ve sürekli öğrenen biriyim, yazılım geliştirmeyi ve içerik üretmeyi seviyorum. Genel olarak javascript ve web teknolojileri ile ilgileniyorum. Artan zamanımda iste kahve hazırlamaktan ve müzik dinlemekten hoşlanırım.", "İstanbul, Türkiye", 3, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Koray", true, "Güler", "korayGüler@gmail.com", null, "$2a$11$182tonlckpGDHEC7FLT.d.q6iq52Bx6BFpmfK5.ZlY4LNurR0jyKO", 1, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Bilgisayar Mühendisi (Android Geliştirici) Android uygulama geliştirmede Kotlin ve Java dillerine hakimim. Üçüncü parti kütüphane kullanabilen, Web Services, SOAP, REST API, JSON, XML konularında bilgi ve tecrübe sahibiyim. Arayüz komponentleri geliştirme ve verilen görsel tasarımları, uygulamalara giydirme konusunda deneyim sahibiyim. GIT, SVN, TFS gibi versiyonlama sistemleri hakkında bilgi sahibiyim. Ekip çalışmasına uyumlu, yeni teknolojileri öğrenmeye meraklı ve araştırmacıyım.", "İzmir, Türkiye", 4, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mert", true, "Doydu", "mertDoydu@gmail.com", null, "$2a$11$jRNonQGz2sHz.OdLxzvsGOtjrEpigSl1C.TroLoFE2TTcwPGT3eey", 1, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "MentorCity tüm kurum ve organizasyonlarda hemen devreye alınabilir. MentorCity bir danışmanlık şirketi değildir. Mentorluk, koçluk veya eğitim hizmeti sunmaz. Kurum olarak eğitim ve gelişim programlarınız için danışmanlık hizmeti alıyorsanız MentorCity platformunuzu kendi danışmanlarınız ile birlikte yönetebilirsiniz.", "Ankara, Türkiye", 5, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kerem", true, "Danışmaz", "danismaz2000@gmail.com", null, "$2a$11$ViRXs3JbGGBLA4r3EtXPLej3Lh.qEmI1TGDijZ43xEJre.HuE4R1y", 1, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CorporationInfos",
                columns: new[] { "Id", "CorporationInfoText", "CorporationServiceFive", "CorporationServiceFour", "CorporationServiceOne", "CorporationServiceSix", "CorporationServiceThree", "CorporationServiceTwo", "CreatedDate", "IsActive", "UpdatedTime", "UserId" },
                values: new object[,]
                {
                    { 1, "Vispeahen, 15 yılı aşkın veri ambarı, iş zekası, yazılım deneyimi bilgi birikiminin sonucu olarak ortaya çıkmış bir veri analiz platformudur. Vispeahen, sürekli artan ve büyüyen verileri stratejik kararlarda kullanılabilecek anlamlı bilgilere dönüştürür ve görselleştirir. Vispeahen, yeni grafikleri eklenti olarak eklemesi, farklı veri kaynaklarını aynı modelde görselleştirmesi, dağıtık mimaride çalışması, yüksek yük altında çalışması, görüntü dosyalarının metadatasını sorgulaması ve raporlaması ile diğer tüm görselleştirme ürünlerinden ayrılmaktadır. Vispeahen ile veriler kolay, hızlı ve estetik olarak görselleştirilebilir, dünyanın herhangi bir yerindeki herhangi bir masaüstü veya mobil cihazda, herhangi bir internet tarayıcısı ile kurulum gerektirmeden görüntülenebilir.", "Toplantılarının zamanını takip et. Asla kaçırma senin için seferber olacağız.", "Mentor bilgilerinden mentoruna bak ve mentorunu tanı.", "Senin için özenle hazırlanmış notları incele.", "Vispeahen ekibi elinden geleni yapacaktır.", "Sorular kısmındaki sorulara cevap ver seni tanımama yardımcı ol.", "Toplantıları takip et ve toplantımızı kaçırma!", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "Dünyanın en büyük teknoloji iletişimi şirketlerinden biri olan Vodafone Grubu’nun bünyesinde yer alan Vodafone Türkiye, “herkes için dijital bir gelecek inşa etme” vizyonu doğrultusunda, birey ve kurumlara sabit, mobil ve içerik hizmetleri dahil tüm telekomünikasyon teknolojilerini tek çatıda sunmaktadır. Türkiye’nin en büyük uluslararası doğrudan yatırımcılarından olan Vodafone Türkiye’nin bugüne kadar toplam yatırımları 24 milyar TL’ye ulaşmıştır. Vodafone Türkiye, 30 Haziran 2020 itibarıyla 23,6 milyon mobil müşteriye ve 1,1 milyon sabit genişbant müşterisine hizmet vermektedir. Ayrıntılı bilgi için www.vodafone.com.tr adresi ziyaret edilebilir.", "Toplantılarının zamanını takip et. Asla kaçırma senin için seferber olacağız.", "Mentor bilgilerinden mentoruna bak ve mentorunu tanı.", "Senin için özenle hazırlanmış notları incele.", "Vodofone ekibi elinden geleni yapacaktır.", "Sorular kısmındaki sorulara cevap ver seni tanımama yardımcı ol.", "Toplantıları takip et ve toplantımızı kaçırma!", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, "Metallerin endüktif ısıtma ve ısıl işlemlerinde uzun yıllara dayanan bilgi birikimi, SMS Elotherm'i güvenilir ortağınız yapar! Uzun ürünlerin ve yassı ürünlerin haddelenmesi, şerit ısıtma, dövme ısıtma, krank mili ve eksantrik mili sertleştirme, yüzey katmanı sertleştirme, halka sertleştirme, mil sertleştirme ve çok daha fazlası için metal ısıtma sistemleri sunuyoruz! Bu yolda eğitebileceğimiz adaylar sizlersiniz.", "Toplantılarının zamanını takip et. Asla kaçırma senin için seferber olacağız.", "Mentor bilgilerinden mentoruna bak ve mentorunu tanı.", "Senin için özenle hazırlanmış notları incele.", "SMS Elotherm ekibi elinden geleni yapacaktır.", "Sorular kısmındaki sorulara cevap ver seni tanımama yardımcı ol.", "Toplantıları takip et ve toplantımızı kaçırma!", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, "Mezunları evrensel değerlere bağlı, araştırmacı, üretken, paylaşımcı, özgüvenli ve yetkin olan; sürdürülebilir ve yenilikçi araştırmalarla bilim ve teknolojiyi üreten; toplumun kalkınması ve refahı için insan ve çevre odaklı çözümler sunan; alanlarında öncü araştırma faaliyetlerini tasarlayan ve gerçekleştiren bir araştırma üniversitesi olmak. KTUN sizleri eğitmek için sabırsılıkla bekliyor.", "Toplantılarının zamanını takip et. Asla kaçırma senin için seferber olacağız.", "Mentor bilgilerinden mentoruna bak ve mentorunu tanı.", "Senin için özenle hazırlanmış notları incele.", "KTUN ekibi elinden geleni yapacaktır.", "Sorular kısmındaki sorulara cevap ver seni tanımama yardımcı ol.", "Toplantıları takip et ve toplantımızı kaçırma!", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, "Bazı insanlar dil öğrenmek için doğal bir yeteneğe sahiptir, ancak diğerleri için yeni bir dil öğrenmek zor bir görev olabilir. Yeni bir dil öğrenmenin en iyi yolu, kendi öğrenme stilinize bağlı olarak değişir. İngilizce eğitimi günümüzde tüm dünyada olmazsa olmaz etkinliklerin arasına girmiş durumda. İngilizce eğitiminin önemi gün geçtikçe daha çok insan tarafından kavranıyor. İster okulda ister iş hayatında olun, başarıya ulaşmak için İngilizce bilmek, daha da önemlisi İngilizce konuşabilmek gerekiyor. Bu alanda başarılı olmanız için elimizden geleni yapacağız.", "Toplantılarının zamanını takip et. Asla kaçırma senin için seferber olacağız.", "Mentor bilgilerinden mentoruna bak ve mentorunu tanı.", "Senin için özenle hazırlanmış notları incele.", "English Time ekibi elinden geleni yapacaktır.", "Sorular kısmındaki sorulara cevap ver seni tanımama yardımcı ol.", "Toplantıları takip et ve toplantımızı kaçırma!", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CorporationInfos_UserId",
                table: "CorporationInfos",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_MeetingLocationId",
                table: "Meetings",
                column: "MeetingLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_MenteeId",
                table: "Meetings",
                column: "MenteeId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_MentorId",
                table: "Meetings",
                column: "MentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_UserId",
                table: "Meetings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_MenteeId",
                table: "Notes",
                column: "MenteeId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_MentorId",
                table: "Notes",
                column: "MentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_UserId",
                table: "Notes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_MenteeId",
                table: "Questions",
                column: "MenteeId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_MentorId",
                table: "Questions",
                column: "MentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_UserId",
                table: "Questions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CoprorationId",
                table: "Users",
                column: "CoprorationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_MentorId",
                table: "Users",
                column: "MentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CorporationInfos");

            migrationBuilder.DropTable(
                name: "Meetings");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "MeetingLocations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Corporations");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
