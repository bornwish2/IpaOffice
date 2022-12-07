using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Content.Entities
{
    public enum ContentState
    {

        [Description("درحال نوشتن")]
        Draft = 1,

        [Description("نوشته شده")]
        Sending = 2,

        [Description("اضافه شده")]
        Sent = 3,
    }
}
