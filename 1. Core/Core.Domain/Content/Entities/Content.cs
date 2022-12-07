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
        public Guid ManifestId { get;private set; }
        public string Name { get;private set; }
        public ContentType Type { get;private set; }
        public Guid ValueId { get;private set; }
        private Content()
        {

        }
        public Content(Guid id,string name,ContentType type,Guid manifestId)
        {
            Id= id;
            Name= name;
            Type= type;
            ManifestId= manifestId;
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
        public static Content ContentPicture(Guid id, string name, Guid manifestId)
        {
            return new Content(id, name, ContentType.Picture,manifestId);
        }
        public static Content ContentString(Guid id, string name, Guid manifestId)
        {
            return new Content(id, name, ContentType.String, manifestId);
        }
        public static Content ContentFile(Guid id, string name, Guid manifestId)
        {
            return new Content(id, name, ContentType.File, manifestId);
        }
        public static Content ContentDocument(Guid id, string name, Guid manifestId)
        {
            return new Content(id, name, ContentType.Document, manifestId);
        }
        public static Content ContentDateTime(Guid id, string name, Guid manifestId)
        {
            return new Content(id, name, ContentType.DateTime, manifestId);
        }
        public static Content ContentDate(Guid id, string name, Guid manifestId)
        {
            return new Content(id, name, ContentType.Date, manifestId);
        }
        public static Content ContentTime(Guid id, string name, Guid manifestId)
        {
            return new Content(id, name, ContentType.Time, manifestId);
        }
        public static Content ContentBoolean(Guid id, string name, Guid manifestId)
        {
            return new Content(id, name, ContentType.Boolean, manifestId);
        }
    }
}
