using Core.Domain.Toolkits.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Picture.Entities
{
    public class Picture
    {
        /*agg
        برای ایجاد و عملیات مربوط به تصاویر با فرمت
       jpg یا  png*/
        public String Name { get; protected set; }
        public Toolkits_Shared_.ValueObjects.Path Path { get; protected set; }
        public Description Description { get; protected set; }
        private Picture() { }
        private Picture(Toolkits_Shared_.ValueObjects.Path path, Description description, string name)
        {
            Name = name;
            Path = path;
            Description = description;
        }
        public Picture CreateFile(Toolkits_Shared_.ValueObjects.Path path, Description description, string name)
        {
            return new Picture(path, description, name);
        }
    }
}
