using Core.Domain.Toolkits.ValueObjects;
using Framework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Picture.Entities
{
    public class Picture : BaseAggregateRoot
    {
        /*agg
        برای ایجاد و عملیات مربوط به تصاویر با فرمت
       jpg یا  png*/
        public String Name { get; protected set; }
        public Toolkits_Shared_.ValueObjects.Path Path { get; protected set; }
        public Description Description { get; protected set; }
        public Guid ContentId { get; set; }
        private Picture() { }
        public Picture(Toolkits_Shared_.ValueObjects.Path path, Description description, string name,Guid contentId)
        {
            Name = name;
            Path = path;
            Description = description;
            ContentId=contentId;
        }
        public void AddFile(Toolkits_Shared_.ValueObjects.Path path, Description description, string name,Guid contentId)
        {
            
        }
        public void ChangePath(long pictureId)
        {

        }
        public void ChangeName(long pictureId)
        {

        }
        public void ChangeDescription(long pictureId)
        {

        }

    }
}
