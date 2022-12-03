using Core.Domain.Toolkits.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.File.Entities
{
    internal class File
    {
        /*agg
         برای ایجاد و عملیات فایل با فرمت zip*/
        public String Name { get; set; }
        public Toolkits_Shared_.ValueObjects.Path Path { get; set; }
        public Description Description { get; set; }
    }
}
