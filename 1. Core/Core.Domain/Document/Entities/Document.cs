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
        #region Properties
        public String Code { get;protected set; }
        public Toolkits.ValueObjects.Path Path { get; protected set; }
        public Description Description { get; protected set; }
        public Guid ContentId { get;protected set; }
        #endregion

        #region Constructors
        public Document(Toolkits.ValueObjects.Path path, Description description, string code, Guid contentId)
        {
            Code = code;
            Path = path;
            Description = description;
            ContentId = contentId;
        }
        private Document()
        {

        }
        #endregion

        #region Methods
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
        #endregion
    }
}
