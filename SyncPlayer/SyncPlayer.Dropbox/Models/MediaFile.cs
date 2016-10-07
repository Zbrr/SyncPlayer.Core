using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncPlayer.Dropbox.Models
{
    public class MediaFile
    {
        public string Url { get; set; }

        public DateTime Expires { get; set; }
    }
}
