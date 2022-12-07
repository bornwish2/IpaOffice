using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Content.Entities
{
    public enum ContentType
    {
        [Description("متن")]
        String=1,

        [Description("عکس")]
        Picture=2,

        [Description("فایل")]
        File=3,

        [Description("سند")]
        Document=4,

        [Description("تاریخ زمان")]
        DateTime=5,

        [Description("")]
        Boolean=6,

        [Description("زمان")]
        Time=7,

        [Description("تاریخ")]
        Date=8

    }
}
