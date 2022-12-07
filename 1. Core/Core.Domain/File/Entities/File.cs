using Core.Domain.Toolkits.ValueObjects;
using Framework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.File.Entities
{
    public class File:BaseEntity
    {
        /*agg
         برای ایجاد و عملیات فایل با فرمت zip*/
        public String Name { get;private set; }
        public Toolkits_Shared_.ValueObjects.Path Path { get;private set; }
        public Description Description { get; private set; }
        public Guid ContentId { get; set; }
        private File( Toolkits_Shared_.ValueObjects.Path path, Description description, string name, Guid contentId)
        {
            Name = name;
            Path = path;
            Description = description;
            ContentId = contentId;
        }
        public File CreateFile(Toolkits_Shared_.ValueObjects.Path path,Description description,string name,Guid contentId)
        {
            return new File(path,description,name, contentId);
        } 
        public void DeleteFile (File file)
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
