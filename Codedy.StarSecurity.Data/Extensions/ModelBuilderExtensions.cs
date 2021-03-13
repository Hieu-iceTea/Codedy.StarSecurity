using Codedy.StarSecurity.Data.Entiies;
using Codedy.StarSecurity.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codedy.StarSecurity.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Career>().HasData(
                new Career()
                {
                    Id = 1,
                    Title = "Guard",
                    Salary = 500,
                    WorkAddress = "Ha Noi",
                    ExpirationDate = DateTime.Parse("2021-02-02"),
                    Description = "Emplopyee",
                },
                 new Career()
                 {
                     Id = 2,
                     Title = "Emissary",
                     Salary = 500,
                     WorkAddress = "Ha Noi",
                     ExpirationDate = DateTime.Parse("2021-02-02"),
                     Description = "Emplopyee", 
                      
                 },
                 new Career()
                 {
                     Id = 3,
                     Title = "Bodyguard",
                     Salary = 500,
                     WorkAddress = "Ha Noi",
                     ExpirationDate = DateTime.Parse("2021-02-02"),
                     Description = "Emplopyee",
                 },
                  new Career()
                  {
                      Id = 4,
                      Title = "Sales manager",
                      Salary = 500,
                      WorkAddress = "Ha Noi",
                      ExpirationDate = DateTime.Parse("2021-02-02"),
                      Description = "Emplopyee",
                  },
                   new Career()
                   {
                       Id = 5,
                       Title = "Customer care staff",
                       Salary = 500,
                       WorkAddress = "Ha Noi",
                       ExpirationDate = DateTime.Parse("2021-02-02"),
                       Description = "Emplopyee",
                   },
                    new Career()
                    {
                        Id = 6,
                        Title = "C.E.O secretary",
                        Salary = 500,
                        WorkAddress = "Ha Noi",
                        ExpirationDate = DateTime.Parse("2021-02-02"),
                        Description = "Emplopyee",
                    },
                     new Career()
                     {
                         Id = 7,
                         Title = "Lawyer",
                         Salary = 500,
                         WorkAddress = "Ha Noi",
                         ExpirationDate = DateTime.Parse("2021-02-02"),
                         Description = "Emplopyee",
                     },
                      new Career()
                      {
                          Id = 8,
                          Title = "HRM",
                          Salary = 500,
                          WorkAddress = "Ha Noi",
                          ExpirationDate = DateTime.Parse("2021-02-02"),
                          Description = "Emplopyee",
                      },
                       new Career()
                       {
                           Id = 9,
                           Title = "sniper dog trainer",
                           Salary = 500,
                           WorkAddress = "Ha Noi",
                           ExpirationDate = DateTime.Parse("2021-02-02"),
                           Description = "Emplopyee",
                       },
                        new Career()
                        {
                            Id = 10,
                            Title = "Accountant",
                            Salary = 500,
                            WorkAddress = "Ha Noi",
                            ExpirationDate = DateTime.Parse("2021-02-02"),
                            Description = "Emplopyee",
                        }
                         
                );
           
            modelBuilder.Entity<Client>().HasData(
              new Client()
              {
                  Id = 1,
                  Email = "chanhoa@gmail.com",
                  Phone = "0981159826",
                  Address = "Nhon,Ha Noi",
                  DOB = DateTime.Parse("28-11-2000"),
                  FirtName = "Chan Hoa",
                  LastName = "Do",
                  Gender = Gender.Female,
              },
               new Client()
               {
                   Id = 2,
                   Email = "thanhtu@gmail.com",
                   Phone = "0981159826",
                   Address = "My Dinh,Ha Noi",
                   DOB = DateTime.Parse("22-12-1998"),
                   FirtName = "Thanh Tu",
                   LastName = "Truong",
                   Gender = Gender.Male,
               },
                new Client()
                {
                    Id = 3,
                    Email = "tuan@gmail.com",
                    Phone = "0981159826",
                    Address = "My Dinh,Ha Noi",
                    DOB = DateTime.Parse("22-12-2001"),
                    FirtName = "Tuan",
                    LastName = "Pham",
                    Gender = Gender.Male,
                },
                 new Client()
                 {
                     Id = 4,
                     Email = "quanghuy@gmail.com",
                     Phone = "0981159826",
                     Address = "My Dinh,Ha Noi",
                     DOB = DateTime.Parse("22-12-2001"),
                     FirtName = "Quang Huy",
                     LastName = "Vu",
                     Gender = Gender.Male,
                 },
                  new Client()
                  {
                      Id = 5,
                      Email = "dinhhieu@gmail.com",
                      Phone = "0981159826",
                      Address = "My Dinh,Ha Noi",
                      DOB = DateTime.Parse("22-12-1996"),
                      FirtName = "Dinh Hieu",
                      LastName = "Nguyen",
                      Gender = Gender.Male,
                  },
                   new Client()
                   {
                       Id = 6,
                       Email = "vanduc@gmail.com",
                       Phone = "0981159826",
                       Address = "Dong Da,Ha Noi",
                       DOB = DateTime.Parse("22-12-1995"),
                       FirtName = "Van Duc",
                       LastName = "Nguyen",
                       Gender = Gender.Male,
                   },
                    new Client()
                    {
                        Id = 7,
                        Email = "huyentrang@gmail.com",
                        Phone = "0981159826",
                        Address = "Nhon,Ha Noi",
                        DOB = DateTime.Parse("26-11-2002"),
                        FirtName = "Huyen Trang",
                        LastName = "Do",
                        Gender = Gender.Female,
                    },
                     new Client()
                     {
                         Id = 8,
                         Email = "Thanhhoa@gmail.com",
                         Phone = "0981159826",
                         Address = "Ba Vi, Ha Noi",
                         DOB = DateTime.Parse("17-02-2000"),
                         FirtName = "Thanh Hoa",
                         LastName = "Nguyen",
                         Gender = Gender.Female,
                     },
                      new Client()
                      {
                          Id = 9,
                          Email = "vana@gmail.com",
                          Phone = "0981159826",
                          Address = "Tay Son,Ha Noi",
                          DOB = DateTime.Parse("15/05/1990"),
                          FirtName = " Van A",
                          LastName = "Nguyen",
                          Gender = Gender.Male,
                      },
                       new Client()
                       {
                           Id = 10,
                           Email = "phuongthuy@gmail.com",
                           Phone = "0981159826",
                           Address = "Cau Giay,Ha Noi",
                           DOB = DateTime.Parse("24/2/1994"),
                           FirtName = "Phuong Thuy",
                           LastName = "Phung",
                           Gender = Gender.Female,
                       }
              );
            modelBuilder.Entity<Service>().HasData(
              new Service()
              {
                  Id = 1,
                  Title = "Security services",
                  Description = "The presence of security guards helps form a visible barrier to potential intrusion engines, while also providing protection for the Client's protection goals. With the rise of criminal activity, the demand for security protection services has increased dramatically compared to 10 years ago. Secom implements the recruitment of security guards according to strict standards, and conducts professional training according to the same standards and methods as Secom's in Japan.In addition, our management staff regularly carry out periodic or ad - hoc inspections in order to promptly grasp the performance of the profession, urge employees and thereby improve.service quality.In addition, we also share the know - how of security operations through specialized services including security inspection services and security guard management services.",
                  Image = "security-services.jpg",
                  Price = 500 ,
                  PromotionPrice = 499 ,
                  IsActive = true,
              },
               new Service()
               {
                   Id = 2,
                   Title = "Product",
                   Description = "Access control system is an electronic door opening system that is operated by identifying identifying information contained in the user's magnetic card or fingerprint by a data reader mounted on the door, thereby only Access to authorized persons has been defined in advance. Since all of the information identified by the data reader will be stored in the software, it is easy to know who, when, and where the controlled door opening occurs. In addition, with this software, we can set up decentralization for each person to specify who, which doors can open and for what period of time. Accordingly, the system can be used for a wide range of applications, not only for obvious cases such as when you do not want to be compromised by external objects, but also for cases such as expiration. or when you want to manage the employee's access rights according to different statuses. With actual installation in many cases, Secom can offer appropriate recommendations from the installation stage to the official system operation.",
                   Image = "product.jpg",
                   Price = 300,
                   PromotionPrice = 299,
                   IsActive = true,
               },
                new Service()
                {
                    Id = 3,
                    Title = "Security services",
                    Description = "The presence of security guards helps form a visible barrier to potential intrusion engines, while also providing protection for the Client's protection goals. With the rise of criminal activity, the demand for security protection services has increased dramatically compared to 10 years ago. Secom implements the recruitment of security guards according to strict standards, and conducts professional training according to the same standards and methods as Secom's in Japan.In addition, our management staff regularly carry out periodic or ad - hoc inspections in order to promptly grasp the performance of the profession, urge employees and thereby improve.service quality.In addition, we also share the know - how of security operations through specialized services including security inspection services and security guard management services.",
                    Image = "security-services.jpg",
                    Price = 400,
                    PromotionPrice = 399,
                    IsActive = true,
                },
                 new Service()
                 {
                     Id = 4,
                     Title = "Security services",
                     Description = "The presence of security guards helps form a visible barrier to potential intrusion engines, while also providing protection for the Client's protection goals. With the rise of criminal activity, the demand for security protection services has increased dramatically compared to 10 years ago. Secom implements the recruitment of security guards according to strict standards, and conducts professional training according to the same standards and methods as Secom's in Japan.In addition, our management staff regularly carry out periodic or ad - hoc inspections in order to promptly grasp the performance of the profession, urge employees and thereby improve.service quality.In addition, we also share the know - how of security operations through specialized services including security inspection services and security guard management services.",
                     Image = "security-services.jpg",
                     Price = 250,
                     PromotionPrice = 200,
                     IsActive = true,
                 },
                  new Service()
                  {
                      Id = 5,
                      Title = "Alarm service",
                      Description = "We are delighted and proud to introduce to the Vietnamese market our company's flagship product and service - Alarm Monitoring System Service. We set up the system, which is primarily activated during the unattended period and monitors the signal transmitted through the telephone line connection from the sensors installed at the target. protection of the Customer. We have a control center with a team of highly trained supervisors that carry out surveillance 24 hours a day. If the intrusion signal is detected, the supervisor will immediately contact the designated person in charge of the Customer, in the event of unidentified situation, our emergency response staff. will promptly arrive at the scene for verification. (*) Applies only to areas that already have emergency response services",
                      Image = "alarm-service.jpg",
                      Price = 1000,
                      PromotionPrice = 980,
                      IsActive = true,
                  },
                   new Service()
                   {
                       Id = 6,
                       Title = "Security Guards",
                       Description = "Our certified security guards are highly trained and supported by cutting edge technology to ensure the safety and security of your business operations.We invest time in an intensive selection process, which includes in-depth background checks. Once hired, our security guards undergo rigorous training in first aid, fire prevention, customer service and more.",
                       Image = "security-guards.jpg",
                       Price = 600,
                       PromotionPrice = 549,
                       IsActive = true,
                   },
                    new Service()
                    {
                        Id = 7,
                        Title = "Executive Protection",
                        Description = "When it comes to protecting individuals who may be exposed to an elevated level of risk, executive protection services are critical. This can include both top-notch bodyguards as well as mobile security solutions.Personal protection is a necessary security measure for individuals who may be exposed to increased personal risk due to their employment, celebrity status, wealth, associations, geographical location, or any other reason that could make them the target of a physical attack or kidnapping.",
                        Image = "executive-protection.jpg",
                        Price = 800,
                        PromotionPrice = 599,
                        IsActive = true,
                    },
                     new Service()
                     {
                         Id = 8,
                         Title = "Loss Prevention",
                         Description = "Loss prevention is a form of proactive intervention that consists of taking steps to prevent the risk of incidents that could lead to losses. Outsourcing your loss prevention needs to GardaWorld not only practically guarantees a return on investment, but greatly facilitates the task of your business managers and HR department.",
                         Image = "loss-prevention.jpg",
                         Price = 700,
                         PromotionPrice = 699,
                         IsActive = true,
                     },
                      new Service()
                      {
                          Id = 9,
                          Title = "K9 Security",
                          Description = "When it comes to public safety and securing certain environments, the significant contribution of professionally trained and handled guard dogs no longer needs to be proven.From airports and ports to stadiums, shopping malls and anywhere else where crowd safety can be a concern, the guard dogs from our K9 security units add a layer of protection to our security services.",
                          Image = "k9-security.jpg",
                          Price = 400,
                          PromotionPrice = 399,
                          IsActive = true,
                      },
                       new Service()
                       {
                           Id = 10,
                           Title = "Asset Tracking",
                           Description = "If you run a business where you have shipping containers, vehicles or personnel on the move, security and visibility of your high-value assets is critical. That’s why we offer first-rate asset tracking solutions, making asset management simple for our clients.Our tracking products all feature modern, flexible and intuitive interfaces, which you can access from your computer or mobile device. Plus, we offer a comprehensive range of functionalities to satisfy even advanced users.",
                           Image = "asset-tracking.jpg",
                           Price = 600,
                           PromotionPrice = 499,
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
                 DOB = DateTime.Parse("22-12-1996"),
                 Gender = Gender.Male,
                 FirtName = "Dinh Hieu",
                 LastName = "Nguyen ",
                EmployeeEducationalQualification = "University",
                EmployeeCode = "H123",
                EmployeeDepartment = "Technical staff" ,
                EmployeeRole = "Leader",
                EmployeeGrade = "level 5 staff",
                //EmployeeClient = ,
                EmployeeAchievements = "the first prize in the singing contest of the room" ,
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
                  DOB = DateTime.Parse("22-12-1998"),
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
                   Phone = "98372837362",
                   Address = "My Dinh, Ha Noi",
                   DOB = DateTime.Parse("22-12-2001"),
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
                    Phone = "98372837362",
                    Address = "My Dinh, Ha Noi",
                    DOB = DateTime.Parse("22-12-2001"),
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
                      DOB = DateTime.Parse("28-11-2000"),
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
                       DOB = DateTime.Parse("28-12-2000"),
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
                       DOB = DateTime.Parse("24-02-1999"),
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
                        DOB = DateTime.Parse("24-02-1999"),
                        Gender = Gender.Female,
                        FirtName = "Employee",
                        LastName = "Employee",
                        EmployeeEducationalQualification = "University",
                        EmployeeCode = "E123456",
                        EmployeeDepartment = "Technical staff",
                        EmployeeRole = "Leader",
                        EmployeeGrade = "level 5 staff",
                        //EmployeeClient = ,
                        EmployeeAchievements = "the first prize in the singing contest of the room",
                        //LastLoginDate = null ,
                    }

             );



        }
    }
}
