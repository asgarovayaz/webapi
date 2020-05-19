using System;

namespace WebApiSkeleton.Core.Domain
{
    public class Person
    {
        public long Id { get; set; }
        public long? ProjectId { get; set; }
        public long? WebApiSkeletonsId { get; set; }
        public string CountryCode { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int Gender { get; set; }
        public int? License { get; set; }

        public virtual Project Project { get; set; }
        public virtual WebApiSkeletons WebApiSkeletons { get; set; }

    }
}
