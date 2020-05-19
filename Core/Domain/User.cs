using System;
using System.Collections.Generic;

namespace WebApiSkeleton.Core.Domain
{
    /// <summary>
    /// Initial model
    /// </summary>
    public class User
    {
        public long Id { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int Role { get; set; }
        public long? ProjectId { get; set; }
        public string CountryCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Status { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string Token { get; internal set; }

        public Guid Verification { get; set; }
        public bool IsVerified { get; set; }

        public virtual Project Project { get; set; }

    }
}
