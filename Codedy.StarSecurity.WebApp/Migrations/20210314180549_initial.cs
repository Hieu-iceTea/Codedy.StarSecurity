using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Codedy.StarSecurity.WebApp.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Careers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WorkAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Admin"),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Admin"),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Careers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    FirtName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DOB = table.Column<DateTime>(type: "Date", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Admin"),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Admin"),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PromotionPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Admin"),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Admin"),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    FirtName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DOB = table.Column<DateTime>(type: "Date", nullable: false),
                    EmployeeEducationalQualification = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmployeeCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmployeeDepartment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmployeeRole = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmployeeGrade = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmployeeAchievements = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastLoginDate = table.Column<DateTime>(type: "Date", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Admin"),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Admin"),
                    Version = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Careers",
                columns: new[] { "Id", "Description", "ExpirationDate", "Salary", "Title", "WorkAddress" },
                values: new object[,]
                {
                    { new Guid("f58c0412-8400-412b-801b-06b6090e67d3"), "Absolutely safe protection for customers during working time by all measures", new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m, "Guard", "Ha Noi" },
                    { new Guid("5bd5f5d8-4899-4e4f-844c-ffd0ba71683e"), "Securely transfer cash and valuables, replenish ATM,warehouse and handling, multi-point collection", new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m, "Cash teller", "Ha Noi" },
                    { new Guid("14323e88-8116-4231-a6d5-3703c1535108"), "Independent business investigation, providing information in the field of Marriage - Economics - Civil under Enterprise Law. Find people, monitor supervision, verify relatives", new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m, "Emissary", "Ha Noi" },
                    { new Guid("f3470a7b-062f-4c7e-8d57-cf67dbbdf636"), "Design, installation and maintenance of access control system, CCTV, fire alarm system, fire prevention system, intrusion / theft alarm, belt protection system, etc. customer base.", new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m, "Network security staff", "Ha Noi" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "DOB", "Email", "FirtName", "Gender", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("1923f274-426f-46e1-bc42-2d16747437ff"), "Cau Giay,Ha Noi", new DateTime(1994, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "phuongthuy@gmail.com", "Phuong Thuy", 1, "Phung", "0981159826" },
                    { new Guid("f1724618-d229-4e4f-b226-7f7b294a9224"), "Ba Vi, Ha Noi", new DateTime(2000, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thanhhoa@gmail.com", "Thanh Hoa", 1, "Nguyen", "0981159826" },
                    { new Guid("bab0201c-bb95-4423-b34d-85c6d99c3488"), "Nhon,Ha Noi", new DateTime(2002, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "huyentrang@gmail.com", "Huyen Trang", 1, "Do", "0981159826" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "DOB", "Email", "FirtName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("e1a0f991-4b21-429e-8131-719d7b2b690f"), "Dong Da,Ha Noi", new DateTime(1995, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "vanduc@gmail.com", "Van Duc", "Nguyen", "0981159826" },
                    { new Guid("802a2ff6-9fa8-4ebf-89ee-215f210eac00"), "Tay Son,Ha Noi", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "vana@gmail.com", " Van A", "Nguyen", "0981159826" },
                    { new Guid("e5c9a908-11df-4922-b27d-9a2cfd10c4e0"), "My Dinh,Ha Noi", new DateTime(2001, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "quanghuy@gmail.com", "Quang Huy", "Vu", "0981159826" },
                    { new Guid("9d381895-3b23-4def-a851-1f296a863ca8"), "My Dinh,Ha Noi", new DateTime(2001, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "tuan@gmail.com", "Tuan", "Pham", "0981159826" },
                    { new Guid("ba42e262-948d-4c60-ac0a-24b4cc32af9c"), "My Dinh,Ha Noi", new DateTime(1998, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhtu@gmail.com", "Thanh Tu", "Truong", "0981159826" },
                    { new Guid("6fbf38b7-5671-49c8-b622-ae56f07d7d60"), "My Dinh,Ha Noi", new DateTime(1996, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "dinhhieu@gmail.com", "Dinh Hieu", "Nguyen", "0981159826" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "DOB", "Email", "FirtName", "Gender", "LastName", "Phone" },
                values: new object[] { new Guid("dd555925-5f29-4ad3-9323-47fa8b3838a4"), "Nhon,Ha Noi", new DateTime(2000, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "chanhoa@gmail.com", "Chan Hoa", 1, "Do", "0981159826" });

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "IsActive", "Price", "PromotionPrice", "Title" },
                values: new object[,]
                {
                    { new Guid("1d4110dc-1883-4e96-b695-a1f55daddba1"), 0, "This division works in close association with SIS's strategic partners i.e. reputed system integrators & installers. The primary area of activity for this division is design, installation and maintenance of Access control systems, CCTVs, fire alarm systems, fire suppression systems, intruder/burglar alarms, perimeter protection systems, etc. The division aims at marketing its products to the existing customer base. .", "electronic security systems .jpg", true, 400m, 399m, "Electronic security systems " },
                    { new Guid("2599d241-1f72-44b0-9e5f-cedee1ed4ba2"), 0, "The service range of the Cash Services division includes secured transfer of cash and valuables, ATM replenishment, Vaulting and Processing Services, multi-point cash collection and Caretaker Services.", "cash-services .jpg", true, 250m, 200m, "Cash services " },
                    { new Guid("1458aa9a-4398-4828-a451-d42467bfef94"), 0, "The service portfolio of this division includes guarding, fire squad, dog squad, bodyguards etc. for industries, banks, retail outlets, residential colonies, hotels and institutions.", "manned-guarding .jpg", true, 500m, 499m, "Manned guarding  " },
                    { new Guid("b8434194-a6a7-4dc7-a75d-76893bc3d2da"), 0, "DEATH INVESTIGATION - MONITORING,MONITOR YOUR CHILDREN, INVESTIGATION INVESTIGATION, INVESTIGATION INVESTIGATION - DISABILITY, SEARCH DNA TRACK, PHONE NUMBER INVESTIGATION.Professional detective team, well-trained and with professional ethics, complete and sophisticated equipment system with the most modern and advanced technology today.", "investigations.jpg", true, 300m, 299m, "Investigations" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "EmployeeAchievements", "EmployeeCode", "EmployeeDepartment", "EmployeeEducationalQualification", "EmployeeGrade", "EmployeeRole", "FirtName", "Gender", "LastLoginDate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("383d5fe5-e255-4cdf-9589-dff92df193c8"), 0, "Dong Da, Ha Noi", "40d8d190-13ad-4219-b774-f5a409297d16", new DateTime(1999, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Host@gmail.com", false, "the first prize in the singing contest of the room", "H123456", "Technical staff", "University", "level 5 staff", "Leader", "Host", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Host", false, null, null, null, "AQAAAAEAACcQAAAAEOdCZrZrA4NNNYmZCzTqrGD53XpbmFMyF5BrrnuAcUYFDmNjk/x8fG2kzamJuNiPeg==", "0981159826", null, false, null, false, "Host" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "EmployeeAchievements", "EmployeeCode", "EmployeeDepartment", "EmployeeEducationalQualification", "EmployeeGrade", "EmployeeRole", "FirtName", "LastLoginDate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("5139dbf8-9410-4144-8bf1-78cae007ed51"), 0, "Xuan Loc, Nghe An", "a68310e3-1c2d-4539-b1f8-4f4c377041aa", new DateTime(1996, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyendinhhieu@gmail.com", false, "the first prize in the singing contest of the room", "H123", "Technical staff", "University", "level 5 staff", "Leader", "Dinh Hieu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen ", false, null, null, null, "AQAAAAEAACcQAAAAEGlflPWSTiCvm1fSAy509noYp0PvW5tF0aQjUdnX3KWxsdUREFnaWGTB59rICxe7tw==", "98372837362", null, false, null, false, "nguyendinhhieu" },
                    { new Guid("ddadf25d-9968-4766-aa78-608d52f631b9"), 0, "Thuy Bieu, Hue", "65c6e42e-94ca-41d6-bce5-095efa5d2d77", new DateTime(1998, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "truongthanhtu@gmail.com", false, "the first prize in the singing contest of the room", "T123", "Technical staff", "University", "level 5 staff", "Leader", "Thanh Tu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Truong ", false, null, null, null, "AQAAAAEAACcQAAAAEHPDoXGad4968HHZNSTeP9TiYfLqoG0pPFDCdggVgka15YcD3QwxJMjZR96ZDEzFLQ==", "0367376544", null, false, null, false, "truongthanhtu" },
                    { new Guid("a2183c7c-3a09-47f5-865d-1ebb9ae52a1f"), 0, "My Dinh, Ha Noi", "7c9b818c-76e1-4cf5-b665-23395f1b917c", new DateTime(2001, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "phamtuan@gmail.com", false, "the first prize in the singing contest of the room", "T1234", "Technical staff", "University", "level 5 staff", "Leader", "Pham", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tuan", false, null, null, null, "AQAAAAEAACcQAAAAEAnEUTZuEy5FyYDPU58jq7Qf3zxv99BCWUfNrgdVsWS6glmrcu5KI06Vszbqs/vLeg==", "0382548442", null, false, null, false, "phamtuan" },
                    { new Guid("562548c6-88b4-4d1e-bcb8-ad49078ed896"), 0, "My Dinh, Ha Noi", "afc3910f-1372-42ab-94ce-91ab48355d41", new DateTime(2001, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "vuquanghuy@gmail.com", false, "the first prize in the singing contest of the room", "H1234", "Technical staff", "University", "level 5 staff", "Leader", "Quang Huy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vu", false, null, null, null, "AQAAAAEAACcQAAAAEC9yulXG1CRsAVbt+e7wT6Hqe3XpbYWbvQ7BqyqSw+YaBytIKPTVxqgLeRqvR4kQHA==", "0964576059", null, false, null, false, "vuquanghuy" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "EmployeeAchievements", "EmployeeCode", "EmployeeDepartment", "EmployeeEducationalQualification", "EmployeeGrade", "EmployeeRole", "FirtName", "Gender", "LastLoginDate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("4aebade0-fe97-4d9c-9172-7ff132f98c7c"), 0, "Bac Tu Liem, Ha Noi", "3e8f279f-7bf7-4723-af3b-855a1316f54c", new DateTime(2000, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "chanhoa@gmail.com", false, "the first prize in the singing contest of the room", "H12345", "Technical staff", "University", "level 5 staff", "Leader", "Chan Hoa", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Do", false, null, null, null, "AQAAAAEAACcQAAAAEPDxGqYFXyDK9T6mLPN7kuWtp42ZB8g1Dx9C87K0GPjYjEqc20gFO4CijfDMvpk8rw==", "0981159826", null, false, null, false, "dothichanhoa" },
                    { new Guid("6c2661f1-e224-42e1-89f5-679690270fb7"), 0, "Nam Tu Liem, Ha Noi", "5a9335b9-ab1f-4668-8e34-f2e979d64b0f", new DateTime(2000, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin@gmail.com", false, "the first prize in the singing contest of the room", "A12345", "Technical staff", "University", "level 5 staff", "Leader", "Admin", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEN+F06M2fWRyMN7DFoJ9MEBa4KSo+Wf12qynlV9FEolp1ET/xR17xHjxYwUZy8JOjg==", "0981159826", null, false, null, false, "Admin" },
                    { new Guid("49b23d38-8e90-474e-8a46-63129cfbaa56"), 0, "Ba Dinh, Ha Noi", "cce9292c-cdd8-4462-a9f2-e18b2e702c9c", new DateTime(1999, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee@gmail.com", false, "the first prize in the singing contest of the room", "E123456", "Technical staff", "University", "level 5 staff", "Leader", "Employee", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee", false, null, null, null, "AQAAAAEAACcQAAAAEJ0iYepeVWYDQoWOaFjlE6DjjE5IBZzs69c7YFnBPowqJxx/3wT01KSSn3qkSf4rkA==", "0981159826", null, false, null, false, "Employee" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Careers");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTokens");
        }
    }
}
