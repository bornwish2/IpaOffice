using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Core.Domain.Manifest.ValueObjects
{
    //public sealed class ContentType<StructIdType, FormIdType, ContentType, ContentIdType> : Tuple<StructIdType, FormIdType, ContentType, ContentIdType>
    //{
    //    public ContentType(Guid structId,
    //                       Guid formId,
    //                       string contentType,
    //                       Guid contentId)
    //        : base(structId, formId, contentType, contentId) { }

    //    public Guid Struct_Id => Item1;

    //    public Guid Form_Id => Item2;

    //    public string Content_Type => Item3;

    //    public Guid Content_Id => Item4;
    //}

    /// <summary>
    /// create a dictionary by tuple of keys as key of dictionary for improved content accessibility
    /// </summary>
    public sealed class ContentType : Tuple<Guid, Guid, string, Guid>
    {
        public ContentType(Guid structId,
                           Guid formId,
                           string contentType,
                           Guid contentId)
            : base(structId, formId, contentType, contentId) { }

        public Guid Struct_Id => Item1;

        public Guid Form_Id => Item2;

        public string Content_Type => Item3;

        public Guid Content_Id => Item4;
    }
}