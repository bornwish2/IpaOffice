using Core.Domain.Picture.Entities;
using Framework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Content.Entities
{
    public class Content : BaseEntity
    {
        public Guid Id { get; private set; }
        public long FormId { get;private set; }
        public string Name { get;private set; }
        public ContentType Type { get;private set; }
        public Guid ValueId { get;private set; }
        private Content()
        {

        }
        public Content(Guid id,string name,ContentType type,long formId)
        {
            Id= id;
            Name= name;
            Type= type;
            FormId= formId;
        }
        public void FillContent(Guid valueId)
        {
            ValueId= valueId;
        }
        public void ModifyContent(Guid valueId)
        {
            ValueId = valueId;
        }
    }
    public static class ContentFactory
    {
        public static Content ContentPicture(Guid id, string name, long formId)
        {
            return new Content(id, name, ContentType.Picture, formId);
        }
        public static Content ContentString(Guid id, string name, long formId)
        {
            return new Content(id, name, ContentType.String, formId);
        }
        public static Content ContentFile(Guid id, string name, long formId)
        {
            return new Content(id, name, ContentType.File, formId);
        }
        public static Content ContentDocument(Guid id, string name, long formId)
        {
            return new Content(id, name, ContentType.Document, formId);
        }
        public static Content ContentDateTime(Guid id, string name, long formId)
        {
            return new Content(id, name, ContentType.DateTime, formId);
        }
        public static Content ContentDate(Guid id, string name, long formId)
        {
            return new Content(id, name, ContentType.Date, formId);
        }
        public static Content ContentTime(Guid id, string name, long formId)
        {
            return new Content(id, name, ContentType.Time, formId);
        }
        public static Content ContentBoolean(Guid id, string name, long formId)
        {
            return new Content(id, name, ContentType.Boolean, formId);
        }
    }
}
