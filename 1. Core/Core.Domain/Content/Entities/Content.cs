using Core.Domain.Picture.Entities;
using Framework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Content.Entities
{
    public class Content : BaseAggregateRoot
    {
        #region Properties
        public Guid Id { get; private set; }
        public string Name { get;private set; }
        public ContentType Type { get;private set; }
        public ContentState State { get; set; }
        public long FormId { get; private set; }
        public Guid ValueId { get;private set; }
        #endregion

        #region Constructors
        private Content()
        {

        }
        public Content(Guid id,string name,ContentType type,long formId)
        {
            Id= id;
            Name= name;
            Type= type;
            FormId= formId;
            State = ContentState.Writing;
        }
        #endregion

        #region Methods
        public void FillContent(Guid valueId)
        {
            ValueId= valueId;
        }
        public void ChangeName(Content content,string name)
        {
            content.Name = name;
        }
        public void SetContentState(Content content,ContentState state)
        {
            content.State = state;
        }
        public void SetContentType(Content content, ContentType type)
        {
            content.Type = type;
        }
        #endregion
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
