//using Codedy.StarSecurity.WebApp.Models.Database.Entities;
//using Codedy.StarSecurity.WebApp.Models.Database.Enums;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Codedy.StarSecurity.WebApp.Models.Database.Extensions
//{
//    public static void Seed(this ModelBuilder modelBuilder)
//    {
//        modelBuilder.Entity<Career>().HasData(
//            new Career()
//            {
//                Id =  new Guid("f58c0412-8400-412b-801b-06b6090e67d3"),
//                Title = "Guard",
//                Salary = 500,
//                WorkAddress = "Ha Noi",
//                ExpirationDate = DateTime.Parse("2021-02-02"),
//                Description = "Absolutely safe protection for customers during working time by all measures",
//            },
//             new Career()
//             {
//                 Id = new Guid("5bd5f5d8-4899-4e4f-844c-ffd0ba71683e"),
//                 Title = "Cash teller",
//                 Salary = 500,
//                 WorkAddress = "Ha Noi",
//                 ExpirationDate = DateTime.Parse("2021-02-02"),
//                 Description = "Securely transfer cash and valuables, replenish ATM,warehouse and handling, multi-point collection",

//             },
//             new Career()
//             {
//                 Id = new Guid("14323e88-8116-4231-a6d5-3703c1535108"),
//                 Title = "Emissary",
//                 Salary = 500,
//                 WorkAddress = "Ha Noi",
//                 ExpirationDate = DateTime.Parse("2021-02-02"),
//                 Description = "Independent business investigation, providing information in the field of Marriage - Economics - Civil under Enterprise Law. Find people, monitor supervision, verify relatives, ...",
//             },
//              new Career()
//              {
//                  Id = new Guid("f3470a7b-062f-4c7e-8d57-cf67dbbdf636"),
//                  Title = "Network security staff",
//                  Salary = 500,
//                  WorkAddress = "Ha Noi",
//                  ExpirationDate = DateTime.Parse("2021-02-02"),
//                  Description = "Design, installation and maintenance of access control system, CCTV, fire alarm system, fire prevention system, intrusion / theft alarm, belt protection system, etc. customer base.",
//              }
//            );

//        modelBuilder.Entity<Client>().HasData(
//          new Client()
//          {
//              Id = 1,
//              Email = "chanhoa@gmail.com",
//              Phone = "0981159826",
//              Address = "Nhon,Ha Noi",
//              DOB = DateTime.Parse("28-11-2000"),
//              FirtName = "Chan Hoa",
//              LastName = "Do",
//              Gender = Gender.Female,
//          },
//           new Client()
//           {
//               Id = 2,
//               Email = "thanhtu@gmail.com",
//               Phone = "0981159826",
//               Address = "My Dinh,Ha Noi",
//               DOB = DateTime.Parse("22-12-1998"),
//               FirtName = "Thanh Tu",
//               LastName = "Truong",
//               Gender = Gender.Male,
//           },
//            new Client()
//            {
//                Id = 3,
//                Email = "tuan@gmail.com",
//                Phone = "0981159826",
//                Address = "My Dinh,Ha Noi",
//                DOB = DateTime.Parse("22-12-2001"),
//                FirtName = "Tuan",
//                LastName = "Pham",
//                Gender = Gender.Male,
//            },
//             new Client()
//             {
//                 Id = 4,
//                 Email = "quanghuy@gmail.com",
//                 Phone = "0981159826",
//                 Address = "My Dinh,Ha Noi",
//                 DOB = DateTime.Parse("22-12-2001"),
//                 FirtName = "Quang Huy",
//                 LastName = "Vu",
//                 Gender = Gender.Male,
//             },
//              new Client()
//              {
//                  Id = 5,
//                  Email = "dinhhieu@gmail.com",
//                  Phone = "0981159826",
//                  Address = "My Dinh,Ha Noi",
//                  DOB = DateTime.Parse("22-12-1996"),
//                  FirtName = "Dinh Hieu",
//                  LastName = "Nguyen",
//                  Gender = Gender.Male,
//              },
//               new Client()
//               {
//                   Id = 6,
//                   Email = "vanduc@gmail.com",
//                   Phone = "0981159826",
//                   Address = "Dong Da,Ha Noi",
//                   DOB = DateTime.Parse("22-12-1995"),
//                   FirtName = "Van Duc",
//                   LastName = "Nguyen",
//                   Gender = Gender.Male,
//               },
//                new Client()
//                {
//                    Id = 7,
//                    Email = "huyentrang@gmail.com",
//                    Phone = "0981159826",
//                    Address = "Nhon,Ha Noi",
//                    DOB = DateTime.Parse("26-11-2002"),
//                    FirtName = "Huyen Trang",
//                    LastName = "Do",
//                    Gender = Gender.Female,
//                },
//                 new Client()
//                 {
//                     Id = 8,
//                     Email = "Thanhhoa@gmail.com",
//                     Phone = "0981159826",
//                     Address = "Ba Vi, Ha Noi",
//                     DOB = DateTime.Parse("17-02-2000"),
//                     FirtName = "Thanh Hoa",
//                     LastName = "Nguyen",
//                     Gender = Gender.Female,
//                 },
//                  new Client()
//                  {
//                      Id = 9,
//                      Email = "vana@gmail.com",
//                      Phone = "0981159826",
//                      Address = "Tay Son,Ha Noi",
//                      DOB = DateTime.Parse("15/05/1990"),
//                      FirtName = " Van A",
//                      LastName = "Nguyen",
//                      Gender = Gender.Male,
//                  },
//                   new Client()
//                   {
//                       Id = 10,
//                       Email = "phuongthuy@gmail.com",
//                       Phone = "0981159826",
//                       Address = "Cau Giay,Ha Noi",
//                       DOB = DateTime.Parse("24/2/1994"),
//                       FirtName = "Phuong Thuy",
//                       LastName = "Phung",
//                       Gender = Gender.Female,
//                   }
//          );
//        modelBuilder.Entity<Service>().HasData(
//          new Service()
//          {
//              Id = 1,
//              Title = "Manned guarding  ",
//              Description = "The service portfolio of this division includes guarding, fire squad, dog squad, bodyguards etc. for industries, banks, retail outlets, residential colonies, hotels and institutions.",
//              Image = "manned-guarding .jpg",
//              Price = 500,
//              PromotionPrice = 499,
//              IsActive = true,
//          },
//           new Service()
//           {
//               Id = 2,
//               Title = "Investigations",
//               Description = "DEATH INVESTIGATION - MONITORING,MONITOR YOUR CHILDREN, INVESTIGATION INVESTIGATION, INVESTIGATION INVESTIGATION - DISABILITY, SEARCH DNA TRACK, PHONE NUMBER INVESTIGATION.Professional detective team, well-trained and with professional ethics, complete and sophisticated equipment system with the most modern and advanced technology today.",
//               Image = "investigations.jpg",
//               Price = 300,
//               PromotionPrice = 299,
//               IsActive = true,
//           },
//            new Service()
//            {
//                Id = 3,
//                Title = "Electronic security systems ",
//                Description = "This division works in close association with SIS's strategic partners i.e. reputed system integrators & installers. The primary area of activity for this division is design, installation and maintenance of Access control systems, CCTVs, fire alarm systems, fire suppression systems, intruder/burglar alarms, perimeter protection systems, etc. The division aims at marketing its products to the existing customer base. .",
//                Image = "electronic security systems .jpg",
//                Price = 400,
//                PromotionPrice = 399,
//                IsActive = true,
//            },
//             new Service()
//             {
//                 Id = 4,
//                 Title = "Cash services ",
//                 Description = "The service range of the Cash Services division includes secured transfer of cash and valuables, ATM replenishment, Vaulting and Processing Services, multi-point cash collection and Caretaker Services.",
//                 Image = "cash-services .jpg",
//                 Price = 250,
//                 PromotionPrice = 200,
//                 IsActive = true,
//             }
//          );

//        var hasher = new PasswordHasher<User>();
//        modelBuilder.Entity<User>().HasData(
//         new User()
//         {
//             Id = new Guid("5139DBF8-9410-4144-8BF1-78CAE007ED51"),
//             UserName = "nguyendinhhieu",
//             PasswordHash = hasher.HashPassword(null, "123456"),
//             Email = "nguyendinhhieu@gmail.com",
//             Phone = "98372837362",
//             Address = "Xuan Loc, Nghe An",
//             DOB = DateTime.Parse("22-12-1996"),
//             Gender = Gender.Male,
//             FirtName = "Dinh Hieu",
//             LastName = "Nguyen ",
//             EmployeeEducationalQualification = "University",
//             EmployeeCode = "H123",
//             EmployeeDepartment = "Technical staff",
//             EmployeeRole = "Leader",
//             EmployeeGrade = "level 5 staff",
//             //EmployeeClient = ,
//             EmployeeAchievements = "the first prize in the singing contest of the room",
//             //LastLoginDate = null ,
//         },
//          new User()
//          {
//              Id = new Guid("DDADF25D-9968-4766-AA78-608D52F631B9"),
//              UserName = "truongthanhtu",
//              PasswordHash = hasher.HashPassword(null, "123456"),
//              Email = "truongthanhtu@gmail.com",
//              Phone = "0367376544",
//              Address = "Thuy Bieu, Hue",
//              DOB = DateTime.Parse("22-12-1998"),
//              Gender = Gender.Male,
//              FirtName = "Thanh Tu",
//              LastName = "Truong ",
//              EmployeeEducationalQualification = "University",
//              EmployeeCode = "T123",
//              EmployeeDepartment = "Technical staff",
//              EmployeeRole = "Leader",
//              EmployeeGrade = "level 5 staff",
//              //EmployeeClient = ,
//              EmployeeAchievements = "the first prize in the singing contest of the room",
//              //LastLoginDate = null ,
//          },
//           new User()
//           {
//               Id = new Guid("A2183C7C-3A09-47F5-865D-1EBB9AE52A1F"),
//               UserName = "phamtuan",
//               PasswordHash = hasher.HashPassword(null, "123456"),
//               Email = "phamtuan@gmail.com",
//               Phone = "98372837362",
//               Address = "My Dinh, Ha Noi",
//               DOB = DateTime.Parse("22-12-2001"),
//               Gender = Gender.Male,
//               FirtName = "Pham",
//               LastName = "Tuan",
//               EmployeeEducationalQualification = "University",
//               EmployeeCode = "T1234",
//               EmployeeDepartment = "Technical staff",
//               EmployeeRole = "Leader",
//               EmployeeGrade = "level 5 staff",
//               //EmployeeClient = ,
//               EmployeeAchievements = "the first prize in the singing contest of the room",
//               //LastLoginDate = null ,
//           },
//            new User()
//            {
//                Id = new Guid("562548C6-88B4-4D1E-BCB8-AD49078ED896"),
//                UserName = "vuquanghuy",
//                PasswordHash = hasher.HashPassword(null, "123456"),
//                Email = "vuquanghuy@gmail.com",
//                Phone = "98372837362",
//                Address = "My Dinh, Ha Noi",
//                DOB = DateTime.Parse("22-12-2001"),
//                Gender = Gender.Male,
//                FirtName = "Quang Huy",
//                LastName = "Vu",
//                EmployeeEducationalQualification = "University",
//                EmployeeCode = "H1234",
//                EmployeeDepartment = "Technical staff",
//                EmployeeRole = "Leader",
//                EmployeeGrade = "level 5 staff",
//                //EmployeeClient = ,
//                EmployeeAchievements = "the first prize in the singing contest of the room",
//                //LastLoginDate = null ,
//            },
//              new User()
//              {
//                  Id = new Guid("4AEBADE0-FE97-4D9C-9172-7FF132F98C7C"),
//                  UserName = "dothichanhoa",
//                  PasswordHash = hasher.HashPassword(null, "123456"),
//                  Email = "chanhoa@gmail.com",
//                  Phone = "0981159826",
//                  Address = "Bac Tu Liem, Ha Noi",
//                  DOB = DateTime.Parse("28-11-2000"),
//                  Gender = Gender.Female,
//                  FirtName = "Chan Hoa",
//                  LastName = "Do",
//                  EmployeeEducationalQualification = "University",
//                  EmployeeCode = "H12345",
//                  EmployeeDepartment = "Technical staff",
//                  EmployeeRole = "Leader",
//                  EmployeeGrade = "level 5 staff",
//                  //EmployeeClient = ,
//                  EmployeeAchievements = "the first prize in the singing contest of the room",
//                  //LastLoginDate = null ,
//              },
//               new User()
//               {
//                   Id = new Guid("6C2661F1-E224-42E1-89F5-679690270FB7"),
//                   UserName = "Admin",
//                   PasswordHash = hasher.HashPassword(null, "123456"),
//                   Email = "Admin@gmail.com",
//                   Phone = "0981159826",
//                   Address = "Nam Tu Liem, Ha Noi",
//                   DOB = DateTime.Parse("28-12-2000"),
//                   Gender = Gender.Female,
//                   FirtName = "Admin",
//                   LastName = "Admin",
//                   EmployeeEducationalQualification = "University",
//                   EmployeeCode = "A12345",
//                   EmployeeDepartment = "Technical staff",
//                   EmployeeRole = "Leader",
//                   EmployeeGrade = "level 5 staff",
//                   //EmployeeClient = ,
//                   EmployeeAchievements = "the first prize in the singing contest of the room",
//                   //LastLoginDate = null ,
//               },
//               new User()
//               {
//                   Id = new Guid("383D5FE5-E255-4CDF-9589-DFF92DF193C8"),
//                   UserName = "Host",
//                   PasswordHash = hasher.HashPassword(null, "123456"),
//                   Email = "Host@gmail.com",
//                   Phone = "0981159826",
//                   Address = "Dong Da, Ha Noi",
//                   DOB = DateTime.Parse("24-02-1999"),
//                   Gender = Gender.Female,
//                   FirtName = "Host",
//                   LastName = "Host",
//                   EmployeeEducationalQualification = "University",
//                   EmployeeCode = "H123456",
//                   EmployeeDepartment = "Technical staff",
//                   EmployeeRole = "Leader",
//                   EmployeeGrade = "level 5 staff",
//                   //EmployeeClient = ,
//                   EmployeeAchievements = "the first prize in the singing contest of the room",
//                   //LastLoginDate = null ,
//               },
//                new User()
//                {
//                    Id = new Guid("49B23D38-8E90-474E-8A46-63129CFBAA56"),
//                    UserName = "Employee",
//                    PasswordHash = hasher.HashPassword(null, "123456"),
//                    Email = "Employee@gmail.com",
//                    Phone = "0981159826",
//                    Address = "Ba Dinh, Ha Noi",
//                    DOB = DateTime.Parse("24-02-1999"),
//                    Gender = Gender.Female,
//                    FirtName = "Employee",
//                    LastName = "Employee",
//                    EmployeeEducationalQualification = "University",
//                    EmployeeCode = "E123456",
//                    EmployeeDepartment = "Technical staff",
//                    EmployeeRole = "Leader",
//                    EmployeeGrade = "level 5 staff",
//                    EmployeeAchievements = "the first prize in the singing contest of the room",
//                }

//         );
//    }
//}