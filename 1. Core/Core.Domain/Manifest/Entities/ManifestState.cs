using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Manifest.Entities
{
    public enum ManifestState
    {
        [Description("پیش نویس")]
        Draft=1,

        [Description("در حال ارسال")]
        Sending=2,

        [Description("ارسال شده")]
        Sent=3,

        [Description("بسته شده")]
        Closed=4
    }
}
