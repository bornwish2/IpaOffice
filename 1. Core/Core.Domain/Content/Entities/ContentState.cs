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
        Writing= 1,

        [Description("نوشته شده")]
        Written = 2,

        [Description("اضافه شده")]
        Added = 3,
    }
}
