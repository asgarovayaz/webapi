using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSkeleton.Core.Options
{
    public class ResourceFolderOptions
    {
        public string TempFolder { get; set; }
        public string UploadsFolder { get; set; }
        public string DocumentsFolder { get; set; }
        public string MusicsFolder { get; set; }
    }
}
