using Core.Domain.Toolkits.ValueObjects;
using Framework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.File.Entities
{
    public class File: BaseAggregateRoot
    {
        /*agg
         برای ایجاد و عملیات فایل با فرمت zip*/
        public String Name { get;private set; }
        public Toolkits.ValueObjects.Path Path { get;private set; }
        public Description Description { get; private set; }
        public Guid ContentId { get; set; }
        public File( Toolkits.ValueObjects.Path path, string name, Guid contentId)
        {
            Name = name;
            Path = path;
            ContentId = contentId;
        }
        public void ChangePath(File file, Toolkits.ValueObjects.Path path)
        {
            file.Path = path;
        }
        public void ChangeName(File file,string name)
        {
            file.Name = name;
        }
        public void ChangeDescription(File file, Description description)
        {
            file.Description = description;
        }
    }
}
