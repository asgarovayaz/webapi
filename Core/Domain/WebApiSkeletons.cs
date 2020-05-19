using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WebApiSkeleton.Core.Domain
{
    public class WebApiSkeletons
    {
        public long Id { get; set; }

        public int? WebApiSkeletonContactId { get; set; }

        public string CountryCode { get; set; }

        public DateTime LastUpdate { get; set; }

        public long UpdatedBy { get; set; }
        
        public long ProjectId { get; set; }

        public virtual Project Project { get; set; }

        public virtual WebApiSkeletonContact WebApiSkeletonContact { get; set; }

    }
}
