﻿using Core.Domain.Form.Entities;
using Core.Domain.Toolkits_Shared_.ValueObjects;
using Framework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Manifest.Entities
{
    public class Manifest : BaseAggregateRoot
    {
        public Guid Id { get;protected set; }
        public string Title { get;protected set; }
        public long FormId { get;protected set; }
        public long DispatcherId { get; protected set; }
        public ManifestState State { get;protected set; }
        private Manifest(string title, long formId ,long dispatcherId)
        {
            Title = title;
            FormId= formId;
            DispatcherId = dispatcherId;
        }

        private Manifest()
        {

        }
        public Manifest CreateManifest(string title,long formId,long dispatcherId)
        {
            return new Manifest(title,formId, dispatcherId);
        }
        public void DeleteManifest (Guid manifestId)
        {

        }
        //public void SetTitle(string title)
        //{
        //    Title = title;
        //}
        public void ChangeTitle(Guid manifestId)
        {
          
        }
    }
}
