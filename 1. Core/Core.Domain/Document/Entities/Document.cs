using Core.Domain.Toolkits.ValueObjects;
using Framework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Core.Domain.Document.Entities
{
    public class Document : BaseAggregateRoot
    {
        /*agg
         برای ایجاد و عملیات مربوط به مستندات با فرمت
        pdf یا  word*/
        public String Code { get;protected set; }
        public Toolkits.ValueObjects.Path Path { get; protected set; }
        public Description Description { get; protected set; }
        public Guid ContentId { get;protected set; }
        public Document(Toolkits.ValueObjects.Path path, Description description, string code, Guid contentId)
        {
            Code = code;
            Path = path;
            Description = description;
            ContentId = contentId;
        }
        public void AddDocument(Toolkits.ValueObjects.Path path, Description description, string name,Guid contentId)
        {
          
        }
        public void ChangePath(Document document, Toolkits.ValueObjects.Path path)
        {
            document.Path = path;
        }
        public void ChangeCode(Document document, string code)
        {
            document.Code = code;
        }
        public void ChangeDescription(Document document, Description description)
        {
            document.Description = description;
        }
    }
}
