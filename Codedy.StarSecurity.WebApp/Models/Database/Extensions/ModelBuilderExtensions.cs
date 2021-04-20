using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using Codedy.StarSecurity.WebApp.Models.Database.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Codedy.StarSecurity.WebApp.Models.Database.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Career>().HasData(
                new Career()
                {
                    Id = new Guid("f58c0412-8400-412b-801b-06b6090e67d3"),
                    Title = "Investigation management specialist",
                    Image = "investigation-management-specialist.jpg",
                    Salary = "800 - 1600 $",
                    WorkAddress = "Ha Noi",
                    ExpirationDate = DateTime.Parse("2021-06-02"),
                    Description = "Conduct investigation according to the assigned tasks. Verify suspected fraud information received from designated external sources. Collect information, support to blacklist information about customers, companies, scammers. Professional training support for new employees or retrained employees.",
                },
                new Career()
                {
                    Id = new Guid("f3470a7b-062f-4c7e-8d57-cf67dbbdf636"),
                    Title = "Network security staff",
                    Image = "network-security-staff.jpg",
                    Salary = "Negotiate",
                    WorkAddress = "Ho Chi Minh",
                    ExpirationDate = DateTime.Parse("2021-12-22"),
                    Description = "Design, installation and maintenance of access control system, CCTV, fire alarm system, fire prevention system, intrusion / theft alarm, belt protection system, etc. customer base.",
                },
                new Career()
                {
                    Id = new Guid("5bd5f5d8-4899-4e4f-844c-ffd0ba71683e"),
                    Title = "Fraud Prevention Specialist",
                    Image = "fraud-prevention-specialist.jpg",
                    Salary = "800 - 1200 $",
                    WorkAddress = "Ha Noi",
                    ExpirationDate = DateTime.Parse("2021-05-15"),
                    Description = "Working in the assigned area to monitor suspected fraud behaviors, fraud trends of external fraudsters to promptly update the Sale department to take timely measures. Build good relationships with local government agencies you manage to support smooth investigation, verification and information collection.",
                },
                new Career()
                {
                    Id = new Guid("14323e88-8116-4231-a6d5-3703c1535108"),
                    Title = "Recruiting detective",
                    Image = "recruiting-detective.jpg",
                    Salary = "1200 - 2000 $",
                    WorkAddress = "Da Nang",
                    ExpirationDate = DateTime.Parse("2021-08-25"),
                    Description = "Track, investigate, verify goals according to customer requirements. Investigate counterfeit goods, origin of goods, trademark copyright. Investigate and verify identity records.",
                },
                  new Career()
                  {
                      Id = new Guid("36A3586B-B04F-443B-8729-BB64DE8A7FD3"),
                      Title = "Recruit professional security guards",
                      Image = "recruitprofessionalsecurityguards.jpg",
                      Salary = "800 - 1000 $",
                      WorkAddress = "Da Nang",
                      ExpirationDate = DateTime.Parse("2021-08-30"),
                      Description = "Guard, patrol and supervise jobs in offices, factories, buildings, hospitals and construction sites, banks, fashion stores",
                  },
                  new Career()
                  {
                      Id = new Guid("7ABAB841-0A03-4F5D-8C2C-73A1DC4ECEBC"),
                      Title = "Camera installation technician",
                      Image = "camerainstallationtechnician.png",
                      Salary = "500 - 600  $",
                      WorkAddress = "Nha Trang",
                      ExpirationDate = DateTime.Parse("2021-06-29"),
                      Description = "construction and installation of camera equipment, fire alarm, timekeeper, access control machine, total length",
                  },
                   new Career()
                   {
                       Id = new Guid("E4FC6F52-BF22-4F1A-A7AD-252D89301AF9"),
                       Title = "IT PROGRAMMERS & NETWORK STAFF",
                       Image = "itprogrammers&networkstaff.jpg",
                       Salary = "1000 - 1500 $",
                       WorkAddress = "Ha Noi",
                       ExpirationDate = DateTime.Parse("2021-09-29"),
                       Description = "Developing and implementing information technology plans for the whole system.Join the deployment of application software to support production needs.Support other departments when they have IT requirements or difficulties. ",
                   },
                    new Career()
                    {
                        Id = new Guid("57C10D2B-A2C6-40F9-A12C-54B9A802DE5A"),
                        Title = "Professional Dog Trainer",
                        Image = "professionaldogtrainer.jpg",
                        Salary = "Negotiate",
                        WorkAddress = "Ha Noi",
                        ExpirationDate = DateTime.Parse("2021-08-03"),
                        Description = "Take care of your dog and train according to a plan, Perform professional work according to the exercise program, Hone skills, guide and take care of sniffing dogs to get the best results.",
                    },
                     new Career()
                     {
                         Id = new Guid("5CC93D63-7D02-4B4B-A8E4-3C0414C5D687"),
                         Title = "High-Tech Monitoring Staff",
                         Image = "high-techmonitoringstaff.jpg",
                         Salary = "Negotiate",
                         WorkAddress = "Da Nang",
                         ExpirationDate = DateTime.Parse("2021-09-03"),
                         Description = "Surveying and planning for operation management and technical system maintenance, Statistics, description and status assessment of technical items. Develop a process of performing the work of the technical department and the technical values to be collected for evaluation.",
                     },
                      new Career()
                      {
                          Id = new Guid("43474CF6-57E4-42A9-AA5E-C7B2B8FFD545"),
                          Title = "Investigation Consultant",
                          Image = "investigation-consultant.jpg",
                          Salary = " 1500-1600 $",
                          WorkAddress = "Can Tho",
                          ExpirationDate = DateTime.Parse("2021-05-01"),
                          Description = "Provides solutions tailored to the client's investigative consulting needs to detect fraud or crime, such as workplace harassment, assault, intimidation, absence, drugs and addictive substances, theft and fraud, counterfeiting, piracy and industrial espionage.",
                      }

                );

            modelBuilder.Entity<Client>().HasData(
              new Client()
              {
                  Id = new Guid("dd555925-5f29-4ad3-9323-47fa8b3838a4"),
                  ID_Service = new Guid("1458aa9a-4398-4828-a451-d42467bfef94"),
                  Email = "chanhoa@gmail.com",
                  Phone = "0981159826",
                  Address = "Nhon,Ha Noi",
                  DOB = DateTime.Parse("2000-03-03"),
                  FirtName = "Chan Hoa",
                  LastName = "Do",
                  Gender = Gender.Female,
                  Status = Status.Processing,
              },
               new Client()
               {
                   Id = new Guid("ba42e262-948d-4c60-ac0a-24b4cc32af9c"),
                   ID_Service = new Guid("1458aa9a-4398-4828-a451-d42467bfef94"),
                   Email = "thanhtu@gmail.com",
                   Phone = "0359077335",
                   Address = "My Dinh,Ha Noi",
                   DOB = DateTime.Parse("1998-09-02"),
                   FirtName = "Thanh Tu",
                   LastName = "Truong",
                   Gender = Gender.Male,
                   Status = Status.Using,
               },
                new Client()
                {
                    Id = new Guid("9d381895-3b23-4def-a851-1f296a863ca8"),
                    ID_Service = new Guid("b8434194-a6a7-4dc7-a75d-76893bc3d2da"),
                    Email = "tuan@gmail.com",
                    Phone = "0382548442",
                    Address = "My Dinh,Ha Noi",
                    DOB = DateTime.Parse("2021-05-06"),
                    FirtName = "Tuan",
                    LastName = "Pham",
                    Gender = Gender.Male,
                    Status = Status.Used,
                },
                 new Client()
                 {
                     Id = new Guid("e5c9a908-11df-4922-b27d-9a2cfd10c4e0"),
                     ID_Service = new Guid("2599d241-1f72-44b0-9e5f-cedee1ed4ba2"),
                     Email = "quanghuy@gmail.com",
                     Phone = "0954576059",
                     Address = "My Dinh,Ha Noi",
                     DOB = DateTime.Parse("2001-02-08"),
                     FirtName = "Quang Huy",
                     LastName = "Vu",
                     Gender = Gender.Male,
                     Status = Status.Cancelled,
                 },
                  new Client()
                  {
                      Id = new Guid("6fbf38b7-5671-49c8-b622-ae56f07d7d60"),
                      ID_Service = new Guid("2599d241-1f72-44b0-9e5f-cedee1ed4ba2"),
                      Email = "dinhhieu@gmail.com",
                      Phone = "0868663315",
                      Address = "My Dinh,Ha Noi",
                      DOB = DateTime.Parse("2021-01-04"),
                      FirtName = "Dinh Hieu",
                      LastName = "Nguyen",
                      Gender = Gender.Male,
                      Status = Status.Used,
                  },
                   new Client()
                   {
                       Id = new Guid("e1a0f991-4b21-429e-8131-719d7b2b690f"),
                       ID_Service = new Guid("83A899EE-1108-48BB-AD81-33607A88C86C"),
                       Email = "vanduc@gmail.com",
                       Phone = "0332589099",
                       Address = "Dong Da,Ha Noi",
                       DOB = DateTime.Parse("2001-02-02"),
                       FirtName = "Van Duc",
                       LastName = "Nguyen",
                       Gender = Gender.Male,
                   },
                    new Client()
                    {
                        Id = new Guid("bab0201c-bb95-4423-b34d-85c6d99c3488"),
                        ID_Service = new Guid("A7EDA5BF-7D25-44C4-8444-38721533CFBE"),
                        Email = "huyentrang@gmail.com",
                        Phone = "0974275920",
                        Address = "Nhon,Ha Noi",
                        DOB = DateTime.Parse("2001-02-02"),
                        FirtName = "Huyen Trang",
                        LastName = "Do",
                        Gender = Gender.Female,
                    },
                     new Client()
                     {
                         Id = new Guid("f1724618-d229-4e4f-b226-7f7b294a9224"),
                         ID_Service = new Guid("A7EDA5BF-7D25-44C4-8444-38721533CFBE"),
                         Email = "Thanhhoa@gmail.com",
                         Phone = "0394169232",
                         Address = "Ba Vi, Ha Noi",
                         DOB = DateTime.Parse("2001-02-02"),

                         FirtName = "Thanh Hoa",
                         LastName = "Nguyen",
                         Gender = Gender.Female,
                     },
                      new Client()
                      {
                          Id = new Guid("802a2ff6-9fa8-4ebf-89ee-215f210eac00"),
                          ID_Service = new Guid("3E7E36E9-B173-4880-BB6D-8552CF0F29F7"),
                          Email = "vana@gmail.com",
                          Phone = "0352535272",
                          Address = "Tay Son,Ha Noi",
                          DOB = DateTime.Parse("2001-02-02"),
                          FirtName = " Van A",
                          LastName = "Nguyen",
                          Gender = Gender.Male,
                      },
                       new Client()
                       {
                           Id = new Guid("1923f274-426f-46e1-bc42-2d16747437ff"),
                           ID_Service = new Guid("3E7E36E9-B173-4880-BB6D-8552CF0F29F7"),
                           Email = "phuongthuy@gmail.com",
                           Phone = "0983770377",
                           Address = "Cau Giay,Ha Noi",
                           DOB = DateTime.Parse("2003-02-02"),
                           FirtName = "Phuong Thuy",
                           LastName = "Phung",
                           Gender = Gender.Female,
                       }
              );
            modelBuilder.Entity<Service>().HasData(
              new Service()
              {
                  Id = new Guid("1458aa9a-4398-4828-a451-d42467bfef94"),
                  Title = "Manned guarding  ",
                  Description = "The service portfolio of this division includes guarding, fire squad, dog squad, bodyguards etc. for industries, banks, retail outlets, residential colonies, hotels and institutions.",
                  Image = "manned-guarding.jpg",
                  Price = 500,
                  PromotionPrice = 499,
                  IsActive = true,
                  IsFeatured = true,
              },
               new Service()
               {
                   Id = new Guid("b8434194-a6a7-4dc7-a75d-76893bc3d2da"),
                   Title = "Investigations",
                   Description = "Provides leading professional information and advice in Vietnam, ready to help businesses, family and friends in the field of marriage as well as civil detective services, finding and providing information about relationship, providing legal information in civil proceedings.",
                   Image = "investigations.jpg",
                   Price = 300,
                   PromotionPrice = 299,
                   IsActive = true,
                   IsFeatured = true,
               },
                new Service()
                {
                    Id = new Guid("1d4110dc-1883-4e96-b695-a1f55daddba1"),
                    Title = "Electronic security systems ",
                    Description = "This division works in close association with SIS's strategic partners i.e. reputed system integrators & installers. The primary area of activity for this division is design, installation and maintenance of Access control systems, CCTVs, fire alarm systems, fire suppression systems, intruder/burglar alarms, perimeter protection systems, etc. The division aims at marketing its products to the existing customer base. .",
                    Image = "electronicsecuritysystems.jpg",
                    Price = 400,
                    PromotionPrice = 399,
                    IsActive = true,
                    IsFeatured = true,
                },
                 new Service()
                 {
                     Id = new Guid("2599d241-1f72-44b0-9e5f-cedee1ed4ba2"),
                     Title = "Cash services ",
                     Description = "The service range of the cash services division includes secured transfer of cash and valuables, ATM replenishment, vaulting and processing services, multi-point cash collection and caretaker services.",
                     Image = "cash-services.jpg",
                     Price = 250,
                     PromotionPrice = 200,
                     IsActive = true,
                     IsFeatured = true,
                 },
                 new Service()
                 {
                     Id = new Guid("83A899EE-1108-48BB-AD81-33607A88C86C"),
                     Title = "Police Support Services",
                     Description = "Our police support services allow police officers to focus on their frontline duties. We make this possible by taking on certain responsibilities, such as: witness protection, detainee surveillance and traffic management.We can provide police support services by performing certain non-essential operational tasks with utmost professionalism and efficacy, at a fraction of the cost.",
                     Image = "police-support-services.jpg",
                     Price = 280,
                     PromotionPrice = 240,
                     IsActive = true,
                     IsFeatured = false,
                 },
                  new Service()
                  {
                      Id = new Guid("A7EDA5BF-7D25-44C4-8444-38721533CFBE"),
                      Title = "CCTV Monitoring & Response",
                      Description = "We offer a range of choices, from traditional analog CCTV systems to the latest IP-based digital solutions. We can provide everything from stand-alone cameras for a branch office to full CCTV coverage for large building complexes and multiple properties. We also offer fully integrated IP addressable CCTV systems for high-security environments.",
                      Image = "cctv-monitoring&response.jpeg",
                      Price = 600,
                      PromotionPrice = 560,
                      IsActive = true,
                      IsFeatured = false,
                  },
                   new Service()
                   {
                       Id = new Guid("3E7E36E9-B173-4880-BB6D-8552CF0F29F7"),
                       Title = "Loss Prevention",
                       Description = "When it comes to your store, construction site, plant, warehouse or distribution center, protecting your inventory from loss is essential. Our loss prevention professionals help reduce your costs, prevent loss or internal fraud, and improve inventory management.",
                       Image = "loss-prevention.jpg",
                       Price = 900,
                       PromotionPrice = 888,
                       IsActive = true,
                       IsFeatured = false,
                   },
                    new Service()
                    {
                        Id = new Guid("5E20297C-E028-46D7-AC53-FEA030996CE0"),
                        Title = "Airport Security",
                        Description = "Our airport security services combine our highly trained personnel and specialized equipment. Effective passenger screening and air cargo freight screening are core components airport security expertise.",
                        Image = "airport-security.jpg",
                        Price = 550,
                        PromotionPrice = 500,
                        IsActive = true,
                        IsFeatured = false,
                    },
                    new Service()
                    {
                        Id = new Guid("A161C1D4-85D4-4735-8C67-3C66D843DD11"),
                        Title = "Crowd Management",
                        Description = "We have the experience to offer specialized event security teams for your sporting or cultural events of any size.",
                        Image = "crowd-management.jpg",
                        Price = 560,
                        PromotionPrice = 555,
                        IsActive = true,
                        IsFeatured = false,
                    },
                     new Service()
                     {
                         Id = new Guid("DCA90E37-D702-4E59-83B5-DD554B737121"),
                         Title = "Mobile Patrol",
                         Description = "Mobile patrol units are an important part of a successful security system. Not only does their presence serve as a deterrent, but the patrollers’ rapid response times ensure better protection of your facilities and assets against criminal acts.",
                         Image = "mobile-patrol.jpg",
                         Price = 700,
                         PromotionPrice = 690,
                         IsActive = true,
                         IsFeatured = false,
                     }
              );

            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(
             new User()
             {
                 Id = new Guid("5139DBF8-9410-4144-8BF1-78CAE007ED51"),
                 UserName = "nguyendinhhieu",
                 PasswordHash = hasher.HashPassword(null, "123456"),
                 Password = "123456",
                 Level = Level.Employee,
                 Email = "nguyendinhhieu@gmail.com",
                 Phone = "98372837362",
                 Address = "Xuan Loc, Nghe An",
                 DOB = DateTime.Parse("1996-02-02"),
                 Gender = Gender.Male,
                 FirtName = "Dinh Hieu",
                 LastName = "Nguyen ",
                 EmployeeEducationalQualification = "University",
                 EmployeeCode = "H123",
                 EmployeeDepartment = "Technical staff",
                 EmployeeRole = "Leader",
                 EmployeeGrade = "level 5 staff",
                 //EmployeeClient = ,
                 EmployeeAchievements = "the first prize in the singing contest of the room",
                 //LastLoginDate = null ,
             },
              new User()
              {
                  Id = new Guid("DDADF25D-9968-4766-AA78-608D52F631B9"),
                  UserName = "truongthanhtu",
                  PasswordHash = hasher.HashPassword(null, "123456"),
                  Password = "123456",
                  Level = Level.Customer,
                  Email = "truongthanhtu@gmail.com",
                  Phone = "0367376544",
                  Address = "Thuy Bieu, Hue",
                  DOB = DateTime.Parse("1998-09-03"),
                  Gender = Gender.Male,
                  FirtName = "Thanh Tu",
                  LastName = "Truong ",
                  EmployeeEducationalQualification = "University",
                  EmployeeCode = "T123",
                  EmployeeDepartment = "Technical staff",
                  EmployeeRole = "Leader",
                  EmployeeGrade = "level 5 staff",
                  //EmployeeClient = ,
                  EmployeeAchievements = "the first prize in the singing contest of the room",
                  //LastLoginDate = null ,
              },
               new User()
               {
                   Id = new Guid("A2183C7C-3A09-47F5-865D-1EBB9AE52A1F"),
                   UserName = "phamtuan",
                   PasswordHash = hasher.HashPassword(null, "123456"),
                   Password = "123456",
                   Level = Level.Employee,
                   Email = "phamtuan@gmail.com",
                   Phone = "0382548442",
                   Address = "My Dinh, Ha Noi",
                   DOB = DateTime.Parse("2001-02-02"),
                   Gender = Gender.Male,
                   FirtName = "Pham",
                   LastName = "Tuan",
                   EmployeeEducationalQualification = "University",
                   EmployeeCode = "T1234",
                   EmployeeDepartment = "Technical staff",
                   EmployeeRole = "Leader",
                   EmployeeGrade = "level 5 staff",
                   //EmployeeClient = ,
                   EmployeeAchievements = "the first prize in the singing contest of the room",
                   //LastLoginDate = null ,
               },
                new User()
                {
                    Id = new Guid("562548C6-88B4-4D1E-BCB8-AD49078ED896"),
                    UserName = "vuquanghuy",
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    Password = "123456",
                    Level = Level.Employee,
                    Email = "vuquanghuy@gmail.com",
                    Phone = "0964576059",
                    Address = "My Dinh, Ha Noi",
                    DOB = DateTime.Parse("2001-02-23"),
                    Gender = Gender.Male,
                    FirtName = "Quang Huy",
                    LastName = "Vu",
                    EmployeeEducationalQualification = "University",
                    EmployeeCode = "H1234",
                    EmployeeDepartment = "Technical staff",
                    EmployeeRole = "Leader",
                    EmployeeGrade = "level 5 staff",
                    //EmployeeClient = ,
                    EmployeeAchievements = "the first prize in the singing contest of the room",
                    //LastLoginDate = null ,
                },
                  new User()
                  {
                      Id = new Guid("4AEBADE0-FE97-4D9C-9172-7FF132F98C7C"),
                      UserName = "dothichanhoa",
                      PasswordHash = hasher.HashPassword(null, "123456"),
                      Password = "123456",
                      Level = Level.Employee,
                      Email = "chanhoa@gmail.com",
                      Phone = "0981159826",
                      Address = "Bac Tu Liem, Ha Noi",
                      DOB = DateTime.Parse("2000-12-22"),
                      Gender = Gender.Female,
                      FirtName = "Chan Hoa",
                      LastName = "Do",
                      EmployeeEducationalQualification = "University",
                      EmployeeCode = "H12345",
                      EmployeeDepartment = "Technical staff",
                      EmployeeRole = "Leader",
                      EmployeeGrade = "level 5 staff",
                      //EmployeeClient = ,
                      EmployeeAchievements = "the first prize in the singing contest of the room",
                      //LastLoginDate = null ,
                  },
                   new User()
                   {
                       Id = new Guid("6C2661F1-E224-42E1-89F5-679690270FB7"),
                       UserName = "Admin",
                       PasswordHash = hasher.HashPassword(null, "123456"),
                       Password = "123456",
                       Level = Level.Admin,
                       Email = "Admin@gmail.com",
                       Phone = "0981159826",
                       Address = "Nam Tu Liem, Ha Noi",
                       DOB = DateTime.Parse("2001-02-02"),
                       Gender = Gender.Female,
                       FirtName = "Admin",
                       LastName = "Admin",
                       EmployeeEducationalQualification = "University",
                       EmployeeCode = "A12345",
                       EmployeeDepartment = "Technical staff",
                       EmployeeRole = "Leader",
                       EmployeeGrade = "level 5 staff",
                       //EmployeeClient = ,
                       EmployeeAchievements = "the first prize in the singing contest of the room",
                       //LastLoginDate = null ,
                   },
                   new User()
                   {
                       Id = new Guid("383D5FE5-E255-4CDF-9589-DFF92DF193C8"),
                       UserName = "Host",
                       PasswordHash = hasher.HashPassword(null, "123456"),
                       Password = "123456",
                       Level = Level.Customer,
                       Email = "Host@gmail.com",
                       Phone = "0981159826",
                       Address = "Dong Da, Ha Noi",
                       DOB = DateTime.Parse("2001-02-02"),
                       Gender = Gender.Female,
                       FirtName = "Host",
                       LastName = "Host",
                       EmployeeEducationalQualification = "University",
                       EmployeeCode = "H123456",
                       EmployeeDepartment = "Technical staff",
                       EmployeeRole = "Leader",
                       EmployeeGrade = "level 5 staff",
                       //EmployeeClient = ,
                       EmployeeAchievements = "the first prize in the singing contest of the room",
                       //LastLoginDate = null ,
                   },
                    new User()
                    {
                        Id = new Guid("49B23D38-8E90-474E-8A46-63129CFBAA56"),
                        UserName = "Employee",
                        PasswordHash = hasher.HashPassword(null, "123456"),
                        Password = "123456",
                        Level = Level.Employee,
                        Email = "Employee@gmail.com",
                        Phone = "0981159826",
                        Address = "Ba Dinh, Ha Noi",
                        DOB = DateTime.Parse("2001-02-02"),
                        Gender = Gender.Female,
                        FirtName = "Employee",
                        LastName = "Employee",
                        EmployeeEducationalQualification = "University",
                        EmployeeCode = "E123456",
                        EmployeeDepartment = "Technical staff",
                        EmployeeRole = "Leader",
                        EmployeeGrade = "level 5 staff",
                        EmployeeAchievements = "the first prize in the singing contest of the room",
                    }

             );
            modelBuilder.Entity<Contact>().HasData(
           new Contact()
           {

               ID = new Guid("1FBB4429-5864-4E83-9D77-C7BB8308E3D3"),
               ID_Service = new Guid("1458aa9a-4398-4828-a451-d42467bfef94"),
               FullName = "Nguyen Van Duc",
               Email = "Vanduc@gmail.com",
               Phone = "0332589099",
               Subject = "CCTV Monitoring & Response",
               Message = "I want to learn about this service",
               Status = Status.Cancelled,
           },

           new Contact()
           {
               ID = new Guid("44154421-0DD7-4367-B4D8-B2B7E99CC099"),
               ID_Service = new Guid("1458aa9a-4398-4828-a451-d42467bfef94"),
               FullName = "Nguyen Dinh Xuan",
               Email = "Xuan123@gmail.com",
               Phone = "033268712",
               Subject = "Manned guarding",
               Message = "I would like advice on this service",
               Status = Status.Processing,
           },
            new Contact()
            {
                ID = new Guid("C7DF955F-5587-4A3B-BAAF-07CBD344B0E6"),
                ID_Service = new Guid("DCA90E37-D702-4E59-83B5-DD554B737121"),
                FullName = "Do Van B",
                Email = "Vanb123@gmail.com",
                Phone = "09687234",
                Subject = "Mobile Patrol",
                Message = "I would like advice on this service",
                Status = Status.Processing,
            },
             new Contact()
             {
                 ID = new Guid("B1311D6A-EF82-4245-8260-8A6C17C8F450"),
                 ID_Service = new Guid("3E7E36E9-B173-4880-BB6D-8552CF0F29F7"),
                 FullName = "Lai Trung Hoa",
                 Email = "Trunghoa@gmail.com",
                 Phone = "09942345",
                 Subject = "Loss Prevention",
                 Message = "I want to learn about this service",
                 Status = Status.Cancelled,
             },
             new Contact()
             {
                 ID = new Guid("2599d241-1f72-44b0-9e5f-cedee1ed4ba2"),
                 ID_Service = new Guid("3E7E36E9-B173-4880-BB6D-8552CF0F29F7"),
                 FullName = "Duong Van Loi",
                 Email = "Loi@gmail.com",
                 Phone = "09678213",
                 Subject = "Loss Prevention",
                 Message = "I want to learn about this service",
                 Status = Status.Used,
             },
              new Contact()
              {
                  ID = new Guid("149F9E93-5B05-44A8-A6C8-369CB0462857"),
                  ID_Service = new Guid("83A899EE-1108-48BB-AD81-33607A88C86C"),
                  FullName = "Do Dinh Huan",
                  Email = "Huan@gmail.com",
                  Phone = "033478990",
                  Subject = "Police Support Services",
                  Message = "I want to learn about this service",
                  Status = Status.Used,
              },
               new Contact()
               {
                   ID = new Guid("E6716FC7-C741-4587-B9A0-F5D816ED9922"),
                   ID_Service = new Guid("83A899EE-1108-48BB-AD81-33607A88C86C"),
                   FullName = "Do Minh Hoang",
                   Email = "Hoang@gmail.com",
                   Phone = "033908921",
                   Subject = "Police Support Services",
                   Message = "I want to use this service",
                   Status = Status.Cancelled,
               },
               new Contact()
               {
                   ID = new Guid("9E951C3B-4F80-4A5F-A78D-BD0D2FCA7779"),
                   ID_Service = new Guid("A161C1D4-85D4-4735-8C67-3C66D843DD11"),
                   FullName = "Nguyen Thanh Hang",
                   Email = "Hang@gmail.com",
                   Phone = "033257890",
                   Subject = "Crowd Management",
                   Message = "I want to use this service",
                   Status = Status.Using,
               },
                new Contact()
                {
                    ID = new Guid("C7EE237F-8E4D-48B9-8B11-FFC641C8D6D7"),
                    ID_Service = new Guid("A161C1D4-85D4-4735-8C67-3C66D843DD11"),
                    FullName = "Nguyen Thanh Hoa",
                    Email = "Hoa@gmail.com",
                    Phone = "03325789021",
                    Subject = "Crowd Management",
                    Message = "I want to use this service",
                    Status = Status.Using,
                },
                 new Contact()
                 {
                     ID = new Guid("9990C928-D3D3-43C7-BC8F-217B6B64FE3B"),
                     ID_Service = new Guid(" 5E20297C-E028-46D7-AC53-FEA030996CE0"),
                     FullName = "Nguyen Van Hoang",
                     Email = "Hoang234@gmail.com",
                     Phone = "033243134",
                     Subject = "Airport Security",
                     Message = "I want to use this service",
                     Status = Status.Using,
                 }


           );
            modelBuilder.Entity<Recruitment>().HasData(
         new Recruitment()
         {
             Id = new Guid("B99AD8BC-47A9-425F-8D72-1F4F2F35518A"),
             ID_Career = new Guid("57C10D2B-A2C6-40F9-A12C-54B9A802DE5A"),
             FirstName = "Thanh Thuy",
             LastName = "Phung",
             FileNameRecruitment = "Professional Dog Trainer",
             Phone = "03127321",
             Email ="Thuy@gmail.com",
             Address = "Ba Vi , Ha Noi",
             StatusRecruitment = StatusRecruitment.Interview,
             Gender= Gender.Female,
             DOB = DateTime.Parse("2001-02-02"),

         },
         new Recruitment()
         {
             Id = new Guid("984DB456-DA95-49ED-80C1-FA309E289F69"),
             ID_Career = new Guid("57C10D2B-A2C6-40F9-A12C-54B9A802DE5A"),
             FirstName = "Thuy Hoa",
             LastName = "Hoang",
             FileNameRecruitment = "Professional Dog Trainer",
             Phone = "09874321",
             Email = "Hoa123@gmail.com",
             Address = "My Dinh , Ha Noi",
             StatusRecruitment = StatusRecruitment.Refuse,
             Gender = Gender.Female,
             DOB = DateTime.Parse("1999-02-02"),

         },
          new Recruitment()
          {
              Id = new Guid("E8A07454-75F0-4858-A44D-51438BC9E1AC"),
              ID_Career = new Guid("43474CF6-57E4-42A9-AA5E-C7B2B8FFD545"),
              FirstName = "Trung Hieu",
              LastName = "Hoang",
              FileNameRecruitment = "Investigation Consultant",
              Phone = "0954319090",
              Email = "Hieu123@gmail.com",
              Address = "Dong Da , Ha Noi",
              StatusRecruitment = StatusRecruitment.Interview,
              Gender = Gender.Female,
              DOB = DateTime.Parse("1999-02-02"),

          },
          new Recruitment()
          {
              Id = new Guid("D6A0B594-1421-4178-8BD1-9895E3AA4FFC"),
              ID_Career = new Guid("7ABAB841-0A03-4F5D-8C2C-73A1DC4ECEBC"),
              FirstName = "Van Loi",
              LastName = "Hoang",
              FileNameRecruitment = "Camera installation technician",
              Phone = "033645782",
              Email = "Loi123@gmail.com",
              Address = "Hoang Mai , Ha Noi",
              StatusRecruitment = StatusRecruitment.Interview,
              Gender = Gender.Female,
              DOB = DateTime.Parse("2000-12-22"),

          },
          new Recruitment()
          {
              Id = new Guid("74158EED-8C42-47E7-9A6D-0EC3F2150718"),
              ID_Career = new Guid("f3470a7b-062f-4c7e-8d57-cf67dbbdf636"),
              FirstName = "Van Long",
              LastName = "Nguyen",
              FileNameRecruitment = "Network security staff",
              Phone = "03354890821",
              Email = "Long123@gmail.com",
              Address = "Hai Ba Trung , Ha Noi",
              StatusRecruitment = StatusRecruitment.Refuse,
              Gender = Gender.Female,
              DOB = DateTime.Parse("2000-04-22"),

          },
           new Recruitment()
           {
               Id = new Guid("96639E84-429D-40EB-8EA7-53521739C3C2"),
               ID_Career = new Guid("f3470a7b-062f-4c7e-8d57-cf67dbbdf636"),
               FirstName = "Duc",
               LastName = "Nguyen",
               FileNameRecruitment = "Network security staff",
               Phone = "09842531289",
               Email = "Duc123@gmail.com",
               Address = "Quan 2, Thanh Pho Ho Chi Minh",
               StatusRecruitment = StatusRecruitment.Interview,
               Gender = Gender.Female,
               DOB = DateTime.Parse("1998-04-22"),

           },
           new Recruitment()
           {
               Id = new Guid("5DF3F311-22F4-4B68-AFDA-37B2E8E86D46"),
               ID_Career = new Guid("5CC93D63-7D02-4B4B-A8E4-3C0414C5D687"),
               FirstName = " Van Dat",
               LastName = "Nguyen",
               FileNameRecruitment = "High-Tech Monitoring Staff",
               Phone = "0957124561",
               Email = "Dat123@gmail.com",
               Address = "Quan Thu Duc, Thanh Pho Ho Chi Minh",
               StatusRecruitment = StatusRecruitment.Refuse,
               Gender = Gender.Female,
               DOB = DateTime.Parse("1996-02-22"),

           },
             new Recruitment()
             {
                 Id = new Guid("DEF3A6F4-71E9-4E53-A442-CCE29002E890"),
                 ID_Career = new Guid("43474CF6-57E4-42A9-AA5E-C7B2B8FFD545"),
                 FirstName = " Van huynh",
                 LastName = "Hoang",
                 FileNameRecruitment = "Recruit professional security guards",
                 Phone = "0336590812",
                 Email = "Huynh123@gmail.com",
                 Address = "Ung Hoa, Ha Noi",
                 StatusRecruitment = StatusRecruitment.Refuse,
                 Gender = Gender.Female,
                 DOB = DateTime.Parse("1996-05-20"),

             }

         );
        }
    }
}