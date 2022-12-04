using Core.Domain.Form.Entities;
using Core.Domain.Manifest.ValueObjects;
using Core.Domain.Toolkits_Shared_.ValueObjects;
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
        public string Title { get; set; }
        public long StructureId { get; set; }
        public Manifest(string title, long structureId)
        {
            Title = title;
            StructureId = structureId;
        }

        private Manifest()
        {

        }
        public Manifest CreateManifest(string title,long structureId)
        {
            return new Manifest(title,structureId);
        }
        public void DeleteManifest (long manifestId)
        {

        }
        public void SetTitle(string title)
        {
            Title = title;
        }
        public void ChangeTitle(long manifestId)
        {
          
        }

    }
}
