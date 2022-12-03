using Core.Domain.Form.Entities;
using Core.Domain.Manifest.ValueObjects;
using Core.Domain.Structure.Entities;
using Framework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Manifest.Entities
{
    public class Manifest : BaseAggregateRoot
    {
        /*agg
         برای ایجاد و دیگر عملیات های مربوط به نامه یا اعلامیه یا فراخوان یا ...
        پیاده سازی با کمک composite design pattern
        شامل لیستی از کانتنت ها به صورت dictionary<tuple(structureId,formId,contentId),value>*/
        //public ICollection<Content> Contents { get; set; }
        public ICollection<Form.Entities.Form> Forms { get;protected set; }
        public Structure.Entities.Structure Structure { get; set; }
    }
}
