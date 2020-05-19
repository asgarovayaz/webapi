using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSkeleton.Core.Domain.Users
{
    public class Register
    {
        public int Role { get; set; }
        public long? ProjectId { get; set; }
        public string CountryCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
