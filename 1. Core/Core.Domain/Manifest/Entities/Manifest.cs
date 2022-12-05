using Core.Domain.Form.Entities;
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
        public string Title { get;protected set; }
        public long StructureId { get;protected set; }
        public long DispatcherId { get; protected set; }
        public ManifestState State { get; set; }
        public Manifest(string title, long structureId,long dispatcherId)
        {
            Title = title;
            StructureId = structureId;
            DispatcherId = dispatcherId;
        }

        private Manifest()
        {

        }
        public Manifest CreateManifest(string title,long structureId,long dispatcherId)
        {
            return new Manifest(title,structureId, dispatcherId);
        }
        public void DeleteManifest (long manifestId)
        {

        }
        //public void SetTitle(string title)
        //{
        //    Title = title;
        //}
        public void ChangeTitle(long manifestId)
        {
          
        }
    }
}
