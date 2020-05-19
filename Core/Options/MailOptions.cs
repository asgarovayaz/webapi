using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace WebApiSkeleton.Core.Options
{
    public class MailOptions
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public string FromAddress { set; get; }

    }
}
