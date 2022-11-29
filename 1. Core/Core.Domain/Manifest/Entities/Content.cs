using Core.Domain.Manifest.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Manifest.Entities
{
    /// <summary>
    /// Value of once content in 'manifest'
    /// </summary>
    /// <typeparam name="T"> T can be File or Picture or Document 
    /// or other value objects such as string or datetime or etc</typeparam>
    public class Content<T>
    {
        public Guid Id { get; private set; }

        ////sample of impliment generic content of manifest according to structure
        //public Dictionary<ContentType, T> CreateContent(Guid structureId, Guid formId, T value)
        //{
        //    Dictionary<ContentType, T> componentByValue = new Dictionary<ContentType, T>
        //    {
        //        { new ContentType(structureId, formId,nameof(T) ,this.Id), value }
        //    };
        //    return componentByValue;
        //}
    }
}
