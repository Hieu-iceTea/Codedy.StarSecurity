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
                    Title = "Senior Fleet Manager",
                    Image = "senior-fleet-manager.jpg",
                    Salary = "800 - 1600 $",
                    WorkAddress = "Ha Noi",
                    ExpirationDate = DateTime.Parse("2021-06-02"),
                    Description = "The Senior Fleet Manager reports directly to Regional Director, Iraq and is responsible for the management of all GardaWorld (GW) vehicles in Iraq.  They are also responsible for ensuring operation delivery of all GW Vehicle Servicing Centres (VSC) and managing VSC Managers and any Local National mechanics employed within the VSCs. The Senior Fleet Manager will be accountable for over 600 vehicles, the role will manage the day - to - day authorisations for repair and maintenance, legal compliance and management of our VSCs, 3rd party repair garages and vehicle suppliers with the QM and Compliance team. The Senior Fleet Manager will be responsible for the strategic planning of our fleet, analysing data to drive business decisions.It will be critical to identify efficiencies, improvements and innovation in this role",
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
                    Title = "Female Close Protection Officer",
                    Image = "female-close-protection-officer.jpg",
                    Salary = "800 - 1200 $",
                    WorkAddress = "Ha Noi",
                    ExpirationDate = DateTime.Parse("2021-05-15"),
                    Description = "Services provided by the Contractor shall be those typically expected for someone in the position and include, but not be limited to the provision of armed mobile protection services to ensure the safety and security of all client staff and other personnel who come under duty of care of relevant client entity.  Services the Contractor can expect to carry out, would include: + Acting as an armed Close Protection Officer to Authority clients whilst they conduct their daily duties as part of a mobile protection team. + Operating as a driver or commander of a B6 armoured vehicle as part of a mobile protection team.  + Undertaking any other direction or reasonable request given by appropriate GardaWorld Management team in accordance with GW Standard Operating Procedures and Guidelines",
                },
                new Career()
                {
                    Id = new Guid("14323e88-8116-4231-a6d5-3703c1535108"),
                    Title = "Emissary",
                    Image = "emissary.jpg",
                    Salary = "1200 - 2000 $",
                    WorkAddress = "Da Nang",
                    ExpirationDate = DateTime.Parse("2021-08-25"),
                    Description = "Independent business investigation, providing information in the field of Marriage - Economics - Civil under Enterprise Law. Find people, monitor supervision, verify relatives",
                }
                );

            modelBuilder.Entity<Client>().HasData(
              new Client()
              {
                  Id = new Guid("dd555925-5f29-4ad3-9323-47fa8b3838a4"),
                  Email = "chanhoa@gmail.com",
                  Phone = "0981159826",
                  Address = "Nhon,Ha Noi",
                  DOB = DateTime.Parse("2000-03-03"),
                  FirtName = "Chan Hoa",
                  LastName = "Do",
                  Gender = Gender.Female,
              },
               new Client()
               {
                   Id = new Guid("ba42e262-948d-4c60-ac0a-24b4cc32af9c"),
                   Email = "thanhtu@gmail.com",
                   Phone = "0981159826",
                   Address = "My Dinh,Ha Noi",
                   DOB = DateTime.Parse("1998-09-02"),
                   FirtName = "Thanh Tu",
                   LastName = "Truong",
                   Gender = Gender.Male,
               },
                new Client()
                {
                    Id = new Guid("9d381895-3b23-4def-a851-1f296a863ca8"),
                    Email = "tuan@gmail.com",
                    Phone = "0981159826",
                    Address = "My Dinh,Ha Noi",
                    DOB = DateTime.Parse("2021-05-06"),
                    FirtName = "Tuan",
                    LastName = "Pham",
                    Gender = Gender.Male,
                },
                 new Client()
                 {
                     Id = new Guid("e5c9a908-11df-4922-b27d-9a2cfd10c4e0"),
                     Email = "quanghuy@gmail.com",
                     Phone = "0981159826",
                     Address = "My Dinh,Ha Noi",
                     DOB = DateTime.Parse("2001-02-08"),
                     FirtName = "Quang Huy",
                     LastName = "Vu",
                     Gender = Gender.Male,
                 },
                  new Client()
                  {
                      Id = new Guid("6fbf38b7-5671-49c8-b622-ae56f07d7d60"),
                      Email = "dinhhieu@gmail.com",
                      Phone = "0981159826",
                      Address = "My Dinh,Ha Noi",
                      DOB = DateTime.Parse("2021-01-04"),
                      FirtName = "Dinh Hieu",
                      LastName = "Nguyen",
                      Gender = Gender.Male,
                  },
                   new Client()
                   {
                       Id = new Guid("e1a0f991-4b21-429e-8131-719d7b2b690f"),
                       Email = "vanduc@gmail.com",
                       Phone = "0981159826",
                       Address = "Dong Da,Ha Noi",
                       DOB = DateTime.Parse("2001-02-02"),
                       FirtName = "Van Duc",
                       LastName = "Nguyen",
                       Gender = Gender.Male,
                   },
                    new Client()
                    {
                        Id = new Guid("bab0201c-bb95-4423-b34d-85c6d99c3488"),
                        Email = "huyentrang@gmail.com",
                        Phone = "0981159826",
                        Address = "Nhon,Ha Noi",
                        DOB = DateTime.Parse("2001-02-02"),
                        FirtName = "Huyen Trang",
                        LastName = "Do",
                        Gender = Gender.Female,
                    },
                     new Client()
                     {
                         Id = new Guid("f1724618-d229-4e4f-b226-7f7b294a9224"),
                         Email = "Thanhhoa@gmail.com",
                         Phone = "0981159826",
                         Address = "Ba Vi, Ha Noi",
                         DOB = DateTime.Parse("2001-02-02"),

                         FirtName = "Thanh Hoa",
                         LastName = "Nguyen",
                         Gender = Gender.Female,
                     },
                      new Client()
                      {
                          Id = new Guid("802a2ff6-9fa8-4ebf-89ee-215f210eac00"),
                          Email = "vana@gmail.com",
                          Phone = "0981159826",
                          Address = "Tay Son,Ha Noi",
                          DOB = DateTime.Parse("2001-02-02"),
                          FirtName = " Van A",
                          LastName = "Nguyen",
                          Gender = Gender.Male,
                      },
                       new Client()
                       {
                           Id = new Guid("1923f274-426f-46e1-bc42-2d16747437ff"),
                           Email = "phuongthuy@gmail.com",
                           Phone = "0981159826",
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
                  Price = 500,
                  PromotionPrice = 499,
                  IsActive = true,
              },
               new Service()
               {
                   Id = new Guid("b8434194-a6a7-4dc7-a75d-76893bc3d2da"),
                   Title = "Investigations",
                   Description = "DEATH INVESTIGATION - MONITORING,MONITOR YOUR CHILDREN, INVESTIGATION INVESTIGATION, INVESTIGATION INVESTIGATION - DISABILITY, SEARCH DNA TRACK, PHONE NUMBER INVESTIGATION.Professional detective team, well-trained and with professional ethics, complete and sophisticated equipment system with the most modern and advanced technology today.",
                   Price = 300,
                   PromotionPrice = 299,
                   IsActive = true,
               },
                new Service()
                {
                    Id = new Guid("1d4110dc-1883-4e96-b695-a1f55daddba1"),
                    Title = "Electronic security systems ",
                    Description = "This division works in close association with SIS's strategic partners i.e. reputed system integrators & installers. The primary area of activity for this division is design, installation and maintenance of Access control systems, CCTVs, fire alarm systems, fire suppression systems, intruder/burglar alarms, perimeter protection systems, etc. The division aims at marketing its products to the existing customer base. .",
                    Price = 400,
                    PromotionPrice = 399,
                    IsActive = true,
                },
                 new Service()
                 {
                     Id = new Guid("2599d241-1f72-44b0-9e5f-cedee1ed4ba2"),
                     Title = "Cash services ",
                     Description = "The service range of the Cash Services division includes secured transfer of cash and valuables, ATM replenishment, Vaulting and Processing Services, multi-point cash collection and Caretaker Services.",
                     Price = 250,
                     PromotionPrice = 200,
                     IsActive = true,
                 }
              );

            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(
             new User()
             {
                 Id = new Guid("5139DBF8-9410-4144-8BF1-78CAE007ED51"),
                 UserName = "nguyendinhhieu",
                 PasswordHash = hasher.HashPassword(null, "123456"),
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
        }
    }
}