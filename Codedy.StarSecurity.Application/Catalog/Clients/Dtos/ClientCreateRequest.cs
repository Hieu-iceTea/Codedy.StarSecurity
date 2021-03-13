using Codedy.StarSecurity.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codedy.StarSecurity.Application.Catalog.Clients.Dtos
{
    public class ClientCreateRequest
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
    }
}
