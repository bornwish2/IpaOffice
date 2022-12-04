using Core.Domain.Toolkits.ValueObjects;
using Framework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.File.Entities
{
    public class File:BaseAggregateRoot
    {
        /*agg
         برای ایجاد و عملیات فایل با فرمت zip*/
        public String Name { get;private set; }
        public Toolkits_Shared_.ValueObjects.Path Path { get;private set; }
        public Description Description { get; private set; }
        private File( Toolkits_Shared_.ValueObjects.Path path, Description description, string name)
        {
            Name= name;
            Path= path;
            Description= description;
        }
        public File CreateFile(Toolkits_Shared_.ValueObjects.Path path,Description description,string name)
        {
            return new File(path,description,name);
        } 
        public void DeleteFile (File file)
        {

        }
    }
}
