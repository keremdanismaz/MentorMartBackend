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
                    { 1, 1, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Microsoft", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Google", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Tesla", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Lenovo", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Toyota", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "MeetingLocations",
                columns: new[] { "Id", "CreatedDate", "IsActive", "MeetingLocationType", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, "@Google Meet", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, "@Zoom", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, "@Jitsu Meet", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedDate", "IsActive", "Name", "RoleType", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Mentor", 1, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Mentee", 2, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "Address", "CoprorationId", "CreatedDate", "FirstName", "IsActive", "LastName", "Mail", "MentorId", "Password", "RoleId", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, "Merhaba. 2008'den beri grafik tasarım, illüstrasyon ve plastik sanatlar alanlarında, üretmekteyim. Son 4 yıldır yurtiçi-yurtdışı çeşitli markalar için serbest çalışıyorum.2020, Eylül'de Web Tasarım ve Kodlama bölümüne kayıt oldum. Kendime yeni bir artı daha eklemek heyecan verici. Bu yeni alanda üretmek için sabırsızlanıyorum.", "Eskişehir, Türkiye", 1, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmet", true, "Candemir", "ahmetCandemir@gmail.com", null, "AhmetCan123", 1, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Teknik liseden mezun olduktan sonra Sütçü İmam Üni. 'nde Bilgisayar Müh. okumaktayım. Çeşitli firmalarda Frontend Developer olarak görev aldım. Arneca Technology de stajımı yaptıktan sonra aynı firmada aktif olarak Frontned Developer olarak çalışmaktayım. Üzerinde çalıştığım teknolojiler, HTML5, CSS3, SCSS, Bootstrap, JQuery, JSON, AJAX, React.js, PHP, MySQL", "KahramanMaraş, Türkiye", 2, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Muhsin", true, "Dertlitek", "muhsinDertli@gmail.com", null, "MuhsinDertli123", 1, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Merhaba ben Koray arayüz geliştiricisiyim. Yeni teknoloji, trendleri yakından takip eden ve sürekli öğrenen biriyim, yazılım geliştirmeyi ve içerik üretmeyi seviyorum. Genel olarak javascript ve web teknolojileri ile ilgileniyorum. Artan zamanımda iste kahve hazırlamaktan ve müzik dinlemekten hoşlanırım.", "İstanbul, Türkiye", 3, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Koray", true, "Güler", "korayGüler@gmail.com", null, "KorayGüler123", 1, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Bilgisayar Mühendisi (Android Geliştirici) Android uygulama geliştirmede Kotlin ve Java dillerine hakimim. Üçüncü parti kütüphane kullanabilen, Web Services, SOAP, REST API, JSON, XML konularında bilgi ve tecrübe sahibiyim. Arayüz komponentleri geliştirme ve verilen görsel tasarımları, uygulamalara giydirme konusunda deneyim sahibiyim. GIT, SVN, TFS gibi versiyonlama sistemleri hakkında bilgi sahibiyim. Ekip çalışmasına uyumlu, yeni teknolojileri öğrenmeye meraklı ve araştırmacıyım.", "İzmir, Türkiye", 4, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mert", true, "Doydu", "mertDoydu@gmail.com", null, "MertDoydu123", 1, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "MentorCity tüm kurum ve organizasyonlarda hemen devreye alınabilir. MentorCity bir danışmanlık şirketi değildir. Mentorluk, koçluk veya eğitim hizmeti sunmaz. Kurum olarak eğitim ve gelişim programlarınız için danışmanlık hizmeti alıyorsanız MentorCity platformunuzu kendi danışmanlarınız ile birlikte yönetebilirsiniz.", "Ankara, Türkiye", 5, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kerem", true, "Danışmaz", "danismaz2000@gmail.com", null, "KeremDan123", 1, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
