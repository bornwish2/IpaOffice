using Core.Domain.Toolkits.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Core.Domain.Document.Entities
{
    internal class Document
    {
        /*agg
         برای ایجاد و عملیات مربوط به مستندات با فرمت
        pdf یا  word*/
        public String Code { get; set; }
        public Toolkits_Shared_.ValueObjects.Path Path { get; set; }
        public Description Description { get; set; }
        private Document(Toolkits_Shared_.ValueObjects.Path path, Description description, string code)
        {
            Code = code;
            Path = path;
            Description = description;
        }
        public Document CreateDocument(Toolkits_Shared_.ValueObjects.Path path, Description description, string name)
        {
            return new Document(path, description, name);
        }
    }
}
