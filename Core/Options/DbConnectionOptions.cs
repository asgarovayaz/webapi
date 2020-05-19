using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSkeleton.Core.Options
{
    public class DbConnectionOptions
    {
        public string Provider { get; set; }
        public string ConnectionString { get; set; }
    }
}
