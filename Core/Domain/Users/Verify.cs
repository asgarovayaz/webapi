using System;

namespace WebApiSkeleton.Core.Domain.Users
{
    public class Verify
    {
        public long Id { get; set; }
        public Guid VerificationGuid { get; set; }
    }
}
