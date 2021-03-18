using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Codedy.StarSecurity.WebApp.Migrations
{
    public partial class Initial : Migration
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
                values: new object[] { new Guid("1923f274-426f-46e1-bc42-2d16747437ff"), "Cau Giay,Ha Noi", new DateTime(2003, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "phuongthuy@gmail.com", "Phuong Thuy", 1, "Phung", "0981159826" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "DOB", "Email", "FirtName", "LastName", "Phone" },
                values: new object[] { new Guid("802a2ff6-9fa8-4ebf-89ee-215f210eac00"), "Tay Son,Ha Noi", new DateTime(2001, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "vana@gmail.com", " Van A", "Nguyen", "0981159826" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "DOB", "Email", "FirtName", "Gender", "LastName", "Phone" },
                values: new object[] { new Guid("f1724618-d229-4e4f-b226-7f7b294a9224"), "Ba Vi, Ha Noi", new DateTime(2001, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thanhhoa@gmail.com", "Thanh Hoa", 1, "Nguyen", "0981159826" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "DOB", "Email", "FirtName", "LastName", "Phone" },
                values: new object[] { new Guid("e1a0f991-4b21-429e-8131-719d7b2b690f"), "Dong Da,Ha Noi", new DateTime(2001, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "vanduc@gmail.com", "Van Duc", "Nguyen", "0981159826" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "DOB", "Email", "FirtName", "Gender", "LastName", "Phone" },
                values: new object[] { new Guid("bab0201c-bb95-4423-b34d-85c6d99c3488"), "Nhon,Ha Noi", new DateTime(2001, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "huyentrang@gmail.com", "Huyen Trang", 1, "Do", "0981159826" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "DOB", "Email", "FirtName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("e5c9a908-11df-4922-b27d-9a2cfd10c4e0"), "My Dinh,Ha Noi", new DateTime(2001, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "quanghuy@gmail.com", "Quang Huy", "Vu", "0981159826" },
                    { new Guid("9d381895-3b23-4def-a851-1f296a863ca8"), "My Dinh,Ha Noi", new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "tuan@gmail.com", "Tuan", "Pham", "0981159826" },
                    { new Guid("ba42e262-948d-4c60-ac0a-24b4cc32af9c"), "My Dinh,Ha Noi", new DateTime(1998, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhtu@gmail.com", "Thanh Tu", "Truong", "0981159826" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "DOB", "Email", "FirtName", "Gender", "LastName", "Phone" },
                values: new object[] { new Guid("dd555925-5f29-4ad3-9323-47fa8b3838a4"), "Nhon,Ha Noi", new DateTime(2000, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "chanhoa@gmail.com", "Chan Hoa", 1, "Do", "0981159826" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "DOB", "Email", "FirtName", "LastName", "Phone" },
                values: new object[] { new Guid("6fbf38b7-5671-49c8-b622-ae56f07d7d60"), "My Dinh,Ha Noi", new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "dinhhieu@gmail.com", "Dinh Hieu", "Nguyen", "0981159826" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "EmployeeAchievements", "EmployeeCode", "EmployeeDepartment", "EmployeeEducationalQualification", "EmployeeGrade", "EmployeeRole", "FirtName", "Gender", "LastLoginDate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("383d5fe5-e255-4cdf-9589-dff92df193c8"), 0, "Dong Da, Ha Noi", "11afbfb2-22fe-4a2b-b44e-30277411e566", new DateTime(2001, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Host@gmail.com", false, "the first prize in the singing contest of the room", "H123456", "Technical staff", "University", "level 5 staff", "Leader", "Host", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Host", false, null, null, null, "AQAAAAEAACcQAAAAEOq4l1LOpIf+bqXUdsb17k9EyWG4wVnJNAhMUXxekFlkdGBYehVKm32mMVcONylUaw==", "0981159826", null, false, null, false, "Host" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "EmployeeAchievements", "EmployeeCode", "EmployeeDepartment", "EmployeeEducationalQualification", "EmployeeGrade", "EmployeeRole", "FirtName", "LastLoginDate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("5139dbf8-9410-4144-8bf1-78cae007ed51"), 0, "Xuan Loc, Nghe An", "19ccb407-dbcf-4b1d-9cfa-6e72ea36597c", new DateTime(1996, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyendinhhieu@gmail.com", false, "the first prize in the singing contest of the room", "H123", "Technical staff", "University", "level 5 staff", "Leader", "Dinh Hieu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen ", false, null, null, null, "AQAAAAEAACcQAAAAEHHSoJFSIQzIQgeGVegtzqomAh68m+ZJP0+GphC9lJbpQ5J0tr231MlcW+tiBJxncw==", "98372837362", null, false, null, false, "nguyendinhhieu" },
                    { new Guid("ddadf25d-9968-4766-aa78-608d52f631b9"), 0, "Thuy Bieu, Hue", "a371af6c-32a7-4579-8fcc-cb51d1f1fda5", new DateTime(1998, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "truongthanhtu@gmail.com", false, "the first prize in the singing contest of the room", "T123", "Technical staff", "University", "level 5 staff", "Leader", "Thanh Tu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Truong ", false, null, null, null, "AQAAAAEAACcQAAAAEC1MaUM7Mv+1EYwzS4yfRgP8hCf94Z7y1kpYIzRmZJGQUWCSEFJ52S+V59Xs7fyrmA==", "0367376544", null, false, null, false, "truongthanhtu" },
                    { new Guid("a2183c7c-3a09-47f5-865d-1ebb9ae52a1f"), 0, "My Dinh, Ha Noi", "9c46d350-949c-4d2d-8e08-21792a3c32b8", new DateTime(2001, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "phamtuan@gmail.com", false, "the first prize in the singing contest of the room", "T1234", "Technical staff", "University", "level 5 staff", "Leader", "Pham", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tuan", false, null, null, null, "AQAAAAEAACcQAAAAEBLrwSd9DzYdUeIS57oeGA79TY8tuO0Dd3SsXlAqKNyTsu7Zg7K2AgmGEdEFj7Nl8A==", "0382548442", null, false, null, false, "phamtuan" },
                    { new Guid("562548c6-88b4-4d1e-bcb8-ad49078ed896"), 0, "My Dinh, Ha Noi", "2766c13b-fa2e-4f3e-a08a-c8ffe7db11ae", new DateTime(2001, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "vuquanghuy@gmail.com", false, "the first prize in the singing contest of the room", "H1234", "Technical staff", "University", "level 5 staff", "Leader", "Quang Huy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vu", false, null, null, null, "AQAAAAEAACcQAAAAEKkCpfgNjb0yXbuyCpshevWvIsqK7xl8ZA65tNGZjJFl6yWZdtBbKYaDiscm5Pq30w==", "0964576059", null, false, null, false, "vuquanghuy" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "EmployeeAchievements", "EmployeeCode", "EmployeeDepartment", "EmployeeEducationalQualification", "EmployeeGrade", "EmployeeRole", "FirtName", "Gender", "LastLoginDate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("4aebade0-fe97-4d9c-9172-7ff132f98c7c"), 0, "Bac Tu Liem, Ha Noi", "af5f6e9a-a93f-4b17-8873-5804cb5de465", new DateTime(2000, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "chanhoa@gmail.com", false, "the first prize in the singing contest of the room", "H12345", "Technical staff", "University", "level 5 staff", "Leader", "Chan Hoa", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Do", false, null, null, null, "AQAAAAEAACcQAAAAEEQ0mhNks+R7IrvrxYR5CnVxBUSu7YSb4A3rM8ZrQJdjuwW7ob7SbjPwQnUQHjNCQw==", "0981159826", null, false, null, false, "dothichanhoa" },
                    { new Guid("6c2661f1-e224-42e1-89f5-679690270fb7"), 0, "Nam Tu Liem, Ha Noi", "16c052e0-7db9-4726-b08d-e0c6b6be7147", new DateTime(2001, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin@gmail.com", false, "the first prize in the singing contest of the room", "A12345", "Technical staff", "University", "level 5 staff", "Leader", "Admin", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEAGlSPZgylXKaYItmozl4haUNb9n9iBE9+l/7mgOA/Nl92D/mOlAaaCSkgTCaJuNXw==", "0981159826", null, false, null, false, "Admin" },
                    { new Guid("49b23d38-8e90-474e-8a46-63129cfbaa56"), 0, "Ba Dinh, Ha Noi", "4d78e419-9b7b-4aaa-9d35-81d5da8dfce2", new DateTime(2001, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee@gmail.com", false, "the first prize in the singing contest of the room", "E123456", "Technical staff", "University", "level 5 staff", "Leader", "Employee", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee", false, null, null, null, "AQAAAAEAACcQAAAAEDh9/kpjzMH+OR4H+B35yETsIYkNOKQ9AUsDelwM2CpttOBggUVmo0TrCpTBow4KYw==", "0981159826", null, false, null, false, "Employee" }
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
