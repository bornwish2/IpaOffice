using Framework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Department.Entities
{
   public class Department:BaseAggregateRoot
    {
        /* agg
         * بخش های مختلف دبیرخانه
         مثل حسابداری، کارگزینی و ...*/
        public string Title { get; set; }

    }
}
