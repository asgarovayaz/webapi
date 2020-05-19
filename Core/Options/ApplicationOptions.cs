using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSkeleton.Core.Options
{
    public class ApplicationOptions
    {
        public string Address { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string HeaderVersionReader { get; set; }
        public string Secret { get; set; }
        public TimeSpan TokenLife { get; set; }

    }
}